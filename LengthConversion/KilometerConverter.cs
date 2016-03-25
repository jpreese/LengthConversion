using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LengthConversion.Models;
using LengthConversion.ConversionHandlers;

namespace LengthConversion
{
    public class KilometerConverter
    {
        public double Convert(Kilometer kilometer)
        {
            return GetChain().Convert(kilometer);
        }

        private ConversionHandler GetChain()
        {
            var mileHandler = new MileConversionHandler();
            var yardHandler = new YardConversionHandler();
            var footHandler = new FootConversionHandler();

            mileHandler.SetNext(yardHandler);
            yardHandler.SetNext(footHandler);

            return mileHandler;
        }
    }
}
