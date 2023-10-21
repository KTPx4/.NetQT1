using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Model;

namespace Winform.Controller
{
    public class CT_ODetail
    {
        private DbSet<OrderDetail> _orders;
        private QT1Entities efDB;
        public String nextId { get; set; }
        public CT_ODetail()
        {

            Connections.Connection cn = new Connections.Connection();
            efDB = new QT1Entities(cn.GetConnectionString());
            _orders = efDB.OrderDetails;
            nextId = "00001";
        }
        public void Add(string currentID, string oid, string iid, int quan, decimal unit )
        {
           

            if(currentID.Length > 10) {
                currentID = currentID.Substring(0, 10);
            }
            MessageBox.Show(currentID);
            if (isExistsID(currentID))
            {
                MessageBox.Show("The ID was Exists in Database!", "Add Failed", MessageBoxButtons.OK);
                return;
            }

            OrderDetail newCustomer = new OrderDetail
            {
                ID = currentID,
                OrderID = oid,
                ItemID = iid,
                Quantity = quan,
                UnitAmount = unit
            };


            efDB.OrderDetails.Add(newCustomer);
            efDB.SaveChanges();


        }
        public bool isExistsID(string id)
        {
            IQueryable<OrderDetail> cust = getFromID(id);
            if (cust.Count() > 0)
            {
                return true;
            }
            return false;
        }
        public IQueryable<OrderDetail> getFromID(string ID)
        {
            IQueryable<OrderDetail> info =
                from OrderDetail in _orders
                where OrderDetail.ID == ID
                select OrderDetail;

            return info;

        }
        public String getMaxID()
        {
            string maxCustID = _orders.Max(c => c.ID);
            return maxCustID;

        }
    }
}
