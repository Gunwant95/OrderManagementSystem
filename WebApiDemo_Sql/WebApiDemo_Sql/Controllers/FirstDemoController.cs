using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OrderAccess;

namespace WebApiDemo_Sql.Controllers
{
    public class FirstDemoController : ApiController
    {
        public IEnumerable<EmployeesNew> Get()
        {
            using (EmployeeEntities1 emp = new EmployeeEntities1())
            {
                return emp.EmployeesNews.ToList();
            }
        }

        //public EmployeesNew Get(int id)
        //{
        //    using (EmployeeEntities1 emp = new EmployeeEntities1())
        //    {
        //        return emp.EmployeesNews.FirstOrDefault(o => o.E_id == id);
        //    }
        //}
        public HttpResponseMessage Get(int id)
        {
            using (EmployeeEntities1 emp = new EmployeeEntities1())
            {
                var entity=emp.EmployeesNews.FirstOrDefault(o => o.E_id == id);
                if(entity!=null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK,entity);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Employee with Id " + id.ToString() + "Not found");
                }
            }
        }

        //public void Post([FromBody]EmployeesNew emp)
        //{
        //    using (EmployeeEntities1 entities = new EmployeeEntities1())
        //    {
        //        entities.EmployeesNews.Add(emp);
        //        entities.SaveChanges();     
        //    }
        //}
        public HttpResponseMessage Post([FromBody]EmployeesNew emp)
        {
            try
            {
                using (EmployeeEntities1 entities = new EmployeeEntities1())
                {
                    entities.EmployeesNews.Add(emp);
                    entities.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, emp);
                    message.Headers.Location = new Uri(Request.RequestUri + emp.E_id.ToString());
                    return message;
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ex);
            }
        }
    }
}
