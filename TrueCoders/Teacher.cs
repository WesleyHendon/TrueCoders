using System;
namespace TrueCoders
{
    public class Teacher : Person
    {
        public int? teachingExperience;
        public bool TA;

        public Teacher(string fullName) : base(fullName)
        {
            teachingExperience = null;
            TA = false;
        }

        public Teacher(string fullName, int teachingExperience_, bool TA_) : base(fullName)
        {
            teachingExperience = teachingExperience_;
            TA = TA_;
        }

        public Teacher(string fullName, int? age, Color hairColor, int teachingExperience_, bool TA_) : base(fullName, age, hairColor)
        {
            teachingExperience = teachingExperience_;
            TA = TA_;
        }

        public override string ToString()
        {
            return $"Name: {firstName} {lastName}\n" +
                "Age: " + (age == null ? "Unknown\n" : age + "\n") +
                "Hair Color: " + (hairColor == null ? "Unkown" : hairColor.ToString()) + "\n" +
                (TA ? "Teaching Assistant\n" : "Teachers teaching experience: " + teachingExperience + "\n")
                ;
        }
    }
}
