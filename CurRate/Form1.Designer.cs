namespace CurRate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextDayBtn = new System.Windows.Forms.Button();
            this.edRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.setStartPriceBtn = new System.Windows.Forms.Button();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sell1Dollar = new System.Windows.Forms.Button();
            this.buy1Dollar = new System.Windows.Forms.Button();
            this.avalRlbl = new System.Windows.Forms.Label();
            this.avalDlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.avalDlbl);
            this.panel1.Controls.Add(this.avalRlbl);
            this.panel1.Controls.Add(this.buy1Dollar);
            this.panel1.Controls.Add(this.sell1Dollar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.startGameBtn);
            this.panel1.Controls.Add(this.setStartPriceBtn);
            this.panel1.Controls.Add(this.nextDayBtn);
            this.panel1.Controls.Add(this.edRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 100);
            this.panel1.TabIndex = 0;
            // 
            // nextDayBtn
            // 
            this.nextDayBtn.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextDayBtn.Location = new System.Drawing.Point(278, 34);
            this.nextDayBtn.Name = "nextDayBtn";
            this.nextDayBtn.Size = new System.Drawing.Size(111, 37);
            this.nextDayBtn.TabIndex = 4;
            this.nextDayBtn.Text = "Next day!";
            this.nextDayBtn.UseVisualStyleBackColor = true;
            this.nextDayBtn.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // edRate
            // 
            this.edRate.DecimalPlaces = 2;
            this.edRate.Location = new System.Drawing.Point(85, 19);
            this.edRate.Name = "edRate";
            this.edRate.Size = new System.Drawing.Size(97, 20);
            this.edRate.TabIndex = 1;
            this.edRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start $ price:";
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 50D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 100);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "f2";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(758, 350);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // setStartPriceBtn
            // 
            this.setStartPriceBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setStartPriceBtn.Location = new System.Drawing.Point(16, 47);
            this.setStartPriceBtn.Name = "setStartPriceBtn";
            this.setStartPriceBtn.Size = new System.Drawing.Size(166, 37);
            this.setStartPriceBtn.TabIndex = 5;
            this.setStartPriceBtn.Text = "SET";
            this.setStartPriceBtn.UseVisualStyleBackColor = true;
            // 
            // startGameBtn
            // 
            this.startGameBtn.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGameBtn.Location = new System.Drawing.Point(493, 6);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(258, 88);
            this.startGameBtn.TabIndex = 6;
            this.startGameBtn.Text = "START GAME!";
            this.startGameBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Available ₽:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Available $:";
            // 
            // sell1Dollar
            // 
            this.sell1Dollar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sell1Dollar.Location = new System.Drawing.Point(395, 34);
            this.sell1Dollar.Name = "sell1Dollar";
            this.sell1Dollar.Size = new System.Drawing.Size(72, 36);
            this.sell1Dollar.TabIndex = 9;
            this.sell1Dollar.Text = "Sell 1$";
            this.sell1Dollar.UseVisualStyleBackColor = true;
            // 
            // buy1Dollar
            // 
            this.buy1Dollar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buy1Dollar.Location = new System.Drawing.Point(200, 34);
            this.buy1Dollar.Name = "buy1Dollar";
            this.buy1Dollar.Size = new System.Drawing.Size(72, 36);
            this.buy1Dollar.TabIndex = 10;
            this.buy1Dollar.Text = "Buy 1$";
            this.buy1Dollar.UseVisualStyleBackColor = true;
            // 
            // avalRlbl
            // 
            this.avalRlbl.AutoSize = true;
            this.avalRlbl.Location = new System.Drawing.Point(359, 12);
            this.avalRlbl.Name = "avalRlbl";
            this.avalRlbl.Size = new System.Drawing.Size(25, 13);
            this.avalRlbl.TabIndex = 11;
            this.avalRlbl.Text = "500";
            this.avalRlbl.UseMnemonic = false;
            this.avalRlbl.UseWaitCursor = true;
            // 
            // avalDlbl
            // 
            this.avalDlbl.AutoSize = true;
            this.avalDlbl.Location = new System.Drawing.Point(359, 78);
            this.avalDlbl.Name = "avalDlbl";
            this.avalDlbl.Size = new System.Drawing.Size(13, 13);
            this.avalDlbl.TabIndex = 12;
            this.avalDlbl.Text = "0";
            this.avalDlbl.UseMnemonic = false;
            this.avalDlbl.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nextDayBtn;
        private System.Windows.Forms.NumericUpDown edRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button setStartPriceBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buy1Dollar;
        private System.Windows.Forms.Button sell1Dollar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label avalDlbl;
        private System.Windows.Forms.Label avalRlbl;
    }
}

