namespace KanbanProje
{
    partial class KanBanBoard
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.lbTodo = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbDoing = new System.Windows.Forms.ListBox();
            this.lbDone = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lbKategoriler = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.showNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Txt_IV25", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(231, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "TODO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Txt_IV25", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(552, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOING";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Txt_IV25", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(859, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 44);
            this.label3.TabIndex = 1;
            this.label3.Text = "DONE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotEkle.Font = new System.Drawing.Font("Txt_IV25", 20F, System.Drawing.FontStyle.Bold);
            this.btnNotEkle.Location = new System.Drawing.Point(231, 44);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(74, 31);
            this.btnNotEkle.TabIndex = 2;
            this.btnNotEkle.Text = "+";
            this.btnNotEkle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // lbTodo
            // 
            this.lbTodo.AllowDrop = true;
            this.lbTodo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbTodo.ContextMenuStrip = this.contextMenuStrip1;
            this.lbTodo.Font = new System.Drawing.Font("Txt_IV25", 12F, System.Drawing.FontStyle.Bold);
            this.lbTodo.FormattingEnabled = true;
            this.lbTodo.ItemHeight = 20;
            this.lbTodo.Location = new System.Drawing.Point(231, 81);
            this.lbTodo.Name = "lbTodo";
            this.lbTodo.Size = new System.Drawing.Size(240, 424);
            this.lbTodo.TabIndex = 3;
            this.lbTodo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KanBanBoard_MouseClick);
            this.lbTodo.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lbTodo.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lbTodo.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lbTodo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTodo_MouseDoubleClick);
            this.lbTodo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            this.lbTodo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbTodo_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Txt_IV25", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showNoteToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 92);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // lbDoing
            // 
            this.lbDoing.AllowDrop = true;
            this.lbDoing.BackColor = System.Drawing.Color.OliveDrab;
            this.lbDoing.ContextMenuStrip = this.contextMenuStrip1;
            this.lbDoing.Font = new System.Drawing.Font("Txt_IV25", 12F, System.Drawing.FontStyle.Bold);
            this.lbDoing.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbDoing.FormattingEnabled = true;
            this.lbDoing.ItemHeight = 20;
            this.lbDoing.Location = new System.Drawing.Point(558, 81);
            this.lbDoing.Name = "lbDoing";
            this.lbDoing.Size = new System.Drawing.Size(240, 424);
            this.lbDoing.TabIndex = 3;
            this.lbDoing.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lbDoing.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lbDoing.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lbDoing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lbDone
            // 
            this.lbDone.AllowDrop = true;
            this.lbDone.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbDone.ContextMenuStrip = this.contextMenuStrip1;
            this.lbDone.Font = new System.Drawing.Font("Txt_IV25", 12F, System.Drawing.FontStyle.Bold);
            this.lbDone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbDone.FormattingEnabled = true;
            this.lbDone.ItemHeight = 20;
            this.lbDone.Location = new System.Drawing.Point(865, 81);
            this.lbDone.Name = "lbDone";
            this.lbDone.Size = new System.Drawing.Size(240, 424);
            this.lbDone.TabIndex = 3;
            this.lbDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lbDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lbDone.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lbDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(103, 26);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            // 
            // colorDialog1
            // 
            this.colorDialog1.SolidColorOnly = true;
            // 
            // lbKategoriler
            // 
            this.lbKategoriler.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbKategoriler.Font = new System.Drawing.Font("Txt_IV25", 8F, System.Drawing.FontStyle.Bold);
            this.lbKategoriler.FormattingEnabled = true;
            this.lbKategoriler.ItemHeight = 14;
            this.lbKategoriler.Location = new System.Drawing.Point(0, 134);
            this.lbKategoriler.Name = "lbKategoriler";
            this.lbKategoriler.Size = new System.Drawing.Size(167, 158);
            this.lbKategoriler.TabIndex = 5;
            this.lbKategoriler.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbKategoriler_DrawItem);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKategoriEkle);
            this.panel1.Controls.Add(this.txtKategoriAdi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbKategoriler);
            this.panel1.Font = new System.Drawing.Font("Txt_IV25", 8F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(27, 199);
            this.panel1.MaximumSize = new System.Drawing.Size(167, 295);
            this.panel1.MinimumSize = new System.Drawing.Size(167, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 38);
            this.panel1.TabIndex = 6;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(109, 65);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(55, 23);
            this.btnKategoriEkle.TabIndex = 10;
            this.btnKategoriEkle.Text = "Add";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(3, 65);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(100, 21);
            this.txtKategoriAdi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Txt_IV25", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "\r\nCategories";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Txt_IV25", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // showNoteToolStripMenuItem
            // 
            this.showNoteToolStripMenuItem.Name = "showNoteToolStripMenuItem";
            this.showNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showNoteToolStripMenuItem.Text = "Show Note";
            this.showNoteToolStripMenuItem.Click += new System.EventHandler(this.showNoteToolStripMenuItem_Click);
            // 
            // KanBanBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1195, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbDone);
            this.Controls.Add(this.lbDoing);
            this.Controls.Add(this.lbTodo);
            this.Controls.Add(this.btnNotEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KanBanBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KanBanBoard";
            this.Load += new System.EventHandler(this.KanBanBoard_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNotEkle;
        private System.Windows.Forms.ListBox lbTodo;
        private System.Windows.Forms.ListBox lbDoing;
        private System.Windows.Forms.ListBox lbDone;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox lbKategoriler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem showNoteToolStripMenuItem;
    }
}