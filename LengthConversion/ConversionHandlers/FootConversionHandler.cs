using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LengthConversion.Models;

namespace LengthConversion.ConversionHandlers
{
    public class FootConversionHandler : ConversionHandler
    {
        private const double KM_IN_FEET = 3280.84;

        public override double Convert(Kilometer kilometer)
        {
            return kilometer.Value * KM_IN_FEET;
        }
    }
}
