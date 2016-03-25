using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LengthConversion.Models;

namespace LengthConversion.ConversionHandlers
{
    public abstract class ConversionHandler
    {
        protected ConversionHandler _next;

        public abstract double Convert(Kilometer kilometer);

        public void SetNext(ConversionHandler next)
        {
            _next = next;
        }
    }
}
