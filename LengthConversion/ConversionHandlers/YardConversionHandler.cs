using LengthConversion.Models;

namespace LengthConversion.ConversionHandlers
{
    public class YardConversionHandler : ConversionHandler
    {
        private const double KM_IN_YARDS = 1093.61;

        public override IResult Convert(Kilometer kilometer)
        {
            if (kilometer.ConvertTo != Unit.Yard)
            {
                return _next.Convert(kilometer);
            }

            return new Result
            {
                Value = kilometer.Value * KM_IN_YARDS
            };
        }
    }
}
