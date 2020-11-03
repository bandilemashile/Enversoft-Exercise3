using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data;
using System.Web.Http;
using SupplierData;
using System.Data.Entity;




namespace SalesApp.Controllers
{
    public class SupplierController : ApiController
    {

        public IEnumerable<tblSupplier> Get()
        {
            using (SupplierEntities1 entities1 = new SupplierEntities1())
            {
                return entities1.tblSuppliers.ToList();
            }
        }

       public tblSupplier Get(int id)
        {
            using (SupplierEntities1 entities1 = new SupplierEntities1())
            {
                return entities1.tblSuppliers.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
