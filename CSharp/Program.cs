using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        // --------------------------------------------------------------
        // 연습문제 3 팩토리얼 함수 구현
        static int Factorial(int n)
        {
            // 방법 2 재귀함수
            if (n <= 1)
                return 1;
            return n * Factorial(n - 1);

/*
            // 방법 1
            int ret = 1;

            for (int num = 1; num <= n; num++)
            {
                ret *= num;
            }
            return ret;
*/

        }


        // --------------------------------------------------------------
        // 오버로딩(함수 이름의 재사용)
        /*        static int Add(int a, int b)
                {

                    return a + b;
                }
                static int Add(int a, int b, int c)
                {

                    return a + b + c;
                } 

        static float Add(float a, float b)
        {

            return a + b;
        }

        static int Add(int a, int b, int c = 0, float d = 1.0f, double e = 3.0) //매개변수를 안넣을 경우의 기본값을 지정해 줄 수 있다.
        {
            
            return a + b + c + (int)d + (int)e;
        }
        */
        // --------------------------------------------------------------
        // ref(복사가 아닌 진짜 참조), out(값이 필수로 들어가야함)
        /*        static void Divide(int a, int b, out int result1, out int result2)
                {
                    result1 = a / b;
                    result2 = a % b;
                }
        */

        // --------------------------------------------------------------
        // 함수
        /*        static void AddOne(ref int number)
                {
                    number++;
                }
                static int AddOne2(int number)
                {
                    return number + 1;
                }*/
        /*        static int Add(int a, int b)
                {
                    return a + b;
                }*/

        // --------------------------------------------------------------
        // 가위바위보 게임
        // 하드코딩을 줄이는 방법 2 열거형 
        /*        enum Choice
                {
                    Rock = 1,
                    Paper = 2,
                    Scissors = 0
                }*/


        static void Main(string[] args)
        {
            // --------------------------------------------------------------
            // 연습문제 3 팩토리얼 함수 구현
            // 5! = 5 * (4!)
            // 5! = 5 * 4 * 3 * 2 * 1
            // n! = n * (n-1) * ... * 1 (n >= 1)
            int ret = Factorial(5);
            Console.WriteLine(ret);
            // --------------------------------------------------------------
            // 연습문제 2 별찍기

            /*            for (int i = 1; i <= 5; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }*/

            // --------------------------------------------------------------
            // 연습문제 1 구구단
            /*            for (int i = 2; i <= 9; i++)
                        {
                            for (int j = 1; j <= 9; j++)
                            {
                                Console.WriteLine($"{i} X {j} = {i * j}");
                            }
                        }*/



            // --------------------------------------------------------------
            // 오버로딩(함수 이름의 재사용)

            /*            int result = Add(1, 2, 3);
                        Console.WriteLine(result);*/

            // --------------------------------------------------------------
            // ref, out
            /*            int num1 = 10;
                        int num2 = 3;
                        int result1;
                        int result2;

                        Divide(num1, num2, out result1, out result2);
                        Console.WriteLine(result1);
                        Console.WriteLine(result2);


                        int a = 0;
                        AddOne(ref a);  // 참조(진퉁)
                        Console.WriteLine(a);
                        a = AddOne2(a); // 복사(짭퉁)  
                        Console.WriteLine(a);*/

            // --------------------------------------------------------------
            // 함수



            /*            int result = Program.Add(3, 5);
                        Console.WriteLine(result);*/


            // --------------------------------------------------------------
            // break, continue
            // 소수파악
            /*
                        for (int i = 1; i <= 100; i++)
                        {
                            if ((i % 3) != 0)
                                continue;
                            Console.WriteLine($"3으로 나뉘는 숫자 : {i}");
                        }

                        int num = 10002;

                        bool isPrime = true;

                        for (int i = 2; i < num; i++)
                        {
                            if((num % i) == 0)
                            {
                                isPrime = false;

                                break;
                            }
                        }

                        if(isPrime)
                            Console.WriteLine("소수입니다");
                        else
                            Console.WriteLine("소수가 아닙니다");*/

            // --------------------------------------------------------------
            // for 반복문
            /*            for (int i = 0; i <1; i++) {
                            Console.WriteLine(i);
                        }*/


            // --------------------------------------------------------------
            // while 반복문
            /*            int count = 5;

                        while(count > 0)
                        {
                            Console.WriteLine(count);
                            count--;
                        }
                        string answer;
                        do
                        {
                            Console.WriteLine("강사님은 잘 생기셨나요? (y/n) :");
                            answer = Console.ReadLine();
                        } while (answer != "y");

                        Console.WriteLine("정답입니다");*/


            // --------------------------------------------------------------
            // 가위바위보 게임 
            // 하드코딩을 줄이는 방법 1 상수화(const) 
            /*            const int ROCK = 1; 
                        const int PAPER = 2;
                        const int SCISSORS = 0;*/

            /*            Random rand = new Random();
                        int aiChoice = rand.Next(0, 3); // ~ 2 사이의 랜덤 값
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case (int)Choice.Scissors:
                                Console.WriteLine("당신의 선택은 가위입니다.");
                                break;
                            case (int)Choice.Rock:
                                Console.WriteLine("당신의 선택은 바위입니다.");
                                break;
                            case (int)Choice.Paper:
                                Console.WriteLine("당신의 선택은 보입니다.");
                                break;
                        }

                        switch (aiChoice)
                        {
                            case (int)Choice.Scissors:
                                Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                                break;
                            case (int)Choice.Rock:
                                Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                                break;
                            case (int)Choice.Paper:
                                Console.WriteLine("컴퓨터의 선택은 보입니다.");
                                break;
                        }


                        if(choice == aiChoice)
                        {
                            Console.WriteLine("무승부입니다.");
                        }
                        else if(choice == (int)Choice.Scissors && aiChoice == (int)Choice.Paper)
                        {
                            Console.WriteLine("승리입니다.");
                        }
                        else if (choice == (int)Choice.Rock && aiChoice == (int)Choice.Scissors)
                        {
                            Console.WriteLine("승리입니다.");
                        }
                        else if (choice == (int)Choice.Paper && aiChoice == (int)Choice.Rock)
                        {
                            Console.WriteLine("승리입니다.");
                        } else
                        {
                            Console.WriteLine("패배입니다.");
                        }*/


            // --------------------------------------------------------------
            /*            // 삼항연산자
                        int number = 24;
                        bool isPair = ((number % 2) == 0 ? true : false);
                        Console.WriteLine(isPair);

                        // switch
                        int choice = 0;

                        switch (choice)
                        {
                            case 0:
                                Console.WriteLine("가위입니다.");
                                break;
                            case 1:
                                Console.WriteLine("바위입니다.");
                                break;
                            case 2:
                                Console.WriteLine("보입니다.");
                                break;
                            default:
                                Console.WriteLine("치트키입니다.");
                                break;
                        }*/



            // --------------------------------------------------------------
            // if와 else
            /*            int choice = 5; // 0:가위 1:바위 2:보

                        if (choice == 0)
                            Console.WriteLine("가위입니다.");
                        else if (choice == 1)
                            Console.WriteLine("바위입니다.");
                        else if (choice == 2)
                            Console.WriteLine("보입니다.");
                        else
                            Console.WriteLine("치트키입니다.");*/


            // --------------------------------------------------------------
            // 논리 연산
            /*            bool isTall = true;
                        bool isSmart = false;

                        // AND OR NOT 
                        // &&  ||  !

                        // 키가 크면서 AND 똑똑하다
                        bool result = (isTall && isSmart);*/



            // --------------------------------------------------------------
            // 비교 연산
            /*            int hp = 100;
                        int maxHp = 100;
                        bool fullHp = (hp == maxHp);
                        Console.WriteLine(fullHp);

                        bool isAlive = (hp > 0); // 살아있는지 여부
                        Console.WriteLine(isAlive);

                        int level = 10;
                        bool canEnterDungeon = (level <= 5); // 레벨 제한
                        Console.WriteLine(canEnterDungeon);*/


            // --------------------------------------------------------------
            // 스트링 포멧
            /*            string input;
                        input = Console.ReadLine();
                        int number = int.Parse(input);
                        Console.WriteLine(number);

                        int hp = 100;
                        int maxHp = 200;
                        string message = $"당신의 HP는 {hp} / {maxHp}입니다.";
                        Console.WriteLine(message);*/

        }
    }
}
