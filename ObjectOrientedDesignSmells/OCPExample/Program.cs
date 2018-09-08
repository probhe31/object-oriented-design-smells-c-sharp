using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignSmells.OCPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<IStudent> students = new LinkedList<IStudent>();

            students.Add(new Undergraduate("Juanito Pérez"));
            students.Add(new Undergraduate("Juanita Pérez"));
            students.Add(new MaterStudent("Juan Pablo"));
            students.Add(new MaterStudent("Marco"));
            students.Add(new MaterStudent("Luz"));
            students.Add(new PhDStudent("Juan Pérez"));
            students.Add(new PhDStudent("Juana Pérez"));
            
            foreach (IStudent student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("");

            foreach (IStudent student in students)
            {
                student.SaySomething();
            }

            Console.ReadLine();
        }
    }
}
