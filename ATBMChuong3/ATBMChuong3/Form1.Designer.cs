namespace ATBMChuong3
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
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSinhKhoa = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtKhoaX = new System.Windows.Forms.TextBox();
            this.txtKhoaY = new System.Windows.Forms.TextBox();
            this.txtKhoaZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(24, 46);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(24, 75);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 0;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(203, 186);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(186, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Mã hóa / Giải mã";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSinhKhoa
            // 
            this.btnSinhKhoa.Location = new System.Drawing.Point(24, 104);
            this.btnSinhKhoa.Name = "btnSinhKhoa";
            this.btnSinhKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnSinhKhoa.TabIndex = 0;
            this.btnSinhKhoa.Text = "Sinh khóa";
            this.btnSinhKhoa.UseVisualStyleBackColor = true;
            this.btnSinhKhoa.Click += new System.EventHandler(this.btnSinhKhoa_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(136, 46);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(404, 20);
            this.txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(136, 77);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(404, 20);
            this.txtOutput.TabIndex = 1;
            // 
            // txtKhoaX
            // 
            this.txtKhoaX.Location = new System.Drawing.Point(184, 106);
            this.txtKhoaX.Name = "txtKhoaX";
            this.txtKhoaX.Size = new System.Drawing.Size(356, 20);
            this.txtKhoaX.TabIndex = 2;
            this.txtKhoaX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoaX_KeyPress);
            // 
            // txtKhoaY
            // 
            this.txtKhoaY.Location = new System.Drawing.Point(184, 132);
            this.txtKhoaY.Name = "txtKhoaY";
            this.txtKhoaY.Size = new System.Drawing.Size(356, 20);
            this.txtKhoaY.TabIndex = 2;
            this.txtKhoaY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoaY_KeyPress);
            // 
            // txtKhoaZ
            // 
            this.txtKhoaZ.Location = new System.Drawing.Point(184, 158);
            this.txtKhoaZ.Name = "txtKhoaZ";
            this.txtKhoaZ.Size = new System.Drawing.Size(356, 20);
            this.txtKhoaZ.TabIndex = 2;
            this.txtKhoaZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoaZ_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khóa X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khóa Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khóa Z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thuật toán A5/1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 230);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKhoaZ);
            this.Controls.Add(this.txtKhoaY);
            this.Controls.Add(this.txtKhoaX);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSinhKhoa);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSinhKhoa;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtKhoaX;
        private System.Windows.Forms.TextBox txtKhoaY;
        private System.Windows.Forms.TextBox txtKhoaZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

