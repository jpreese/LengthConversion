using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LengthConversion.Models;

namespace LengthConversion.ConversionHandlers
{
    public class YardConversionHandler : ConversionHandler
    {
        private const double KM_IN_YARDS = 1093.61;

        public override double Convert(Kilometer kilometer)
        {
            if(kilometer.ConvertTo != Unit.Yard)
            {
                return _next.Convert(kilometer);
            }

            return kilometer.Value * KM_IN_YARDS;
        }
    }
}
