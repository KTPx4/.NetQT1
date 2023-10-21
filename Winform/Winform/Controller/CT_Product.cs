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
    public class CT_Product
    {

        private DbSet<Item> dbProduct;

        private QT1Entities efDB;

        public String nextId { get; set; }


        public CT_Product()
        {

            Connections.Connection cn = new Connections.Connection();
            efDB = new QT1Entities(cn.GetConnectionString());
            dbProduct = efDB.Items;
            nextId = "00001";
        }


        public void AddItem(string id, string name, string size, decimal price)
        {
            if (isExistsID(id))
            {
                MessageBox.Show("The ID was Exists in Database!", "Add Failed", MessageBoxButtons.OK);
                return;
            }

            Item it = new Item
            {
                ItemID = id,
                ItemName = name,
                Size = size,
                Price = price

            };


            efDB.Items.Add(it);
            efDB.SaveChanges();


        }

        public void AddItem(string name, string size, decimal price)
        {

            String currentID = getMaxID();

            string newId = Px4Library.getNextID(currentID, nextId);

            Item it = new Item
            {
                ItemID = newId,
                ItemName = name,
                Size = size,
                Price = price

            };


            efDB.Items.Add(it);
            efDB.SaveChanges();



        }

        public void EditItem(string id, string name, string size, decimal price)
        {

            if (isExistsID(id))
            {
                // Retrieve the entity first
                var itm = efDB.Items.First(e => e.ItemID == id);

                // Update properties
                itm.ItemName = name;
                itm.Size = size;
                itm.Price = price;
        
                // save
                efDB.SaveChanges();
            }
            else
            {
                MessageBox.Show("The ID not Exists in Database!", "Edit Failed", MessageBoxButtons.OK);
            }
        }

        public void RemoveItem(string id)
        {

            if (isExistsID(id))
            {
                Item itm = dbProduct.Where(c => c.ItemID == id).FirstOrDefault();
                efDB.Items.Remove(itm);
                efDB.SaveChanges();
            }
            else
            {
                MessageBox.Show("The ID not Exists in Database!", "Delete Failed", MessageBoxButtons.OK);
            }
        }


        public bool isExistsID(string id)
        {
            IQueryable<Item> cust = getFromID(id);
            if (cust.Count() > 0)
            {
                return true;
            }
            return false;
        }


        public IQueryable<Item> getFromID(string ID)
        {
            IQueryable<Item> info =
                from Item in dbProduct
                where Item.ItemID == ID
                select Item;

            return info;
        }


        public String getMaxID()
        {
            string maxID = dbProduct.Max(c => c.ItemID);
            return maxID;

        }


        public List<Item> GetAll()
        {
            return dbProduct.ToList();
        }

    }
}
