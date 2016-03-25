using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LengthConversion.Models;

namespace LengthConversion.ConversionHandlers
{
    public class MileConversionHandler : ConversionHandler
    {
        private const double KM_IN_MILES = 0.621371;
        public override double Convert(Kilometer kilometer)
        {
            if(kilometer.ConvertTo != Unit.Mile)
            {
                return _next.Convert(kilometer);
            }

            return kilometer.Value * KM_IN_MILES;
        }
    }
}
