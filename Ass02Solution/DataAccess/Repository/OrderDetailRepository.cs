using BusinessObject;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void delete(int orderId)
        {
            OrderDetailDAO.Instance.delete(orderId);
        }

        public List<OrderDetailObject> GetOrderDetailByOrderId(int orderId)
        {
            return OrderDetailDAO.Instance.GetOrderDetailByOrderId(orderId);
        }

        public List<OrderDetailObject> GetOrdersDetail()
        {
            return OrderDetailDAO.Instance.GetOrdersDetail();
        }

        public void insert(OrderDetailObject orderDetailObject)
        {
            OrderDetailDAO.Instance.insert(orderDetailObject);
        }
        public List<OrderDetailObject> GetOrderDetailByMemberId(int memberId)
        {
            return OrderDetailDAO.Instance.GetOrderDetailByMemberId(memberId);
        }
    }
}
