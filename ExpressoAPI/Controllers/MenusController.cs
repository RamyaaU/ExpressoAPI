using ExpressoAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        ExpressDbContext _expressoDbContext;

        public MenusController(ExpressDbContext expressDbContext)
        {
            _expressoDbContext = expressDbContext;
        }

        [HttpGet]
        public IActionResult GetMenus()
        {
            var menus = _expressoDbContext.Menus.Include("Submenus");
            return Ok(menus);
        }


        [HttpGet("{id}")]
        public IActionResult GetMenu(int id)
        {
            var menu = _expressoDbContext.Menus.Include("Submenus").FirstOrDefault(m=>m.Id==id);
            if(menu==null)
            {
                return NotFound();
            }
            return Ok(menu);
        }
    }
}
