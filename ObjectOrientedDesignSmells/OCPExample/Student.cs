using System;

namespace ObjectOrientedDesignSmells.OCPExample
{
    class Student
    {
        public string Name { get; set; }
        public StudentType Type { get; set; }

        public Student(string Name, StudentType Type)
        {
            this.Name = Name;
            this.Type = Type;
        }

        public void SaySomething()
        {
            switch (Type)
            {
                case StudentType.Undergraduate:
                    Console.WriteLine(Name + " says Party!");
                    break;
                case StudentType.MasterStudent:
                    Console.WriteLine(Name + " says Thesis!!!");
                    break;
                case StudentType.PhDStudent:
                    Console.WriteLine(Name + " says Hard Research!");
                    break;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} : {1}", Type.ToString(), Name);
        }
    }
}
