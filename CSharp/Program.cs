using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // 객체(OOP Object Oriented Programming) 지향 (은닉성/상속성/다형성)


    class Knight
    {
        // 접근 한정자
        // public protected private
        protected int hp;   // 상속된 calss에서 사용가능

    }

    class SuperKnight : Knight
    {
        void Test()
        {
            hp = 100;
        }
    }


    class Program : Knight
    {

        static void Main(string[] args)
        {
            Knight knight = new Knight();
        }
    }
}
