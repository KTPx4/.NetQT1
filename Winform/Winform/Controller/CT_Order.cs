using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform.Controller
{
    public class CT_Order
    {
        private DbSet<Order> _orders;
        private QT1Entities efDB; 
        public String nextId { get; set; }
        public CT_Order()
        {

            Connections.Connection cn = new Connections.Connection();
            efDB = new QT1Entities(cn.GetConnectionString());
            _orders = efDB.Orders;
            nextId = "00001";
        }
        public void Add(string id, DateTime date, string cust)
        {
            if (isExistsID(id))
            {
                MessageBox.Show("The ID was Exists in Database!", "Add Failed", MessageBoxButtons.OK);
                return;
            }

            Order newCustomer = new Order
            {
                OrderID = id,
                OrderDate = date,
                CustID = cust
            };


            efDB.Orders.Add(newCustomer);
            efDB.SaveChanges();


        }
        public bool isExistsID(string id)
        {
            IQueryable<Order> cust = getFromID(id);
            if (cust.Count() > 0)
            {
                return true;
            }
            return false;
        }
        public IQueryable<Order> getFromID(string ID)
        {
            IQueryable<Order> info =
                from Order in _orders
                where Order.OrderID == ID
                select Order;

            return info;
        }


    }
}
