
namespace Coursework
{
    partial class LoginAndRegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Registerpanel = new System.Windows.Forms.Panel();
            this.TypeDropdown = new System.Windows.Forms.ComboBox();
            this.PasswordConfirmText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.Loginpanel = new System.Windows.Forms.Panel();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_GoToRegister = new System.Windows.Forms.Button();
            this.button_GoToLogin = new System.Windows.Forms.Button();
            this.lab = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.Registerpanel.SuspendLayout();
            this.Loginpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.Loginpanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Registerpanel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 629);
            this.panel1.TabIndex = 0;
            // 
            // Registerpanel
            // 
            this.Registerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Registerpanel.Controls.Add(this.TypeDropdown);
            this.Registerpanel.Controls.Add(this.PasswordConfirmText);
            this.Registerpanel.Controls.Add(this.label6);
            this.Registerpanel.Controls.Add(this.EmailText);
            this.Registerpanel.Controls.Add(this.label5);
            this.Registerpanel.Controls.Add(this.PasswordText);
            this.Registerpanel.Controls.Add(this.label4);
            this.Registerpanel.Controls.Add(this.UsernameText);
            this.Registerpanel.Controls.Add(this.label3);
            this.Registerpanel.Controls.Add(this.LastNameText);
            this.Registerpanel.Controls.Add(this.label2);
            this.Registerpanel.Controls.Add(this.FirstNameText);
            this.Registerpanel.Controls.Add(this.label1);
            this.Registerpanel.Controls.Add(this.buttonRegister);
            this.Registerpanel.Location = new System.Drawing.Point(11, 122);
            this.Registerpanel.Name = "Registerpanel";
            this.Registerpanel.Size = new System.Drawing.Size(590, 494);
            this.Registerpanel.TabIndex = 7;
            // 
            // TypeDropdown
            // 
            this.TypeDropdown.FormattingEnabled = true;
            this.TypeDropdown.Items.AddRange(new object[] {
            "USER",
            "ADMIN"});
            this.TypeDropdown.Location = new System.Drawing.Point(211, 362);
            this.TypeDropdown.Name = "TypeDropdown";
            this.TypeDropdown.Size = new System.Drawing.Size(160, 28);
            this.TypeDropdown.TabIndex = 8;
            // 
            // PasswordConfirmText
            // 
            this.PasswordConfirmText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordConfirmText.ForeColor = System.Drawing.Color.Gray;
            this.PasswordConfirmText.Location = new System.Drawing.Point(193, 230);
            this.PasswordConfirmText.Name = "PasswordConfirmText";
            this.PasswordConfirmText.Size = new System.Drawing.Size(344, 26);
            this.PasswordConfirmText.TabIndex = 17;
            this.PasswordConfirmText.Text = "Confirm Password";
            this.PasswordConfirmText.Enter += new System.EventHandler(this.PasswordConfirmText_Enter);
            this.PasswordConfirmText.Leave += new System.EventHandler(this.PasswordConfirmText_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Confirm Password: ";
            // 
            // EmailText
            // 
            this.EmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.ForeColor = System.Drawing.Color.Gray;
            this.EmailText.Location = new System.Drawing.Point(193, 280);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(344, 26);
            this.EmailText.TabIndex = 17;
            this.EmailText.Text = "Email address";
            this.EmailText.Enter += new System.EventHandler(this.EmailText_Enter);
            this.EmailText.Leave += new System.EventHandler(this.EmailText_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email: ";
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.ForeColor = System.Drawing.Color.Gray;
            this.PasswordText.Location = new System.Drawing.Point(193, 179);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(344, 26);
            this.PasswordText.TabIndex = 15;
            this.PasswordText.Text = "Password";
            this.PasswordText.Enter += new System.EventHandler(this.PasswordText_Enter);
            this.PasswordText.Leave += new System.EventHandler(this.PasswordText_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password: ";
            // 
            // UsernameText
            // 
            this.UsernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameText.ForeColor = System.Drawing.Color.Gray;
            this.UsernameText.Location = new System.Drawing.Point(193, 124);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(344, 26);
            this.UsernameText.TabIndex = 13;
            this.UsernameText.Text = "Username";
            this.UsernameText.Enter += new System.EventHandler(this.UsernameText_Enter);
            this.UsernameText.Leave += new System.EventHandler(this.UsernameText_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username: ";
            // 
            // LastNameText
            // 
            this.LastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameText.ForeColor = System.Drawing.Color.Gray;
            this.LastNameText.Location = new System.Drawing.Point(193, 73);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(344, 26);
            this.LastNameText.TabIndex = 11;
            this.LastNameText.Text = "Last name";
            this.LastNameText.Enter += new System.EventHandler(this.LastNameText_Enter);
            this.LastNameText.Leave += new System.EventHandler(this.LastNameText_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lastname: ";
            // 
            // FirstNameText
            // 
            this.FirstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameText.ForeColor = System.Drawing.Color.Gray;
            this.FirstNameText.Location = new System.Drawing.Point(193, 18);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(344, 26);
            this.FirstNameText.TabIndex = 9;
            this.FirstNameText.Text = "First name";
            this.FirstNameText.Enter += new System.EventHandler(this.FirstNameText_Enter);
            this.FirstNameText.Leave += new System.EventHandler(this.FirstNameText_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Firstname: ";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(36, 396);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(511, 73);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // Loginpanel
            // 
            this.Loginpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Loginpanel.Controls.Add(this.TypeBox);
            this.Loginpanel.Controls.Add(this.Loginbutton);
            this.Loginpanel.Controls.Add(this.pass);
            this.Loginpanel.Controls.Add(this.UserName);
            this.Loginpanel.Controls.Add(this.Password);
            this.Loginpanel.Controls.Add(this.user);
            this.Loginpanel.Location = new System.Drawing.Point(11, 122);
            this.Loginpanel.Name = "Loginpanel";
            this.Loginpanel.Size = new System.Drawing.Size(590, 491);
            this.Loginpanel.TabIndex = 9;
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "USER",
            "ADMIN"});
            this.TypeBox.Location = new System.Drawing.Point(211, 292);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(160, 28);
            this.TypeBox.TabIndex = 6;
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.ForeColor = System.Drawing.Color.White;
            this.Loginbutton.Location = new System.Drawing.Point(36, 366);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(511, 73);
            this.Loginbutton.TabIndex = 1;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(211, 176);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(344, 26);
            this.pass.TabIndex = 4;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(33, 99);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(91, 20);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Username: ";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(33, 179);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(86, 20);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password: ";
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(214, 99);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(344, 26);
            this.user.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_GoToRegister);
            this.panel2.Controls.Add(this.button_GoToLogin);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 116);
            this.panel2.TabIndex = 0;
            // 
            // button_GoToRegister
            // 
            this.button_GoToRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_GoToRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GoToRegister.ForeColor = System.Drawing.Color.White;
            this.button_GoToRegister.Location = new System.Drawing.Point(311, 23);
            this.button_GoToRegister.Name = "button_GoToRegister";
            this.button_GoToRegister.Size = new System.Drawing.Size(290, 73);
            this.button_GoToRegister.TabIndex = 1;
            this.button_GoToRegister.Text = "Register";
            this.button_GoToRegister.UseVisualStyleBackColor = false;
            this.button_GoToRegister.Click += new System.EventHandler(this.button_GoToRegister_Click);
            // 
            // button_GoToLogin
            // 
            this.button_GoToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_GoToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GoToLogin.ForeColor = System.Drawing.Color.White;
            this.button_GoToLogin.Location = new System.Drawing.Point(11, 23);
            this.button_GoToLogin.Name = "button_GoToLogin";
            this.button_GoToLogin.Size = new System.Drawing.Size(290, 73);
            this.button_GoToLogin.TabIndex = 1;
            this.button_GoToLogin.Text = "Login";
            this.button_GoToLogin.UseVisualStyleBackColor = false;
            this.button_GoToLogin.Click += new System.EventHandler(this.button_GoToLogin_Click);
            // 
            // LoginAndRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 624);
            this.Controls.Add(this.panel1);
            this.Name = "LoginAndRegisterForm";
            this.Text = "LoginAndRegisterForm";
            this.panel1.ResumeLayout(false);
            this.Registerpanel.ResumeLayout(false);
            this.Registerpanel.PerformLayout();
            this.Loginpanel.ResumeLayout(false);
            this.Loginpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_GoToRegister;
        private System.Windows.Forms.Button button_GoToLogin;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button Loginbutton;
        private System.ComponentModel.BackgroundWorker lab;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Panel Registerpanel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeDropdown;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Loginpanel;
        private System.Windows.Forms.TextBox PasswordConfirmText;
        private System.Windows.Forms.Label label6;
    }
}

