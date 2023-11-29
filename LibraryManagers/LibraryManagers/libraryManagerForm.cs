namespace LibraryManagers
{
    public partial class libraryManagerForm : Form
    {
        public libraryManagerForm()
        {
            InitializeComponent();
        }

     
        private loginForm? MyloginForm { get; set; }
        private void loginPersonalButton_Click(object sender, EventArgs e)
        {
            if (MyloginForm == null || MyloginForm.IsDisposed)
            {
                MyloginForm = new loginForm()
                {

                };

            }
            MyloginForm.ShowDialog();
        }

        private void loginMemberButton_Click(object sender, EventArgs e)
        {
            if (MyloginForm == null || MyloginForm.IsDisposed)
            {
                MyloginForm = new loginForm()
                {

                };

            }
            MyloginForm.ShowDialog();
        }

       


    }
}