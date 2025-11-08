namespace Rodder
{
    partial class Rodder
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rodder));
            this.LogoLabel = new System.Windows.Forms.Label();
            this.PageSection = new System.Windows.Forms.Panel();
            this.HowPageButton = new System.Windows.Forms.Button();
            this.MacroPageButton = new System.Windows.Forms.Button();
            this.ControlSection = new System.Windows.Forms.Panel();
            this.Switch = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PageSection.SuspendLayout();
            this.ControlSection.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoLabel
            // 
            this.LogoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Rabar_013", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.LogoLabel.Location = new System.Drawing.Point(42, 22);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(141, 60);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "Rodder";
            this.LogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageSection
            // 
            this.PageSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PageSection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PageSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PageSection.Controls.Add(this.HowPageButton);
            this.PageSection.Controls.Add(this.MacroPageButton);
            this.PageSection.Controls.Add(this.LogoLabel);
            this.PageSection.ForeColor = System.Drawing.Color.White;
            this.PageSection.Location = new System.Drawing.Point(0, 0);
            this.PageSection.Name = "PageSection";
            this.PageSection.Size = new System.Drawing.Size(224, 495);
            this.PageSection.TabIndex = 1;
            // 
            // HowPageButton
            // 
            this.HowPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HowPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.HowPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HowPageButton.FlatAppearance.BorderSize = 0;
            this.HowPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HowPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowPageButton.Location = new System.Drawing.Point(3, 215);
            this.HowPageButton.Name = "HowPageButton";
            this.HowPageButton.Size = new System.Drawing.Size(216, 53);
            this.HowPageButton.TabIndex = 2;
            this.HowPageButton.Text = "How to use";
            this.HowPageButton.UseVisualStyleBackColor = false;
            this.HowPageButton.Click += new System.EventHandler(this.HowPageButton_Click);
            // 
            // MacroPageButton
            // 
            this.MacroPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MacroPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.MacroPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MacroPageButton.FlatAppearance.BorderSize = 0;
            this.MacroPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MacroPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MacroPageButton.ForeColor = System.Drawing.Color.White;
            this.MacroPageButton.Location = new System.Drawing.Point(3, 137);
            this.MacroPageButton.Name = "MacroPageButton";
            this.MacroPageButton.Size = new System.Drawing.Size(216, 53);
            this.MacroPageButton.TabIndex = 1;
            this.MacroPageButton.Text = "Macro";
            this.MacroPageButton.UseVisualStyleBackColor = false;
            this.MacroPageButton.Click += new System.EventHandler(this.MacroPageButton_Click);
            // 
            // ControlSection
            // 
            this.ControlSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ControlSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlSection.Controls.Add(this.Switch);
            this.ControlSection.Location = new System.Drawing.Point(0, 494);
            this.ControlSection.Name = "ControlSection";
            this.ControlSection.Size = new System.Drawing.Size(929, 81);
            this.ControlSection.TabIndex = 2;
            // 
            // Switch
            // 
            this.Switch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Switch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Switch.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Switch.FlatAppearance.BorderSize = 2;
            this.Switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Switch.Font = new System.Drawing.Font("MS Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Switch.ForeColor = System.Drawing.Color.Maroon;
            this.Switch.Location = new System.Drawing.Point(322, 6);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(294, 66);
            this.Switch.TabIndex = 0;
            this.Switch.Text = "OFF";
            this.Switch.UseVisualStyleBackColor = false;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Location = new System.Drawing.Point(223, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(706, 495);
            this.ContentPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 44);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 41);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(787, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Version 1.0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "By rand";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rodder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(929, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.ControlSection);
            this.Controls.Add(this.PageSection);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Rodder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rodder";
            this.PageSection.ResumeLayout(false);
            this.PageSection.PerformLayout();
            this.ControlSection.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Panel PageSection;
        private System.Windows.Forms.Panel ControlSection;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button MacroPageButton;
        private System.Windows.Forms.Button HowPageButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Switch;
    }
}

