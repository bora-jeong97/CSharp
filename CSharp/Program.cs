using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharp
{


    // Nullable (널러블) : Null이 가능한
    // 형식에 ? 를 붙인다.
    // ?? 를 사용해 초기값을 넣어줄 수 있다.
    class Program
    {


        static int Find()
        {

            return 0;    
        }

        class Monster
        {
            public int id { get; set; }
        }

        static void Main(string[] args)
        {
            Monster monster = null;

            int? id = monster?.id;  // monster값이 null이면 null null이 아니면 id값을 반환한다.


        }
    }
}
