using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Refree
    {
        public string Name { get; set; }
        public void Look(Ball ball)
        {
            Console.WriteLine($"Refree: {Name} Looking At Ball: {ball}");
        }
        public override string ToString()
        {
            return $"Refree Name: {Name}";
        }
    }
}
