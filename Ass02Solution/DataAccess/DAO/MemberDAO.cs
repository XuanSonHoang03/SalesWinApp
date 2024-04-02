
using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Data;
using DataAccess;
using Microsoft.Extensions.Configuration;

namespace DataAccess.DAO
{
    public class MemberDAO
    {
        private static MemberDAO instance;
        private static readonly object instanceLock = new object();
        private MemberDAO()
        {
        }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public MemberObject getMemberByUserNamePassword(string username, string password)
        {
            string sql = "select * from Member where Email = @Email and Password = @Password";
            DataTable dt = DBContext.GetDataBySQL(sql, new SqlParameter("@Email", username), new SqlParameter("@Password", password));
            MemberObject memberObject = null;
            foreach (DataRow dr in dt.Rows)
            {
                memberObject = new MemberObject
                {
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    MemberEmail = dr["Email"].ToString(),
                    MemberCity = dr["City"].ToString(),
                    MemberCountry = dr["Country"].ToString(),
                    MemberPassword = dr["Password"].ToString(),
                    CompanyName = dr["CompanyName"].ToString()
                };
            }
            return memberObject;
        }
        public List<MemberObject> GetMemberObject()
        {
            string sql = "select * from Member";
            var memberList = new List<MemberObject>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql).Rows)
            {
                MemberObject member = new MemberObject
                {
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    MemberEmail = dr["Email"].ToString(),
                    MemberCity = dr["City"].ToString(),
                    MemberCountry = dr["Country"].ToString(),
                    MemberPassword = dr["Password"].ToString(),
                    CompanyName = dr["CompanyName"].ToString()
                };
                memberList.Add(member);
            }
            return memberList;
        }
        public MemberObject getMemberByID(int id)
        {
            string sql = "select * from Member where MemberId = @MemberId";
            DataTable dt = DBContext.GetDataBySQL(sql, new SqlParameter("@MemberId", id));
            MemberObject member = new MemberObject
            {
                MemberId = int.Parse(dt.Rows[0]["MemberId"].ToString()),
                MemberEmail = dt.Rows[0]["Email"].ToString(),
                MemberCity = dt.Rows[0]["City"].ToString(),
                MemberCountry = dt.Rows[0]["Country"].ToString(),
                MemberPassword = dt.Rows[0]["Password"].ToString(),
                CompanyName = dt.Rows[0]["CompanyName"].ToString()
            };
            return member;
        }
        public int AddMember(MemberObject member)
        {
            string sql = "insert into Member(Email, City, Country, Password, CompanyName) values(@Email, @City, @Country, @Password, @CompanyName)";
            DataTable dt = DBContext.GetDataBySQL(sql, new SqlParameter("@Email", member.MemberEmail), new SqlParameter("@City", member.MemberCity), new SqlParameter("@Country", member.MemberCountry), new SqlParameter("@Password", member.MemberPassword), new SqlParameter("@CompanyName", member.CompanyName));
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@Email", member.MemberEmail),
                    new SqlParameter("@City", member.MemberCity),
                    new SqlParameter("@Country", member.MemberCountry),
                    new SqlParameter("@Password", member.MemberPassword),
                    new SqlParameter("@CompanyName", member.CompanyName)
            };
            return DBContext.ExcuteSql(sql, parameters);
        }
        public int UpdateMember(MemberObject member)
        {
            string sql = "UPDATE Member SET Email = @Email, City = @City, Country = @Country, Password = @Password, CompanyName = @CompanyName WHERE MemberId = @MemberId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@Email", member.MemberEmail),
                    new SqlParameter("@City", member.MemberCity),
                    new SqlParameter("@Country", member.MemberCountry),
                    new SqlParameter("@Password", member.MemberPassword),
                    new SqlParameter("@CompanyName", member.CompanyName),
                    new SqlParameter("@MemberId", member.MemberId)
            };
            return DBContext.ExcuteSql(sql, parameters);
        }

        public int remove(int id)
        {
            string sql = "delete from Member where MemberId = @MemberId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@MemberId", id)
            };
            return DBContext.ExcuteSql(sql, parameters);
        }
        public List<MemberObject> FilterByCity(string city)
        {
            string sql = "select * from Member where City = @City";
            List<MemberObject> memberObject = new List<MemberObject>();
            DataTable dataTable = DBContext.GetDataBySQL(sql, new SqlParameter("@City", city));
            foreach (DataRow dr in dataTable.Rows)
            {
                MemberObject member = new MemberObject
                {
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    MemberEmail = dr["Email"].ToString(),
                    MemberCity = dr["City"].ToString(),
                    MemberCountry = dr["Country"].ToString(),
                    MemberPassword = dr["Password"].ToString(),
                    CompanyName = dr["CompanyName"].ToString()
                };
                memberObject.Add(member);
            }
            return memberObject;
        }
        public List<MemberObject> FilterByCountry(string country)
        {
            string sql = "select * from Member where Country = @Country";
            List<MemberObject> memberObject = new List<MemberObject>();
            DataTable dataTable = DBContext.GetDataBySQL(sql, new SqlParameter("@Country", country));
            foreach (DataRow dr in dataTable.Rows)
            {
                MemberObject member = new MemberObject
                {
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    MemberEmail = dr["Email"].ToString(),
                    MemberCity = dr["City"].ToString(),
                    MemberCountry = dr["Country"].ToString(),
                    MemberPassword = dr["Password"].ToString(),
                    CompanyName = dr["CompanyName"].ToString()
                };
                memberObject.Add(member);
            }   
            return memberObject;
        }
        public List<MemberObject> SearchMemberByName(string name)
        {
            string sql = "select * from Member where Name = @Name";
            List<MemberObject> memberObjects = new List<MemberObject>();
            DataTable dataTable = DBContext.GetDataBySQL(sql, new SqlParameter("@Name", name));
            foreach (DataRow dr in dataTable.Rows)
            {
                MemberObject memberObject = new MemberObject
                {
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    MemberEmail = dr["Email"].ToString(),
                    MemberCity = dr["City"].ToString(),
                    MemberCountry = dr["Country"].ToString(),
                    MemberPassword = dr["Password"].ToString(),
                    CompanyName = dr["CompanyName"].ToString()
                };
                memberObjects.Add(memberObject);
            }
            return memberObjects;
        }
    }
}
