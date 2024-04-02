using BusinessObject;
using DataAccess.DAO;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public IMemberRepository memberRepository = new MemberRepository();
        public MemberObject member { get; set; }
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
            try
            {
                if (AdminAccount.checkAdmin(username, password))
                {
                    frmChooseManagement frmChooseManagement = new frmChooseManagement();
                    this.Hide();
                    frmChooseManagement.ShowDialog();
                    this.Close();
                }
                member = memberRepository.getMemberByEmailPass(username, password);
                if (member != null)
                {
                    frmMember frmMember = new frmMember()
                    {
                        MemberObject = member,
                        InsertOrUpdate = true
                    };
                    this.Hide()
                            ;
                    frmMember.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
