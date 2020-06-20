using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProblem
{
    public class Temperature
    {
        public enum Unit
        {
            Fahrenheit,
            FahrenheitToCelsius,
            Celsius
        }

        public double ConvertValueToCelsius(Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Unit.FahrenheitToCelsius))
                {
                    return value * (100/212);
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
