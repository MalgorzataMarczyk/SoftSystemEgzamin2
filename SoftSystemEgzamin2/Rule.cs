using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftSystemEgzamin2
{
    internal class Rule
    {
        private int _numberOfUsage { get; set; }
        private string[] _ruleSet { get; set; }

        public Rule(string input)
        {
            _numberOfUsage = RegexParser.GetNumberOfUsage(input);
            _ruleSet = RegexParser.GetRuleSet(input);
        }

        public int GetNuberOfUsage()
        {
            return _numberOfUsage;
        }

        public string GenerateRuleString()
        {
            Random rnd = new Random();
            int index = rnd.Next(_ruleSet.Length);
            return _ruleSet[index];
        }
    }
}
