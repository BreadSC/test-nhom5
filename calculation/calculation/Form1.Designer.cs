namespace calculation
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
            this.cong = new System.Windows.Forms.Button();
            this.tru = new System.Windows.Forms.Button();
            this.nhan = new System.Windows.Forms.Button();
            this.chia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cong
            // 
            this.cong.Location = new System.Drawing.Point(164, 417);
            this.cong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(180, 91);
            this.cong.TabIndex = 0;
            this.cong.Text = "Cộng";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.Click += new System.EventHandler(this.cong_Click);
            // 
            // tru
            // 
            this.tru.Location = new System.Drawing.Point(460, 417);
            this.tru.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(194, 91);
            this.tru.TabIndex = 1;
            this.tru.Text = "Trừ";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.Click += new System.EventHandler(this.tru_Click);
            // 
            // nhan
            // 
            this.nhan.Location = new System.Drawing.Point(790, 417);
            this.nhan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(182, 91);
            this.nhan.TabIndex = 2;
            this.nhan.Text = "Nhân";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.Click += new System.EventHandler(this.nhan_Click);
            // 
            // chia
            // 
            this.chia.Location = new System.Drawing.Point(1112, 417);
            this.chia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(200, 91);
            this.chia.TabIndex = 3;
            this.chia.Text = "Chia";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.Click += new System.EventHandler(this.chia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số 2";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(246, 117);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(608, 31);
            this.txtNumber1.TabIndex = 6;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(246, 231);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(608, 31);
            this.txtNumber2.TabIndex = 7;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(246, 619);
            this.txtResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(644, 31);
            this.txtResult.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 633);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 866);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chia);
            this.Controls.Add(this.nhan);
            this.Controls.Add(this.tru);
            this.Controls.Add(this.cong);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cong;
		private System.Windows.Forms.Button tru;
		private System.Windows.Forms.Button nhan;
		private System.Windows.Forms.Button chia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNumber1;
		private System.Windows.Forms.TextBox txtNumber2;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Label label3;
	}
}

