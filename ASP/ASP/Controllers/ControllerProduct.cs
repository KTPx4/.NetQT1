using ASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;

namespace ASP.Controllers
{
    public class ControllerProduct : Controller
    {
 

        ModelProduct ModelProduct = new ModelProduct();
    
        [HttpPost]
        public JsonResult SaveItem(ModelProduct item)
        {
            bool success = true;
            string message = "Thêm sản phẩm thành công!";

            var configuration = HttpContext.RequestServices.GetService<IConfiguration>();
            var connectionString = configuration.GetConnectionString("ConnectionString");

            /*
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Item WHERE ItemID = @ItemID", conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", item.ID);

                    int existingItemCount = (int)cmd.ExecuteScalar();

                    if (existingItemCount > 0)
                    {
                        success = false;
                        message = "ID đã tồn tại!";
                    }
                    else
                    {
                        cmd.CommandText = "INSERT INTO Item (ItemID, ItemName, Size, Price) VALUES (@id, @name, @size, @price)";
                        cmd.Parameters.AddWithValue("@id", item.ID);
                        cmd.Parameters.AddWithValue("@name", item.Name);

                        cmd.Parameters.AddWithValue("@size", item.Size);
                        cmd.Parameters.AddWithValue("@price", item.Price);

                        cmd.ExecuteNonQuery();
                    }
                }

                conn.Close();
            }
            */

            if (ModelProduct.isExistsID(item.ID, connectionString))
            {
                success = false;
                message = "ID đã tồn tại!";
            }
            else if(item.ID.Length > 10)
            {
                success = false;
                message = "ID < 10 Ký tự";
            }
            else if(!double.TryParse(item.Price.ToString(), out double b))
            {
                success = false;
                message = "Giá phải là số, không được chứa ký tự";
            }
            else
            {
                ModelProduct.Add(item, connectionString);
            }
            return Json(new { success = success, message = message });
        }

        [HttpPost]
        public JsonResult DeleteItem(ModelProduct item)
        {
            bool success = true;
            string message = "Xóa sản phẩm thành công!";

            var configuration = HttpContext.RequestServices.GetService<IConfiguration>();
            var connectionString = configuration.GetConnectionString("ConnectionString");
                       

            if (ModelProduct.isExistsID(item.ID, connectionString))
            {
                ModelProduct.Remove(item, connectionString);
            }
            else
            {
                success = false;
                message = "ID Không tồn tại!";
              
            }
            return Json(new { success = success, message = message });
        }
    }
}
