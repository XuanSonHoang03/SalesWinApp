using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess.Repository.Member
{
    public interface IMemberRepository
    {
        IEnumerable<BusinessObject.Models.Member> GetMembers();
        BusinessObject.Models.Member GetMemberByUserPass(string user, string pass);
        void DeleteMember(int id);
        void AddMember(BusinessObject.Models.Member member);
        void UpdateMember(BusinessObject.Models.Member member);
        List<BusinessObject.Models.Member> SearchMemberByID(int id);
        List<BusinessObject.Models.Member> SearchMemberByEmail(string email);
        List<BusinessObject.Models.Member> FilterMemberBiCity(string city);
        List<BusinessObject.Models.Member> FilterMemberByCountry(string country);

    }
}
