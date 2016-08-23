using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace RegexTextConverterSite.Services
{
    public class RegexConverterOptions : ConverterOptions
    {
        public RegexConverterOptions([NotNull] string pattern, RegexOptions options)
        {
            this[nameof(Pattern)] = pattern;
            this[nameof(RegexOptions)] = options;
        }

        [NotNull]
        public string Pattern => (string) this[nameof(Pattern)];

        public RegexOptions RegexOptions => (RegexOptions) this[nameof(RegexOptions)];
    }
}
