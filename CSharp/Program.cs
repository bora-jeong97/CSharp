using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharp
{


    // Nullable (널러블) : Null이 가능한
    class Program
    {


        static int Find()
        {

            return 0;    
        }

        static void Main(string[] args)
        {
            int? number = null; //?를 추가하면 이제 null도 사용가능
            
            // 출력 방법 2
            int b = number ?? 0; // null이라면 0을 초기값으로 넣어준다.
            Console.WriteLine(b);
/*
            // 출력 방법 1
            // null체크1
            if(number != null)
            {
                int a = number.Value;
                Console.WriteLine(a);

            }
            // null체크2
            if (number.HasValue)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }*/


        }
    }
}
