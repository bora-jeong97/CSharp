using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Ovsercer Pattern : 구독자를 모집후 특정 이벤트 발생시 구독자들에게 메세지 발송
namespace CSharp
{
    class InputManager
    {
        public delegate void OnInputKey(); // dalegate : 함수자체를 인자로 넘기고 싶을 때 유용
        public event OnInputKey InputKey; // event는 delegate의 외부 접근을 막기 위해 delegate를 한번더 래핑한 것 

        public void Update()
        {
            if (Console.KeyAvailable == false)  // 키 입력
                return;

            ConsoleKeyInfo info = Console.ReadKey();
            if(info.Key == ConsoleKey.A)
            {
                // A입력 사실을 모두한테 알린다.
                InputKey();
            }
        }
    }
}
