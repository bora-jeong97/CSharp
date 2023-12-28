using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // 객체(OOP Object Oriented Programming) 지향

    // Knight
    // 속성 : hp, attack, pos(좌표)
    // 기능 : Move, Attack, Die


    // class(Ref 참조) 
    class Knight    // 객체묘사 class ex) 설계도, 붕어빵 틀
    {
        public int hp;
        public int attack;

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }

        public void Move()
        {
            Console.WriteLine("Knight Moce");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");

        }
    }

    // struct(복사)
    struct Mage
    {
        public int hp;
        public int attack;
    }

    class Program
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }

        static void Main(string[] args)
        {

            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            KillMage(mage);

            Mage mage2 = mage;
            mage2.hp = 0;

            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;
            
            
            Knight knight2 = knight.Clone();    // 기존 값과 분리된 클론 객체
            knight2.hp = 0;



        }
    }
}
