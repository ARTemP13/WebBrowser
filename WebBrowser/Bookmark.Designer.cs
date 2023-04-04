namespace WebBrowser
{
    partial class Bookmark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookmark));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddBookmark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RemoveBookmake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(38, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 43);
            this.textBox1.TabIndex = 0;
            // 
            // AddBookmark
            // 
            this.AddBookmark.Location = new System.Drawing.Point(407, 30);
            this.AddBookmark.Name = "AddBookmark";
            this.AddBookmark.Size = new System.Drawing.Size(104, 43);
            this.AddBookmark.TabIndex = 1;
            this.AddBookmark.Text = "Добавить";
            this.AddBookmark.UseVisualStyleBackColor = true;
            this.AddBookmark.Click += new System.EventHandler(this.AddBookmark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбрать закладку";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(38, 162);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(473, 228);
            this.listBox1.TabIndex = 3;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // RemoveBookmake
            // 
            this.RemoveBookmake.Location = new System.Drawing.Point(38, 397);
            this.RemoveBookmake.Name = "RemoveBookmake";
            this.RemoveBookmake.Size = new System.Drawing.Size(175, 41);
            this.RemoveBookmake.TabIndex = 4;
            this.RemoveBookmake.Text = "Удалить закладку";
            this.RemoveBookmake.UseVisualStyleBackColor = true;
            this.RemoveBookmake.Click += new System.EventHandler(this.RemoveBookmake_Click);
            // 
            // Bookmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.RemoveBookmake);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBookmark);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bookmark";
            this.Text = "Bookmark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddBookmark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button RemoveBookmake;
    }
}