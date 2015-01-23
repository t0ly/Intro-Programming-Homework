// Problem 2. Gravitation on the Moon

//    The gravitational field of the Moon is approximately 17% of that on the Earth.
//    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

//Examples:
//weight 	weight on the Moon
//86 	14.62
//74.6 	12.682
//53.7 	9.129

using System;

class WeightOnMoon
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter weight in kilograms: ");

        double weightOnEarth = Convert.ToDouble(Console.ReadLine());
        
        //74.6;            //86 53.7
        
        double weightOnMoon = weightOnEarth * 0.17;

        Console.WriteLine("Weight on Moon = {0}", weightOnMoon);
    }
}
