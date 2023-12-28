using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // 객체(OOP Object Oriented Programming) 지향 (은닉성/상속성/다형성)
    class Player
    {
        protected int hp;
        protected int attack;
    }

    class Knight : Player
    {
    
    }

    class Mage : Player
    {
        public int mp;
    }


    class Program 
    {
        static void EnterGame(Player player)
        {
            // 방법1
            Mage mage = (player as Mage);   // Knight라면 null이 들어간다.
            if(mage != null)
            {
                mage.mp = 10;
                Console.WriteLine("실행");
            }
   
            // 방법2
            /*            bool isMage = (player is Mage);
                        if (isMage)
                        {

                            Mage mage = (Mage)player;
                            mage.mp = 10;
                        }*/
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            EnterGame(knight);
            EnterGame(mage);
        }
    }
}
