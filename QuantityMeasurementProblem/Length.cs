using System;

namespace QuantityMeasurementProblem
{
    public class Length
    {
        public enum Unit 
        { 
            Feet, 
            Inch, 
            Yard, 
            CentiMeter,
            FeetToInch, 
            YardToInch 
        }

        public Length() 
        {
        }

        public double ConvertTheValue(Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Unit.FeetToInch))
                {
                    return value * 12.0;
                }
                else if (unit.Equals(Unit.YardToInch))
                {
                    return value * 36.0;
                }
                return value;
            }
            catch (Exception e)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

    }
}
