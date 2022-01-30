namespace KanbanProje
{
    partial class AnaPencereForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaPencereForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProjeAdi = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDropDown = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnKanBan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Txt_IV25", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1129, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.lblProjeAdi);
            this.panel1.Controls.Add(this.lblKullanici);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Txt_IV25", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 43);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lblProjeAdi
            // 
            this.lblProjeAdi.Font = new System.Drawing.Font("Txt_IV25", 12F);
            this.lblProjeAdi.Location = new System.Drawing.Point(8, 9);
            this.lblProjeAdi.Name = "lblProjeAdi";
            this.lblProjeAdi.Size = new System.Drawing.Size(402, 20);
            this.lblProjeAdi.TabIndex = 2;
            // 
            // lblKullanici
            // 
            this.lblKullanici.Font = new System.Drawing.Font("Txt_IV25", 14F);
            this.lblKullanici.Location = new System.Drawing.Point(121, 22);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(412, 35);
            this.lblKullanici.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlDropDown
            // 
            this.pnlDropDown.Controls.Add(this.btnBreak);
            this.pnlDropDown.Controls.Add(this.btnClose);
            this.pnlDropDown.Controls.Add(this.btnAbout);
            this.pnlDropDown.Controls.Add(this.btnKanBan);
            this.pnlDropDown.Controls.Add(this.button1);
            this.pnlDropDown.Location = new System.Drawing.Point(12, 49);
            this.pnlDropDown.MaximumSize = new System.Drawing.Size(193, 209);
            this.pnlDropDown.MinimumSize = new System.Drawing.Size(193, 43);
            this.pnlDropDown.Name = "pnlDropDown";
            this.pnlDropDown.Size = new System.Drawing.Size(193, 43);
            this.pnlDropDown.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(0, 169);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(193, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Exit Project";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(0, 85);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(193, 43);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnKanBan
            // 
            this.btnKanBan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnKanBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKanBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKanBan.Location = new System.Drawing.Point(0, 43);
            this.btnKanBan.Name = "btnKanBan";
            this.btnKanBan.Size = new System.Drawing.Size(193, 42);
            this.btnKanBan.TabIndex = 5;
            this.btnKanBan.Text = "Kan Ban Board";
            this.btnKanBan.UseVisualStyleBackColor = false;
            this.btnKanBan.Click += new System.EventHandler(this.btnKanBan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Txt_IV25", 12F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Click";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBreak.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreak.Location = new System.Drawing.Point(0, 128);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(193, 43);
            this.btnBreak.TabIndex = 7;
            this.btnBreak.Text = "Take a Break";
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // AnaPencereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.pnlDropDown);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Txt_IV25", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AnaPencereForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaPencere";
            this.Load += new System.EventHandler(this.AnaPencere_Load);
            this.panel1.ResumeLayout(false);
            this.pnlDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlDropDown;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnKanBan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblProjeAdi;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnBreak;
    }
}