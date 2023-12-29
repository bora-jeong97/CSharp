using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // 객체(OOP Object Oriented Programming) 지향 (은닉성/상속성/다형성 polymorphism)
    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }

    }

    /*
     * 다형성(Polymorphism) :다형성은 한 가지 인터페이스나 기능을 여러 형태로 구현할 수 있는 특성
     * 오버로딩 : 함수 이름의 재사용. 매개변수의 타입, 개수, 순서 등을 다르게 하여 여러 개 정의할 수 있는 기능
     * 오버라이딩 : 부모 클래스에서 이미 정의된 메서드를 자식 클래스에서 같은 이름으로 다시 정의하여 사용하는 것
     */

    class Knight : Player
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Knight 이동!");
        }

    }

    class Mage : Player
    {
        public int mp;
        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }


    class Program 
    {
        static void EnterGame(Player player)
        {

            player.Move();

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
