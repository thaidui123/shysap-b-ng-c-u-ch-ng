namespace shysap_bảng_cửu_chương
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbketqua = new System.Windows.Forms.ListBox();
            this.btnxem = new System.Windows.Forms.Button();
            this.txtso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng Cửu Chương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bạn muốn hiện thị bảng cửu chương mấy ?";
            // 
            // lsbketqua
            // 
            this.lsbketqua.FormattingEnabled = true;
            this.lsbketqua.Location = new System.Drawing.Point(154, 252);
            this.lsbketqua.Name = "lsbketqua";
            this.lsbketqua.Size = new System.Drawing.Size(529, 160);
            this.lsbketqua.TabIndex = 2;
            // 
            // btnxem
            // 
            this.btnxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Location = new System.Drawing.Point(543, 146);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(140, 45);
            this.btnxem.TabIndex = 3;
            this.btnxem.Text = "xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // txtso
            // 
            this.txtso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso.Location = new System.Drawing.Point(163, 146);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(318, 38);
            this.txtso.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.lsbketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bảng cửu chương";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbketqua;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.TextBox txtso;
    }
}

