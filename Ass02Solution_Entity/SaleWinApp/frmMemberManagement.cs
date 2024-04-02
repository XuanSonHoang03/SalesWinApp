using BusinessObject.Models;
using DataAccess.Repository.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmMemberManagement : Form
    {
        public IMemberRepository memberRepository = new MemberRepository();

        public List<Member> ListMembers;
        public List<Member> ListSearchMember;

        BindingSource bindingSources;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            LoadMemberList();
            dgvMember.CellDoubleClick += DgvMember_CellDoubleClick;
        }

        private void DgvMember_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgvMember.CurrentRow.Index > ListMembers.Count)
            {
                MessageBox.Show("Please select a member to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmMember frmMember = new frmMember()
            {
                Text = "Update Member",
                memberRepository = memberRepository,
                //member = GetMemberObject(),
                member = ListMembers[dgvMember.CurrentRow.Index],
                InsertOrUpdate = true,
                isAdmin = true
            };
            if (frmMember.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                bindingSources.Position = bindingSources.Count - 1;
            }
        }


        private void LoadMemberList()
        {
            var member = memberRepository.GetMembers();
            this.ListMembers = member.ToList();
            try
            {
                bindingSources = new BindingSource();
                bindingSources.DataSource = ListMembers;

                tbCity.DataBindings.Clear();
                tbCompany.DataBindings.Clear();
                tbCountry.DataBindings.Clear();
                tbEmail.DataBindings.Clear();
                tbID.DataBindings.Clear();
                tbPassword.DataBindings.Clear();

                tbCity.DataBindings.Add("Text", bindingSources, "City");
                tbCompany.DataBindings.Add("Text", bindingSources, "CompanyName");
                tbCountry.DataBindings.Add("Text", bindingSources, "Country");
                tbEmail.DataBindings.Add("Text", bindingSources, "Email");
                tbID.DataBindings.Add("Text", bindingSources, "MemberId");
                tbPassword.DataBindings.Add("Text", bindingSources, "Password");

                dgvMember.DataSource = bindingSources;

                if (member == null)
                {
                    btNew.Enabled = false;
                    btDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            frmMember frmMember = new frmMember()
            {
                Text = "Add Member",
                memberRepository = memberRepository,
                InsertOrUpdate = false
            };
            frmMember.ShowDialog();
            this.Show();
            LoadMemberList();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex == 0)
            {
                if (tbSearch.Text == "")
                {
                    LoadMemberList();
                }
                else
                {
                    ListSearchMember = memberRepository.SearchMemberByID(int.Parse(tbSearch.Text));
                    bindingSources.DataSource = ListSearchMember;
                    dgvMember.DataSource = bindingSources;
                }
            }
            else
            {
                if (tbSearch.Text == "")
                {
                    LoadMemberList();
                }
                else
                {
                    ListSearchMember = memberRepository.SearchMemberByEmail(tbSearch.Text);
                    bindingSources.DataSource = ListSearchMember;
                    dgvMember.DataSource = bindingSources;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSearchMember = memberRepository.GetMembers().ToList();
            if (cbFilter.SelectedIndex == 0)
            {
                ListSearchMember = memberRepository.FilterMemberBiCity(cbProperties.Text);
                dgvMember.DataSource = ListSearchMember;
            }
            else
            {
                ListSearchMember = memberRepository.FilterMemberByCountry(cbProperties.Text);
                dgvMember.DataSource = ListSearchMember;
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> strings = new List<string>();
            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    strings = GetAllCity();
                    break;
                case 1:
                    strings = GetAllCountry();
                    break;
            }
            cbProperties.Items.Clear();
            if (strings != null)
            {
                cbProperties.Items.AddRange(strings.ToArray());
            }
            cbProperties.SelectedIndex = 0;
        }

        private List<string> GetAllCountry()
        {
            return memberRepository.GetMembers().Select(m => m.Country).Distinct().ToList();
        }

        private List<string> GetAllCity()
        {
            return memberRepository.GetMembers().Select(m => m.City).Distinct().ToList();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            dgvMember.DataSource = memberRepository.GetMembers().ToList();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Member member = null;
            try{ 
                member = ListMembers[dgvMember.CurrentRow.Index];
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (MessageBox.Show("Are you sure to delete this member?", "Delete Member", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                memberRepository.DeleteMember(member.MemberId);
                MessageBox.Show("Delete Success");
                LoadMemberList();
            }
        }
    }
}
