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
    public partial class AddDrugForm : Form
    {

        private DashboardHomeForm dashboardHomeForm;
        SqlConnection con = new SqlConnection("Data Source=DIDIIIDESK;Initial Catalog=tugascrud;Integrated Security=True;TrustServerCertificate=true");

        public AddDrugForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dashboardHomeForm = new DashboardHomeForm();
            dashboardHomeForm.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string selectedTargets = "";
            string jenisObat = "";

            if (checkBoxChild.Checked)
                selectedTargets += checkBoxChild.Text + ",";
            if (checkBoxTeen.Checked)
                selectedTargets += checkBoxTeen.Text + ",";
            if (checkBoxAdult.Checked)
                selectedTargets += checkBoxAdult.Text + ",";

            if (radioButtonCapsule.Checked)
            {
                jenisObat = radioButtonCapsule.Text;
            }
            else if (radioButtonCream.Checked)
            {
                jenisObat = radioButtonCream.Text;
            }
            else if (radioButtonSyrup.Checked)
            {
                jenisObat = radioButtonSyrup.Text;
            }
            else if (radioButtonTablet.Checked)
            {
                jenisObat = radioButtonTablet.Text;
            }

            if (string.IsNullOrWhiteSpace(textBoxCode.Text) || string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(selectedTargets) || string.IsNullOrWhiteSpace(comboBoxDosage.Text) || string.IsNullOrWhiteSpace(jenisObat) || string.IsNullOrWhiteSpace(textBoxStocks.Text) || string.IsNullOrWhiteSpace(textBoxPrice.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Please fill in all the fields first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "Insert into medicineDataTable(medicine_code,medicine_name,medicine_type,dosage,medicine_target,stocks,price,date_expired)Values(@code,@name,@type,@dosage,@target,@stocks,@price,@expired)";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    cmd2.Parameters.AddWithValue("code", textBoxCode.Text);
                    cmd2.Parameters.AddWithValue("name", textBoxName.Text);
                    cmd2.Parameters.AddWithValue("type", jenisObat);
                    cmd2.Parameters.AddWithValue("dosage", comboBoxDosage.Text);
                    cmd2.Parameters.AddWithValue("target", selectedTargets);
                    cmd2.Parameters.AddWithValue("stocks", textBoxStocks.Text);
                    cmd2.Parameters.AddWithValue("price", textBoxPrice.Text);
                    cmd2.Parameters.AddWithValue("expired", dateTimePicker1.Text);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    ClearControls();
                    dashboardHomeForm = new DashboardHomeForm();
                    dashboardHomeForm.Show();
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        DialogResult result = MessageBox.Show("The medicine code you provide has already been created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void ClearControls()
        {
            foreach (var textbox in Controls.OfType<TextBox>())
            {
                textbox.Clear();
            }
        }

        private void textBoxStocks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
