using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OrderAccess;

namespace WebApiDemo_Sql.Controllers
{
    public class OrderController : ApiController
    {
        public IEnumerable<Order> Get()
        {
            using (OrderEntities entities = new OrderEntities())
            {
                return entities.Orders.ToList();
            }
        }
        public IEnumerable<Order> Get(int id)
        {
            using (OrderEntities entities = new OrderEntities())
            {
                yield return entities.Orders.FirstOrDefault(o => o.Order_id == id);
            }
        }
    }
}
