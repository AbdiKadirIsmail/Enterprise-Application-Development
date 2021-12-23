using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Coursework
{
    public partial class LoginAndRegisterForm : Form
    {
        public LoginAndRegisterForm()
        {
            InitializeComponent();
            
        }
        public static string loginuser;
        public static string passuser;
        public static string emailuser;
        public static string fname;
        public static string lname;

        Color Select_colour = Color.FromArgb(22, 22, 22);
            

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // remove the focus from the textboxes
            this.ActiveControl = label1;
        }

        private void button_GoToLogin_Click(object sender, EventArgs e)
        {
            Loginpanel.BringToFront();
            button_GoToLogin.BackColor = Select_colour;
            Loginpanel.BackColor = Select_colour;
        }
        private void button_GoToRegister_Click(object sender, EventArgs e)
        {
            Registerpanel.BringToFront();
            button_GoToRegister.BackColor = Select_colour;
            Registerpanel.BackColor = Select_colour;
        }
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Account WHERE Username = @user AND Password = @pass";
            SQLiteConnection conn1 = new SQLiteConnection(@"Data Source=F:\Computer Science\CS 2020-2021\MODULE (2020) 6COSC001W.1 Enterprise Application Development\Coursework\CWK2\Coursework\Coursework\AccountDB.db;Version=3;");
            conn1.Open();
            SQLiteCommand cmd1 = new SQLiteCommand(query, conn1);
            cmd1.Parameters.AddWithValue("@user", user.Text);
            cmd1.Parameters.AddWithValue("@pass", pass.Text);
            SQLiteDataAdapter db = new SQLiteDataAdapter(cmd1);
            DataTable dt = new DataTable();
            db.Fill(dt);


            //if (user.Text.Trim() == "" && pass.Text.Trim() == "") 
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("You are Logged in", "Login Successfull");
                loginuser = user.Text;
                passuser = pass.Text;
                emailuser = EmailText.Text;
                fname = FirstNameText.Text;
                lname = LastNameText.Text;
                this.Hide();
                MainDashboard maindashboard = new MainDashboard();
                maindashboard.Show();
            }
            else
            {
                if (user.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pass.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        public void buttonRegister_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn2 = new SQLiteConnection(@"Data Source=F:\Computer Science\CS 2020-2021\MODULE (2020) 6COSC001W.1 Enterprise Application Development\Coursework\CWK2\Coursework\Coursework\AccountDB.db;Version=3;");
            SQLiteCommand cmd2 = new SQLiteCommand("INSERT INTO Account(FirstName, LastName, Email, Username, Password) VALUES (@fn, @ln, @email, @usn, @pass)", conn2);
            cmd2.Parameters.AddWithValue("@usn", UsernameText.Text);
            cmd2.Parameters.AddWithValue("@pass", PasswordText.Text);
            cmd2.Parameters.AddWithValue("@fn", FirstNameText.Text);
            cmd2.Parameters.AddWithValue("@ln", LastNameText.Text);
            cmd2.Parameters.AddWithValue("@email", EmailText.Text);
            //cmd2.Parameters.AddWithValue("@type", TypeText.Text);
            conn2.Open();
             // check if the textboxes contains the default values 
            if (!checkTextBoxesValues())
            {
                // check if the password equal the confirm password
                if(PasswordText.Text.Equals(PasswordConfirmText.Text))
                {
                    // check if this username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One","Duplicate Username",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    }
                    else
                    {
                        // execute the query
                        if (cmd2.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created","Account Created",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password","Password Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Enter Your Informations First","Empty Data",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }




            conn2.Close();
        }
        public Boolean checkUsername()
        {
            DataTable table = new DataTable();
            string query = "SELECT * FROM Account WHERE Username = @user";
            SQLiteConnection conn2 = new SQLiteConnection(@"Data Source=F:\Computer Science\CS 2020-2021\MODULE (2020) 6COSC001W.1 Enterprise Application Development\Coursework\CWK2\Coursework\Coursework\AccountDB.db;Version=3;");
            conn2.Open();
            SQLiteCommand cmd2 = new SQLiteCommand(query, conn2);
            cmd2.Parameters.AddWithValue("@user", UserName.Text);

            SQLiteDataAdapter db2 = new SQLiteDataAdapter(cmd2);
            DataTable dt = new DataTable();
            db2.Fill(dt);


            // check if this username already exists in the database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean checkTextBoxesValues()
        {
            String fname = FirstNameText.Text;
            String lname = LastNameText.Text;
            String email = EmailText.Text;
            String uname = UsernameText.Text;
            String pass = PasswordText.Text;

            if (fname.Equals("first name") || lname.Equals("last name") ||
                email.Equals("email address") || uname.Equals("username")
                || pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    
    private void FirstNameText_Enter(object sender, EventArgs e)
        {
            String fname = FirstNameText.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                FirstNameText.Text = "";
                FirstNameText.ForeColor = Color.Black;
            }
        }

        private void FirstNameText_Leave(object sender, EventArgs e)
        {
            String fname = FirstNameText.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                FirstNameText.Text = "first name";
                FirstNameText.ForeColor = Color.Gray;
            }
        }

        private void LastNameText_Enter(object sender, EventArgs e)
        {
            String lname = LastNameText.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                LastNameText.Text = "";
                LastNameText.ForeColor = Color.Black;
            }
        }

        private void LastNameText_Leave(object sender, EventArgs e)
        {
            String lname = LastNameText.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                LastNameText.Text = "last name";
                LastNameText.ForeColor = Color.Gray;
            }
        }

        private void EmailText_Enter(object sender, EventArgs e)
        {
            String email = EmailText.Text;
            if (email.ToLower().Trim().Equals("email address"))
            {
                EmailText.Text = "";
                EmailText.ForeColor = Color.Black;
            }
        }

        private void EmailText_Leave(object sender, EventArgs e)
        {
            String email = EmailText.Text;
            if (email.ToLower().Trim().Equals("email address") || email.Trim().Equals(""))
            {
                EmailText.Text = "email address";
                EmailText.ForeColor = Color.Gray;
            }
        }

        private void UsernameText_Enter(object sender, EventArgs e)
        {
            String username = UsernameText.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                UsernameText.Text = "";
                UsernameText.ForeColor = Color.Black;
            }
        }

        private void UsernameText_Leave(object sender, EventArgs e)
        {
            String username = UsernameText.Text;
            if (username.ToLower().Trim().Equals("username") || username.Trim().Equals(""))
            {
                UsernameText.Text = "username";
                UsernameText.ForeColor = Color.Gray;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            String password = PasswordText.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                PasswordText.Text = "";
                PasswordText.UseSystemPasswordChar = true;
                PasswordText.ForeColor = Color.Black;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            String password = PasswordText.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                PasswordText.Text = "password";
                PasswordText.UseSystemPasswordChar = false;
                PasswordText.ForeColor = Color.Gray;
            }
        }
        private void PasswordConfirmText_Enter(object sender, EventArgs e)
        {
            String cpassword = PasswordConfirmText.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password"))
            {
                PasswordConfirmText.Text = "";
                PasswordConfirmText.UseSystemPasswordChar = true;
                PasswordConfirmText.ForeColor = Color.Black;
            }
        }

        private void PasswordConfirmText_Leave(object sender, EventArgs e)
        {
            String cpassword = PasswordConfirmText.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password") ||
                cpassword.ToLower().Trim().Equals("password") ||
                cpassword.Trim().Equals(""))
            {
                PasswordConfirmText.Text = "confirm password";
                PasswordConfirmText.UseSystemPasswordChar = false;
                PasswordConfirmText.ForeColor = Color.Gray;
            }
        }



    }
}
