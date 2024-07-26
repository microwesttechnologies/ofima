using API.Domain.Entity;
using API.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;



namespace API.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly IRepositoryBase<MenuEntity, int> _menuService;

        public MenuController(IRepositoryBase<MenuEntity, int> menuRepository)
        {
            _menuService = menuRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MenuEntity>> Get()
        {
            var menus = _menuService.GetAll();
            return Ok(menus);
        }

        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}


        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}


        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}


        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
