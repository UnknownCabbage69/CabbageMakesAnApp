namespace TokaApp
{
    partial class frmPremium
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
            this.SuspendLayout();
            // 
            // btnJoinNow
            // 
            this.btnJoinNow.BackColor = System.Drawing.Color.White;
            this.btnJoinNow.BackgroundImage = global::TokaApp.Properties.Resources.Join_Nowbtm;
            this.btnJoinNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJoinNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinNow.ForeColor = System.Drawing.Color.Transparent;
            this.btnJoinNow.Location = new System.Drawing.Point(469, 354);
            this.btnJoinNow.Name = "btnJoinNow";
            this.btnJoinNow.Size = new System.Drawing.Size(147, 31);
            this.btnJoinNow.TabIndex = 0;
            this.btnJoinNow.UseVisualStyleBackColor = false;
            this.btnJoinNow.Click += new System.EventHandler(this.btnJoinNow_Click);
            // 
            // frmPremium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TokaApp.Properties.Resources.PremiumPage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.btnJoinNow);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPremium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPremium";
            this.Load += new System.EventHandler(this.frmPremium_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJoinNow;
    }
}