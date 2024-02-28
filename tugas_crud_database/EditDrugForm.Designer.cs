namespace tugas_crud_database
{
    partial class EditDrugForm
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
            textBoxStocks = new TextBox();
            label8 = new Label();
            buttonCancel = new Button();
            buttonAdd = new Button();
            textBoxPrice = new TextBox();
            label7 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxCode = new TextBox();
            label2 = new Label();
            label1 = new Label();
            radioButtonCream = new RadioButton();
            radioButtonSyrup = new RadioButton();
            radioButtonCapsule = new RadioButton();
            radioButtonTablet = new RadioButton();
            label4 = new Label();
            comboBoxDosage = new ComboBox();
            checkBoxAdult = new CheckBox();
            checkBoxTeen = new CheckBox();
            checkBoxChild = new CheckBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            SuspendLayout();
            // 
            // textBoxStocks
            // 
            textBoxStocks.Location = new Point(892, 730);
            textBoxStocks.Name = "textBoxStocks";
            textBoxStocks.Size = new Size(400, 39);
            textBoxStocks.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(613, 728);
            label8.Name = "label8";
            label8.Size = new Size(107, 48);
            label8.TabIndex = 37;
            label8.Text = "Stocks";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Salmon;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(965, 1013);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(327, 46);
            buttonCancel.TabIndex = 35;
            buttonCancel.Text = "CANCEL";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkSeaGreen;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(613, 1013);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(327, 46);
            buttonAdd.TabIndex = 34;
            buttonAdd.Text = "EDIT";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(892, 810);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(400, 39);
            textBoxPrice.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(613, 808);
            label7.Name = "label7";
            label7.Size = new Size(86, 48);
            label7.TabIndex = 31;
            label7.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(613, 568);
            label5.Name = "label5";
            label5.Size = new Size(123, 48);
            label5.TabIndex = 28;
            label5.Text = "Dosage";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(892, 410);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(400, 39);
            textBoxName.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(613, 408);
            label3.Name = "label3";
            label3.Size = new Size(102, 48);
            label3.TabIndex = 25;
            label3.Text = "Name";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(892, 330);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.ReadOnly = true;
            textBoxCode.Size = new Size(400, 39);
            textBoxCode.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(613, 328);
            label2.Name = "label2";
            label2.Size = new Size(164, 48);
            label2.TabIndex = 23;
            label2.Text = "Drug Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(770, 164);
            label1.Name = "label1";
            label1.Size = new Size(380, 113);
            label1.TabIndex = 22;
            label1.Text = "EDIT DATA";
            // 
            // radioButtonCream
            // 
            radioButtonCream.AutoSize = true;
            radioButtonCream.Location = new Point(1341, 492);
            radioButtonCream.Name = "radioButtonCream";
            radioButtonCream.Size = new Size(114, 36);
            radioButtonCream.TabIndex = 43;
            radioButtonCream.TabStop = true;
            radioButtonCream.Text = "Cream";
            radioButtonCream.UseVisualStyleBackColor = true;
            // 
            // radioButtonSyrup
            // 
            radioButtonSyrup.AutoSize = true;
            radioButtonSyrup.Location = new Point(1199, 493);
            radioButtonSyrup.Name = "radioButtonSyrup";
            radioButtonSyrup.Size = new Size(105, 36);
            radioButtonSyrup.TabIndex = 42;
            radioButtonSyrup.TabStop = true;
            radioButtonSyrup.Text = "Syrup";
            radioButtonSyrup.UseVisualStyleBackColor = true;
            // 
            // radioButtonCapsule
            // 
            radioButtonCapsule.AutoSize = true;
            radioButtonCapsule.Location = new Point(1032, 493);
            radioButtonCapsule.Name = "radioButtonCapsule";
            radioButtonCapsule.Size = new Size(129, 36);
            radioButtonCapsule.TabIndex = 41;
            radioButtonCapsule.TabStop = true;
            radioButtonCapsule.Text = "Capsule";
            radioButtonCapsule.UseVisualStyleBackColor = true;
            // 
            // radioButtonTablet
            // 
            radioButtonTablet.AutoSize = true;
            radioButtonTablet.Location = new Point(892, 493);
            radioButtonTablet.Name = "radioButtonTablet";
            radioButtonTablet.Size = new Size(108, 36);
            radioButtonTablet.TabIndex = 40;
            radioButtonTablet.TabStop = true;
            radioButtonTablet.Text = "Tablet";
            radioButtonTablet.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(613, 490);
            label4.Name = "label4";
            label4.Size = new Size(85, 48);
            label4.TabIndex = 39;
            label4.Text = "Type";
            // 
            // comboBoxDosage
            // 
            comboBoxDosage.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDosage.FormattingEnabled = true;
            comboBoxDosage.Items.AddRange(new object[] { "Sekali sehari", "2x Sehari", "3x Sehari", "4x Sehari", "5x Sehari" });
            comboBoxDosage.Location = new Point(892, 570);
            comboBoxDosage.Name = "comboBoxDosage";
            comboBoxDosage.Size = new Size(400, 40);
            comboBoxDosage.TabIndex = 44;
            // 
            // checkBoxAdult
            // 
            checkBoxAdult.AutoSize = true;
            checkBoxAdult.Location = new Point(1176, 652);
            checkBoxAdult.Name = "checkBoxAdult";
            checkBoxAdult.Size = new Size(103, 36);
            checkBoxAdult.TabIndex = 48;
            checkBoxAdult.Text = "Adult";
            checkBoxAdult.UseVisualStyleBackColor = true;
            // 
            // checkBoxTeen
            // 
            checkBoxTeen.AutoSize = true;
            checkBoxTeen.Location = new Point(1028, 652);
            checkBoxTeen.Name = "checkBoxTeen";
            checkBoxTeen.Size = new Size(97, 36);
            checkBoxTeen.TabIndex = 47;
            checkBoxTeen.Text = "Teen";
            checkBoxTeen.UseVisualStyleBackColor = true;
            // 
            // checkBoxChild
            // 
            checkBoxChild.AutoSize = true;
            checkBoxChild.Location = new Point(892, 652);
            checkBoxChild.Name = "checkBoxChild";
            checkBoxChild.Size = new Size(101, 36);
            checkBoxChild.TabIndex = 46;
            checkBoxChild.Text = "Child";
            checkBoxChild.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(613, 648);
            label6.Name = "label6";
            label6.Size = new Size(237, 48);
            label6.TabIndex = 45;
            label6.Text = "Medicine Target";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(892, 893);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(613, 893);
            label9.Name = "label9";
            label9.Size = new Size(188, 48);
            label9.TabIndex = 49;
            label9.Text = "Date Expired";
            // 
            // EditDrugForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1920, 1200);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(checkBoxAdult);
            Controls.Add(checkBoxTeen);
            Controls.Add(checkBoxChild);
            Controls.Add(label6);
            Controls.Add(comboBoxDosage);
            Controls.Add(radioButtonCream);
            Controls.Add(radioButtonSyrup);
            Controls.Add(radioButtonCapsule);
            Controls.Add(radioButtonTablet);
            Controls.Add(label4);
            Controls.Add(textBoxStocks);
            Controls.Add(label8);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPrice);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(textBoxCode);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditDrugForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditDrugForm";
            Load += EditDrugForm_Load;
            KeyPress += EditDrugForm_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStocks;
        private Label label8;
        private Button buttonCancel;
        private Button buttonAdd;
        private TextBox textBoxPrice;
        private Label label7;
        private Label label5;
        private TextBox textBoxName;
        private Label label3;
        private TextBox textBoxCode;
        private Label label2;
        private Label label1;
        private RadioButton radioButtonCream;
        private RadioButton radioButtonSyrup;
        private RadioButton radioButtonCapsule;
        private RadioButton radioButtonTablet;
        private Label label4;
        private ComboBox comboBoxDosage;
        private CheckBox checkBoxAdult;
        private CheckBox checkBoxTeen;
        private CheckBox checkBoxChild;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label9;
    }
}