﻿namespace Travelman
{
    partial class StartView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LocationPanel = new System.Windows.Forms.Panel();
            this.btnPlanTrip = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LocationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocationPanel
            // 
            this.LocationPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationPanel.BackColor = System.Drawing.Color.White;
            this.LocationPanel.Controls.Add(this.btnPlanTrip);
            this.LocationPanel.Location = new System.Drawing.Point(28, 117);
            this.LocationPanel.Name = "LocationPanel";
            this.LocationPanel.Size = new System.Drawing.Size(294, 252);
            this.LocationPanel.TabIndex = 0;
            // 
            // btnPlanTrip
            // 
            this.btnPlanTrip.AutoSize = true;
            this.btnPlanTrip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlanTrip.Depth = 0;
            this.btnPlanTrip.Icon = null;
            this.btnPlanTrip.Location = new System.Drawing.Point(103, 106);
            this.btnPlanTrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlanTrip.Name = "btnPlanTrip";
            this.btnPlanTrip.Primary = true;
            this.btnPlanTrip.Size = new System.Drawing.Size(89, 36);
            this.btnPlanTrip.TabIndex = 1;
            this.btnPlanTrip.Text = "Plan trip";
            this.btnPlanTrip.UseVisualStyleBackColor = true;
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LocationPanel);
            this.Name = "StartView";
            this.Size = new System.Drawing.Size(351, 386);
            this.Click += new System.EventHandler(this.StartView_Click);
            this.LocationPanel.ResumeLayout(false);
            this.LocationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LocationPanel;
        private MaterialSkin.Controls.MaterialRaisedButton btnPlanTrip;
    }
}
