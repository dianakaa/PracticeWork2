namespace LabWork2
{
    partial class Form1
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
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonRegistration = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(105, 29);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            label2.Click += label2_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(192, 9);
            textBoxLogin.Margin = new Padding(3, 4, 3, 4);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(178, 27);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(192, 60);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(178, 27);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonRegistration
            // 
            buttonRegistration.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRegistration.Location = new Point(12, 242);
            buttonRegistration.Margin = new Padding(50);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(300, 50);
            buttonRegistration.TabIndex = 4;
            buttonRegistration.Text = "Зарегистрироваться";
            buttonRegistration.UseVisualStyleBackColor = true;
            buttonRegistration.Click += buttonRegistration_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 321);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            label3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 353);
            Controls.Add(label3);
            Controls.Add(buttonRegistration);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonRegistration;
        private Label label3;
    }
}
