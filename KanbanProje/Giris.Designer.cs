namespace KanbanProje
{
    partial class Giris
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProjeler = new System.Windows.Forms.ComboBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnYeniProje = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Txt_IV25", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbProjeler
            // 
            this.cmbProjeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjeler.FormattingEnabled = true;
            this.cmbProjeler.Location = new System.Drawing.Point(120, 100);
            this.cmbProjeler.Name = "cmbProjeler";
            this.cmbProjeler.Size = new System.Drawing.Size(157, 22);
            this.cmbProjeler.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Txt_IV25", 12F, System.Drawing.FontStyle.Bold);
            this.btnGiris.Location = new System.Drawing.Point(148, 148);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(101, 39);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Go";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnYeniProje
            // 
            this.btnYeniProje.Font = new System.Drawing.Font("Txt_IV25", 8.25F);
            this.btnYeniProje.Location = new System.Drawing.Point(148, 193);
            this.btnYeniProje.Name = "btnYeniProje";
            this.btnYeniProje.Size = new System.Drawing.Size(101, 38);
            this.btnYeniProje.TabIndex = 3;
            this.btnYeniProje.Text = "New Project";
            this.btnYeniProje.UseVisualStyleBackColor = true;
            this.btnYeniProje.Click += new System.EventHandler(this.btnYeniProje_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.btnYeniProje);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.cmbProjeler);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Txt_IV25", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProjeler;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnYeniProje;
    }
}

