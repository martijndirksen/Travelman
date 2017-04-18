﻿using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Drawing;

namespace Travelman
{
    public partial class MainView : UserControl
    {
        private const bool SIDEBAR_SHOWN = true;
        private ChromiumWebBrowser _browser;
        private LocationSelection _startSelection, _destinationSelection;
        private string _start, _destination;

        public MainView(string start, string destination)
        {
            _start = start;
            _destination = destination;

            Dock = DockStyle.Fill;
            InitializeComponent();
            InitializeBrowser();
            Disposed += MainView_Disposed;

            _destinationSelection = new LocationSelection(scSidebar.Panel1, new Point(0, 48), "Kies een bestemming...", FontAwesome.Sharp.IconChar.FlagCheckered, 2);
            scSidebar.Panel1.Controls.Add(_destinationSelection);

            _startSelection = new LocationSelection(scSidebar.Panel1, new Point(0, 0), "Kies een vertrekpunt...", FontAwesome.Sharp.IconChar.FlagO, 2);
            scSidebar.Panel1.Controls.Add(_startSelection);

            scSidebar.Panel1Collapsed = !SIDEBAR_SHOWN;
        }

        private void MainView_Disposed(object sender, EventArgs e)
        {
            Cef.Shutdown();
        }

        private void InitializeBrowser()
        {
            CefSettings cefSettings = new CefSettings();
            Cef.Initialize(cefSettings);
            string url = string.Format(@"{0}\html\index.html", Application.StartupPath);
            _browser = new ChromiumWebBrowser(url);
            scSidebar.Panel2.Controls.Add(_browser);
            _browser.Dock = DockStyle.Fill;
            // Allow local files
            _browser.BrowserSettings = new BrowserSettings()
            {
                FileAccessFromFileUrls = CefState.Enabled,
                UniversalAccessFromFileUrls = CefState.Enabled
            };
            _browser.FrameLoadEnd += _browser_FrameLoadEnd;
            _browser.SendToBack();
        }

        private void _browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Frame.IsMain)
            {
                _browser.ExecuteScriptAsync("showRoute", _start, _destination);
            }
        }
    }
}
