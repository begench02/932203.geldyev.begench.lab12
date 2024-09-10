using Microsoft.AspNetCore.Mvc;
using W932203_Geldyev_lab12.Models;

namespace W932203_Geldyev_lab12.Controllers
{
    public class Calc : Controller
    {
        public IActionResult Manual(string val1, string val2, string oper)
        {
            if (Request.Method == "POST")
            {
                Actions actions = new Actions();
                // actions.value1 = Request.Form["value1"];
                // actions.value2 = Request.Form["value2"];
                // actions.operation = Request.Form["operation"];

                actions.value1 = val1;
                actions.value2 = val2;
                actions.operation = oper;
                int x;
                if (int.TryParse(actions.value1, out x) && int.TryParse(actions.value2, out x))
                {
                    ViewBag.Result = actions.getResult();
                }
                else ViewBag.Result = "Nulls Components Exists";
                return View("Result");
            }
            else
                return View();
        }
        [HttpGet]
        public IActionResult ManualWithSeparateHandlers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ManualWithSeparateHandlers(string val1, string val2, string oper)
        {
            Actions actions = new Actions();
            // actions.value1 = Request.Form["value1"];
            // actions.value2 = Request.Form["value2"];
            // actions.operation = Request.Form["operation"];
            actions.value1 = val1;
            actions.value2 = val2;
            actions.operation = oper;
            int x;
            if (int.TryParse(actions.value1, out x) && int.TryParse(actions.value2, out x))
                ViewBag.Result = actions.getResult();
            else ViewBag.Result = "Nulls Components Exists";
            return View("Result");
        }
        [HttpPost]
        public IActionResult ModelBindingInParameters(string val1, string val2, string oper)
        {
            // System.Diagnostics.Debug.WriteLine(val1)
            Actions actions = new Actions();
            actions.value1 = val1;
            actions.value2 = val2;
            actions.operation = oper;
            int x;
            if (int.TryParse(actions.value1, out x) && int.TryParse(actions.value2, out x))
                ViewBag.Result = actions.getResultModel();
            else ViewBag.Result = "Nulls Components Exists";
            return View("Result");
        }
        [HttpGet]
        public IActionResult ModelBindingInParameters()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ModelBindingInSeparateModel(Actions actions, string val1, string val2, string oper)
        {
            actions.value1 = val1;
            actions.value2 = val2;
            actions.operation = oper;
            int x;
            if (int.TryParse(actions.value1, out x) && int.TryParse(actions.value2, out x))
                ViewBag.Result = actions.getResultModel();
            else ViewBag.Result = "Nulls Components Exists";
            return View("Result");
        }
        [HttpGet]
        public IActionResult ModelBindingInSeparateModel()
        {
            return View();
        }
    }
}
