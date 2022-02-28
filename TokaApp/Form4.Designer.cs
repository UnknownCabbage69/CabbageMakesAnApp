namespace TokaApp
{
    partial class Form4
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
            this.BtnSignInHere = new System.Windows.Forms.Button();
            this.BtnSignUpConf = new System.Windows.Forms.Button();
            this.txtUsernameDB = new System.Windows.Forms.TextBox();
            this.txtPasswordDB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSignInHere
            // 
            this.BtnSignInHere.BackColor = System.Drawing.Color.Transparent;
            this.BtnSignInHere.BackgroundImage = global::TokaApp.Properties.Resources.btnSigninhere;
            this.BtnSignInHere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSignInHere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignInHere.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSignInHere.Location = new System.Drawing.Point(728, 505);
            this.BtnSignInHere.Name = "BtnSignInHere";
            this.BtnSignInHere.Size = new System.Drawing.Size(190, 30);
            this.BtnSignInHere.TabIndex = 4;
            this.BtnSignInHere.UseVisualStyleBackColor = false;
            this.BtnSignInHere.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // BtnSignUpConf
            // 
            this.BtnSignUpConf.BackColor = System.Drawing.Color.Transparent;
            this.BtnSignUpConf.BackgroundImage = global::TokaApp.Properties.Resources.btnSignUp;
            this.BtnSignUpConf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSignUpConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUpConf.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSignUpConf.Location = new System.Drawing.Point(563, 408);
            this.BtnSignUpConf.Name = "BtnSignUpConf";
            this.BtnSignUpConf.Size = new System.Drawing.Size(258, 39);
            this.BtnSignUpConf.TabIndex = 5;
            this.BtnSignUpConf.UseVisualStyleBackColor = false;
            this.BtnSignUpConf.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUsernameDB
            // 
            this.txtUsernameDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameDB.Location = new System.Drawing.Point(570, 259);
            this.txtUsernameDB.Name = "txtUsernameDB";
            this.txtUsernameDB.Size = new System.Drawing.Size(241, 13);
            this.txtUsernameDB.TabIndex = 6;
            this.txtUsernameDB.TextChanged += new System.EventHandler(this.txtUsernameDB_TextChanged);
            // 
            // txtPasswordDB
            // 
            this.txtPasswordDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordDB.Location = new System.Drawing.Point(570, 353);
            this.txtPasswordDB.Name = "txtPasswordDB";
            this.txtPasswordDB.PasswordChar = '•';
            this.txtPasswordDB.Size = new System.Drawing.Size(241, 13);
            this.txtPasswordDB.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::TokaApp.Properties.Resources.mini;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(883, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::TokaApp.Properties.Resources.x;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(914, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cbShowPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbShowPass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cbShowPass.FlatAppearance.BorderSize = 0;
            this.cbShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbShowPass.ForeColor = System.Drawing.Color.Transparent;
            this.cbShowPass.Location = new System.Drawing.Point(681, 389);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(13, 12);
            this.cbShowPass.TabIndex = 10;
            this.cbShowPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbShowPass.UseVisualStyleBackColor = false;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Image = global::TokaApp.Properties.Resources.Check_Password3;
            this.label1.Location = new System.Drawing.Point(682, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "                                                ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TokaApp.Properties.Resources.signherecompleted;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPasswordDB);
            this.Controls.Add(this.txtUsernameDB);
            this.Controls.Add(this.BtnSignUpConf);
            this.Controls.Add(this.BtnSignInHere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSignInHere;
        private System.Windows.Forms.Button BtnSignUpConf;
        private System.Windows.Forms.TextBox txtUsernameDB;
        private System.Windows.Forms.TextBox txtPasswordDB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.Label label1;
    }
}