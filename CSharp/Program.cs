using System;
using System.Collections.Generic;

namespace CSharp
{


    class Program
    {

        static void Main(string[] args) {

            // 어떤 형식이든 호환되게 하는 형식
            // 1. object : 참조타입, 형식이 object이다.
            // 2. var   : 담겨있는 값을 보고 형식을 그 형식으로 바꿔준다. (var = 3) == (int = 3)

            var obj3 = 3;
            var obj4 = "hello";

            object obj = 3;
            object obj2 = "hello";

            int num = (int)obj;
            string str = (string)obj;


        }
    }
}
