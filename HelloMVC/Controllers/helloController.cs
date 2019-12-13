using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/index had (string name)
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='language' id='language'>" +
                "<option value='Baguette'>French</option>"+
                "<option value='Konbonwa'>Japanese</option>"+
                "<option value='Holas'>Spanish</option>"+
                "<option value='Gutentag'>German</option>"+
                "<option value='Aloha'>Hawaiian</option>"+
                "</select>"+
                "<input type ='submit' value='Greet me!' />" +
                "</form>";

           
            return Content(html, "text/html");
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string language,string name= "World")
         {

           return Content($"<h1>{language} {name}</h1>","text/html");
         }




        //Hello/Goodbye
        //alter the route to thiis controller to be /hello/aloha
        //[Route("/Hello/Aloha")]

         // public static string CreateMessage(string name, string language)

        //Handle request to /Hello/NAME/NOAH(URL segment)




        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content($"<h1>Hello {name}</h1>", "text/html");
        }


        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }


    }
}
