namespace FractionSums
{
    using System;

    class Sum
    {
        static void Main()
        {
            Console.WriteLine("Add firstNominator:");
            long firstNominator = long.Parse(Console.ReadLine());
            Console.WriteLine("Add firstDenominator:");
            long firstDenominator = long.Parse(Console.ReadLine());

            Console.WriteLine("Add secondDenominator:");            
            long secondNominator = long.Parse(Console.ReadLine());
            Console.WriteLine("Add secondDenominator:");
            long secondDenominator = long.Parse(Console.ReadLine());

            long resultNominator = firstNominator * secondDenominator + secondNominator * firstDenominator;
            long resultDenominator = firstDenominator * secondDenominator;


            decimal result = ((decimal)resultNominator / resultDenominator);

            if (result >= 1)
            {
                
                Console.WriteLine("Console.WriteLine((long)result);");
                Console.WriteLine((long)result);
            }
            else
            {
                Console.WriteLine("Console.WriteLine(\"{0:F20}\", result);");
                Console.WriteLine("{0:F20}", result);
            }

            Console.WriteLine("Console.WriteLine(resultNominator + \"/\" + resultDenominator);");
            Console.WriteLine(resultNominator + "/" + resultDenominator);
          
        }
    }
}
