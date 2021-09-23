using System;

namespace _20210923_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, weight;

            height = Convert.ToInt32(Console.ReadLine());
            weight = Convert.ToInt32(Console.ReadLine());

            double h = height / 100;
            double ans = Math.Round(weight / (h*h),3);  //Math.Round(數值, 小數位數, MidpointRounding.AwayFromZero)
         
            Console.Write($"Height: {height} Weight: {weight} ,BMI is : {ans}");    

            Console.Read();
        }
    }
}
