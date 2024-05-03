using API.Controller.View.Models;
using Microsoft.AspNetCore.Mvc;


public class PeopleController : Controller
{
    private readonly WebApiControllerViewContext _dbcontext;

    public PeopleController(WebApiControllerViewContext Dbcontext)
    {
        _dbcontext = Dbcontext;
    }

    [HttpGet]
    public IActionResult GetAllPeople()
    {
        return View(_dbcontext.people.ToList());
    }
}

