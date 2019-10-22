using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Controller
    {
        private Board game;
        private Player p1, p2;

        public Controller()
        {
            game = new Board(3, 5, 7);
            p1 = new Player("DIO");
            p2 = new Player("JOtaro");
        }
        public void Playgame()
        {
            game.printGame();
            while (true)
            {
                Console.WriteLine(p1.GetName() + "a turn");
                p1.pickball(game);
                game.printGame();
                if (game.IsOver())
                {
                    Console.WriteLine(p1.GetName() + " Loses ");
                    Console.WriteLine(p2.GetName() + " Wins ");
                    break;
                }
                Console.WriteLine(p2.GetName() + " a turn ");
                p2.pickball(game);
                game.printGame();
                if (game.IsOver())
                {
                    Console.WriteLine(p2.GetName() + " Loses ");
                    Console.WriteLine(p1.GetName() + " Wins ");
                    break;
                }
            }
        }
    }
   }

