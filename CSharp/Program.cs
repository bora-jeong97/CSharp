using System;
using System.Collections.Generic;

namespace CSharp
{
    // 예외처리
    class Program
    {
        class TestException : Exception
        {

        }


        static void Main(string[] args)
        {

            try
            {
                // 예외상황
                // 1. 0으로 나눌 때
                // 2. 잘못된 메모리를 참조(null)
                // 3. 오버플로우
                throw new TestException();
            }
            catch (DivideByZeroException e)
            {

            }
            catch (Exception e)
            {

            }
            finally // 에러가 발생 됐음에도 무조건 실행해야할 때 ex) DB, 파일 정리 등
            {

            }
        }
    }
}
