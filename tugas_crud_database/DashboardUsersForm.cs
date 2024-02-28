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

namespace tugas_crud_database
{
    public partial class DashboardUsersForm : Form
    {
        private LoginForm loginForm;
        private DashboardHomeForm dashboardHomeForm;
        DataGridViewRow selectedRow;
        SqlConnection con = new SqlConnection("Data Source=DIDIIIDESK;Initial Catalog=tugascrud;Integrated Security=True;TrustServerCertificate=true");

        public DashboardUsersForm()
        {
            InitializeComponent();
        }

        private void bind_data()
        {
            string query = "SELECT username FROM authTable";
            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            dashboardHomeForm = new DashboardHomeForm();
            dashboardHomeForm.Show();
            this.Hide();
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            dashboardHomeForm = new DashboardHomeForm();
            dashboardHomeForm.Show();
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

        private void labelLogout_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                User.DeleteUsername();
                loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void DashboardUsersForm_Load(object sender, EventArgs e)
        {
            bind_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataGridView1.Rows[e.RowIndex];
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                if (User.CheckUserAccountsUsername(selectedRow.Cells[0].Value.ToString()))
                {
                    deletePopUp.Show();
                }
                else
                {
                    MessageBox.Show("Akun sedang dipakai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diedit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                bind_data();
            }
            else
            {
                try
                {
                    SqlCommand cmdSearch = new SqlCommand("SELECT username FROM authTable WHERE username LIKE @search", con);
                    cmdSearch.Parameters.AddWithValue("@search", "%" + searchValue + "%");

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmdSearch;

                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Data Not Found !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bind_data();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonClosePopup_Click(object sender, EventArgs e)
        {
            textBoxPass.Clear();
            deletePopUp.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM authTable WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(checkQuery, con);
            cmd.Parameters.AddWithValue("@username", selectedRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@password", textBoxPass.Text);
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                string query = "DELETE FROM authTable WHERE username=@code";
                SqlCommand cmd1 = new SqlCommand(query, con);
                cmd1.Parameters.AddWithValue("code", selectedRow.Cells[0].Value.ToString());
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                bind_data();
                textBoxPass.Clear();
                deletePopUp.Hide();
            }
            else
            {
                MessageBox.Show("Password Invalid");
            }
        }
    }
}
