namespace CompMathLab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewCoordinates = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddCoordinate = new System.Windows.Forms.Button();
            this.buttonDeleteCoordinate = new System.Windows.Forms.Button();
            this.comboBoxMethods = new System.Windows.Forms.ComboBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.buttonUseMethod = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDownDegree = new System.Windows.Forms.NumericUpDown();
            this.labelDegree = new System.Windows.Forms.Label();
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.textBoxA3 = new System.Windows.Forms.TextBox();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.textBoxA4 = new System.Windows.Forms.TextBox();
            this.textBoxA0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericStepDegree = new System.Windows.Forms.NumericUpDown();
            this.labelStepBase10 = new System.Windows.Forms.Label();
            this.labelStep = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelFirstDev = new System.Windows.Forms.Label();
            this.numericUpDownAccuracy = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordinates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStepDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccuracy)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisX.Minimum = -1D;
            chartArea1.AxisY.Maximum = 20D;
            chartArea1.AxisY.Minimum = -5D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(19, 10);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 10;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Violet;
            series1.Name = "Series1";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series2";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Name = "Series4";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Lime;
            series5.Name = "Series5";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Indigo;
            series6.LegendText = "Кубические сплайны";
            series6.MarkerSize = 2;
            series6.Name = "Series6";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Name = "Series7";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Name = "Series8";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series9.LegendText = "Первая производная сплайна";
            series9.Name = "Series9";
            series10.BorderWidth = 5;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series10.LegendText = "Вторая производная сплайна";
            series10.Name = "Series10";
            series11.BorderWidth = 6;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series11.Color = System.Drawing.Color.Black;
            series11.Name = "Series11";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Color = System.Drawing.Color.Black;
            series12.LegendText = "Вторая производная функции";
            series12.MarkerSize = 2;
            series12.Name = "Series13";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Color = System.Drawing.Color.Red;
            series13.LegendText = "y=2*x^2";
            series13.Name = "Series14";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(853, 602);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Графики";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataGridViewCoordinates
            // 
            this.dataGridViewCoordinates.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewCoordinates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoordinates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataGridViewCoordinates.Location = new System.Drawing.Point(893, 14);
            this.dataGridViewCoordinates.Name = "dataGridViewCoordinates";
            this.dataGridViewCoordinates.RowHeadersWidth = 51;
            this.dataGridViewCoordinates.Size = new System.Drawing.Size(295, 244);
            this.dataGridViewCoordinates.TabIndex = 5;
            // 
            // x
            // 
            this.x.Frozen = true;
            this.x.HeaderText = "x";
            this.x.MinimumWidth = 6;
            this.x.Name = "x";
            this.x.Width = 125;
            // 
            // y
            // 
            this.y.Frozen = true;
            this.y.HeaderText = "y";
            this.y.MinimumWidth = 6;
            this.y.Name = "y";
            this.y.Width = 125;
            // 
            // buttonAddCoordinate
            // 
            this.buttonAddCoordinate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCoordinate.Location = new System.Drawing.Point(893, 275);
            this.buttonAddCoordinate.Name = "buttonAddCoordinate";
            this.buttonAddCoordinate.Size = new System.Drawing.Size(298, 35);
            this.buttonAddCoordinate.TabIndex = 6;
            this.buttonAddCoordinate.Text = "Добавить точку";
            this.buttonAddCoordinate.UseVisualStyleBackColor = true;
            this.buttonAddCoordinate.Click += new System.EventHandler(this.buttonAddCoordinate_Click);
            // 
            // buttonDeleteCoordinate
            // 
            this.buttonDeleteCoordinate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCoordinate.Location = new System.Drawing.Point(893, 317);
            this.buttonDeleteCoordinate.Name = "buttonDeleteCoordinate";
            this.buttonDeleteCoordinate.Size = new System.Drawing.Size(298, 35);
            this.buttonDeleteCoordinate.TabIndex = 7;
            this.buttonDeleteCoordinate.Text = "Удалить точку";
            this.buttonDeleteCoordinate.UseVisualStyleBackColor = true;
            this.buttonDeleteCoordinate.Click += new System.EventHandler(this.buttonDeleteCoordinate_Click);
            // 
            // comboBoxMethods
            // 
            this.comboBoxMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxMethods.FormattingEnabled = true;
            this.comboBoxMethods.Items.AddRange(new object[] {
            "Кубические сплайны",
            "Первая производная"});
            this.comboBoxMethods.Location = new System.Drawing.Point(1198, 40);
            this.comboBoxMethods.Name = "comboBoxMethods";
            this.comboBoxMethods.Size = new System.Drawing.Size(251, 32);
            this.comboBoxMethods.TabIndex = 8;
            this.comboBoxMethods.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethods_SelectedIndexChanged);
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelMethod.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMethod.ForeColor = System.Drawing.Color.Black;
            this.labelMethod.Location = new System.Drawing.Point(1225, 12);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(65, 23);
            this.labelMethod.TabIndex = 9;
            this.labelMethod.Text = "Метод";
            // 
            // buttonUseMethod
            // 
            this.buttonUseMethod.BackColor = System.Drawing.Color.Transparent;
            this.buttonUseMethod.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUseMethod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUseMethod.Location = new System.Drawing.Point(1198, 78);
            this.buttonUseMethod.Name = "buttonUseMethod";
            this.buttonUseMethod.Size = new System.Drawing.Size(252, 40);
            this.buttonUseMethod.TabIndex = 10;
            this.buttonUseMethod.Text = "Применить";
            this.buttonUseMethod.UseVisualStyleBackColor = false;
            this.buttonUseMethod.Click += new System.EventHandler(this.buttonUseMethod_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1198, 122);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(252, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // numericUpDownDegree
            // 
            this.numericUpDownDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownDegree.Location = new System.Drawing.Point(1197, 304);
            this.numericUpDownDegree.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDegree.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownDegree.Name = "numericUpDownDegree";
            this.numericUpDownDegree.Size = new System.Drawing.Size(252, 29);
            this.numericUpDownDegree.TabIndex = 11;
            this.numericUpDownDegree.Visible = false;
            this.numericUpDownDegree.ValueChanged += new System.EventHandler(this.numericUpDownDegree_ValueChanged);
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelDegree.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDegree.ForeColor = System.Drawing.Color.Black;
            this.labelDegree.Location = new System.Drawing.Point(1197, 278);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(76, 23);
            this.labelDegree.TabIndex = 12;
            this.labelDegree.Text = "Степень";
            this.labelDegree.Visible = false;
            // 
            // textBoxA1
            // 
            this.textBoxA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxA1.Location = new System.Drawing.Point(1356, 178);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(85, 24);
            this.textBoxA1.TabIndex = 15;
            this.textBoxA1.Visible = false;
            // 
            // textBoxA3
            // 
            this.textBoxA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxA3.Location = new System.Drawing.Point(1227, 206);
            this.textBoxA3.Name = "textBoxA3";
            this.textBoxA3.Size = new System.Drawing.Size(85, 24);
            this.textBoxA3.TabIndex = 16;
            this.textBoxA3.Visible = false;
            // 
            // textBoxA2
            // 
            this.textBoxA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxA2.Location = new System.Drawing.Point(1226, 235);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(85, 24);
            this.textBoxA2.TabIndex = 17;
            this.textBoxA2.Visible = false;
            // 
            // textBoxA4
            // 
            this.textBoxA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA4.Location = new System.Drawing.Point(1227, 178);
            this.textBoxA4.Name = "textBoxA4";
            this.textBoxA4.Size = new System.Drawing.Size(83, 24);
            this.textBoxA4.TabIndex = 18;
            this.textBoxA4.Visible = false;
            // 
            // textBoxA0
            // 
            this.textBoxA0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxA0.Location = new System.Drawing.Point(1354, 206);
            this.textBoxA0.Name = "textBoxA0";
            this.textBoxA0.Size = new System.Drawing.Size(86, 24);
            this.textBoxA0.TabIndex = 19;
            this.textBoxA0.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1327, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "a0";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1327, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "a1";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1195, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "a2";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1194, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "a3";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1195, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "a4";
            this.label5.Visible = false;
            // 
            // numericStepDegree
            // 
            this.numericStepDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericStepDegree.Location = new System.Drawing.Point(1393, 279);
            this.numericStepDegree.Margin = new System.Windows.Forms.Padding(2);
            this.numericStepDegree.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericStepDegree.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            -2147483648});
            this.numericStepDegree.Name = "numericStepDegree";
            this.numericStepDegree.Size = new System.Drawing.Size(56, 26);
            this.numericStepDegree.TabIndex = 25;
            this.numericStepDegree.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericStepDegree.Visible = false;
            // 
            // labelStepBase10
            // 
            this.labelStepBase10.AutoSize = true;
            this.labelStepBase10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelStepBase10.ForeColor = System.Drawing.Color.Black;
            this.labelStepBase10.Location = new System.Drawing.Point(1353, 305);
            this.labelStepBase10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStepBase10.Name = "labelStepBase10";
            this.labelStepBase10.Size = new System.Drawing.Size(36, 26);
            this.labelStepBase10.TabIndex = 26;
            this.labelStepBase10.Text = "10";
            this.labelStepBase10.Visible = false;
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelStep.ForeColor = System.Drawing.Color.Black;
            this.labelStep.Location = new System.Drawing.Point(1297, 305);
            this.labelStep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(57, 26);
            this.labelStep.TabIndex = 27;
            this.labelStep.Text = "Шаг:";
            this.labelStep.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBox1.Location = new System.Drawing.Point(893, 378);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(295, 234);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // labelFirstDev
            // 
            this.labelFirstDev.AutoSize = true;
            this.labelFirstDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFirstDev.ForeColor = System.Drawing.Color.Black;
            this.labelFirstDev.Location = new System.Drawing.Point(889, 355);
            this.labelFirstDev.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstDev.Name = "labelFirstDev";
            this.labelFirstDev.Size = new System.Drawing.Size(291, 20);
            this.labelFirstDev.TabIndex = 29;
            this.labelFirstDev.Text = "Приближ. знач. первой производной:";
            this.labelFirstDev.Visible = false;
            // 
            // numericUpDownAccuracy
            // 
            this.numericUpDownAccuracy.DecimalPlaces = 3;
            this.numericUpDownAccuracy.Location = new System.Drawing.Point(1295, 17);
            this.numericUpDownAccuracy.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownAccuracy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownAccuracy.Name = "numericUpDownAccuracy";
            this.numericUpDownAccuracy.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownAccuracy.TabIndex = 30;
            this.numericUpDownAccuracy.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1460, 676);
            this.Controls.Add(this.numericUpDownAccuracy);
            this.Controls.Add(this.labelFirstDev);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.labelStepBase10);
            this.Controls.Add(this.numericStepDegree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxA0);
            this.Controls.Add(this.textBoxA4);
            this.Controls.Add(this.textBoxA2);
            this.Controls.Add(this.textBoxA3);
            this.Controls.Add(this.textBoxA1);
            this.Controls.Add(this.labelDegree);
            this.Controls.Add(this.numericUpDownDegree);
            this.Controls.Add(this.buttonUseMethod);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.comboBoxMethods);
            this.Controls.Add(this.buttonDeleteCoordinate);
            this.Controls.Add(this.buttonAddCoordinate);
            this.Controls.Add(this.dataGridViewCoordinates);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chart1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordinates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStepDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccuracy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridViewCoordinates;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.Button buttonAddCoordinate;
        private System.Windows.Forms.Button buttonDeleteCoordinate;
        private System.Windows.Forms.ComboBox comboBoxMethods;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.Button buttonUseMethod;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDownDegree;
        private System.Windows.Forms.Label labelDegree;
        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.TextBox textBoxA3;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.TextBox textBoxA4;
        private System.Windows.Forms.TextBox textBoxA0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericStepDegree;
        private System.Windows.Forms.Label labelStepBase10;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelFirstDev;
        private System.Windows.Forms.NumericUpDown numericUpDownAccuracy;
    }
}

