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

        public ActionResult Index()
        {
            var model = new RegexModel();
            return View(model);
        }
    }
}