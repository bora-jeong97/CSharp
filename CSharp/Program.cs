using System;
using System.Collections.Generic;

namespace CSharp
{

    // 자료구조
    // 리스트(List) <- 동적 배열 
    class Program
    {

        // 배열과는 달리 만들때 크기가 고정되지 않는다.
        static void Main(string[] args)
        {
            // List <- 동적배열
            // class 형이기 때문에 참조형이다.
            List<int> list = new List<int>();

            // 뒤에 추가
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);    // 뒤에 추가
            }
    
            // 삽입
            list.Insert(2, 999); // 지정 인덱스에 요소를 삽입
            
            // 삭제
            list.RemoveAt(0); // 인덱스로 삭제


            list.Remove(3); // 값으로 삭제

            // 전체 삭제
            list.Clear();

            // 출력
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
