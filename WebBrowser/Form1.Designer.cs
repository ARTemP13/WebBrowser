namespace WebBrowser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Setting = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.RefreshPage = new System.Windows.Forms.Button();
            this.ForwardPage = new System.Windows.Forms.Button();
            this.BackPage = new System.Windows.Forms.Button();
            this.SearchPage = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.Setting);
            this.panel1.Controls.Add(this.Download);
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.RefreshPage);
            this.panel1.Controls.Add(this.ForwardPage);
            this.panel1.Controls.Add(this.BackPage);
            this.panel1.Controls.Add(this.SearchPage);
            this.panel1.Controls.Add(this.SearchText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 73);
            this.panel1.TabIndex = 0;
            // 
            // Setting
            // 
            this.Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Setting.BackgroundImage = global::WebBrowser.Properties.Resources.dots;
            this.Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Setting.FlatAppearance.BorderSize = 0;
            this.Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting.Location = new System.Drawing.Point(814, 17);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(41, 36);
            this.Setting.TabIndex = 7;
            this.Setting.UseVisualStyleBackColor = true;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // Download
            // 
            this.Download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Download.BackgroundImage = global::WebBrowser.Properties.Resources.download;
            this.Download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Download.FlatAppearance.BorderSize = 0;
            this.Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Download.Location = new System.Drawing.Point(757, 17);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(41, 36);
            this.Download.TabIndex = 6;
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Stop
            // 
            this.Stop.BackgroundImage = global::WebBrowser.Properties.Resources.close;
            this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Location = new System.Drawing.Point(142, 19);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(36, 32);
            this.Stop.TabIndex = 5;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // RefreshPage
            // 
            this.RefreshPage.BackgroundImage = global::WebBrowser.Properties.Resources.refresh;
            this.RefreshPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshPage.FlatAppearance.BorderSize = 0;
            this.RefreshPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshPage.Location = new System.Drawing.Point(95, 17);
            this.RefreshPage.Name = "RefreshPage";
            this.RefreshPage.Size = new System.Drawing.Size(41, 36);
            this.RefreshPage.TabIndex = 4;
            this.RefreshPage.UseVisualStyleBackColor = true;
            this.RefreshPage.Click += new System.EventHandler(this.RefreshPage_Click);
            // 
            // ForwardPage
            // 
            this.ForwardPage.BackgroundImage = global::WebBrowser.Properties.Resources.forward;
            this.ForwardPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForwardPage.FlatAppearance.BorderSize = 0;
            this.ForwardPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardPage.Location = new System.Drawing.Point(48, 17);
            this.ForwardPage.Name = "ForwardPage";
            this.ForwardPage.Size = new System.Drawing.Size(41, 36);
            this.ForwardPage.TabIndex = 3;
            this.ForwardPage.UseVisualStyleBackColor = true;
            this.ForwardPage.Click += new System.EventHandler(this.ForwardPage_Click);
            // 
            // BackPage
            // 
            this.BackPage.BackgroundImage = global::WebBrowser.Properties.Resources.back;
            this.BackPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackPage.FlatAppearance.BorderSize = 0;
            this.BackPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackPage.Location = new System.Drawing.Point(3, 17);
            this.BackPage.Name = "BackPage";
            this.BackPage.Size = new System.Drawing.Size(41, 36);
            this.BackPage.TabIndex = 2;
            this.BackPage.UseVisualStyleBackColor = true;
            this.BackPage.Click += new System.EventHandler(this.BackPage_Click);
            // 
            // SearchPage
            // 
            this.SearchPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchPage.Location = new System.Drawing.Point(660, 17);
            this.SearchPage.Name = "SearchPage";
            this.SearchPage.Size = new System.Drawing.Size(81, 40);
            this.SearchPage.TabIndex = 1;
            this.SearchPage.Text = "Search";
            this.SearchPage.UseVisualStyleBackColor = true;
            this.SearchPage.Click += new System.EventHandler(this.SearchPage_Click);
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(184, 17);
            this.SearchText.Multiline = true;
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(461, 40);
            this.SearchText.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.picture);
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 501);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.History);
            this.panel3.Location = new System.Drawing.Point(619, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 99);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(20, 50);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(223, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закладки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // History
            // 
            this.History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.History.FlatAppearance.BorderSize = 0;
            this.History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History.Location = new System.Drawing.Point(20, 6);
            this.History.Name = "History";
            this.History.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.History.Size = new System.Drawing.Size(223, 37);
            this.History.TabIndex = 0;
            this.History.Text = "История";
            this.History.UseVisualStyleBackColor = true;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picture.BackgroundImage = global::WebBrowser.Properties.Resources.nature;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(874, 501);
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(874, 501);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tux Edge";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Setting;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button RefreshPage;
        private System.Windows.Forms.Button ForwardPage;
        private System.Windows.Forms.Button BackPage;
        public System.Windows.Forms.Button SearchPage;
        public System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox picture;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button History;
    }
}

