using System.Collections.Generic;
using JetBrains.Annotations;

namespace RegexpTextConverterSite.Services
{
    public interface IConverter
    {
        /// <summary>
        /// Convert input using replacement
        /// </summary>
        /// <param name="input">input text</param>
        /// <param name="replacement">when found to replace with replacement</param>
        /// <param name="options">other conviguration options</param>
        /// <returns>converted text</returns>
        [NotNull]
        string Convert([NotNull] string input, [NotNull] string replacement = "", ConverterOptions options = null);
    }
}