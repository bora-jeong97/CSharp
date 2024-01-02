using System;
using System.Collections.Generic;

namespace CSharp
{

    // 이벤트 ( delegate를 래핑하는 문법 접근제한을 걸기위해)
    class Program
    {


        static void OnInputTest()
        {
            Console.WriteLine("Input Received");
        }

        static void Main(string[] args) {

            InputManager inputManager = new InputManager();

            inputManager.InputKey += OnInputTest;

            while (true)
            {
                inputManager.Update();
            }
        }
    }
}
