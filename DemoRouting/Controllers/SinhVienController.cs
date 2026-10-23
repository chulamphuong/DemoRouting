
using Microsoft.AspNetCore.Mvc;

namespace DemoRouting.Controllers
{
    public class SinhVienController : Controller
    {
        public string Index()
        {
            return "Conventional Routing: Danh sach sinh vien";
        }

        public string Details(int id)
        {
            return "Conventional Routing: Sinh vien co ID: " + id;
        }
    }
}
