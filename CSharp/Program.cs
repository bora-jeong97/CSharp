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
        // 필드
        static public int counter = 1; // static 오로지 1개만 존재

        public int id;
        public int hp;
        public int attack;

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }


        public Knight()    // 생성자 반환값 없음. class와 명이 같아야함
        {
            id = counter;
            counter++;

            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출");
        }

        public Knight(int hp) : this()  // this() = Knight(), 즉 상단의 Knight()를 먼저 호출 후 실행됨 
        {
            this.hp = hp;
            Console.WriteLine("int 생성자 호출");
        }

        public Knight(int hp, int attack)   
        {
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("int, int 생성자 호출");
        }

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
            Knight knight = Knight.CreateKnight();  // static 함수 : 클래스에서 바로 접근가능
            knight.Move();  // 일반 함수 : 객체를 만든뒤에 접근가능




        }
    }
}
