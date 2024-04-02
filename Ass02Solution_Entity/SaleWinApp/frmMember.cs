using BusinessObject.Models;
using DataAccess.Repository.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmMember : Form
    {
        public IMemberRepository memberRepository = new MemberRepository();
        public Member member;
        public bool InsertOrUpdate { get; set; } //true: insert, false: update
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
                    member.MemberId = int.Parse(tbID.Text);
                    member.Email = tbEmail.Text;
                    member.Password = tbPassword.Text;
                    member.Country = tbCountry.Text;
                    member.City = tbCity.Text;
                    member.CompanyName = tbCompany.Text;

                    memberRepository.UpdateMember(member);
                    MessageBox.Show("Update member successfully");
                    Close();
                }
                else
                {
                    Member memberNew = new Member()
                    {
                        Email = tbEmail.Text,
                        Password = tbPassword.Text,
                        Country = tbCountry.Text,
                        City = tbCity.Text,
                        CompanyName = tbCompany.Text
                    };
                    memberRepository.AddMember(memberNew);
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
                    tbID.Enabled = false;
                }
                if (InsertOrUpdate)
                {
                    tbID.Enabled = false;
                    tbID.Text = member.MemberId.ToString();
                    tbEmail.Text = member.Email;
                    tbPassword.Text = member.Password;
                    tbCity.Text = member.City;
                    tbCountry.Text = member.Country;
                    tbCompany.Text = member.CompanyName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
