
namespace TokaApp
{
    partial class Payment
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
            this.btnJoinNow = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtMMYY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJoinNow
            // 
            this.btnJoinNow.BackColor = System.Drawing.Color.Transparent;
            this.btnJoinNow.BackgroundImage = global::TokaApp.Properties.Resources.SUBMIT_PAYMENT;
            this.btnJoinNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJoinNow.FlatAppearance.BorderSize = 0;
            this.btnJoinNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinNow.ForeColor = System.Drawing.Color.Transparent;
            this.btnJoinNow.Location = new System.Drawing.Point(213, 375);
            this.btnJoinNow.Name = "btnJoinNow";
            this.btnJoinNow.Size = new System.Drawing.Size(296, 44);
            this.btnJoinNow.TabIndex = 16;
            this.btnJoinNow.UseVisualStyleBackColor = false;
            this.btnJoinNow.Click += new System.EventHandler(this.btnJoinNow_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.Location = new System.Drawing.Point(45, 183);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(285, 22);
            this.txtUsername.TabIndex = 17;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Location = new System.Drawing.Point(398, 183);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(285, 22);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtSurname_Leave);
            // 
            // txtCardNum
            // 
            this.txtCardNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNum.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCardNum.Location = new System.Drawing.Point(45, 247);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(427, 22);
            this.txtCardNum.TabIndex = 19;
            this.txtCardNum.Text = "Card Number";
            this.txtCardNum.TextChanged += new System.EventHandler(this.txtCardNum_TextChanged);
            this.txtCardNum.Enter += new System.EventHandler(this.txtCardNum_Enter);
            this.txtCardNum.Leave += new System.EventHandler(this.txtCardNum_Leave);
            // 
            // txtCVV
            // 
            this.txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVV.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCVV.Location = new System.Drawing.Point(544, 247);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(139, 22);
            this.txtCVV.TabIndex = 20;
            this.txtCVV.Text = "CVV";
            this.txtCVV.TextChanged += new System.EventHandler(this.txtCVV_TextChanged);
            this.txtCVV.Enter += new System.EventHandler(this.textBox3_Enter);
            this.txtCVV.Leave += new System.EventHandler(this.txtCVV_Leave);
            // 
            // txtMMYY
            // 
            this.txtMMYY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMMYY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMMYY.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMMYY.Location = new System.Drawing.Point(544, 310);
            this.txtMMYY.Name = "txtMMYY";
            this.txtMMYY.Size = new System.Drawing.Size(139, 22);
            this.txtMMYY.TabIndex = 21;
            this.txtMMYY.Text = "MM/YYYY";
            this.txtMMYY.TextChanged += new System.EventHandler(this.txtMMYY_TextChanged);
            this.txtMMYY.Enter += new System.EventHandler(this.txtMMYY_Enter);
            this.txtMMYY.Leave += new System.EventHandler(this.txtMMYY_Leave);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TokaApp.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.txtMMYY);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.txtCardNum);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnJoinNow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJoinNow;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtMMYY;
    }
}