using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Member
{
    public class MemberRepository : IMemberRepository
    {
        public void AddMember(BusinessObject.Models.Member member)
        {
            MemberDAO.Instance.AddMember(member);
        }

        public void DeleteMember(int id)
        {
            MemberDAO.Instance.DeleteMember(id);
        }

        public List<BusinessObject.Models.Member> FilterMemberBiCity(string city)
        {
            return MemberDAO.Instance.FilterMemberByCity(city);
        }

        public List<BusinessObject.Models.Member> FilterMemberByCountry(string country)
        {
            return MemberDAO.Instance.FilterMemberByCountry(country);
        }

        public BusinessObject.Models.Member GetMemberByUserPass(string user, string pass)
        {
            return MemberDAO.Instance.GetMemberByUserPass(user, pass);
        }

        public IEnumerable<BusinessObject.Models.Member> GetMembers()
        {
            return MemberDAO.Instance.GetMembers();
        }

        public List<BusinessObject.Models.Member> SearchMemberByEmail(string email)
        {
            return MemberDAO.Instance.SearchMemberByEmail(email);
        }

        public List<BusinessObject.Models.Member> SearchMemberByID(int id)
        {
            return MemberDAO.Instance.SearchMemberByID(id);
        }

        public void UpdateMember(BusinessObject.Models.Member member)
        {
            MemberDAO.Instance.UpdateMember(member);
        }
    }
}
