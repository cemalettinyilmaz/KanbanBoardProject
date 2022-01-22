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
            this.button1 = new System.Windows.Forms.Button();
            this.lbTodo = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Txt_IV25", 20F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(231, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbTodo
            // 
            this.lbTodo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbTodo.FormattingEnabled = true;
            this.lbTodo.Location = new System.Drawing.Point(231, 81);
            this.lbTodo.Name = "lbTodo";
            this.lbTodo.Size = new System.Drawing.Size(240, 446);
            this.lbTodo.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(558, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 446);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(865, 81);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(240, 446);
            this.listBox2.TabIndex = 3;
            // 
            // KanBanBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1195, 554);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbTodo);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbTodo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}