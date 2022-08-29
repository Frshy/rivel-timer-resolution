namespace rivel_timer_resolution {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.authorLinkLbl = new System.Windows.Forms.LinkLabel();
            this.lowerTrBtn = new MaterialSkin.Controls.MaterialCheckbox();
            this.actualResolutionLbl = new MaterialSkin.Controls.MaterialLabel();
            this.minResolutionLbl = new MaterialSkin.Controls.MaterialLabel();
            this.maxResolutionLbl = new MaterialSkin.Controls.MaterialLabel();
            this.addToStartUpsCheck = new MaterialSkin.Controls.MaterialCheckbox();
            this.lowerAtLaunchCheck = new MaterialSkin.Controls.MaterialCheckbox();
            this.darkThemeCheck = new MaterialSkin.Controls.MaterialCheckbox();
            this.hideInTrayBtn = new MaterialSkin.Controls.MaterialButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.fajnyLbl = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // authorLinkLbl
            // 
            this.authorLinkLbl.ActiveLinkColor = System.Drawing.Color.Blue;
            this.authorLinkLbl.AutoSize = true;
            this.authorLinkLbl.BackColor = System.Drawing.Color.Transparent;
            this.authorLinkLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.authorLinkLbl.LinkColor = System.Drawing.Color.Teal;
            this.authorLinkLbl.Location = new System.Drawing.Point(449, 68);
            this.authorLinkLbl.Name = "authorLinkLbl";
            this.authorLinkLbl.Size = new System.Drawing.Size(73, 19);
            this.authorLinkLbl.TabIndex = 1;
            this.authorLinkLbl.TabStop = true;
            this.authorLinkLbl.Text = "By Freshy";
            this.authorLinkLbl.Click += new System.EventHandler(this.authorLbl_Click);
            // 
            // lowerTrBtn
            // 
            this.lowerTrBtn.AutoSize = true;
            this.lowerTrBtn.Depth = 0;
            this.lowerTrBtn.Location = new System.Drawing.Point(3, 66);
            this.lowerTrBtn.Margin = new System.Windows.Forms.Padding(0);
            this.lowerTrBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lowerTrBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.lowerTrBtn.Name = "lowerTrBtn";
            this.lowerTrBtn.ReadOnly = false;
            this.lowerTrBtn.Ripple = true;
            this.lowerTrBtn.Size = new System.Drawing.Size(202, 37);
            this.lowerTrBtn.TabIndex = 2;
            this.lowerTrBtn.Text = "Lower Timer Resolution";
            this.lowerTrBtn.UseVisualStyleBackColor = true;
            this.lowerTrBtn.CheckedChanged += new System.EventHandler(this.lowerTrBtn_CheckedChanged);
            // 
            // actualResolutionLbl
            // 
            this.actualResolutionLbl.AutoSize = true;
            this.actualResolutionLbl.Depth = 0;
            this.actualResolutionLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.actualResolutionLbl.Location = new System.Drawing.Point(11, 101);
            this.actualResolutionLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.actualResolutionLbl.Name = "actualResolutionLbl";
            this.actualResolutionLbl.Size = new System.Drawing.Size(152, 20);
            this.actualResolutionLbl.TabIndex = 3;
            this.actualResolutionLbl.Text = "Actual resolution: ???";
            // 
            // minResolutionLbl
            // 
            this.minResolutionLbl.AutoSize = true;
            this.minResolutionLbl.Depth = 0;
            this.minResolutionLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.minResolutionLbl.Location = new System.Drawing.Point(11, 125);
            this.minResolutionLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.minResolutionLbl.Name = "minResolutionLbl";
            this.minResolutionLbl.Size = new System.Drawing.Size(175, 20);
            this.minResolutionLbl.TabIndex = 4;
            this.minResolutionLbl.Text = "Minimum resolution: ???";
            // 
            // maxResolutionLbl
            // 
            this.maxResolutionLbl.AutoSize = true;
            this.maxResolutionLbl.Depth = 0;
            this.maxResolutionLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.maxResolutionLbl.Location = new System.Drawing.Point(11, 150);
            this.maxResolutionLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.maxResolutionLbl.Name = "maxResolutionLbl";
            this.maxResolutionLbl.Size = new System.Drawing.Size(179, 20);
            this.maxResolutionLbl.TabIndex = 5;
            this.maxResolutionLbl.Text = "Maximum resolution: ???";
            // 
            // addToStartUpsCheck
            // 
            this.addToStartUpsCheck.AutoSize = true;
            this.addToStartUpsCheck.Depth = 0;
            this.addToStartUpsCheck.Location = new System.Drawing.Point(224, 101);
            this.addToStartUpsCheck.Margin = new System.Windows.Forms.Padding(0);
            this.addToStartUpsCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.addToStartUpsCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.addToStartUpsCheck.Name = "addToStartUpsCheck";
            this.addToStartUpsCheck.ReadOnly = false;
            this.addToStartUpsCheck.Ripple = true;
            this.addToStartUpsCheck.Size = new System.Drawing.Size(143, 37);
            this.addToStartUpsCheck.TabIndex = 6;
            this.addToStartUpsCheck.Text = "Add to startups";
            this.addToStartUpsCheck.UseVisualStyleBackColor = true;
            this.addToStartUpsCheck.Visible = false;
            // 
            // lowerAtLaunchCheck
            // 
            this.lowerAtLaunchCheck.AutoSize = true;
            this.lowerAtLaunchCheck.Depth = 0;
            this.lowerAtLaunchCheck.Location = new System.Drawing.Point(3, 227);
            this.lowerAtLaunchCheck.Margin = new System.Windows.Forms.Padding(0);
            this.lowerAtLaunchCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lowerAtLaunchCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.lowerAtLaunchCheck.Name = "lowerAtLaunchCheck";
            this.lowerAtLaunchCheck.ReadOnly = false;
            this.lowerAtLaunchCheck.Ripple = true;
            this.lowerAtLaunchCheck.Size = new System.Drawing.Size(233, 37);
            this.lowerAtLaunchCheck.TabIndex = 7;
            this.lowerAtLaunchCheck.Text = "Lower Resolution At Launch";
            this.lowerAtLaunchCheck.UseVisualStyleBackColor = true;
            // 
            // darkThemeCheck
            // 
            this.darkThemeCheck.AutoSize = true;
            this.darkThemeCheck.Checked = true;
            this.darkThemeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkThemeCheck.Depth = 0;
            this.darkThemeCheck.Location = new System.Drawing.Point(3, 197);
            this.darkThemeCheck.Margin = new System.Windows.Forms.Padding(0);
            this.darkThemeCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.darkThemeCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkThemeCheck.Name = "darkThemeCheck";
            this.darkThemeCheck.ReadOnly = false;
            this.darkThemeCheck.Ripple = true;
            this.darkThemeCheck.Size = new System.Drawing.Size(120, 37);
            this.darkThemeCheck.TabIndex = 8;
            this.darkThemeCheck.Text = "Dark Theme";
            this.darkThemeCheck.UseVisualStyleBackColor = true;
            this.darkThemeCheck.CheckedChanged += new System.EventHandler(this.darkThemeCheck_CheckedChanged);
            // 
            // hideInTrayBtn
            // 
            this.hideInTrayBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hideInTrayBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.hideInTrayBtn.Depth = 0;
            this.hideInTrayBtn.HighEmphasis = true;
            this.hideInTrayBtn.Icon = null;
            this.hideInTrayBtn.Location = new System.Drawing.Point(371, 109);
            this.hideInTrayBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.hideInTrayBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.hideInTrayBtn.Name = "hideInTrayBtn";
            this.hideInTrayBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.hideInTrayBtn.Size = new System.Drawing.Size(117, 36);
            this.hideInTrayBtn.TabIndex = 9;
            this.hideInTrayBtn.Text = "Hide To Tray";
            this.hideInTrayBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.hideInTrayBtn.UseAccentColor = false;
            this.hideInTrayBtn.UseVisualStyleBackColor = true;
            this.hideInTrayBtn.Visible = false;
            this.hideInTrayBtn.Click += new System.EventHandler(this.hideInTrayBtn_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Double click to bring it back!";
            this.notifyIcon.BalloonTipTitle = "Rivel Timer Resolution";
            this.notifyIcon.Text = "Rivel Timer Resolution";
            this.notifyIcon.Visible = true;
            // 
            // fajnyLbl
            // 
            this.fajnyLbl.AutoSize = true;
            this.fajnyLbl.Depth = 0;
            this.fajnyLbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fajnyLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.fajnyLbl.Location = new System.Drawing.Point(269, 248);
            this.fajnyLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.fajnyLbl.Name = "fajnyLbl";
            this.fajnyLbl.Size = new System.Drawing.Size(248, 15);
            this.fajnyLbl.TabIndex = 10;
            this.fajnyLbl.Text = "(Keep it running in background, don\' t close it)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 266);
            this.Controls.Add(this.fajnyLbl);
            this.Controls.Add(this.hideInTrayBtn);
            this.Controls.Add(this.darkThemeCheck);
            this.Controls.Add(this.lowerAtLaunchCheck);
            this.Controls.Add(this.addToStartUpsCheck);
            this.Controls.Add(this.maxResolutionLbl);
            this.Controls.Add(this.minResolutionLbl);
            this.Controls.Add(this.actualResolutionLbl);
            this.Controls.Add(this.lowerTrBtn);
            this.Controls.Add(this.authorLinkLbl);
            this.Name = "MainForm";
            this.Text = "Rivel Timer Resolution";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel authorLinkLbl;
        private MaterialSkin.Controls.MaterialCheckbox lowerTrBtn;
        private MaterialSkin.Controls.MaterialLabel actualResolutionLbl;
        private MaterialSkin.Controls.MaterialLabel minResolutionLbl;
        private MaterialSkin.Controls.MaterialLabel maxResolutionLbl;
        private MaterialSkin.Controls.MaterialCheckbox addToStartUpsCheck;
        private MaterialSkin.Controls.MaterialCheckbox lowerAtLaunchCheck;
        private MaterialSkin.Controls.MaterialCheckbox darkThemeCheck;
        private MaterialSkin.Controls.MaterialButton hideInTrayBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MaterialSkin.Controls.MaterialLabel fajnyLbl;
    }
}

