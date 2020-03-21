namespace JakubPietrusLab4Zadanie
{
    partial class FormSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.textBoxNewUserLogin = new System.Windows.Forms.TextBox();
            this.textBoxNewUserPassword = new System.Windows.Forms.TextBox();
            this.labelNewUserLogin = new System.Windows.Forms.Label();
            this.labelNewUserPassword = new System.Windows.Forms.Label();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.buttonExitSignInForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNewUserLogin
            // 
            this.textBoxNewUserLogin.Location = new System.Drawing.Point(368, 137);
            this.textBoxNewUserLogin.Name = "textBoxNewUserLogin";
            this.textBoxNewUserLogin.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewUserLogin.TabIndex = 0;
            // 
            // textBoxNewUserPassword
            // 
            this.textBoxNewUserPassword.Location = new System.Drawing.Point(368, 206);
            this.textBoxNewUserPassword.Name = "textBoxNewUserPassword";
            this.textBoxNewUserPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewUserPassword.TabIndex = 1;
            this.textBoxNewUserPassword.UseSystemPasswordChar = true;
            // 
            // labelNewUserLogin
            // 
            this.labelNewUserLogin.AutoSize = true;
            this.labelNewUserLogin.Location = new System.Drawing.Point(279, 142);
            this.labelNewUserLogin.Name = "labelNewUserLogin";
            this.labelNewUserLogin.Size = new System.Drawing.Size(43, 17);
            this.labelNewUserLogin.TabIndex = 2;
            this.labelNewUserLogin.Text = "Login";
            // 
            // labelNewUserPassword
            // 
            this.labelNewUserPassword.AutoSize = true;
            this.labelNewUserPassword.Location = new System.Drawing.Point(279, 209);
            this.labelNewUserPassword.Name = "labelNewUserPassword";
            this.labelNewUserPassword.Size = new System.Drawing.Size(69, 17);
            this.labelNewUserPassword.TabIndex = 3;
            this.labelNewUserPassword.Text = "Password";
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(368, 275);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(122, 30);
            this.buttonCreateAccount.TabIndex = 4;
            this.buttonCreateAccount.Text = "Stwórz konto!";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // buttonExitSignInForm
            // 
            this.buttonExitSignInForm.Location = new System.Drawing.Point(671, 399);
            this.buttonExitSignInForm.Name = "buttonExitSignInForm";
            this.buttonExitSignInForm.Size = new System.Drawing.Size(117, 39);
            this.buttonExitSignInForm.TabIndex = 5;
            this.buttonExitSignInForm.Text = "Wyjdź";
            this.buttonExitSignInForm.UseVisualStyleBackColor = true;
            this.buttonExitSignInForm.Click += new System.EventHandler(this.buttonExitSignInForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(249, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dołącz do nas!!!";
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExitSignInForm);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.labelNewUserPassword);
            this.Controls.Add(this.labelNewUserLogin);
            this.Controls.Add(this.textBoxNewUserPassword);
            this.Controls.Add(this.textBoxNewUserLogin);
            this.Name = "FormSignIn";
            this.Text = "FormSignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewUserLogin;
        private System.Windows.Forms.TextBox textBoxNewUserPassword;
        private System.Windows.Forms.Label labelNewUserLogin;
        private System.Windows.Forms.Label labelNewUserPassword;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonExitSignInForm;
        private System.Windows.Forms.Label label1;
    }
}