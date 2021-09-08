using Entities.Concrete;
using Proje.Business.Concrete;
using System;


namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            numbers.Number1 = Convert.ToDouble(Console.ReadLine());
            numbers.Number2 = Convert.ToDouble(Console.ReadLine());
            MathService mathService = new MathService();
            mathService.Division(numbers);
        }
    }
}
