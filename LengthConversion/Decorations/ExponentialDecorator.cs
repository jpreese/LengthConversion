using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LengthConversion.Models;

namespace LengthConversion.Decorations
{
    class ExponentialDecorator : Decorator
    {
        public ExponentialDecorator(IResult result) : base(result) { }
    }
}
