using System.Data;
using System.Data.SqlClient;

namespace Seoul_Stay
{
    public partial class Create_Account_Form : Form
    {
        private bool ViewTerm = false;
        private bool isRegistering = false;
        public Create_Account_Form()
        {
            InitializeComponent();
            termsCheckBox.Checked = false;
            termsCheckBox.Checked = false;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ViewTerm)
            {
                MessageBox.Show("Please view the Terms and Conditions before registering.");
                return;
            }

            else if (!termsCheckBox.Checked)
            {
                MessageBox.Show("Please agree to the Terms and Conditions before registering.");
                return;
            }

            else if (!IsInputValid())
            {
                MessageBox.Show("Please add your information...");
                return;
            }

            else if (!isRegistering)
            {
                isRegistering = true;
            }

            if (RegisterUser())
            {
                Management_form mn = new Management_form();
                mn.ShowDialog();
            }

        }
        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
        string.IsNullOrWhiteSpace(txtFullname.Text) ||
        string.IsNullOrWhiteSpace(txtPw.Text) ||
        string.IsNullOrWhiteSpace(txtRetypePw.Text) ||
        (!rbMale.Checked && !rbFemale.Checked) ||
        !termsCheckBox.Checked)
            {
                MessageBox.Show("Please fill out all required fields and accept the terms and conditions.");
                return false;
            }

            if (txtPw.Text != txtRetypePw.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }

            if (txtPw.Text.Length < 5)
            {
                MessageBox.Show("Password must be at least 5 characters long.");
                return false;
            }

            return true;
        }
        private bool RegisterUser()
        {
            int genderBit = rbFemale.Checked ? 0 : 1;
            Guid userGuid = Guid.NewGuid();
            string sqlCode = @"INSERT INTO Users (Username,GUID,Gender,FullName,FamilyCount,BirthDate,Password,UserTypeID)
                       VALUES (@Username, @GUID,@Gender, @FullName, @FamilyCount, @BirthDate, @Password,@UserTypeID);";

            SqlCommand cmd = new SqlCommand(sqlCode);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@FullName", txtFullname.Text);
            cmd.Parameters.AddWithValue("@GUID", userGuid);
            cmd.Parameters.AddWithValue("@Gender", genderBit);
            cmd.Parameters.AddWithValue("@FamilyCount", numericUpDownMember.Value);
            cmd.Parameters.AddWithValue("@BirthDate", dtpBirthday.Value);
            cmd.Parameters.AddWithValue("@Password", txtPw.Text);
            cmd.Parameters.AddWithValue("@UserTypeID", 2);
            DataTable dt = SqlMethod.GetData(cmd);
            if (dt.Rows.Count <= 0)
            {
                DialogResult dr = MessageBox.Show("Register successful!!", "info", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    return true;
                }
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("You already have an account...");
            }
            return false;
        }

        private void GoToLoginForm()
        {
            this.Hide();
            Login_Form loginForm = new Login_Form();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnReturnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form Ln = new Login_Form();
            Ln.ShowDialog();
            this.Close();
        }
        private void ClearInputFields()
        {
            txtUsername.Clear();
            txtFullname.Clear();
            txtPw.Clear();
            txtRetypePw.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            numericUpDownMember.Value = 0;
            dtpBirthday.Value = DateTime.Now;
            termsCheckBox.Checked = false;
            termsCheckBox.Enabled = false;
            ViewTerm = false;
        }

        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!ViewTerm)
            {
                termsCheckBox.Checked = false;
                MessageBox.Show("Please view the terms and conditions before agreeing.");
            }
            else
            {
                termsCheckBox.Enabled = false;
                if (!termsCheckBox.Checked)
                {
                    MessageBox.Show("Please agree to the terms and conditions.");
                }
            }
        }

        private void linkLabelViewTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Terms and Conditions content here...");
            termsCheckBox.Enabled = true;
            ViewTerm = true;
        }
    }
}




