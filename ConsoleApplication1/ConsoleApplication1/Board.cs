using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     class Board
    {
        private int G1, G2, G3;
        public Board(int g1, int g2, int g3)
        {
           this.G1 = g1;
           this.G2 = g2;
           this.G3 = g3;
           
        }
        public void printGame()
        {            
            Console.Write("Line 1 :");
            for (int i = 0; i < G1; i++)
            {
                Console.Write(" O ");
            }
            Console.WriteLine();
            Console.Write("Line 2 :");
            for (int i = 0; i < G2; i++)
            {
                Console.Write(" O ");
            }
            Console.WriteLine();
            Console.Write("Line 3 :");
            for (int i = 0; i < G3; i++)
            {
                Console.Write(" O ");
            }
            Console.WriteLine();
        }
        public void pickball(int group, int balls)
        {
              if (balls > G1 && balls > G2 && balls > G3)
                    {
                        Console.WriteLine("That can't be done.");
                    }
            switch(group){
                case 1:
                    G1 -= balls;
                    break;
                case 2:
                    G2 -= balls;
                    break;
                case 3:
                    G3 -= balls;
                    break;
                }                  
            }
        public bool IsOver()
        {
            if (G1 == 0 && G2 == 0 && G3 == 0)
                return true;
            else
                return false;
        }  
        }
        
}
