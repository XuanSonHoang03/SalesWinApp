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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Xml.Linq;

namespace SalesWinApp
{
    public partial class frmMemberManagement : Form
    {
        public IMemberRepository memberRepository = new MemberRepository();
        private List<MemberObject> membersList;
        private List<MemberObject> searchList;
        BindingSource binding;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            cbSearch.SelectedIndex = 0;
            cbFilter.SelectedIndex = 0;
            LoadMemberList();
            dgvMember.CellDoubleClick += DgvMember_CellDoubleClick;
        }

        private void LoadMemberList()
        {
            var member = memberRepository.GetMembers();
            this.membersList = member;
            try
            {
                binding = new BindingSource();
                binding.DataSource = membersList;

                tbID.DataBindings.Clear();
                tbCity.DataBindings.Clear();
                tbEmail.DataBindings.Clear();
                tbCompany.DataBindings.Clear();
                tbCountry.DataBindings.Clear();
                tbPassword.DataBindings.Clear();

                tbID.DataBindings.Add("Text", binding, "MemberID");
                tbCity.DataBindings.Add("Text", binding, "MemberCity");
                tbEmail.DataBindings.Add("Text", binding, "MemberEmail");
                tbCompany.DataBindings.Add("Text", binding, "CompanyName");
                tbCountry.DataBindings.Add("Text", binding, "MemberCountry");
                tbPassword.DataBindings.Add("Text", binding, "MemberPassword");

                dgvMember.DataSource = binding;

                if (membersList == null)
                {
                    ClearText();
                    btDelete.Enabled = false;
                    btNew.Enabled = false;
                }
                else
                {
                    btDelete.Enabled = true;
                    btNew.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearText()
        {
            tbCity.Text = "";
            tbEmail.Text = "";
            tbCompany.Text = "";
            tbCountry.Text = "";
            tbPassword.Text = "";
            tbID.Text = "";
        }

        private void DgvMember_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmMember frmMember = new frmMember()
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                isAdmin = true,
                memberRepository = memberRepository,
                MemberObject = membersList[dgvMember.CurrentRow.Index]
            };
            if (frmMember.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                binding.Position = binding.Count - 1;
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            frmMember frmMember = new frmMember()
            {
                Text = "Insert Member",
                InsertOrUpdate = false,
                memberRepository = memberRepository
            };
            if (frmMember.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                binding.Position = binding.Count - 1;
            }
            LoadMemberList();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberId);
                LoadMemberList();
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
        }

        private MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject()
                {
                    MemberId = int.Parse(tbID.Text),
                    MemberEmail = tbEmail.Text,
                    MemberPassword = tbPassword.Text,
                    MemberCountry = tbCountry.Text,
                    MemberCity = tbCity.Text,
                    CompanyName = tbCompany.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return member;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string textSearch = tbSearch.Text;
                if (cbSearch.SelectedIndex == 0)
                {
                    if (string.IsNullOrEmpty(textSearch))
                    {
                        LoadMemberList();
                    }
                    else
                    {
                        searchList = membersList.Where(x => x.MemberId.ToString().Contains(textSearch)).ToList();
                        LoadSearchMember(searchList);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(textSearch))
                    {
                        LoadMemberList();
                    }
                    else
                    {
                        searchList = membersList.Where(x => x.MemberEmail.Contains(textSearch)).ToList();
                        LoadSearchMember(searchList);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSearchMember(List<MemberObject> searchList)
        {
            binding = new BindingSource();
            binding.DataSource = searchList;

            tbID.DataBindings.Clear();
            tbEmail.DataBindings.Clear();
            tbCountry.DataBindings.Clear();
            tbCity.DataBindings.Clear();
            tbCompany.DataBindings.Clear();
            tbPassword.DataBindings.Clear();

            tbID.DataBindings.Add("Text", binding, "MemberID");
            tbEmail.DataBindings.Add("Text", binding, "MemberEmail");
            tbCountry.DataBindings.Add("Text", binding, "MemberCountry");
            tbCity.DataBindings.Add("Text", binding, "MemberCity");
            tbCompany.DataBindings.Add("Text", binding, "CompanyName");
            tbPassword.DataBindings.Add("Text", binding, "MemberPassword");

            binding.DataSource = searchList;
            dgvMember.DataSource = binding;

            if (searchList == null)
            {
                ClearText();
                btDelete.Enabled = false;
                btNew.Enabled = false;
            }
            else
            {
                btDelete.Enabled = true;
                btNew.Enabled = true;
                btLoad.Enabled = true;
            }
        }

        private void cbFilterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchList = memberRepository.GetMembers();

            if (cbFilter.SelectedIndex == 0)
            {
                searchList = memberRepository.FilterByCity(cbFilterList.SelectedItem.ToString());
                LoadSearchMember(searchList);
            }
            else
            {
                searchList = memberRepository.FilterByCountry(cbFilterList.SelectedItem.ToString());
                LoadSearchMember(searchList);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> strings = new List<string>();
            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    strings = GetListCity();
                    break;
                case 1:
                    strings = GetListCountry();
                    break;
            }
            cbFilterList.Items.Clear();
            if (strings != null)
            {
                cbFilterList.Items.AddRange(strings.ToArray());
            }
            cbFilterList.SelectedIndex = 0;
        }

        private List<string> GetListCountry()
        {
            return memberRepository.GetMembers().Select(x => x.MemberCountry).Distinct().ToList();
        }

        private List<string> GetListCity()
        {
            return memberRepository.GetMembers().Select(x => x.MemberCity).Distinct().ToList();
        }

        private void DESC_Click(object sender, EventArgs e)
        {
            List<MemberObject> memberObjects = new List<MemberObject>();
            if(searchList == null)
            {
                memberObjects = memberRepository.GetMembers();
            } else
            {
                memberObjects = searchList;
            }
            if(btSort.Text.Trim().Equals("DESC"))
            {
                memberObjects = memberObjects.OrderByDescending(x => x.MemberId).ToList();
                LoadSearchMember(memberObjects);
                btSort.Text = "ASC";
            } else
            {
                memberObjects = memberObjects.OrderBy(x => x.MemberId).ToList();
                LoadSearchMember(memberObjects);
                btSort.Text = "DESC";
            }
        }
    }
}
