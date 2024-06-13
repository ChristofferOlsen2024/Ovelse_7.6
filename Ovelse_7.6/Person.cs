using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse_7._6
{
    internal class Person
    {

        public required String Navn { get; set; }
        public required String Email { get; set; }

        public void Udskriv()
        {
            Console.WriteLine($"Personen hedder {Navn} og email er {Email}");
        }
    }
}
