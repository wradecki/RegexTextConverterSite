using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexpTextConverterSite.Model
{
    public class RegexModel
    {
        public RegexModel()
        {
            Input = string.Empty;
            Repalcement = string.Empty;
            Pattern = string.Empty;

            AllRegexOptions = Enum.GetValues(typeof(RegexOptions)).Cast<RegexOptions>().ToList();
            SelectedRegexOptions = new List<RegexOptions>() {RegexOptions.None};

            Result = string.Empty;
        }

        public string Input { get; set; }

        public string Repalcement { get; set; }

        public string Pattern { get; set; }
        
        public IList<RegexOptions> AllRegexOptions { get; set; }

        public IList<RegexOptions> SelectedRegexOptions { get; set; }


        public string Result { get; set; }
    }
}