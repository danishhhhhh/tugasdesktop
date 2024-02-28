using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace tugas_crud_database
{
    public partial class RegisterForm : Form
    {
        private LoginForm loginForm;
        SqlConnection con = new SqlConnection("Data Source=DIDIIIDESK;Initial Catalog=tugascrud;Integrated Security=True;TrustServerCertificate=true");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxConfirmPassword.PasswordChar = '*';
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                textBoxConfirmPassword.PasswordChar = '*';
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please fill in all the fields first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBoxPassword.Text == textBoxConfirmPassword.Text)
                {
                    try
                    {
                        string query = "INSERT INTO authTable (username, password) VALUES (@username, @password)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                        cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                        con.Open();
                        cmd.ExecuteScalar();
                        con.Close();
                        loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            DialogResult result = MessageBox.Show("The username has already been used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearControls();
                        }
                        else
                        {
                            MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearControls();
                        }
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill confirm password correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void ClearControls()
        {
            foreach (var textbox in Controls.OfType<TextBox>())
            {
                textbox.Clear();
            }
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
