using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.RoundedSkinPanel;

namespace Winform.Model
{
    public class CT_Customer
    {
        private DbSet<Customer> dbCustomer;

        private QT1Entities efDB;

        public String nextId {  get; set; }


        public CT_Customer()
        {
            
            Connections.Connection cn = new Connections.Connection();
            efDB = new QT1Entities(cn.GetConnectionString());
            dbCustomer = efDB.Customers;
            nextId = "00001";
        }

        //public Customer getFID(string ID)
        //{
        //    return dbCustomer.FirstOrDefault(c => c.CustID == "521H0125");
        //}


        public void AddCustomer(string id, string name, string address)
        {
            if(isExistsID(id))
            {
                MessageBox.Show("The ID was Exists in Database!", "Add Failed", MessageBoxButtons.OK);
                return;
            }

            Customer newCustomer = new Customer
            {
                CustID = id,
                CustName = name,
                Address = address
            };
          
          
            efDB.Customers.Add(newCustomer);
            efDB.SaveChanges();


        }

        public void AddCustomer(string name, string address)
        {
            
            String currentID = getMaxID();

            string newId = Px4Library.getNextID(currentID, nextId);

            Customer newCustomer = new Customer
            {
                CustID = newId,
                CustName = name,
                Address = address
            };

            efDB.Customers.Add(newCustomer);
            efDB.SaveChanges();


        }

        public void EditCustomer(string id, string name, string address)
        {

            if (isExistsID(id))
            {
                // Retrieve the entity first
                var cust = efDB.Customers.First(e => e.CustID == id);

                // Update properties
                cust.CustName = name;
                cust.Address = address;

                // save
                efDB.SaveChanges();
            }
            else
            {
                MessageBox.Show("The ID not Exists in Database!", "Edit Failed", MessageBoxButtons.OK);
            }
        }

        public void RemoveCustomer(string id)
        {
         
           
            if(isExistsID(id))
            {
                Customer Customer = dbCustomer.Where(c => c.CustID == id).FirstOrDefault();
                efDB.Customers.Remove(Customer);
                efDB.SaveChanges();
            }
            else
            {
                MessageBox.Show("The ID not Exists in Database!", "Delete Failed", MessageBoxButtons.OK);
            }
        }


        public bool isExistsID(string id)
        {
            IQueryable<Customer> cust = getFromID(id);
            if (cust.Count() > 0)
            {
                return true;
            }
            return false;
        }


        public IQueryable<Customer> getFromID(string ID)
        {
            IQueryable<Customer> info =
                from Customer in dbCustomer
                where Customer.CustID == ID
                select Customer;

            return info;
        }


        public String getMaxID()
        {
            string maxCustID = dbCustomer.Max(c => c.CustID);
            return maxCustID;

        }
     

        public List<Customer> GetAllCustomers()
        {
            return dbCustomer.ToList();
        }

    }
}
