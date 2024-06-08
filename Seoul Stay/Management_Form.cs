using System.Data;
using System.Data.SqlClient;

namespace Seoul_Stay
{
    public partial class Management_form : Form
    {
        public Management_form()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            Guid newGuid = Guid.NewGuid();
            string SqlCode = @"SELECT Title,Capacity,AreaID
                            FROM Session1.dbo.Items
                            WHERE Title LIKE @Search OR Capacity LIKE @Search OR AreaID LIKE @Search;";
            SqlCommand cmd = new SqlCommand(SqlCode);
            cmd.Parameters.AddWithValue("@Search", "%" + txtSearch + "%");
            DataTable dt = SqlMethod.GetData(cmd);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvShowList.DataSource = dt;
                laCount.Text = dt.Rows.Count.ToString();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out???", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Employee = string.Empty;
                Properties.Settings.Default.Username = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
                Properties.Settings.Default.KeepMeSignedIn = false;
                Properties.Settings.Default.Save();
                GoToLoginForm();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You want to exit???", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void GoToLoginForm()
        {
            this.Hide();
            Login_Form loginForm = new Login_Form();
            loginForm.ShowDialog();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


        }
        private void SearchListings(string searchTerm)
        {
            string SqlCode = "";

            SqlCommand cmd = new SqlCommand(SqlCode);
            //cmd.Parameters.AddWithValue();
        }
    }
}
