using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CompMathLab3
{
    internal class CubeSpline
    {

        private double[,] _numbers;
        private double[,] _splineSystem;
        private Matrix _matrix;
        private TridiagonalMatrixAlgorithm _t;

        public double[,] SplineSystem { get => _splineSystem; }

        public CubeSpline(double[,] numbers)
        {
            _numbers = numbers;
            GetSplineSystem();
        }


        private void GetCoefA(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = _numbers[1, i];

        }
        private void GetCoefC(out double[] c)
        {
            int rowIndex = 0;
            double[,] matrixC = new double[_numbers.GetLength(1) - 1, _numbers.GetLength(1)];
            matrixC[rowIndex, 0] = 1;
            rowIndex++;

            for (int i = 1; i < _numbers.GetLength(1) - 1; i++)
            {
                matrixC[rowIndex, i - 1] = _numbers[0, i] - _numbers[0, i - 1];
                matrixC[rowIndex, i] = 2 * (_numbers[0, i] - _numbers[0, i - 1] + _numbers[0, i + 1] - _numbers[0, i]);

                if (i + 1 != _numbers.GetLength(1))
                    matrixC[rowIndex, i + 1] = _numbers[0, i + 1] - _numbers[0, i];


                matrixC[rowIndex, matrixC.GetLength(1) - 1] = 3 * ((_numbers[1, i + 1] - _numbers[1, i]) / (_numbers[0, i + 1] - _numbers[0, i]) -
                    (_numbers[1, i] - _numbers[1, i - 1]) / (_numbers[0, i] - _numbers[0, i - 1]));
                rowIndex++;
            }
            _matrix = new Matrix(matrixC);
            _t = new TridiagonalMatrixAlgorithm(_matrix);
            c = _t.Answers;
        }

        private void GetCoefD(double[] d, double[] c)
        {
            for (int i = 0; i < _numbers.GetLength(1) - 1; i++)
            {
                if (i + 1 == _numbers.GetLength(1) - 1)
                {
                    d[i] = (0 - c[i]) / (3 * (_numbers[0, i + 1] - _numbers[0, i]));
                    continue;
                }
                d[i] = (c[i + 1] - c[i]) / (3 * (_numbers[0, i + 1] - _numbers[0, i]));
            }
        }
        private void GetCoefB(double[] b, double[] c)
        {
            for (int i = 0; i < _numbers.GetLength(1) - 1; i++)
            {
                if (i + 1 == _numbers.GetLength(1) - 1)
                {
                    b[i] = (_numbers[1, i + 1] - _numbers[1, i]) / (_numbers[0, i + 1] - _numbers[0, i]) - ((0 + 2 * c[i]) * (_numbers[0, i + 1] - _numbers[0, i])) / 3;
                    continue;
                }
                b[i] = (_numbers[1, i + 1] - _numbers[1, i]) / (_numbers[0, i + 1] - _numbers[0, i]) - ((c[i + 1] + 2 * c[i]) * (_numbers[0, i + 1] - _numbers[0, i])) / 3;
            }
        }

        private void GetSplineSystem()
        {
            double[] a = new double[_numbers.GetLength(1) - 1];
            double[] b = new double[_numbers.GetLength(1) - 1];
            double[] c = new double[_numbers.GetLength(1) - 1];
            double[] d = new double[_numbers.GetLength(1) - 1];

            GetCoefA(a);
            GetCoefC(out c);
            GetCoefB(b, c);
            GetCoefD(d, c);

            double[,] result = new double[a.Length, 4];
            for (int i = 0; i < a.Length; i++)
            {
                result[i, 0] = a[i];
                result[i, 1] = b[i];
                result[i, 2] = c[i];
                result[i, 3] = d[i];
            }
            _splineSystem = result;
        }
        public double Interpolate(double x)
        {
            int splineIndex = _numbers.GetLength(1) - 2;
            for (int i = _numbers.GetLength(1) - 2; i > 0; i--)
            {
                if (_numbers[0, i] > x)
                {
                    splineIndex = i - 1;
                }
            }

            double result = _splineSystem[splineIndex, 0] + _splineSystem[splineIndex, 1] * (x - _numbers[0, splineIndex]) + _splineSystem[splineIndex, 2] * Math.Pow((x - _numbers[0, splineIndex]), 2) + _splineSystem[splineIndex, 3] * Math.Pow((x - _numbers[0, splineIndex]), 3);
            return result;
        }
    }
}
