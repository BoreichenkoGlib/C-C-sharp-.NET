namespace WindowsFormsAppCrypt
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.архіваціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.архівуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розархівуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифруванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифруватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розшифруватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.архіваціяToolStripMenuItem,
            this.шифруванняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // архіваціяToolStripMenuItem
            // 
            this.архіваціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.архівуватиToolStripMenuItem,
            this.розархівуватиToolStripMenuItem});
            this.архіваціяToolStripMenuItem.Name = "архіваціяToolStripMenuItem";
            this.архіваціяToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.архіваціяToolStripMenuItem.Text = "Архівація";
            // 
            // архівуватиToolStripMenuItem
            // 
            this.архівуватиToolStripMenuItem.Name = "архівуватиToolStripMenuItem";
            this.архівуватиToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.архівуватиToolStripMenuItem.Text = "Архівувати";
            this.архівуватиToolStripMenuItem.Click += new System.EventHandler(this.архівуватиToolStripMenuItem_Click);
            // 
            // розархівуватиToolStripMenuItem
            // 
            this.розархівуватиToolStripMenuItem.Name = "розархівуватиToolStripMenuItem";
            this.розархівуватиToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.розархівуватиToolStripMenuItem.Text = "Розархівувати";
            this.розархівуватиToolStripMenuItem.Click += new System.EventHandler(this.розархівуватиToolStripMenuItem_Click);
            // 
            // шифруванняToolStripMenuItem
            // 
            this.шифруванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шифруватиToolStripMenuItem,
            this.розшифруватиToolStripMenuItem});
            this.шифруванняToolStripMenuItem.Name = "шифруванняToolStripMenuItem";
            this.шифруванняToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.шифруванняToolStripMenuItem.Text = "Шифрування";
            // 
            // шифруватиToolStripMenuItem
            // 
            this.шифруватиToolStripMenuItem.Name = "шифруватиToolStripMenuItem";
            this.шифруватиToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.шифруватиToolStripMenuItem.Text = "Шифрувати";
            this.шифруватиToolStripMenuItem.Click += new System.EventHandler(this.шифруватиToolStripMenuItem_Click);
            // 
            // розшифруватиToolStripMenuItem
            // 
            this.розшифруватиToolStripMenuItem.Name = "розшифруватиToolStripMenuItem";
            this.розшифруватиToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.розшифруватиToolStripMenuItem.Text = "Розшифрувати";
            this.розшифруватиToolStripMenuItem.Click += new System.EventHandler(this.розшифруватиToolStripMenuItem_Click);
            // 
            // listBox
            // 
            this.listBox.AllowDrop = true;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 50);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(589, 264);
            this.listBox.TabIndex = 1;
            this.listBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 342);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem архіваціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem архівуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розархівуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шифруванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шифруватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розшифруватиToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

