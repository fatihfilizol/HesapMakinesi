using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Business.Abstract
{
    public interface IMathService
    {
        double Addition(Numbers numbers);
        double ExtractionProcess(Numbers numbers);
        double Division(Numbers numbers);
        double Multiplication(Numbers numbers);
    }
}
