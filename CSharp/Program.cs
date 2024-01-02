﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharp
{


    // 리플렉션 Reflection : X-Ray 
    class Program
    {
        class Monster
        {
            public int hp;
            protected int attack;
            private float speed;

            void Attack() { }
        }

        static void Main(string[] args)
        {
            
            Monster monster = new Monster();
            Type type = monster.GetType();

            var fields = type.GetFields(System.Reflection.BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance
                );

            foreach (FieldInfo field in fields)
            {
                string access = "protected";
                if (field.IsPublic)
                    access = "public";
                else if (field.IsPrivate)
                    access = "private";

                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
            }

        }
    }
}
