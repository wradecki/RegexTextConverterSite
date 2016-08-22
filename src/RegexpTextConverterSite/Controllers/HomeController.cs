using Microsoft.AspNetCore.Mvc;
using RegexpTextConverterSite.Model;
using RegexpTextConverterSite.Services;

namespace RegexpTextConverterSite.Controllers
{
    public class HomeController : Controller

    {
        private readonly IConverter _converter;

        public HomeController(IConverter converter)
        {
            _converter = converter;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new RegexModel());
        }

        [HttpPost]
        public string Index(RegexModel model)
        {
            model.Result = model.ToString();
            return model.Result;
        }
    }
}