using System;
using System.Collections.Generic;

namespace CSharp
{

    // delegate (대리자)
    class Program
    {

        // 업체 사장 ~ 사장님의 비서
        // 우리의 연락처/용건 ->
        // 거꾸로 연락을 달라고 함.


        delegate int OnClicked(); // 이것은 함수가 아닌 형식
        // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 그런 형식
        // 반환 int 입력 void
        // OnClicked가 delegate 형식의 이름이다.

        // UI
        static void ButtonPressed(OnClicked clickedFunction) // 함수 자체를 인자로 넘겨주고 함수를 호출
        {
            clickedFunction();
        }


        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }

        static int TestDelegate2()
        {
            Console.WriteLine("Hello Delegate2");
            return 0;
        }

        static void Main(string[] args) {

            OnClicked clicked = new OnClicked(TestDelegate);
            clicked += TestDelegate2;

            ButtonPressed(clicked);
        }
    }
}
