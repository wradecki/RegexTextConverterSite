using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace RegexpTextConverterSite.Services
{
    public class RegexConverterOptions : ConverterOptions
    {
        public RegexConverterOptions([NotNull] string pattern, [NotNull] RegexOptions options)
        {
            this[nameof(Pattern)] = pattern;
            this[nameof(RegexOptions)] = options;
        }

        [NotNull]
        public string Pattern => (string) this[nameof(Pattern)];

        [NotNull]
        public RegexOptions RegexOptions => (RegexOptions) this[nameof(RegexOptions)];
    }
}
