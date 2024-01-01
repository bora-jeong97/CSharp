using System;
using System.Collections.Generic;

namespace CSharp
{

    // 추상 클래스
    class Program
    {

        abstract class Monster  // abstract 추상클래스 : 개념적으로만 존재 인스턴스를 만들 수 없음. 상속받는 자식클래스는 무조건 부모클래스의 함수를 구현해야함.
        {
            public abstract void Shout();
        }

        interface IFlyable
        {
            void Fly();

        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("록타르 오가르!");
            }
        }

        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {
            }
        }

        static void DoFly(IFlyable flayable)
        {
            flayable.Fly(); 
        }




        static void Main(string[] args) {

            IFlyable orc = new FlyableOrc();
            DoFly(orc); // IFlyable을 내포한 클래스만 매개변수로 사용가능
                       
        }
    }
}
