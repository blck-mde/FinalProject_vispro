namespace FinalProject_vispro
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.emailPhone = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.blmPnyaAkun = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(508, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(946, 131);
            this.label1.TabIndex = 0;
            this.label1.Text = "GG!- Girls Guide";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(705, 349);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(541, 31);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(704, 504);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(541, 31);
            this.txtPassword.TabIndex = 2;
            // 
            // emailPhone
            // 
            this.emailPhone.AutoSize = true;
            this.emailPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.emailPhone.ForeColor = System.Drawing.Color.RosyBrown;
            this.emailPhone.Location = new System.Drawing.Point(709, 320);
            this.emailPhone.Name = "emailPhone";
            this.emailPhone.Size = new System.Drawing.Size(0, 25);
            this.emailPhone.TabIndex = 3;
            this.emailPhone.Click += new System.EventHandler(this.emailPhone_Click);
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(709, 474);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(106, 25);
            this.Pass.TabIndex = 4;
            this.Pass.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogin.Location = new System.Drawing.Point(704, 643);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(541, 68);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // blmPnyaAkun
            // 
            this.blmPnyaAkun.AutoSize = true;
            this.blmPnyaAkun.Location = new System.Drawing.Point(793, 796);
            this.blmPnyaAkun.Name = "blmPnyaAkun";
            this.blmPnyaAkun.Size = new System.Drawing.Size(206, 25);
            this.blmPnyaAkun.TabIndex = 6;
            this.blmPnyaAkun.Text = "Belum Punya Akun?";
            this.blmPnyaAkun.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.ForeColor = System.Drawing.Color.DimGray;
            this.btnSignUp.Location = new System.Drawing.Point(1005, 774);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(148, 68);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "Sign-Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(567, 205);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(825, 785);
            this.progressBar2.TabIndex = 32;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Username or Phone Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1972, 1105);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.blmPnyaAkun);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.emailPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar2);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "FormLogin";
            this.Text = "GG! - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label emailPhone;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label blmPnyaAkun;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label2;
    }
}

