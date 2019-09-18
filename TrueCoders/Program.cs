using System;
using System.Collections.Generic;

namespace TrueCoders
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newTeacher = new Teacher("Michael Doyle", 32, Color.Black(), 2, false);
            Person newTeacher2 = new Teacher("Will Jones", 1, true);
            Person newStudent = new Student("John Clarke", 200);
            Person newStudent2 = new Student("James Tisdale", 79);
            Person newStudent3 = new Student("Ben Gazzini", 278);

            Queue<Person> personQueue = new Queue<Person>();
            personQueue.Enqueue(newTeacher);
            personQueue.Enqueue(newTeacher2);
            personQueue.Enqueue(newStudent);
            personQueue.Enqueue(newStudent2);
            personQueue.Enqueue(newStudent3);

            while (personQueue.Count > 0)
            {
                System.Console.WriteLine(personQueue.Dequeue().ToString());
            }
        }
    }
}
