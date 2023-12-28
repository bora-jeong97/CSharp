using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // 객체(OOP Object Oriented Programming) 지향 (은닉성/상속성/다형성)

    // Knight
    // 속성 : hp, attack, pos(좌표)
    // 기능 : Move, Attack, Die

    class Player    // 부모/기반 클래스
    {
        static public int counter = 1; // static 오로지 1개만 존재
        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출!");
        }

        public void Move()
        {
            Console.WriteLine("Player Move");
        }

        public void Attack()
        {
            Console.WriteLine("Player Attack");

        }

    }

    



    class Mage : Player // : Player 상속. 자식/파생 클래스
    {

    }

    class Archer : Player
    {

    }



    // class(Ref 참조) 
    class Knight : Player    // 객체묘사 class ex) 설계도, 붕어빵 틀
    {
        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }



        public Knight()  // 생성자 반환값 없음. class와 명이 같아야함. : base(100) 부모클래스 접근. base(100) == Player(100) 이 메소드가 호출되면 ()의 기본 생성자는 호출 안됨.
        {
            Console.WriteLine("Knight 생성자 호출");
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
            Knight knight = new Knight();  // static 함수 : 클래스에서 바로 접근가능

            knight.Move();

        }
    }
}
