namespace tugas_crud_database
{
    partial class RegisterForm
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
            labelLogin = new Label();
            label4 = new Label();
            buttonRegister = new Button();
            checkBoxShowPassword = new CheckBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxConfirmPassword = new TextBox();
            label5 = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.Transparent;
            labelLogin.FlatStyle = FlatStyle.Flat;
            labelLogin.Font = new Font("Poppins", 8F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.MediumSeaGreen;
            labelLogin.Location = new Point(1077, 839);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(77, 39);
            labelLogin.TabIndex = 17;
            labelLogin.Text = "Login";
            labelLogin.Click += labelLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(771, 839);
            label4.Name = "label4";
            label4.Size = new Size(306, 39);
            label4.TabIndex = 16;
            label4.Text = "Already have an account?";
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.DarkSeaGreen;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Popup;
            buttonRegister.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(786, 747);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(350, 46);
            buttonRegister.TabIndex = 15;
            buttonRegister.Text = "REGISTER";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Font = new Font("Poppins", 6F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxShowPassword.Location = new Point(1156, 642);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(166, 32);
            checkBoxShowPassword.TabIndex = 14;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(922, 517);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(400, 39);
            textBoxPassword.TabIndex = 13;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(922, 437);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(400, 39);
            textBoxUsername.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(593, 515);
            label3.Name = "label3";
            label3.Size = new Size(149, 48);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(593, 435);
            label2.Name = "label2";
            label2.Size = new Size(159, 48);
            label2.TabIndex = 10;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(786, 241);
            label1.Name = "label1";
            label1.Size = new Size(347, 113);
            label1.TabIndex = 9;
            label1.Text = "REGISTER";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(922, 597);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(400, 39);
            textBoxConfirmPassword.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(593, 595);
            label5.Name = "label5";
            label5.Size = new Size(265, 48);
            label5.TabIndex = 18;
            label5.Text = "Confirm Password";
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
            buttonClose.TabIndex = 20;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1920, 1200);
            Controls.Add(buttonClose);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(label5);
            Controls.Add(labelLogin);
            Controls.Add(label4);
            Controls.Add(buttonRegister);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label label4;
        private Button buttonRegister;
        private CheckBox checkBoxShowPassword;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxConfirmPassword;
        private Label label5;
        private Button buttonClose;
    }
}