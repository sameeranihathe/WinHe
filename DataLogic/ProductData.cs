using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model; 

namespace DataLogic
{
    public class ProductData
    {
        EContactEntities db = new EContactEntities();
        public void productsave()
        {
            List<ProductModel> prolist = new List<ProductModel>();
            ProductModel model = new ProductModel();

            model.ContactID = 1;
            model.FirstName = "no";
            prolist.Add(model);

            db.tbl_contact.Add(model);
            db.SaveChanges();
            
            


        }
    }

}
