using System.Linq;

namespace CompMathLab3
{
    public class NewtonForm
    {
        public double FindDividedDifference(double[] xValues, double[] functionValues)
        {
            if (xValues.Length > 2)
            {
                
                double[] xFirstArray = new double[xValues.Length - 1];
                double[] xSecondArray = new double[xValues.Length - 1];
                double[] yFirstArray = new double[xValues.Length - 1];
                double[] ySecondArray = new double[xValues.Length - 1];
                for (int i = 0; i < xValues.Length - 1; i++)
                {
                    xFirstArray[i] = xValues[i];
                    yFirstArray[i] = functionValues[i];
                }

                for (int i = 1; i < xValues.Length; i++)
                {
                    xSecondArray[i - 1] = xValues[i];
                    ySecondArray[i - 1] = functionValues[i];
                }
                double ans = (FindDividedDifference(xFirstArray, yFirstArray) -
                             FindDividedDifference(xSecondArray, ySecondArray)) /
                            (xValues[0] - xValues.Last());
                return ans;
            }

            double ans1 = (functionValues[0] - functionValues[1]) / (xValues[0] - xValues[1]);  
            return ans1;
        }

        public double MainFunction(double x, double[] xValues, double[] functionValues)
        {
            double answer = functionValues[0];
            double mult = 1;

            for (int i = 1; i < xValues.Length; i++)
            {
                mult *= x - xValues[i - 1];
                double[] newArrX = new double[i + 1];
                double[] newArrY = new double[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    newArrX[j] = xValues[j];
                    newArrY[j] = functionValues[j];
                }

                answer += mult * FindDividedDifference(newArrX, newArrY);
            }

            return answer;
        }
    }
}