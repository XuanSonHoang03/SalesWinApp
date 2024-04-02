namespace SaleWinApp
{
    using BusinessObject;
    using BusinessObject.Models;
    using DataAccess;
    using DataAccess.Repository.Member;

    public partial class frmLogin : Form
    {
        public IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            Boolean checkEmptyTb = checkEmpty(username, password);

            if(checkEmptyTb)
            {
                MessageBox.Show("Please enter username and password");
            }
            else
            {
                if(checkAdminAccount(username, password))
                {
                    frmChooseManagement frmChooseManagement = new frmChooseManagement();
                    this.Hide();
                    frmChooseManagement.ShowDialog();
                    this.Close();
                } else
                {
                    var member = memberRepository.GetMemberByUserPass(username, password);
                    if (member == null)
                    {
                        MessageBox.Show("Username or password is incorrect");
                    }
                    else
                    {
                        this.Hide();
                        frmMember frmMember = new frmMember()
                        {
                            member = member
                        };
                        frmMember.ShowDialog();
                        this.Close();
                    }
                }
            }

        }

        private bool checkAdminAccount(string username, string password)
        {
            return CheckAdminAccount.checkAdminAccount(username, password);
        }

        private bool checkEmpty(string username, string password)
        {
            if(username == "" || password == "")
            {
                return true;
            }
            return false;
        }
    }
}
