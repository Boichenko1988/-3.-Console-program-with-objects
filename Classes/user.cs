using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Console_program_with_objects.Classes
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender ChoiseGend { get; set; }

        public readonly int Age;
        public User()
        {
        }

        public User(int age)
        {
            Age = age;
        }


        public override string ToString()
        {
            if (Age <= 10)
            {
                return $"Hi, my name is {FirstName} and last name {LastName}. I am a baby. I am {ChoiseGend}";
            }
            else
            {
                return $"Hi, my name is {FirstName} and last name {LastName}. I am {Age} years old. I am {ChoiseGend}";
            }
        }

    }
}
