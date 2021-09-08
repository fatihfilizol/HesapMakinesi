using Entities.Concrete;
using Proje.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Business.Concrete
{
    public class MathService : IMathService
    {
        public double Addition(Numbers numbers)
        {
            numbers.Total = numbers.Number1 + numbers.Number2;
            Console.WriteLine(numbers.Total);
            return numbers.Total;
        }

        public double Division(Numbers numbers)
        {
            numbers.Division = numbers.Number1 / numbers.Number2;
            Console.WriteLine(numbers.Division);
            return numbers.Division;
        }

        public double ExtractionProcess(Numbers numbers)
        {
            numbers.Extraction = numbers.Number1 - numbers.Number2;
            Console.WriteLine(numbers.Extraction);
            return numbers.Extraction;
        }

        public double Multiplication(Numbers numbers)
        {
            numbers.Multiplication = numbers.Number1 * numbers.Number2;
            Console.WriteLine(numbers.Multiplication);
            return numbers.Multiplication;
        }
    }
}
