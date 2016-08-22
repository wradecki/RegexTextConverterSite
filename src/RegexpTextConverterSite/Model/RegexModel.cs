using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RegexpTextConverterSite.Model
{
    public class RegexModel
    {
        public RegexModel()
        {
            Input = string.Empty;
            Repalcement = string.Empty;
            Pattern = string.Empty;
            SelectedRegexOptions = new List<RegexOptions> {RegexOptions.None};
        }

        [Required]
        public string Input { get; set; }

        public string Repalcement { get; set; }

        [Required]
        public string Pattern { get; set; }

        public static IList<SelectListItem> AllRegexOptions
            =>
            Enum.GetValues(typeof(RegexOptions))
                .Cast<RegexOptions>()
                .Select(item => new SelectListItem {Text = item.ToString(), Value = item.ToString()})
                .ToList();

        public IList<RegexOptions> SelectedRegexOptions { get; set; }

        public string Result { get; set; }
    }
}