using System;
using System.Linq;
using System.Windows.Forms;
using Testing;

namespace CompMathLab3
{
    public partial class Form1 : Form
    {
        private bool _isPointsExist = false;
        private double[,] _numbersFirstDeriv = new double[2, 5] { { 0.01, 0.1, 1, 10, 100 }, { 0.04, 0.4, 4, 40, 400 } };
        private CubeSpline _cubeSpline;
        private Derivative _derivative = new Derivative();

        private double MaxX
        {
            get
            {
                double maxValue = double.MinValue;
                for (int i = 0; i < Numbers.GetLength(1); i++)
                    if (Numbers[0, i]> maxValue)
                        maxValue = Numbers[0, i];
                    
                return maxValue;
            }
        }
        private double[,] _numbers;
        private double[,] Numbers
        {
            get
            {
                if (_numbers == null)
                {
                    _numbers = new double[dataGridViewCoordinates.Columns.Count, dataGridViewCoordinates.Rows.Count];
                    for (int i = 0; i < dataGridViewCoordinates.Columns.Count; i++)
                    {
                        for (int j = 0; j < (dataGridViewCoordinates.Rows.Count); j++)
                        {
                            _numbers[i, j] = double.Parse(dataGridViewCoordinates[i, j].Value.ToString());
                        }
                    }

                }
                return _numbers;
            }
        }
        public Form1()
        {
            InitializeComponent();
            dataGridViewCoordinates.AllowUserToAddRows = false;
        }

        private void DrawByCubeSpline()
        {
            chart1.ChartAreas[0].Axes[0].Maximum = 4;
            chart1.ChartAreas[0].Axes[0].Minimum = -4;
            chart1.ChartAreas[0].Axes[1].Maximum = 4;
            chart1.ChartAreas[0].Axes[1].Minimum = -4;

            chart1.Series[5].Points.Clear();
            chart1.Series[8].Points.Clear();
            chart1.Series[9].Points.Clear();

            double x = Numbers[0,0], y, yPlusStep, yMinusStep, derivFirst = 0, derivSecond = 0, derivSecondY2 = 0,
                yPlusTwoSteps, yMinusTwoSteps;
            double step = (double)numericUpDownAccuracy.Value;
            _cubeSpline = new CubeSpline(Numbers);
            double y2;
            while (x <= MaxX)
            {
                y = _cubeSpline.Interpolate(x);
                y2 = Math.Pow(x, 2);
                chart1.Series[5].Points.AddXY(x, y);    //кубич. сплайн
                chart1.Series[12].Points.AddXY(x, y2);
                if (x >= Numbers[0, 0] + 2 * step && x <= MaxX - 2 * step)
                {

                    yPlusStep = _cubeSpline.Interpolate(x + step);
                    yMinusStep = _cubeSpline.Interpolate(x - step);
                    derivFirst = _derivative.CalculateFirstDerivativeTwoSteps(yPlusStep, yMinusStep, step);

                    yPlusTwoSteps = _cubeSpline.Interpolate(x + 2 * step);
                    yMinusTwoSteps = _cubeSpline.Interpolate(x - 2 * step);
                    derivSecond = _derivative.CalculateSecondDerivative(yPlusTwoSteps, yMinusTwoSteps, y, step);
                    derivSecondY2 = _derivative.CalculateSecondDerivative(Math.Pow(x + 2 * step, 2), Math.Pow(x - 2 * step, 2), Math.Pow(x, 2), step);

                    chart1.Series[8].Points.AddXY(x, derivFirst);    //первые производные
                    chart1.Series[9].Points.AddXY(x, derivSecond);    //вторые производные
                    chart1.Series[11].Points.AddXY(x, derivSecondY2);    //вторые производные
                }
                x += step;
            }

        }

        private void DrawByFirstDerivative()
        {
            chart1.ChartAreas[0].Axes[0].Maximum = 1.1;
            chart1.ChartAreas[0].Axes[0].Minimum = 0;
            chart1.ChartAreas[0].Axes[1].Maximum = 2.1;
            chart1.ChartAreas[0].Axes[1].Minimum = 0;

            _derivative = new Derivative();
            richTextBox1.Text = $"\nШаг: 10^{(double)numericStepDegree.Value}\n";
            chart1.Series[6].Points.Clear();
            
            double step = Math.Pow(10,(double) numericStepDegree.Value);
            double derivative = 0;

            for (int i = 0; i < Numbers.GetLength(1); i++)
            {
                derivative = _derivative.CalculateFirstDerivative(Numbers[0, i], step);
                chart1.Series[6].Points.AddXY(Numbers[0, i],derivative );
                richTextBox1.Text += $"\nx = {Numbers[0, i]}, f ' (x) = {derivative}\n";
            }
            
        }

