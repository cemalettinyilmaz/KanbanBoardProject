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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.lbTodo = new System.Windows.Forms.ListBox();
            this.lbDoing = new System.Windows.Forms.ListBox();
            this.lbDone = new System.Windows.Forms.ListBox();
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
            this.lbTodo.Font = new System.Drawing.Font("Txt_IV25", 20F, System.Drawing.FontStyle.Bold);
            this.lbTodo.FormattingEnabled = true;
            this.lbTodo.ItemHeight = 33;
            this.lbTodo.Location = new System.Drawing.Point(231, 81);
            this.lbTodo.Name = "lbTodo";
            this.lbTodo.Size = new System.Drawing.Size(240, 433);
            this.lbTodo.TabIndex = 3;
            this.lbTodo.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lbTodo.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lbTodo.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lbTodo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lbDoing
            // 
            this.lbDoing.AllowDrop = true;
            this.lbDoing.BackColor = System.Drawing.Color.OliveDrab;
            this.lbDoing.Font = new System.Drawing.Font("Txt_IV25", 20F, System.Drawing.FontStyle.Bold);
            this.lbDoing.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbDoing.FormattingEnabled = true;
            this.lbDoing.ItemHeight = 33;
            this.lbDoing.Location = new System.Drawing.Point(558, 81);
            this.lbDoing.Name = "lbDoing";
            this.lbDoing.Size = new System.Drawing.Size(240, 433);
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
            this.lbDone.Font = new System.Drawing.Font("Txt_IV25", 20F, System.Drawing.FontStyle.Bold);
            this.lbDone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbDone.FormattingEnabled = true;
            this.lbDone.ItemHeight = 33;
            this.lbDone.Location = new System.Drawing.Point(865, 81);
            this.lbDone.Name = "lbDone";
            this.lbDone.Size = new System.Drawing.Size(240, 433);
            this.lbDone.TabIndex = 3;
            this.lbDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lbDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lbDone.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lbDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // KanBanBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1195, 554);
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
    }
}