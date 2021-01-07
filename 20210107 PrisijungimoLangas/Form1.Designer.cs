
namespace _20210107_PrisijungimoLangas
{
    partial class prisijungimoForma
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
            this.vartotojasLabel = new System.Windows.Forms.Label();
            this.passwrodLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.LoggedInUserLabel = new System.Windows.Forms.Label();
            this.statusIndicationLabel = new System.Windows.Forms.Label();
            this.loggedInUserIndicationLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vartotojasLabel
            // 
            this.vartotojasLabel.AutoSize = true;
            this.vartotojasLabel.Location = new System.Drawing.Point(12, 32);
            this.vartotojasLabel.Name = "vartotojasLabel";
            this.vartotojasLabel.Size = new System.Drawing.Size(53, 13);
            this.vartotojasLabel.TabIndex = 0;
            this.vartotojasLabel.Text = "vartotojas";
            // 
            // passwrodLabel
            // 
            this.passwrodLabel.AutoSize = true;
            this.passwrodLabel.Location = new System.Drawing.Point(12, 68);
            this.passwrodLabel.Name = "passwrodLabel";
            this.passwrodLabel.Size = new System.Drawing.Size(59, 13);
            this.passwrodLabel.TabIndex = 1;
            this.passwrodLabel.Text = "slaptazodis";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(12, 106);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "prisijungti";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(77, 29);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(100, 20);
            this.userTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(77, 65);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.MouseEnter += new System.EventHandler(this.passwordTextBox_MouseEnter);
            this.passwordTextBox.MouseLeave += new System.EventHandler(this.passwordTextBox_MouseLeave);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(93, 106);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "atsijungti";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(15, 148);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(49, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "statusas:";
            // 
            // LoggedInUserLabel
            // 
            this.LoggedInUserLabel.AutoSize = true;
            this.LoggedInUserLabel.Location = new System.Drawing.Point(15, 181);
            this.LoggedInUserLabel.Name = "LoggedInUserLabel";
            this.LoggedInUserLabel.Size = new System.Drawing.Size(108, 13);
            this.LoggedInUserLabel.TabIndex = 7;
            this.LoggedInUserLabel.Text = "prisijunges vartotojas:";
            // 
            // statusIndicationLabel
            // 
            this.statusIndicationLabel.AutoSize = true;
            this.statusIndicationLabel.ForeColor = System.Drawing.Color.Red;
            this.statusIndicationLabel.Location = new System.Drawing.Point(90, 148);
            this.statusIndicationLabel.Name = "statusIndicationLabel";
            this.statusIndicationLabel.Size = new System.Drawing.Size(66, 13);
            this.statusIndicationLabel.TabIndex = 8;
            this.statusIndicationLabel.Text = "neprisijungta";
            // 
            // loggedInUserIndicationLbl
            // 
            this.loggedInUserIndicationLbl.AutoSize = true;
            this.loggedInUserIndicationLbl.Location = new System.Drawing.Point(133, 181);
            this.loggedInUserIndicationLbl.Name = "loggedInUserIndicationLbl";
            this.loggedInUserIndicationLbl.Size = new System.Drawing.Size(0, 13);
            this.loggedInUserIndicationLbl.TabIndex = 9;
            // 
            // prisijungimoForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 219);
            this.Controls.Add(this.loggedInUserIndicationLbl);
            this.Controls.Add(this.statusIndicationLabel);
            this.Controls.Add(this.LoggedInUserLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwrodLabel);
            this.Controls.Add(this.vartotojasLabel);
            this.Name = "prisijungimoForma";
            this.Text = "Prisijungimo Langas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vartotojasLabel;
        private System.Windows.Forms.Label passwrodLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label LoggedInUserLabel;
        private System.Windows.Forms.Label statusIndicationLabel;
        private System.Windows.Forms.Label loggedInUserIndicationLbl;
    }
}

