using System.Data;
using System.Data.SqlClient;

namespace Seoul_Stay
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            LoadUserSetting();
        }

        private void LoadUserSetting()
        {
            if (Properties.Settings.Default.KeepMeSignedIn)
            {
                txtUser.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
                cbSignin.Checked = Properties.Settings.Default.KeepMeSignedIn;
                txtEmployee.Text = Properties.Settings.Default.Employee;
            }
        }


        public void RegisterUser()
        {
            if (IsInputValid())
            {
                bool isEmployeeAuthenticated = false;
                bool isUserAuthenticated = false;

                if (!string.IsNullOrWhiteSpace(txtEmployee.Text))
                {
                    isEmployeeAuthenticated = AuthenticateUser(txtEmployee.Text, txtPassword.Text);
                    if (isEmployeeAuthenticated)
                    {
                        MessageBox.Show("Welcome Employee", "Welcome", MessageBoxButtons.OK);
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtUser.Text))
                {
                    isUserAuthenticated = AuthenticateUser(txtUser.Text, txtPassword.Text);
                    if (isUserAuthenticated)
                    {
                        MessageBox.Show("Welcome User", "Welcome", MessageBoxButtons.OK);
                    }
                }

                if (isEmployeeAuthenticated || isUserAuthenticated)
                {
                    DialogResult result = MessageBox.Show("Successfully logged in", "Login", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        SaveUserSetting();
                        ShowManagementForm();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please enter your Username and Password...", "Error", MessageBoxButtons.OK);
            }
        }
        private bool IsInputValid()
        {
            return (!string.IsNullOrWhiteSpace(txtUser.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text)) ||
                   (!string.IsNullOrWhiteSpace(txtEmployee.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text));
        }
        private bool AuthenticateUser(string username, string password)
        {
            string SqlCode = @"SELECT Username, Password FROM Session1.dbo.Users 
                                WHERE Username = @Username AND Password = @Password";

            SqlCommand cmd = new SqlCommand(SqlCode);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            DataTable dt = SqlMethod.GetData(cmd);
            return dt.Rows.Count > 0;

        }
        private void SaveUserSetting()
        {
            if (cbSignin.Checked)
            {
                Properties.Settings.Default.Employee = txtEmployee.Text;
                Properties.Settings.Default.Username = txtUser.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.KeepMeSignedIn = true;
            }
            else
            {
                Properties.Settings.Default.Employee = string.Empty;
                Properties.Settings.Default.Username = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
                Properties.Settings.Default.KeepMeSignedIn = false;
            }
            Properties.Settings.Default.Save();
        }
        private void ShowManagementForm()
        {
            Management_form managementForm = new Management_form();
            this.Visible = false;
            managementForm.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return;
            }
            this.Close();
        }

        private void cbShowPw_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = cbShowPw.Checked;
        }

        private void lbCreateone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Create_Account_Form create_Account_Form = new Create_Account_Form();
            create_Account_Form.ShowDialog();
            this.Show();
        }

        private void txtEmployee_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmployee.Text))
            {
                txtUser.ReadOnly = true;
            }
            else
            {
                txtUser.ReadOnly = false;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUser.Text))
            {
                txtEmployee.ReadOnly = true;
            }
            else
            {
                txtEmployee.ReadOnly = false;
            }
        }
    }
}
