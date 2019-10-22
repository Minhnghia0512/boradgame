using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player
    {
        public string NAme;
        private Board game;
        public void pickball(Board game)
        {
            Console.WriteLine("Pick a Group : ");
            int group = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick the number of balls that u want: ");
            int balls = Convert.ToInt32(Console.ReadLine());
           
        }
        public Player(string name)
        {
            this.NAme = name;
        }
        public string GetName()
        {
            return this.NAme;
        }
    }
}
