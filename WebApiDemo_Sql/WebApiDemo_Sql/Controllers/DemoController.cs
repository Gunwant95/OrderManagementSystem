using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OrderAccess;

namespace WebApiDemo_Sql.Controllers
{
    public class DemoController : ApiController
    {
        public IEnumerable<Client> Get()
        {
            using (OrderEntities1 e = new OrderEntities1())
            {
                return e.Clients.ToList();
            }
        }
        public IEnumerable<Client> Get(int id)
        {
            using (OrderEntities1 e = new OrderEntities1())
            {
                yield return e.Clients.FirstOrDefault(O => O.Cust_id == id);
            }
        }
    }
}
