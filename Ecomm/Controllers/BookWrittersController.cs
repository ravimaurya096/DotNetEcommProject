using EmpDemoRest.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookWrittersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BookWrittersController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
