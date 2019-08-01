
namespace ConfigManagerEditor
{
    using System;
    using System.Globalization;
    using System.Collections.Generic;
    public class ConfigConstants
    {
        public const NumberStyles NUMBER_STYPLES =
           NumberStyles.AllowCurrencySymbol |
           NumberStyles.AllowExponent |
           NumberStyles.AllowDecimalPoint |
           NumberStyles.AllowParentheses |
           NumberStyles.AllowTrailingSign |
           NumberStyles.AllowLeadingSign |
           NumberStyles.AllowTrailingWhite |
           NumberStyles.AllowLeadingWhite;

        public static Type OBJECT_ARRAY_TYPE = typeof(object[]);
        public static Type OBJECT_DICTIONARY_TYPE = typeof(Dictionary<string, object>);
    }
}

