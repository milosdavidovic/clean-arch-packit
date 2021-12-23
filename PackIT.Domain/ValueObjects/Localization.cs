using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.ValueObjects
{
    internal record Localization (string country, string city)
    {
        public string Country { get; private set; }
        public string City { get; }

        public static Localization Create(string value)
        {
            var split = value.Split(',');
            return new Localization(split[0], split[1]);
        }

        public override string ToString() => 
            $"{Country},{City}";
        
    }
}
 