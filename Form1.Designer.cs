namespace Skola_jovan_popovic_registroanje_ucenika
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uklonitiUcenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dodatiUListuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dodatiPredmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodatiOcenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1820, 748);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum pravljenja naloga";
            this.columnHeader1.Width = 178;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 110;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodatiToolStripMenuItem,
            this.uklonitiUcenikaToolStripMenuItem,
            this.dodatiUListuToolStripMenuItem,
            this.dodatiPredmetToolStripMenuItem,
            this.dodatiOcenuToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 24);
            this.toolStripMenuItem1.Text = "Ucenik";
            // 
            // dodatiToolStripMenuItem
            // 
            this.dodatiToolStripMenuItem.Name = "dodatiToolStripMenuItem";
            this.dodatiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodatiToolStripMenuItem.Text = "Napraviti nalog";
            this.dodatiToolStripMenuItem.Click += new System.EventHandler(this.dodatiToolStripMenuItem_Click);
            // 
            // uklonitiUcenikaToolStripMenuItem
            // 
            this.uklonitiUcenikaToolStripMenuItem.Name = "uklonitiUcenikaToolStripMenuItem";
            this.uklonitiUcenikaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.uklonitiUcenikaToolStripMenuItem.Text = "Ukloniti ucenika";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum rodjenja";
            this.columnHeader4.Width = 167;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Broj";
            this.columnHeader5.Width = 80;
            // 
            // dodatiUListuToolStripMenuItem
            // 
            this.dodatiUListuToolStripMenuItem.Name = "dodatiUListuToolStripMenuItem";
            this.dodatiUListuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodatiUListuToolStripMenuItem.Text = "Dodati u listu";
            this.dodatiUListuToolStripMenuItem.Click += new System.EventHandler(this.dodatiUListuToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(891, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pokazi dodate na listu ucenike";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dodatiPredmetToolStripMenuItem
            // 
            this.dodatiPredmetToolStripMenuItem.Name = "dodatiPredmetToolStripMenuItem";
            this.dodatiPredmetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodatiPredmetToolStripMenuItem.Text = "Dodati predmet";
            this.dodatiPredmetToolStripMenuItem.Click += new System.EventHandler(this.dodatiPredmetToolStripMenuItem_Click);
            // 
            // dodatiOcenuToolStripMenuItem
            // 
            this.dodatiOcenuToolStripMenuItem.Name = "dodatiOcenuToolStripMenuItem";
            this.dodatiOcenuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodatiOcenuToolStripMenuItem.Text = "Dodati ocenu";
            this.dodatiOcenuToolStripMenuItem.Click += new System.EventHandler(this.dodatiOcenuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 896);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "OS \"Jovan Popovic\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uklonitiUcenikaToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem dodatiUListuToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem dodatiPredmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodatiOcenuToolStripMenuItem;
    }
}

