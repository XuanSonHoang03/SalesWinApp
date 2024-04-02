using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMember : Form
    {
        public MemberObject MemberObject { get; set; }
        public IMemberRepository memberRepository = new MemberRepository();
        internal IMemberRepository MemberRepository;
        public bool InsertOrUpdate { get; set; } //true: update - false: insert
        public bool isAdmin { get; set; }
        public frmMember()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertOrUpdate)
                {
                    MemberObject.MemberId = int.Parse(tbID.Text);
                    MemberObject.MemberEmail = tbEmail.Text;
                    MemberObject.MemberPassword = tbPassword.Text;
                    MemberObject.MemberCountry = tbCountry.Text;
                    MemberObject.MemberCity = tbCity.Text;
                    MemberObject.CompanyName = tbCompany.Text;

                    memberRepository.UpdateMember(MemberObject);
                    MessageBox.Show("Update member successfully");
                    Close();
                }
                else
                {
                    MemberObject = new MemberObject()
                    {
                        MemberId = int.Parse(tbID.Text),
                        MemberEmail = tbEmail.Text,
                        MemberPassword = tbPassword.Text,
                        MemberCountry = tbCountry.Text,
                        MemberCity = tbCity.Text,
                        CompanyName = tbCompany.Text
                    };
                    memberRepository.InsertMember(MemberObject);
                    MessageBox.Show("Insert member successfully");
                    Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            try
            {
                if (isAdmin)
                {
                    tbPassword.Enabled = false;
                    tbEmail.Enabled = false;
                    btView.Enabled = false;
                    tbID.Enabled = false;
                }
                if (InsertOrUpdate)
                {
                    tbID.Enabled = false;
                    tbID.Text = MemberObject.MemberId.ToString();
                    tbEmail.Text = MemberObject.MemberEmail;
                    tbPassword.Text = MemberObject.MemberPassword;
                    tbCity.Text = MemberObject.MemberCity;
                    tbCountry.Text = MemberObject.MemberCountry;
                    tbCompany.Text = MemberObject.CompanyName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btView_Click(object sender, EventArgs e)
        {
            frmCart frmCart = new frmCart()
            {
               memberObject = MemberObject
            };
            this.Hide();
            frmCart.ShowDialog();
            this.Show();
        }
    }
}
