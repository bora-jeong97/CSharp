using System;
using System.Collections.Generic;

namespace CSharp
{

    class Monster
    {
        public int id;

        public Monster(int id)
        {
            this.id = id;
        }
    }


    // 자료구조
    // 사전 Dictionary
    class Program
    {

        static void Main(string[] args) {


            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            for (int i = 0; i < 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }

            // 찾기
            // 방법 2
            Monster mon;
            bool found = dic.TryGetValue(5000, out mon);

            // 방법 1
            //Monster mon = dic[5000];    // 직접 명시적으로 가져오는 경우 값이 없으면 에러가 나기 때문에 위 방법을 선호

            // 삭제
            dic.Remove(7777);

            // 전체삭제
            dic.Clear();


        }
    }
}
