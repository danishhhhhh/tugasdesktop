namespace tugas_crud_database
{
    partial class AddDrugForm
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
            label1 = new Label();
            textBoxCode = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxPrice = new TextBox();
            label7 = new Label();
            buttonAdd = new Button();
            buttonCancel = new Button();
            textBoxStocks = new TextBox();
            label8 = new Label();
            checkBoxChild = new CheckBox();
            checkBoxTeen = new CheckBox();
            checkBoxAdult = new CheckBox();
            comboBoxDosage = new ComboBox();
            radioButtonTablet = new RadioButton();
            radioButtonCapsule = new RadioButton();
            radioButtonSyrup = new RadioButton();
            radioButtonCream = new RadioButton();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(769, 96);
            label1.Name = "label1";
            label1.Size = new Size(382, 113);
            label1.TabIndex = 1;
            label1.Text = "ADD DATA";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(892, 299);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(400, 39);
            textBoxCode.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(613, 297);
            label2.Name = "label2";
            label2.Size = new Size(222, 48);
            label2.TabIndex = 4;
            label2.Text = "Medicine Code";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(892, 379);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(400, 39);
            textBoxName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(613, 377);
            label3.Name = "label3";
            label3.Size = new Size(102, 48);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(613, 457);
            label4.Name = "label4";
            label4.Size = new Size(85, 48);
            label4.TabIndex = 8;
            label4.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(613, 537);
            label5.Name = "label5";
            label5.Size = new Size(123, 48);
            label5.TabIndex = 10;
            label5.Text = "Dosage";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(613, 617);
            label6.Name = "label6";
            label6.Size = new Size(237, 48);
            label6.TabIndex = 12;
            label6.Text = "Medicine Target";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(892, 779);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(400, 39);
            textBoxPrice.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(613, 777);
            label7.Name = "label7";
            label7.Size = new Size(86, 48);
            label7.TabIndex = 14;
            label7.Text = "Price";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkSeaGreen;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(613, 1026);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(327, 46);
            buttonAdd.TabIndex = 17;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Salmon;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(965, 1026);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(327, 46);
            buttonCancel.TabIndex = 18;
            buttonCancel.Text = "CANCEL";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxStocks
            // 
            textBoxStocks.Location = new Point(892, 699);
            textBoxStocks.Name = "textBoxStocks";
            textBoxStocks.Size = new Size(400, 39);
            textBoxStocks.TabIndex = 21;
            textBoxStocks.KeyPress += textBoxStocks_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(613, 697);
            label8.Name = "label8";
            label8.Size = new Size(107, 48);
            label8.TabIndex = 20;
            label8.Text = "Stocks";
            // 
            // checkBoxChild
            // 
            checkBoxChild.AutoSize = true;
            checkBoxChild.Location = new Point(892, 621);
            checkBoxChild.Name = "checkBoxChild";
            checkBoxChild.Size = new Size(101, 36);
            checkBoxChild.TabIndex = 22;
            checkBoxChild.Text = "Child";
            checkBoxChild.UseVisualStyleBackColor = true;
            // 
            // checkBoxTeen
            // 
            checkBoxTeen.AutoSize = true;
            checkBoxTeen.Location = new Point(1028, 621);
            checkBoxTeen.Name = "checkBoxTeen";
            checkBoxTeen.Size = new Size(97, 36);
            checkBoxTeen.TabIndex = 23;
            checkBoxTeen.Text = "Teen";
            checkBoxTeen.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdult
            // 
            checkBoxAdult.AutoSize = true;
            checkBoxAdult.Location = new Point(1176, 621);
            checkBoxAdult.Name = "checkBoxAdult";
            checkBoxAdult.Size = new Size(103, 36);
            checkBoxAdult.TabIndex = 24;
            checkBoxAdult.Text = "Adult";
            checkBoxAdult.UseVisualStyleBackColor = true;
            // 
            // comboBoxDosage
            // 
            comboBoxDosage.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDosage.FormattingEnabled = true;
            comboBoxDosage.Items.AddRange(new object[] { "Sekali sehari", "2x Sehari", "3x Sehari", "4x Sehari", "5x Sehari" });
            comboBoxDosage.Location = new Point(892, 539);
            comboBoxDosage.Name = "comboBoxDosage";
            comboBoxDosage.Size = new Size(400, 40);
            comboBoxDosage.TabIndex = 25;
            // 
            // radioButtonTablet
            // 
            radioButtonTablet.AutoSize = true;
            radioButtonTablet.Location = new Point(892, 460);
            radioButtonTablet.Name = "radioButtonTablet";
            radioButtonTablet.Size = new Size(108, 36);
            radioButtonTablet.TabIndex = 26;
            radioButtonTablet.TabStop = true;
            radioButtonTablet.Text = "Tablet";
            radioButtonTablet.UseVisualStyleBackColor = true;
            // 
            // radioButtonCapsule
            // 
            radioButtonCapsule.AutoSize = true;
            radioButtonCapsule.Location = new Point(1032, 460);
            radioButtonCapsule.Name = "radioButtonCapsule";
            radioButtonCapsule.Size = new Size(129, 36);
            radioButtonCapsule.TabIndex = 27;
            radioButtonCapsule.TabStop = true;
            radioButtonCapsule.Text = "Capsule";
            radioButtonCapsule.UseVisualStyleBackColor = true;
            // 
            // radioButtonSyrup
            // 
            radioButtonSyrup.AutoSize = true;
            radioButtonSyrup.Location = new Point(1199, 460);
            radioButtonSyrup.Name = "radioButtonSyrup";
            radioButtonSyrup.Size = new Size(105, 36);
            radioButtonSyrup.TabIndex = 28;
            radioButtonSyrup.TabStop = true;
            radioButtonSyrup.Text = "Syrup";
            radioButtonSyrup.UseVisualStyleBackColor = true;
            // 
            // radioButtonCream
            // 
            radioButtonCream.AutoSize = true;
            radioButtonCream.Location = new Point(1341, 459);
            radioButtonCream.Name = "radioButtonCream";
            radioButtonCream.Size = new Size(114, 36);
            radioButtonCream.TabIndex = 29;
            radioButtonCream.TabStop = true;
            radioButtonCream.Text = "Cream";
            radioButtonCream.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(613, 865);
            label9.Name = "label9";
            label9.Size = new Size(188, 48);
            label9.TabIndex = 30;
            label9.Text = "Date Expired";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(892, 865);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 31;
            // 
            // AddDrugForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1920, 1200);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(radioButtonCream);
            Controls.Add(radioButtonSyrup);
            Controls.Add(radioButtonCapsule);
            Controls.Add(radioButtonTablet);
            Controls.Add(comboBoxDosage);
            Controls.Add(checkBoxAdult);
            Controls.Add(checkBoxTeen);
            Controls.Add(checkBoxChild);
            Controls.Add(textBoxStocks);
            Controls.Add(label8);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPrice);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(textBoxCode);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddDrugForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDrugForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCode;
        private Label label2;
        private TextBox textBoxName;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private TextBox textBoxPrice;
        private Label label7;
        private Button buttonAdd;
        private Button buttonCancel;
        private TextBox textBoxStocks;
        private Label label8;
        private CheckBox checkBoxChild;
        private CheckBox checkBoxTeen;
        private CheckBox checkBoxAdult;
        private ComboBox comboBoxDosage;
        private RadioButton radioButtonTablet;
        private RadioButton radioButtonCapsule;
        private RadioButton radioButtonSyrup;
        private RadioButton radioButtonCream;
        private Label label9;
        private DateTimePicker dateTimePicker1;
    }
}