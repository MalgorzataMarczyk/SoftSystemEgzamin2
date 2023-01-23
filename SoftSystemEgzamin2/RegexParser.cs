using System.Text.RegularExpressions;

namespace SoftSystemEgzamin2
{
    internal static class RegexParser
    {
        const string rulePattern = @"(?<=\[)(.*?)(?=\])";
        static Regex rgx = new Regex(rulePattern);

        const string numberOfUsagePattern = @"(.*?)(?=\{)";
        static Regex rgx2 = new Regex(numberOfUsagePattern);
        
        const string ruleStePattern = @"(?<=\{)(.*?)(?=\})";
        static Regex rgx3 = new Regex(ruleStePattern);

        public static string[] ParseInputToRule(string input)
        {
            return rgx.Matches(input).Select(x => x.Value).ToArray();
        }

        public static int GetNumberOfUsage(string input)
        {
            return Int32.Parse(rgx2.Matches(input).Select(x => x.Value).First());
        }

        public static string[] GetRuleSet(string input)
        {
            return rgx3.Matches(input).Select(x => x.Value).First().Split(",");
        }
    }
}
