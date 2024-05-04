using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Controller.View.Pages.RandomNumber
{
    public class IndexModel : PageModel
    {
        public List<int> numbers = new List<int>();

        public void OnGet(int num=1)
        {
            for (int i = 1; i <= num; i++)
            {
                numbers.Add(i);
            }
        }

        public IActionResult Test(int b)
        {
            if (b==1)
            {
                return BadRequest();
            }
            return Page();
        }
    }
}
