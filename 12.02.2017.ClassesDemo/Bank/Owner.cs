using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Owner
    {
        public Owner(string name, int age, bool hasBadCreditHistory = false)
        {
            this.Name = name;
            this.Age = age;
            this.HasBadCreditHistory = hasBadCreditHistory;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool HasBadCreditHistory { get; set; }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}, Bad history: {2}"
                , Name, Age,HasBadCreditHistory);
        }
    }
}
