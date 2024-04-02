using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        List<OrderDetailObject> GetOrdersDetail();
        List<OrderDetailObject> GetOrderDetailByOrderId(int orderId);
        void delete(int orderId);
        void insert(OrderDetailObject orderDetailObject);
        List<OrderDetailObject> GetOrderDetailByMemberId(int memberId);
    }
}
