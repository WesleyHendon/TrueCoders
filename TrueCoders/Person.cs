using System;
namespace TrueCoders
{
    public abstract class Person
    {
        public string firstName;
        public string lastName;
        public int? age;
        public Color hairColor;

        public Person (string fullName)
        {
            string[] name = fullName.Split(" ");
            firstName = name[0];
            lastName = name[1];
            age = null;
            hairColor = null;
        }

        public Person(string fullName, int? age_)
        {
            string[] name = fullName.Split(" ");
            firstName = name[0];
            lastName = name[1];
            age = age_;
            hairColor = null;
        }

        public Person(string fullName, int? age_, Color hairColor_)
        {
            string[] name = fullName.Split(" ");
            firstName = name[0];
            lastName = name[1];
            age = age_;
            hairColor = hairColor_;
        }

        public Person(string firstName_, string lastName_, int? age_, Color hairColor_)
        {
            firstName = firstName_;
            lastName = lastName_;
            age = age_;
            hairColor = hairColor_;
        }

        public override abstract string ToString();
    }

    public class Color
    {
        private double r; // 0-1
        private double g; // 0-1
        private double b; // 0-1
        private double a; // 0-1

        public Color(double r_, double g_, double b_)
        {
            r = r_ > 1 ? TrueCodersOperations.MapValue(r_, 0, 255, 0, 1) : r_;
            g = g_ > 1 ? TrueCodersOperations.MapValue(g_, 0, 255, 0, 1) : g_;
            b = b_ > 1 ? TrueCodersOperations.MapValue(b_, 0, 255, 0, 1) : b_;
            a = 1;
        }

        public Color(double r_, double g_, double b_, double a_)
        {
            r = r_ > 1 ? TrueCodersOperations.MapValue(r_, 0, 255, 0, 1) : r_;
            g = g_ > 1 ? TrueCodersOperations.MapValue(g_, 0, 255, 0, 1) : g_;
            b = b_ > 1 ? TrueCodersOperations.MapValue(b_, 0, 255, 0, 1) : b_;
            a = a_ > 1 ? TrueCodersOperations.MapValue(a_, 0, 255, 0, 1) : a_;
        }

        public static Color Red()
        {
            return new Color(255, 0, 0);
        }

        public static Color Green()
        {
            return new Color(0, 255, 0);
        }

        public static Color Blue()
        {
            return new Color(0, 0, 255);
        }

        public static Color Black()
        {
            return new Color(0, 0, 0);
        }

        public static Color Brown()
        {
            return new Color(165, 42, 42);
        }

        public static Color Blonde()
        {
            return new Color(250, 240, 190);
        }

        public override string ToString()
        {
            return $"RGB: {r},{g},{b}";
        }
    }

    public static class TrueCodersOperations
    {
        public static double MapValue(double valueToMap, double oldMin, double oldMax, double newMin, double newMax)
        {
            return ((valueToMap - oldMin) * ((newMax - newMin) / (oldMax - oldMin))) + newMin;
        }
    }
}
