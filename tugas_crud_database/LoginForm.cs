using System.Data.SqlClient;

namespace tugas_crud_database
{
    public partial class LoginForm : Form
    {
        private RegisterForm registerForm;
        private DashboardHomeForm dashboardHomeForm;
        SqlConnection con = new SqlConnection("Data Source=DIDIIIDESK;Initial Catalog=tugascrud;Integrated Security=True;TrustServerCertificate=true");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please fill in all the fields first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "SELECT COUNT(*) FROM authTable WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                if (count > 0)
                {
                    MessageBox.Show("Login Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    User.AddUsername(textBoxUsername.Text);
                    dashboardHomeForm = new DashboardHomeForm();
                    dashboardHomeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error Login");
                }
            }
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Apakah Anda yakin ingin menutup aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}