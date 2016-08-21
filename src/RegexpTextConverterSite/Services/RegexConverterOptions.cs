using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexpTextConverterSite.Services
{
    public class RegexConverterOptions : ConverterOptions
    {
        public RegexConverterOptions(string pattern, RegexOptions options)
        {
            this[nameof(Pattern)] = pattern;
            this[nameof(RegexOptions)] = options;
        }

        public string Pattern => (string) this[nameof(Pattern)];

        public RegexOptions RegexOptions => (RegexOptions) this[nameof(RegexOptions)];
    }
}
