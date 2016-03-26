using LengthConversion.Models;
using LengthConversion.ConversionHandlers;

namespace LengthConversion
{
    public class KilometerConverter
    {
        public Result Convert(Kilometer kilometer)
        {
            var startOfChain = GetChain();
            var result = startOfChain.Convert(kilometer);

            return new ResultDecorator(result, kilometer.ConvertTo).Decorate();
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
