using ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Controllers
{
    public class ControllerCustomer : Controller
    {

        ModelCustomer Model = new ModelCustomer();

        [HttpPost]
        public JsonResult Save(ModelCustomer item)
        {
            bool success = true;
            string message = "Thêm khách hàng thành công!";

            var configuration = HttpContext.RequestServices.GetService<IConfiguration>();
            var connectionString = configuration.GetConnectionString("ConnectionString");
                      

            if (Model.isExistsID(item.ID, connectionString))
            {
                success = false;
                message = "ID đã tồn tại!";
            }
            else if (item.ID.Length > 10)
            {
                success = false;
                message = "ID < 10 Ký tự";
            }           
            else
            {
                Model.Add(item, connectionString);
            }
            return Json(new { success = success, message = message });
        }

        [HttpPost]
        public JsonResult Delete(ModelCustomer item)
        {
            bool success = true;
            string message = "Xóa khách hàng thành công!";

            var configuration = HttpContext.RequestServices.GetService<IConfiguration>();
            var connectionString = configuration.GetConnectionString("ConnectionString");


            if (Model.isExistsID(item.ID, connectionString))
            {
                Model.Remove(item, connectionString);
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
