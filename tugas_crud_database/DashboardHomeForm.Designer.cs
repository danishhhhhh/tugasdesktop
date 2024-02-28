namespace tugas_crud_database
{
    partial class DashboardHomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardHomeForm));
            panel1 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            labelHome = new Label();
            labelLogout = new Label();
            panel2 = new Panel();
            labelUsername = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonCreate = new Button();
            button1 = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            buttonClose = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(labelLogout);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labelUsername);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 1200);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSeaGreen;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 284);
            panel4.Name = "panel4";
            panel4.Size = new Size(306, 85);
            panel4.TabIndex = 5;
            panel4.Click += panel4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(102, 18);
            label3.Name = "label3";
            label3.Size = new Size(117, 56);
            label3.TabIndex = 3;
            label3.Text = "Users";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Controls.Add(labelHome);
            panel3.Location = new Point(3, 193);
            panel3.Name = "panel3";
            panel3.Size = new Size(306, 85);
            panel3.TabIndex = 4;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHome.ForeColor = Color.White;
            labelHome.Location = new Point(70, 18);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(174, 56);
            labelHome.TabIndex = 3;
            labelHome.Text = "Medicine";
            // 
            // labelLogout
            // 
            labelLogout.AutoSize = true;
            labelLogout.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogout.ForeColor = Color.Salmon;
            labelLogout.Location = new Point(75, 1104);
            labelLogout.Name = "labelLogout";
            labelLogout.Size = new Size(155, 56);
            labelLogout.TabIndex = 2;
            labelLogout.Text = "LOGOUT";
            labelLogout.Click += labelLogout_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkKhaki;
            panel2.Location = new Point(0, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 10);
            panel2.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Poppins", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(55, 61);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(203, 76);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "APOTEK";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(383, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1462, 812);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSeaGreen;
            label1.Location = new Point(383, 68);
            label1.Name = "label1";
            label1.Size = new Size(658, 67);
            label1.TabIndex = 4;
            label1.Text = "Stock of Medicine in Pharmacies";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(1329, 198);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(350, 43);
            textBoxSearch.TabIndex = 5;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.DarkSeaGreen;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(1695, 193);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(150, 46);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Salmon;
            buttonDelete.FlatStyle = FlatStyle.Popup;
            buttonDelete.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(1695, 1104);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 46);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.DarkSeaGreen;
            buttonEdit.FlatStyle = FlatStyle.Popup;
            buttonEdit.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(1519, 1104);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(150, 46);
            buttonEdit.TabIndex = 8;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.YellowGreen;
            buttonCreate.FlatStyle = FlatStyle.Popup;
            buttonCreate.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreate.ForeColor = Color.White;
            buttonCreate.Location = new Point(1343, 1104);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(150, 46);
            buttonCreate.TabIndex = 9;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(383, 1104);
            button1.Name = "button1";
            button1.Size = new Size(170, 46);
            button1.TabIndex = 10;
            button1.Text = "Print PDF";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.Salmon;
            buttonClose.FlatStyle = FlatStyle.Popup;
            buttonClose.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.White;
            buttonClose.Location = new Point(1799, 61);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(46, 46);
            buttonClose.TabIndex = 11;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // DashboardHomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1920, 1200);
            Controls.Add(buttonClose);
            Controls.Add(button1);
            Controls.Add(buttonCreate);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardHomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardHomeForm";
            Load += DashboardHomeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelUsername;
        private Panel panel3;
        private Label labelHome;
        private Label labelLogout;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonCreate;
        private Button button1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button buttonClose;
        private Panel panel4;
        private Label label3;
    }
}