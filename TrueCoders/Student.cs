using System;
namespace TrueCoders
{
    public class Student : Person
    {
        public int? codeWarsScore;

        public Student(string fullName) : base (fullName)
        {
            codeWarsScore = null;
        }

        public Student(string fullName, int? codeWarsScore_) : base (fullName)
        {
            codeWarsScore = codeWarsScore_;
        }

        public Student(string fullName, int? age, Color hairColor, int? codeWarsScore_) : base(fullName, age, hairColor)
        {
            codeWarsScore = codeWarsScore_;
        }

        public override string ToString()
        {
            return $"Name: {firstName} {lastName}\n" +
                "Age: " + (age == null ? "Unknown\n" : age + "\n") +
                "Hair Color: " + (hairColor == null ? "Unkown" : hairColor.ToString()) + "\n" +
                "Student's codewars score: " + (codeWarsScore == null ? "Unknown" : codeWarsScore.ToString()) + "\n";
        }
    }
}
