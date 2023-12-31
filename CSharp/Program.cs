using System;
using System.Collections.Generic;

namespace CSharp
{


    class Program
    {
        // 클래스의 일반화
        // 일반화 형식 : 어떤 형식을 넣어도 사용 가능
        class MyList<T> // 제네릭/일반화 클래스
        {

            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }

        class Monster{}

        // 함수의 일반화
        static void Test<T>(T input)
        {

        }

        // 함수 인자가 여러개 일 떄
        static void Test2<T, K>(T input, K input2)
        {

        }

        // 조건을 주는 경우
        static void Test3<T, K>(T input) where T : struct // where T : struct(값형식), class(참조형식), new(어떠한 인자도 받지않는 기본생성자), Monster(몬스터 혹은 몬스터를 상속받는 것)
        {

        }

        static void Main(string[] args) {

            MyList<int> myIntList = new MyList<int>();
            int item = myIntList.GetItem(0);
            MyList<short> mySortList = new MyList<short>();
            MyList<Monster> myMonsterLList = new MyList<Monster>();

            Test<int>(3);
            Test<float>(3.0f);

            Test2<int, string>(1, "아무거나 넣어도 된다.");
        }
    }
}
