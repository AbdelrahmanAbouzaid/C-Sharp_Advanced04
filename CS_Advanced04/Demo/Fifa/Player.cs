using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Player
    {
        public string Name { get; set; }
        public string TeamName { get; set; }
        public void Run(Ball ball)
        {
            Console.WriteLine($"Player {Name} Running At {ball}");
        }
        public override string ToString()
            => $"Player Name: {Name}, Team Name: {TeamName}";
    }
}
