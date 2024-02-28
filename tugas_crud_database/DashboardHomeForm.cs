using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tugas_crud_database
{
    public partial class DashboardHomeForm : Form
    {
        private LoginForm loginForm;
        private AddDrugForm addDrugForm;
        private EditDrugForm editDrugForm;
        private DashboardUsersForm dashboardUsersForm;
        DataGridViewRow selectedRow;
        SqlConnection con = new SqlConnection("Data Source=DIDIIIDESK;Initial Catalog=tugascrud;Integrated Security=True;TrustServerCertificate=true");

        public DashboardHomeForm()
        {
            InitializeComponent();
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

        private void DashboardHomeForm_Load(object sender, EventArgs e)
        {
            bind_data();
        }

        private void bind_data()
        {
            string query = "SELECT * FROM medicineDataTable";
            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataGridView1.Rows[e.RowIndex];
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            addDrugForm = new AddDrugForm();
            addDrugForm.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                DialogResult hasil = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    string query = "DELETE FROM medicineDataTable WHERE medicine_code=@code";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("code", selectedRow.Cells[0].Value.ToString());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    bind_data();
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
                    SqlCommand cmdSearch = new SqlCommand("SELECT * FROM medicineDataTable WHERE medicine_code LIKE @search OR medicine_name LIKE @search", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new System.Drawing.Rectangle(0, 0, imagebmp.Width, imagebmp.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                editDrugForm = new EditDrugForm(selectedRow.Cells[0].Value.ToString());
                editDrugForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diedit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void panel4_Click(object sender, EventArgs e)
        {
            dashboardUsersForm = new DashboardUsersForm();
            dashboardUsersForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            dashboardUsersForm = new DashboardUsersForm();
            dashboardUsersForm.Show();
            this.Hide();
        }
    }
}
