namespace BMS1
{
    partial class fWithdraw
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
            this.tbWithdrawAmt = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lbGoBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 73);
            this.label1.TabIndex = 30;
            this.label1.Text = "WITHDRAW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(153, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Withdrawal Amount:";
            // 
            // tbWithdrawAmt
            // 
            this.tbWithdrawAmt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWithdrawAmt.Location = new System.Drawing.Point(339, 203);
            this.tbWithdrawAmt.Name = "tbWithdrawAmt";
            this.tbWithdrawAmt.Size = new System.Drawing.Size(306, 22);
            this.tbWithdrawAmt.TabIndex = 32;
            this.tbWithdrawAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWithdrawAmt_KeyPress);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(237, 328);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(306, 50);
            this.btnWithdraw.TabIndex = 33;
            this.btnWithdraw.Text = "WITHDRAW";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lbGoBack
            // 
            this.lbGoBack.AutoSize = true;
            this.lbGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoBack.ForeColor = System.Drawing.Color.White;
            this.lbGoBack.Location = new System.Drawing.Point(12, 437);
            this.lbGoBack.Name = "lbGoBack";
            this.lbGoBack.Size = new System.Drawing.Size(54, 15);
            this.lbGoBack.TabIndex = 34;
            this.lbGoBack.Text = "Go Back";
            this.lbGoBack.Click += new System.EventHandler(this.lbGoBack_Click);
            // 
            // fWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lbGoBack);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.tbWithdrawAmt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fWithdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWithdrawAmt;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lbGoBack;
    }
}