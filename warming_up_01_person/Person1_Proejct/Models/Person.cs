﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Person1_Proejct.Models
{
   public class Person
    {
        // fields
        private string name;
        private int age;

        // constructor 
        public Person(string name, int age )
        {
            this.name = name;
            this.age = age;
        }

        // setter and getter
        public string Name { get;  set; }
        public int Age { get; set; }

        public void CelebrateMyBirthday()
        {
            this.age += 1;
        }

        // to string method 
        public override string ToString()
        {
            
                return "I am celebrating my birthday, and my age is " + age + " Years old";
            
        }
    }
}