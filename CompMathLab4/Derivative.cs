using CompMathLab3;
using System;

namespace Testing
{
    public class Derivative
    {
        /// <summary>
        /// Первая производная для функции y=x^2
        /// </summary>
        /// <param name="x"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public double CalculateFirstDerivative(double x, double step) =>
                 2*(Math.Pow(x + step, 2) - Math.Pow(x, 2)) / step;

        /// <summary>
        /// Первая производная для функций сплайнов
        /// </summary>
        /// <param name="x"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public double CalculateFirstDerivativeTwoSteps(double yPlusStep, double yMinusStep, double step) =>
            (yPlusStep - yMinusStep) / (2*step);

        /// <summary>
        /// Вторая производная для функций сплайнов
        /// </summary>
        /// <param name="x"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public double CalculateSecondDerivative(double yPlusTwoSteps, double yMinusTwoSteps, double y, double step) =>
            (yPlusTwoSteps-2*y+yMinusTwoSteps) / (4 * step * step);

        
    }
}
