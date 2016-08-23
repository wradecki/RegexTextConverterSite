using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using RegexTextConverterSite.Model;
using RegexTextConverterSite.Services;

namespace RegexTextConverterSite.Controllers
{
    public class HomeController : Controller

    {
        private readonly IConverter _converter;

        public HomeController(IConverter converter)
        {
            _converter = converter;
        }

        [HttpGet]
        public ActionResult Index() => View(new RegexModel());

        [HttpPost]
        public string Index(RegexModel model)
        {
            string result;
            try
            {
                var options = new RegexConverterOptions(model.Pattern, ConvertToFlag(model.SelectedRegexOptions));
                result = _converter.Convert(model.Input, model.Repalcement, options);
            }
            catch (Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        private static RegexOptions ConvertToFlag([NotNull] IList<RegexOptions> selectedRegexOptions)
            => selectedRegexOptions.Any() ? selectedRegexOptions.Aggregate((resultedOptions, nextOption) => resultedOptions | nextOption) : RegexOptions.None;
    }
}