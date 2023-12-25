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
