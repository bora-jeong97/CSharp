using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{

    // 자료구조
    class Program
    {
        
        static int GetHighestScore(int[] scores)
        {
            int max = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (max < scores[i])
                    max = scores[i];
            }
            return max;
        }

        static int GetAverageScore(int[] scores)
        {
            if (scores.Length == 0)
                return 0;

            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }


            int re = sum / scores.Length;
            return re;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            int re = -1;
            for (int i = 0; i < scores.Length; i++)
            {
                if (value == scores[i])
                    re = i; 

            }

            return re;
        }

        static void Sort(int[] scores)
        {
            int tmp;
            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = 0; j < scores.Length-1; j++)
                {
                    if(scores[j] > scores[j + 1])
                    {
                        tmp = scores[j];
                        scores[j] = scores[j + 1];
                        scores[j + 1] = tmp;
                    }
                }
            }

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
            
        }

        static void Main(string[] args)
        {
            // 배열
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };
            
            Console.WriteLine(GetHighestScore(scores));
            Console.WriteLine(GetAverageScore(scores));
            Console.WriteLine(GetIndexOf(scores, 20));
            Sort(scores);

        }
    }
}
