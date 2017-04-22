namespace BankClient
{
    partial class RegisterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.regSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.regTelephone = new System.Windows.Forms.TextBox();
            this.regEmail = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.regSecName = new System.Windows.Forms.TextBox();
            this.regName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Введені дані не піддаються розголошенню";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.regSend);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.regTelephone);
            this.groupBox1.Controls.Add(this.regEmail);
            this.groupBox1.Controls.Add(this.regPassword);
            this.groupBox1.Controls.Add(this.regSecName);
            this.groupBox1.Controls.Add(this.regName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(14, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 356);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Особисті дані:";
            // 
            // regSend
            // 
            this.regSend.Location = new System.Drawing.Point(321, 312);
            this.regSend.Name = "regSend";
            this.regSend.Size = new System.Drawing.Size(140, 38);
            this.regSend.TabIndex = 5;
            this.regSend.Text = "Зареєструватися";
            this.regSend.UseVisualStyleBackColor = true;
            this.regSend.Click += new System.EventHandler(this.regSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Усі дані обов\'язкові для заповнення";
            // 
            // regTelephone
            // 
            this.regTelephone.Location = new System.Drawing.Point(220, 270);
            this.regTelephone.Name = "regTelephone";
            this.regTelephone.Size = new System.Drawing.Size(241, 22);
            this.regTelephone.TabIndex = 4;
            // 
            // regEmail
            // 
            this.regEmail.Location = new System.Drawing.Point(220, 220);
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(241, 22);
            this.regEmail.TabIndex = 3;
            // 
            // regPassword
            // 
            this.regPassword.Location = new System.Drawing.Point(220, 168);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(241, 22);
            this.regPassword.TabIndex = 2;
            // 
            // regSecName
            // 
            this.regSecName.Location = new System.Drawing.Point(220, 113);
            this.regSecName.Name = "regSecName";
            this.regSecName.Size = new System.Drawing.Size(241, 22);
            this.regSecName.TabIndex = 1;
            // 
            // regName
            // 
            this.regName.Location = new System.Drawing.Point(220, 57);
            this.regName.Name = "regName";
            this.regName.Size = new System.Drawing.Size(241, 22);
            this.regName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(61, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ім\'я:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(61, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Прізвище:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(61, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Пароль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(61, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Пошта:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(61, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Телефон:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "Реєстрація";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regTelephone;
        private System.Windows.Forms.TextBox regEmail;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.TextBox regSecName;
        private System.Windows.Forms.TextBox regName;
        private System.Windows.Forms.Button regSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}