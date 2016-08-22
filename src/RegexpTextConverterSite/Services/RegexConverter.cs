using System;
using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace RegexpTextConverterSite.Services
{
    public class RegexConverter : IConverter
    {
        /// <inheritdoc />
        [NotNull]
        public string Convert([NotNull] string input, [NotNull] string replacement = "", ConverterOptions options = null)
        {
            var regexOptions = options as RegexConverterOptions;
            if (regexOptions == null)
            {
                throw new ArgumentNullException(nameof(regexOptions));
            }

            var regex = new Regex(regexOptions.Pattern, regexOptions.RegexOptions);

            return regex.Replace(input, replacement);
        }
    }
}