        private void DrawPoints()
        {
            chart1.Series[3].Points.Clear();
            chart1.Series[3].MarkerSize = 8;
            chart1.Series[3].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;

            for (int i = 0; i < Numbers.GetLength(1); i++)
                chart1.Series[3].Points.AddXY(Numbers[0, i], Numbers[1, i]);
            
        }
        private void DrawPointsFirstDerivative()
        {
            
            if(!_isPointsExist)
            {
                chart1.Series[7].Points.Clear();
                chart1.Series[7].MarkerSize = 8;
                chart1.Series[7].MarkerColor = System.Drawing.Color.Red;
                chart1.Series[7].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                for (int i = 0; i < _numbersFirstDeriv.GetLength(1); i++)
                    chart1.Series[7].Points.AddXY(_numbersFirstDeriv[0, i], _numbersFirstDeriv[1, i]);
                
                _isPointsExist = true;
            }
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < chart1.Series.Count;i++)
                chart1.Series[i].Points.Clear();
        }

        private void buttonAddCoordinate_Click(object sender, EventArgs e)
        {
            _numbers = null;
            dataGridViewCoordinates.Rows.Add();
        }

        private void buttonDeleteCoordinate_Click(object sender, EventArgs e)
        {
            _numbers = null;
            dataGridViewCoordinates.Rows.RemoveAt(dataGridViewCoordinates.CurrentCell.RowIndex);
        }

        private void buttonUseMethod_Click(object sender, EventArgs e)
        {
            _numbers = null;
            for (int j = Numbers.GetLength(1) - 1; j > 0; j--)
            {
                // основной цикл внутри каждого прогона
                // перебираем все элементы от первого до последнего в прогоне, который мы определили выше
                for (int i = 0; i < j; i++)
                {
                    // если текущий элемент больше следующего
                    if (Numbers[0,i] > Numbers[0,i + 1])
                    {
                        // запоминаем значение текущего элемента
                        double temp = Numbers[0, i];
                        // записываем на его место значение следующего
                        Numbers[0, i] = Numbers[0, i + 1];
                        // а на место следующего ставим значение текущего, тем самым меняем их местами
                        Numbers[0, i + 1] = temp;

                        temp = Numbers[1, i];
                        Numbers[1, i] = Numbers[1, i + 1];
                        Numbers[1, i + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < Numbers.GetLength(1) - 1; i++)
            {
                if(Numbers[0,i] == Numbers[0, i + 1])
                {
                    if (Numbers[1, i] != Numbers[1, i + 1])
                    {
                        MessageBox.Show("Некорректные координаты точек");
                        return;
                    }
                    if (Numbers[1, i] == Numbers[1, i + 1])
                    {
                        MessageBox.Show("Удалите дублирование");
                        return;
                    }
                }
            }



            if (comboBoxMethods.SelectedIndex != 1)
                DrawPoints();
            else
                DrawPointsFirstDerivative();

            switch (comboBoxMethods.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Выберите метод");
                    break;
                case 0:
                    DrawByCubeSpline();
                    break;
                case 1:
                    DrawByFirstDerivative();
                    break;
                case 2:
                    //DrawByLeastSquares();
                    break;

            }
        }

        private void comboBoxMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMethods.SelectedIndex == 1)
            {
                labelDegree.Visible = false;
                numericUpDownDegree.Visible = false;
                labelStep.Visible = true;
                labelStepBase10.Visible = true;
                numericStepDegree.Visible = true;
                labelFirstDev.Visible = true;
                richTextBox1.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                textBoxA4.Visible = false;
                textBoxA3.Visible = false;
                textBoxA2.Visible = false;
                textBoxA1.Visible = false;
                textBoxA0.Visible = false;
                labelDegree.Visible = false;
                numericUpDownDegree.Visible = false;
            }
            else
            {
                labelFirstDev.Visible = false;
                richTextBox1.Visible = false;
                labelStep.Visible = false;
                labelStepBase10.Visible = false;
                numericStepDegree.Visible = false;
                numericUpDownDegree.Value = 0;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                textBoxA4.Visible = false;
                textBoxA3.Visible = false;
                textBoxA2.Visible = false;
                textBoxA1.Visible = false;
                textBoxA0.Visible = false;
                labelDegree.Visible = false;
                numericUpDownDegree.Visible = false;
            }
        }

        private void numericUpDownDegree_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDownDegree.Value == 1) 
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                textBoxA4.Visible = true;
                textBoxA3.Visible = true;
                textBoxA2.Visible = true;
                textBoxA1.Visible = true;
                textBoxA0.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                textBoxA4.Visible = false;
                textBoxA3.Visible = false;
                textBoxA2.Visible = false;
                textBoxA1.Visible = false;
                textBoxA0.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
