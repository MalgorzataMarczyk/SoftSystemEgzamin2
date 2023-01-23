using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftSystemEgzamin2
{
    internal class PasswordGenerator
    {
        private string[] _tempPasswordArray { get; set; }
        private List<Rule> _rules { get; set; }
        private int _passwordLength { get; set; }

        private Random _rnd = new Random();

        public PasswordGenerator(string input)
        {
            _rules = new List<Rule>();

            int lenght = 0;

            foreach (var match in RegexParser.ParseInputToRule(input))
            {
                Rule rule = new Rule(match);
                _rules.Add(rule);
                lenght += rule.GetNuberOfUsage();
            }


            _passwordLength = _rnd.Next(lenght, lenght + 10);
            _tempPasswordArray = new string[_passwordLength];

        }

        public string GeneratePassword()
        {
            int index = 0;

            foreach (var rule in _rules)
            {
                for (int i = 0; i < rule.GetNuberOfUsage(); i++)
                {
                    _tempPasswordArray[index] = rule.GenerateRuleString();
                    index++;
                }
            }

            while (index < _tempPasswordArray.Length)
            {
                _tempPasswordArray[index] = _rules.ElementAt(_rnd.Next(_rules.Count)).GenerateRuleString();
                index++;
            }

            Shuffle(_tempPasswordArray);

            return String.Concat(_tempPasswordArray);
        }

        public void Shuffle( string[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = _rnd.Next(n--);
                string temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
