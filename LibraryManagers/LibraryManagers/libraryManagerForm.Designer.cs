namespace LibraryManagers
{
    partial class libraryManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libraryManagerForm));
            loginMemberButton = new Button();
            loginPersonalButton = new Button();
            registerButton = new Button();
            allBookDataGridView = new DataGridView();
            popularBookDataGridView = new DataGridView();
            searchTextBox = new TextBox();
            searchButton = new Button();
            logoPictureBox = new PictureBox();
            informationLabel = new Label();
            signLabel1 = new Label();
            signLabel2 = new Label();
            ((System.ComponentModel.ISupportInitialize)allBookDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popularBookDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // loginMemberButton
            // 
            loginMemberButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginMemberButton.Location = new Point(601, 41);
            loginMemberButton.Name = "loginMemberButton";
            loginMemberButton.Size = new Size(75, 23);
            loginMemberButton.TabIndex = 0;
            loginMemberButton.Text = "ورود اعضا";
            loginMemberButton.UseVisualStyleBackColor = true;
            loginMemberButton.Click += loginMemberButton_Click;
            // 
            // loginPersonalButton
            // 
            loginPersonalButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginPersonalButton.Location = new Point(601, 12);
            loginPersonalButton.Name = "loginPersonalButton";
            loginPersonalButton.Size = new Size(75, 23);
            loginPersonalButton.TabIndex = 1;
            loginPersonalButton.Text = "ورود پرسنل";
            loginPersonalButton.UseVisualStyleBackColor = true;
            loginPersonalButton.Click += loginPersonalButton_Click;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            registerButton.Location = new Point(601, 70);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 2;
            registerButton.Text = "ثبت نام";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // allBookDataGridView
            // 
            allBookDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            allBookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allBookDataGridView.Location = new Point(12, 51);
            allBookDataGridView.Name = "allBookDataGridView";
            allBookDataGridView.RowTemplate.Height = 25;
            allBookDataGridView.Size = new Size(573, 444);
            allBookDataGridView.TabIndex = 3;
            // 
            // popularBookDataGridView
            // 
            popularBookDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            popularBookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            popularBookDataGridView.Location = new Point(601, 99);
            popularBookDataGridView.Name = "popularBookDataGridView";
            popularBookDataGridView.RowTemplate.Height = 25;
            popularBookDataGridView.Size = new Size(159, 396);
            popularBookDataGridView.TabIndex = 4;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchTextBox.Location = new Point(12, 13);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "جستجوی کتاب";
            searchTextBox.RightToLeft = RightToLeft.Yes;
            searchTextBox.Size = new Size(514, 23);
            searchTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.BackColor = Color.Transparent;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Location = new Point(532, 12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(53, 23);
            searchButton.TabIndex = 6;
            searchButton.Text = "جستجو";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(682, 15);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(78, 78);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 7;
            logoPictureBox.TabStop = false;
            // 
            // informationLabel
            // 
            informationLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            informationLabel.AutoSize = true;
            informationLabel.Font = new Font("_MRT_Khodkar", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            informationLabel.Location = new Point(55, 498);
            informationLabel.Name = "informationLabel";
            informationLabel.Size = new Size(285, 29);
            informationLabel.TabIndex = 8;
            informationLabel.Text = "کتابخانه اندیشه  شماره تماس:09332096323 09129328908 ";
       
            // 
            // signLabel1
            // 
            signLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            signLabel1.AutoSize = true;
            signLabel1.Location = new Point(695, 498);
            signLabel1.Name = "signLabel1";
            signLabel1.Size = new Size(58, 15);
            signLabel1.TabIndex = 9;
            signLabel1.Text = "@scheller";
            // 
            // signLabel2
            // 
            signLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            signLabel2.AutoSize = true;
            signLabel2.Location = new Point(695, 513);
            signLabel2.Name = "signLabel2";
            signLabel2.Size = new Size(75, 15);
            signLabel2.TabIndex = 10;
            signLabel2.Text = "@Izadipanah";
            // 
            // libraryManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 530);
            Controls.Add(signLabel2);
            Controls.Add(signLabel1);
            Controls.Add(informationLabel);
            Controls.Add(logoPictureBox);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(popularBookDataGridView);
            Controls.Add(allBookDataGridView);
            Controls.Add(registerButton);
            Controls.Add(loginPersonalButton);
            Controls.Add(loginMemberButton);
            MaximumSize = new Size(789, 569);
            MinimumSize = new Size(789, 569);
            Name = "libraryManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Linrary Manager";
            ((System.ComponentModel.ISupportInitialize)allBookDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)popularBookDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginMemberButton;
        private Button loginPersonalButton;
        private Button registerButton;
        private DataGridView allBookDataGridView;
        private DataGridView popularBookDataGridView;
        private TextBox searchTextBox;
        private Button searchButton;
        private PictureBox logoPictureBox;
        private Label informationLabel;
        private Label signLabel1;
        private Label signLabel2;
    }
}