namespace Lab_PL_02
{
    partial class Lab02
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
            this.buttonCalculation = new System.Windows.Forms.Button();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.textBoxExspression = new System.Windows.Forms.TextBox();
            this.labelFunction = new System.Windows.Forms.Label();
            this.textBoxDerivate = new System.Windows.Forms.TextBox();
            this.labelDerivate = new System.Windows.Forms.Label();
            this.textBoxRPN = new System.Windows.Forms.TextBox();
            this.labelRPN = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.labelK = new System.Windows.Forms.Label();
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.labelLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculation
            // 
            this.buttonCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCalculation.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculation.Location = new System.Drawing.Point(99, 575);
            this.buttonCalculation.Name = "buttonCalculation";
            this.buttonCalculation.Size = new System.Drawing.Size(124, 60);
            this.buttonCalculation.TabIndex = 0;
            this.buttonCalculation.Text = "Подсчитать значения";
            this.buttonCalculation.UseVisualStyleBackColor = false;
            this.buttonCalculation.Click += new System.EventHandler(this.buttonCalculation_Click);
            // 
            // chartFunction
            // 
            this.chartFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartFunction.BackColor = System.Drawing.Color.Transparent;
            this.chartFunction.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea1);
            this.chartFunction.Location = new System.Drawing.Point(12, 12);
            this.chartFunction.Name = "chartFunction";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Name = "Series1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Lime;
            series2.Name = "Series2";
            this.chartFunction.Series.Add(series1);
            this.chartFunction.Series.Add(series2);
            this.chartFunction.Size = new System.Drawing.Size(1066, 557);
            this.chartFunction.TabIndex = 1;
            this.chartFunction.Text = "chart1";
            this.chartFunction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chartFunction_MouseDown);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDraw.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDraw.Location = new System.Drawing.Point(875, 644);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(124, 60);
            this.buttonDraw.TabIndex = 2;
            this.buttonDraw.Text = "Нарисовать график";
            this.buttonDraw.UseVisualStyleBackColor = false;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // textBoxExspression
            // 
            this.textBoxExspression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExspression.BackColor = System.Drawing.Color.White;
            this.textBoxExspression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExspression.Location = new System.Drawing.Point(347, 575);
            this.textBoxExspression.Name = "textBoxExspression";
            this.textBoxExspression.Size = new System.Drawing.Size(445, 26);
            this.textBoxExspression.TabIndex = 3;
            // 
            // labelFunction
            // 
            this.labelFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFunction.AutoSize = true;
            this.labelFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunction.Location = new System.Drawing.Point(295, 578);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(50, 20);
            this.labelFunction.TabIndex = 4;
            this.labelFunction.Text = "f(x) =";
            // 
            // textBoxDerivate
            // 
            this.textBoxDerivate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDerivate.BackColor = System.Drawing.Color.White;
            this.textBoxDerivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDerivate.Location = new System.Drawing.Point(347, 660);
            this.textBoxDerivate.Name = "textBoxDerivate";
            this.textBoxDerivate.ReadOnly = true;
            this.textBoxDerivate.Size = new System.Drawing.Size(445, 26);
            this.textBoxDerivate.TabIndex = 5;
            // 
            // labelDerivate
            // 
            this.labelDerivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDerivate.AutoSize = true;
            this.labelDerivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDerivate.Location = new System.Drawing.Point(291, 663);
            this.labelDerivate.Name = "labelDerivate";
            this.labelDerivate.Size = new System.Drawing.Size(54, 20);
            this.labelDerivate.TabIndex = 6;
            this.labelDerivate.Text = "f\'(x) =";
            // 
            // textBoxRPN
            // 
            this.textBoxRPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRPN.BackColor = System.Drawing.Color.White;
            this.textBoxRPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRPN.Location = new System.Drawing.Point(347, 617);
            this.textBoxRPN.Name = "textBoxRPN";
            this.textBoxRPN.ReadOnly = true;
            this.textBoxRPN.Size = new System.Drawing.Size(445, 26);
            this.textBoxRPN.TabIndex = 7;
            // 
            // labelRPN
            // 
            this.labelRPN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRPN.AutoSize = true;
            this.labelRPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRPN.Location = new System.Drawing.Point(282, 620);
            this.labelRPN.Name = "labelRPN";
            this.labelRPN.Size = new System.Drawing.Size(63, 20);
            this.labelRPN.TabIndex = 8;
            this.labelRPN.Text = "ОПН =";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(99, 660);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(124, 60);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxK
            // 
            this.textBoxK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxK.BackColor = System.Drawing.Color.White;
            this.textBoxK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxK.Location = new System.Drawing.Point(347, 704);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.ReadOnly = true;
            this.textBoxK.Size = new System.Drawing.Size(445, 26);
            this.textBoxK.TabIndex = 10;
            // 
            // labelK
            // 
            this.labelK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelK.AutoSize = true;
            this.labelK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelK.Location = new System.Drawing.Point(291, 707);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(52, 20);
            this.labelK.TabIndex = 11;
            this.labelK.Text = "кас =";
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLeft.Location = new System.Drawing.Point(875, 615);
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.Size = new System.Drawing.Size(55, 20);
            this.textBoxLeft.TabIndex = 12;
            // 
            // textBoxRight
            // 
            this.textBoxRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRight.Location = new System.Drawing.Point(944, 615);
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.Size = new System.Drawing.Size(55, 20);
            this.textBoxRight.TabIndex = 13;
            // 
            // labelLeft
            // 
            this.labelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLeft.AutoSize = true;
            this.labelLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeft.Location = new System.Drawing.Point(872, 586);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(56, 15);
            this.labelLeft.TabIndex = 14;
            this.labelLeft.Text = "Начало";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(951, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Конец";
            // 
            // Lab02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 747);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.textBoxRight);
            this.Controls.Add(this.textBoxLeft);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxRPN);
            this.Controls.Add(this.labelRPN);
            this.Controls.Add(this.textBoxDerivate);
            this.Controls.Add(this.labelDerivate);
            this.Controls.Add(this.textBoxExspression);
            this.Controls.Add(this.labelFunction);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.chartFunction);
            this.Controls.Add(this.buttonCalculation);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Lab02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab02";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxExspression;
        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.TextBox textBoxDerivate;
        private System.Windows.Forms.Label labelDerivate;
        private System.Windows.Forms.TextBox textBoxRPN;
        private System.Windows.Forms.Label labelRPN;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label label1;
    }
}

