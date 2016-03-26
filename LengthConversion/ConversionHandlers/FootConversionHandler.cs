using LengthConversion.Models;

namespace LengthConversion.ConversionHandlers
{
    public class FootConversionHandler : ConversionHandler
    {
        private const double KM_IN_FEET = 3280.84;

        public override Result Convert(Kilometer kilometer)
        {
            return new Result
            {
                Value = kilometer.Value * KM_IN_FEET
            };
        }
    }
}
