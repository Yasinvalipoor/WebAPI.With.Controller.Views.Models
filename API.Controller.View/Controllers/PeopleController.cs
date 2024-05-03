using API.Controller.View.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller.View.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PeopleController : ControllerBase
    {
        private readonly WebApiControllerViewContext dbcontext;

        public PeopleController(WebApiControllerViewContext Dbcontext)
        {
            dbcontext = Dbcontext;
        }

        [HttpGet("GetAllPeople")]
        public IActionResult GetAllPeople()
        {
            return Ok(dbcontext.people.ToList());
        }
    }
}
