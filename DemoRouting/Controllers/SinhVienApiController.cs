
using Microsoft.AspNetCore.Mvc;

namespace DemoRouting.Controllers
{
    [ApiController]
    [Route("api/sinhvien")]
    public class SinhVienApiController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Attribute Routing: Danh sach sinh vien";
        }

        [HttpGet("{id}")]
        public string Details(int id)
        {
            return "Attribute Routing: Sinh vien co ID: " + id;
        }
    }
}
