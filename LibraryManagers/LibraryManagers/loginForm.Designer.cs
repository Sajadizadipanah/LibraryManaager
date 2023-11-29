namespace LibraryManagers
{
    partial class loginForm
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
            exitButton = new Button();
            loginButton = new Button();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(100, 101);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 5;
            exitButton.Text = "خروج";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(181, 101);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 4;
            loginButton.Text = "ورود";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(12, 12);
            usernameTextBox.MaxLength = 40;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(168, 23);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 55);
            passwordTextBox.MaxLength = 20;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(168, 23);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(208, 20);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(55, 15);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "نام کاربری";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(208, 58);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(48, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "رمز ورود";
            // 
            // loginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(277, 138);
            ControlBox = false;
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(loginButton);
            Controls.Add(exitButton);
            MaximizeBox = false;
            MaximumSize = new Size(293, 177);
            MinimizeBox = false;
            MinimumSize = new Size(293, 177);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ورود ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Button loginButton;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label usernameLabel;
        private Label passwordLabel;
    }
}