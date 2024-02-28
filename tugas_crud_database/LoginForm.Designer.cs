namespace tugas_crud_database
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            checkBoxShowPassword = new CheckBox();
            buttonLogin = new Button();
            label4 = new Label();
            labelRegister = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(837, 241);
            label1.Name = "label1";
            label1.Size = new Size(245, 113);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(606, 458);
            label2.Name = "label2";
            label2.Size = new Size(159, 48);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(606, 538);
            label3.Name = "label3";
            label3.Size = new Size(149, 48);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(885, 460);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(400, 39);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(885, 540);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(400, 39);
            textBoxPassword.TabIndex = 4;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Font = new Font("Poppins", 6F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxShowPassword.Location = new Point(1119, 585);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(166, 32);
            checkBoxShowPassword.TabIndex = 5;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DarkSeaGreen;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(785, 746);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(350, 46);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(754, 839);
            label4.Name = "label4";
            label4.Size = new Size(314, 39);
            label4.TabIndex = 7;
            label4.Text = "Dont have an account yet?";
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.BackColor = Color.Transparent;
            labelRegister.FlatStyle = FlatStyle.Flat;
            labelRegister.Font = new Font("Poppins", 8F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegister.ForeColor = Color.MediumSeaGreen;
            labelRegister.Location = new Point(1060, 839);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(110, 39);
            labelRegister.TabIndex = 8;
            labelRegister.Text = "Register";
            labelRegister.Click += labelRegister_Click;
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
            buttonClose.TabIndex = 12;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1920, 1200);
            Controls.Add(buttonClose);
            Controls.Add(labelRegister);
            Controls.Add(label4);
            Controls.Add(buttonLogin);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private CheckBox checkBoxShowPassword;
        private Button buttonLogin;
        private Label label4;
        private Label labelRegister;
        private Button buttonClose;
    }
}