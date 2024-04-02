using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.Data.SqlClient;
namespace DataAccess.DAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;
        private static readonly object instanceLock = new object();
        private OrderDAO()
        {
        }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        public List<OrderObject> GetAllOrder()
        {
            string sql = "select * from [Order]";
            var orderList = new List<OrderObject>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql).Rows)
            {
                OrderObject order = new OrderObject
                {
                    OrderId = int.Parse(dr["OrderId"].ToString()),
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    OrderDate = DateTime.Parse(dr["OrderDate"].ToString()),
                    RequiredDate = DateTime.Parse(dr["RequiredDate"].ToString()),
                    ShippedDate = DateTime.Parse(dr["ShippedDate"].ToString()),
                    Freight = double.Parse(dr["Freight"].ToString()),
                };
                orderList.Add(order);
            }
            return orderList;
        }
        public OrderObject GetOrderById(int orderId)
        {
            string sql = "select * from [Order] where OrderId = @OrderId";
            DataTable dt = DBContext.GetDataBySQL(sql, new SqlParameter("@OrderId", orderId));
            OrderObject orderObject = null;
            foreach (DataRow dr in dt.Rows)
            {
                orderObject = new OrderObject
                {
                    OrderId = int.Parse(dr["OrderId"].ToString()),
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    OrderDate = DateTime.Parse(dr["OrderDate"].ToString()),
                    RequiredDate = DateTime.Parse(dr["RequiredDate"].ToString()),
                    ShippedDate = DateTime.Parse(dr["ShippedDate"].ToString()),
                    Freight = double.Parse(dr["Freight"].ToString()),
                };
            }
            return orderObject;
        }
        public int InsertOrder(OrderObject orderObject)
        {
            string sql = "insert into [Order] values ( @MemberId, @OrderDate, @RequiredDate, @ShippedDate, @Freight)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MemberId", orderObject.MemberId),
                new SqlParameter("@OrderDate", orderObject.OrderDate),
                new SqlParameter("@RequiredDate", orderObject.RequiredDate),
                new SqlParameter("@ShippedDate", orderObject.ShippedDate),
                new SqlParameter("@Freight", orderObject.Freight),
            };
            return DBContext.ExcuteSql(sql, parameters);
        }
        public int delete(int id)
        {
            string sql = "delete from [Order] where OrderId = @OrderId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", id),
            };
            return DBContext.ExcuteSql(sql, parameters);
        }

        internal int InsertAndGetOrderId(OrderObject orderObject)
        {
            //code get orderId after insert
            string sql = "insert into [Order] values ( @MemberId, @OrderDate, @RequiredDate, @ShippedDate, @Freight); SELECT SCOPE_IDENTITY()";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MemberId", orderObject.MemberId),
                new SqlParameter("@OrderDate", orderObject.OrderDate),
                new SqlParameter("@RequiredDate", orderObject.RequiredDate),
                new SqlParameter("@ShippedDate", orderObject.ShippedDate),
                new SqlParameter("@Freight", orderObject.Freight),
            };
            return int.Parse(DBContext.ExcuteSql(sql, parameters).ToString());
        }

        internal string GetTotalOrderByID(string v)
        {
            string sql = "SELECT SUM(Quantity * UnitPrice) FROM OrderDetails WHERE OrderId = @OrderId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", v),
            };

            object result = DBContext.ExcuteSql(sql, parameters);

            if (result != DBNull.Value)
            {
                return result.ToString();
            }
            else
            {
                return "0";
            }
        }

        internal List<OrderObject> SearchByOrderDate(DateTime date1, DateTime date2)
        {
            string sql = "select * from [Order] where OrderDate between @date1 and @date2";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@date1", date1),
                new SqlParameter("@date2", date2),
            };
            var orderList = new List<OrderObject>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql, parameters).Rows)
            {
                OrderObject order = new OrderObject
                {
                    OrderId = int.Parse(dr["OrderId"].ToString()),
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    OrderDate = DateTime.Parse(dr["OrderDate"].ToString()),
                    RequiredDate = DateTime.Parse(dr["RequiredDate"].ToString()),
                    ShippedDate = DateTime.Parse(dr["ShippedDate"].ToString()),
                    Freight = double.Parse(dr["Freight"].ToString()),
                };
                orderList.Add(order);
            }
            return orderList;
        }
    }
}
