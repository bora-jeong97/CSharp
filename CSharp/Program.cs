using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{

    // 자료구조
    // 이차원 배열
    class Program
    {
        class Map
        {
            int[,] tiles =
            {
                { 1, 1, 1, 1, 1},
                { 1, 0, 0, 0, 1},
                { 1, 0, 0, 0, 1},
                { 1, 0, 0, 0, 1},
                { 1, 1, 1, 1, 1},

            };

            public void Render()
            {
                var defaultColor = Console.ForegroundColor;

                for (int i = 0; i < tiles.GetLength(1); i++)
                {
                    for (int j = 0; j < tiles.GetLength(0); j++)
                    {
                        if (tiles[i, j] == 1)
                            Console.ForegroundColor = ConsoleColor.Red; // 색 변경
                        else
                            Console.ForegroundColor = ConsoleColor.Green; // 색 변경

                        Console.Write('\u25cf');    // 타원형 
                    }
                    Console.WriteLine();
                }

                Console.ForegroundColor = defaultColor; // 마지막 색을 디폴트로 다시 바꿔주기 위함
            }
        }

        static void Main(string[] args)
        {
            Map map = new Map();
            map.Render();
        }
    }
}
