using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
 
    class Player
    {

        static void Main(string[] args)
        {
            string name = "Harry Potter";
            
            
            // 1. 찾기
            bool find = name.Contains("Harry"); // True
            int index = name.IndexOf('o');  // 7

            // 2. 변형
            name = name + "Junior"; // Harry PotterJunior
            string lowerCaseNmae = name.ToLower();  // harry potterjunior
            string upperCaseNmae = name.ToUpper();  // HARRY POTTERJUNIOR
            string replaceName = name.Replace('t', 'k');    // Harry PokkerJunior


            // 3. 분할
            string[] names = name.Split(new char[] { ' ' });
            string substringNmae = name.Substring(4);   // y PotterJunior

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
/*
            Console.WriteLine(find);
            Console.WriteLine(index);
            Console.WriteLine(name);
            Console.WriteLine(lowerCaseNmae);
            Console.WriteLine(upperCaseNmae);
            Console.WriteLine(replaceName);
            Console.WriteLine(names);
            Console.WriteLine(substringNmae);*/
            

        }
    }
}
