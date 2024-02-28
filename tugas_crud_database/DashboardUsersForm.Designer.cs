namespace tugas_crud_database
{
    partial class DashboardUsersForm
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
            buttonClose = new Button();
            buttonDelete = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            labelHome = new Label();
            labelLogout = new Label();
            panel2 = new Panel();
            labelUsername = new Label();
            deletePopUp = new Panel();
            button1 = new Button();
            label2 = new Label();
            textBoxPass = new TextBox();
            buttonClosePopup = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            deletePopUp.SuspendLayout();
            SuspendLayout();
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
            buttonClose.TabIndex = 18;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
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
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
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
            buttonSearch.TabIndex = 16;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(1329, 198);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(350, 43);
            textBoxSearch.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSeaGreen;
            label1.Location = new Point(383, 68);
            label1.Name = "label1";
            label1.Size = new Size(405, 67);
            label1.TabIndex = 14;
            label1.Text = "User in Pharmacies";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(383, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1462, 812);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            panel1.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SeaGreen;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 284);
            panel4.Name = "panel4";
            panel4.Size = new Size(306, 85);
            panel4.TabIndex = 5;
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
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSeaGreen;
            panel3.Controls.Add(labelHome);
            panel3.Location = new Point(3, 193);
            panel3.Name = "panel3";
            panel3.Size = new Size(306, 85);
            panel3.TabIndex = 4;
            panel3.Click += panel3_Click;
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
            labelHome.Click += labelHome_Click;
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
            // deletePopUp
            // 
            deletePopUp.Controls.Add(button1);
            deletePopUp.Controls.Add(label2);
            deletePopUp.Controls.Add(textBoxPass);
            deletePopUp.Controls.Add(buttonClosePopup);
            deletePopUp.Location = new Point(763, 422);
            deletePopUp.Name = "deletePopUp";
            deletePopUp.Size = new Size(686, 354);
            deletePopUp.TabIndex = 19;
            deletePopUp.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(276, 229);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 20;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(140, 115);
            label2.Name = "label2";
            label2.Size = new Size(232, 39);
            label2.TabIndex = 22;
            label2.Text = "Insert the password";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(140, 153);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(400, 39);
            textBoxPass.TabIndex = 21;
            // 
            // buttonClosePopup
            // 
            buttonClosePopup.BackColor = Color.Salmon;
            buttonClosePopup.FlatStyle = FlatStyle.Popup;
            buttonClosePopup.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClosePopup.ForeColor = Color.White;
            buttonClosePopup.Location = new Point(618, 27);
            buttonClosePopup.Name = "buttonClosePopup";
            buttonClosePopup.Size = new Size(46, 46);
            buttonClosePopup.TabIndex = 20;
            buttonClosePopup.Text = "X";
            buttonClosePopup.UseVisualStyleBackColor = false;
            buttonClosePopup.Click += buttonClosePopup_Click;
            // 
            // DashboardUsersForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1920, 1200);
            Controls.Add(deletePopUp);
            Controls.Add(buttonClose);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardUsersForm";
            Load += DashboardUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            deletePopUp.ResumeLayout(false);
            deletePopUp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Button buttonDelete;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel4;
        private Label label3;
        private Panel panel3;
        private Label labelHome;
        private Label labelLogout;
        private Panel panel2;
        private Label labelUsername;
        private Panel deletePopUp;
        private Button buttonClosePopup;
        private Button button1;
        private Label label2;
        private TextBox textBoxPass;
    }
}