namespace KanbanProje
{
    partial class NotEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNotAdi = new System.Windows.Forms.TextBox();
            this.lblNotAdi = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtNot = new System.Windows.Forms.RichTextBox();
            this.lblNot = new System.Windows.Forms.Label();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.lblKalan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Txt_IV25", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Txt_IV25", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 40);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // txtNotAdi
            // 
            this.txtNotAdi.Font = new System.Drawing.Font("Txt_IV25", 8.25F);
            this.txtNotAdi.Location = new System.Drawing.Point(98, 55);
            this.txtNotAdi.Name = "txtNotAdi";
            this.txtNotAdi.Size = new System.Drawing.Size(229, 21);
            this.txtNotAdi.TabIndex = 2;
            // 
            // lblNotAdi
            // 
            this.lblNotAdi.AutoSize = true;
            this.lblNotAdi.Font = new System.Drawing.Font("Txt_IV25", 8.25F);
            this.lblNotAdi.Location = new System.Drawing.Point(12, 58);
            this.lblNotAdi.Name = "lblNotAdi";
            this.lblNotAdi.Size = new System.Drawing.Size(71, 14);
            this.lblNotAdi.TabIndex = 3;
            this.lblNotAdi.Text = "Not Name";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Txt_IV25", 8.25F);
            this.lblKategori.Location = new System.Drawing.Point(12, 91);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(71, 14);
            this.lblKategori.TabIndex = 3;
            this.lblKategori.Text = "Category";
            // 
            // txtKategori
            // 
            this.txtKategori.Font = new System.Drawing.Font("Txt_IV25", 8.25F);
            this.txtKategori.Location = new System.Drawing.Point(98, 91);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(229, 21);
            this.txtKategori.TabIndex = 2;
            // 
            // txtNot
            // 
            this.txtNot.Font = new System.Drawing.Font("Txt_IV25", 8.25F);
            this.txtNot.Location = new System.Drawing.Point(98, 128);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(229, 98);
            this.txtNot.TabIndex = 4;
            this.txtNot.Text = "";
            this.txtNot.TextChanged += new System.EventHandler(this.txtNot_TextChanged);
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Font = new System.Drawing.Font("Txt_IV25", 8.25F);
            this.lblNot.Location = new System.Drawing.Point(53, 128);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(39, 14);
            this.lblNot.TabIndex = 3;
            this.lblNot.Text = "Note";
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.Font = new System.Drawing.Font("Txt_IV25", 8.25F);
            this.btnNotEkle.Location = new System.Drawing.Point(244, 232);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(83, 27);
            this.btnNotEkle.TabIndex = 5;
            this.btnNotEkle.Text = "Add Note";
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Font = new System.Drawing.Font("Txt_IV25", 8.25F);
            this.lblKalan.Location = new System.Drawing.Point(199, 238);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(39, 14);
            this.lblKalan.TabIndex = 3;
            this.lblKalan.Text = "Note";
            // 
            // NotEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 272);
            this.Controls.Add(this.btnNotEkle);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblNotAdi);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.txtNotAdi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NotEkle";
            this.Load += new System.EventHandler(this.NotEkle_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNotAdi;
        private System.Windows.Forms.Label lblNotAdi;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.RichTextBox txtNot;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.Button btnNotEkle;
        private System.Windows.Forms.Label lblKalan;
    }
}