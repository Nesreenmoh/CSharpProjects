using System;
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
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age {
            get
            {
                return age;
            }
           private set
            {
                 age = value;
            }
            }

        public void CelebrateMyBirthday()
        {
            this.age += 1;
        }

        // to string method 
        public override string ToString()
        {
            
                return " "+name.ToUpper()+" is celebrating my birthday, and my age is " + age + " Years old";
            
        }
    }
}
