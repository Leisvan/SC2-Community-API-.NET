using System;
using System.Collections.Generic;
using System.Text;

namespace SC2CommunityAPI.Tools
{
    internal static class DateHelper
    {
        private static readonly DateTime GLOBALSTART = new DateTime(1970, 1, 1);
        public static DateTime FormatFromStandardSeconds(string timestampInSeconds)
        {
            if (double.TryParse(timestampInSeconds, out double numValue))
            {
                return FormatFromStandardSeconds(numValue);
            }
            return GLOBALSTART;
        }
        public static DateTime FormatFromStandardSeconds(double timestampInSeconds)
        {
            if (timestampInSeconds > 0)
            {
                return GLOBALSTART.Add(TimeSpan.FromSeconds(timestampInSeconds));
            }
            return GLOBALSTART;
        }

    }
}
