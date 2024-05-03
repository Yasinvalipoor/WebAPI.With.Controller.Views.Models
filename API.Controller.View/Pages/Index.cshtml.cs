using API.Controller.View.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace API.Controller.View.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WebApiControllerViewContext _dbcontext;

        public IndexModel(WebApiControllerViewContext Dbcontext)
        {
            this._dbcontext = Dbcontext;
        }
        public void OnGet()
        {
            var people = _dbcontext.people.ToList();
        }

        public string GetDataTime()
        {
            return DateTime.Now.ToString();
        }


    }
}
