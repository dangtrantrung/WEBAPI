using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WEBAPI.EntitiesM;

namespace MyShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController: ControllerBase
    {
        private readonly MyShopContext _context;

        public CategoriesController(MyShopContext ctx)
        {
            _context=ctx;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
           
                        
            return Ok(_context.Categories.ToList());
        }

    }
    
}