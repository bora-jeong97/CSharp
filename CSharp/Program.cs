using System;
using System.Collections.Generic;

namespace CSharp
{

   
    class Program
    {
        class Knight
        {

            // 프로퍼티
            // 방법 1
            /*            private int hp;
                        public int Hp
                        {
                            get { return hp; }
                            private set { hp = value; }
                        }*/

            // 방법 2 사용성과 은닉성을 챙길 수 있는 1석 2조의 방법
            public int Hp
            {
                get; set;
            } = 100; // 요런식으로 초기화 값도 넣을 수 있다. 안넣어도 됨

            // 해당 아래 코드가 위 코드에 내포된 값임.
            private int _hp;
            public int GetHP() { return _hp; }
            public void SetHp(int value) { _hp = value; }

        }

        static void Main(string[] args) {
            Knight knight = new Knight();
            
            int hp = knight.Hp; // set
            knight.Hp = 100;    // get

        }
    }
}
