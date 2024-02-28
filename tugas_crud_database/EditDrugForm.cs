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
    public partial class EditDrugForm : Form
    {

        private DashboardHomeForm dashboardHomeForm;
        SqlConnection con = new SqlConnection("Data Source=DIDIIIDESK;Initial Catalog=tugascrud;Integrated Security=True;TrustServerCertificate=true");
        string drugCode;

        public EditDrugForm(string drugCode)
        {
            this.drugCode = drugCode;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dashboardHomeForm = new DashboardHomeForm();
            dashboardHomeForm.Show();
            this.Hide();
        }

        private void EditDrugForm_Load(object sender, EventArgs e)
        {
            try
            {
                string searchQuery = "SELECT * FROM medicineDataTable WHERE medicine_code = @searchCode";
                SqlCommand cmd = new SqlCommand(searchQuery, con);
                cmd.Parameters.AddWithValue("searchCode", drugCode);
                con.Open();
                SqlDataReader data = cmd.ExecuteReader();

                if (data.Read())
                {
                    string code = data["medicine_code"].ToString();
                    string name = data["medicine_name"].ToString();
                    string type = data["medicine_type"].ToString();
                    string dosage = data["dosage"].ToString();
                    string medicineTarget = data["medicine_target"].ToString();
                    int stocks = Convert.ToInt32(data["stocks"]);
                    string price = data["price"].ToString();
                    string expired = data["date_expired"].ToString();

                    textBoxCode.Text = code;
                    textBoxName.Text = name;

                    switch (type)
                    {
                        case "Tablet":
                            radioButtonTablet.Checked = true;
                            break;
                        case "Capsule":
                            radioButtonCapsule.Checked = true;
                            break;
                        case "Syrup":
                            radioButtonSyrup.Checked = true;
                            break;
                        case "Cream":
                            radioButtonCream.Checked = true;
                            break;
                        default:
                            break;
                    }

                    comboBoxDosage.Text = dosage;

                    string[] targets = medicineTarget.Split(',');
                    foreach (string target in targets)
                    {
                        switch (target.Trim())
                        {
                            case "Child":
                                checkBoxChild.Checked = true;
                                break;
                            case "Teen":
                                checkBoxTeen.Checked = true;
                                break;
                            case "Adult":
                                checkBoxAdult.Checked = true;
                                break;
                            default:
                                break;
                        }
                    }

                    textBoxStocks.Text = stocks.ToString();
                    textBoxPrice.Text = price;
                    dateTimePicker1.Text = expired;
                }

                con.Close();
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

        private void ClearControls()
        {
            foreach (var textbox in Controls.OfType<TextBox>())
            {
                textbox.Clear();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
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

                string query = "UPDATE medicineDataTable SET medicine_name = @name, medicine_type = @type, dosage = @dosage, medicine_target = @target, stocks = @stocks, price = @price, date_expired = @date WHERE medicine_code = @code";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("code", textBoxCode.Text);
                cmd.Parameters.AddWithValue("name", textBoxName.Text);
                cmd.Parameters.AddWithValue("type", jenisObat);
                cmd.Parameters.AddWithValue("dosage", comboBoxDosage.Text);
                cmd.Parameters.AddWithValue("target", selectedTargets);
                cmd.Parameters.AddWithValue("stocks", textBoxStocks.Text);
                cmd.Parameters.AddWithValue("price", textBoxPrice.Text);
                cmd.Parameters.AddWithValue("date", dateTimePicker1.Text);
                con.Open();
                cmd.ExecuteNonQuery();
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
                    DialogResult result = MessageBox.Show("The drug code you provide has already been created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void EditDrugForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
