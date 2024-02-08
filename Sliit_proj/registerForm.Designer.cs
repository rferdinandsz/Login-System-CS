namespace Sliit_proj
{
    partial class registerForm
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
            form_username = new TextBox();
            form_password = new TextBox();
            form_cpassword = new TextBox();
            form_firstname = new TextBox();
            form_lastname = new TextBox();
            button1 = new Button();
            form_email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // form_username
            // 
            form_username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            form_username.ForeColor = SystemColors.MenuHighlight;
            form_username.Location = new Point(60, 189);
            form_username.Name = "form_username";
            form_username.Size = new Size(219, 23);
            form_username.TabIndex = 0;
            // 
            // form_password
            // 
            form_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            form_password.BackColor = SystemColors.Menu;
            form_password.ForeColor = SystemColors.MenuHighlight;
            form_password.Location = new Point(60, 256);
            form_password.Name = "form_password";
            form_password.PasswordChar = '*';
            form_password.Size = new Size(462, 23);
            form_password.TabIndex = 1;
            // 
            // form_cpassword
            // 
            form_cpassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            form_cpassword.BackColor = SystemColors.Menu;
            form_cpassword.ForeColor = SystemColors.MenuHighlight;
            form_cpassword.Location = new Point(60, 315);
            form_cpassword.Name = "form_cpassword";
            form_cpassword.PasswordChar = '*';
            form_cpassword.Size = new Size(462, 23);
            form_cpassword.TabIndex = 2;
            // 
            // form_firstname
            // 
            form_firstname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            form_firstname.BackColor = SystemColors.Menu;
            form_firstname.ForeColor = SystemColors.MenuHighlight;
            form_firstname.Location = new Point(60, 129);
            form_firstname.Name = "form_firstname";
            form_firstname.Size = new Size(219, 23);
            form_firstname.TabIndex = 3;
            // 
            // form_lastname
            // 
            form_lastname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            form_lastname.BackColor = SystemColors.Menu;
            form_lastname.ForeColor = SystemColors.MenuHighlight;
            form_lastname.Location = new Point(303, 129);
            form_lastname.Name = "form_lastname";
            form_lastname.Size = new Size(219, 23);
            form_lastname.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(0, 400);
            button1.Name = "button1";
            button1.Size = new Size(554, 47);
            button1.TabIndex = 5;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // form_email
            // 
            form_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            form_email.BackColor = SystemColors.Menu;
            form_email.ForeColor = SystemColors.MenuHighlight;
            form_email.Location = new Point(303, 188);
            form_email.Name = "form_email";
            form_email.Size = new Size(219, 23);
            form_email.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(60, 104);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 7;
            label1.Text = "First Name";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(303, 104);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 8;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(60, 169);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(303, 169);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 10;
            label4.Text = "Email Address";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(60, 235);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 11;
            label5.Text = "Enter Password";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(60, 296);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 12;
            label6.Text = "Confirm Password";
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(553, 515);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(form_email);
            Controls.Add(button1);
            Controls.Add(form_lastname);
            Controls.Add(form_firstname);
            Controls.Add(form_cpassword);
            Controls.Add(form_password);
            Controls.Add(form_username);
            Name = "registerForm";
            Text = "Register Now !!!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox form_username;
        private TextBox form_password;
        private TextBox form_cpassword;
        private TextBox form_firstname;
        private TextBox form_lastname;
        private Button button1;
        private TextBox form_email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}