using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurRate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool gameIsRunning = false;

        const double k = 0.05;

        int daysSpent = 0;
        
        double startRate = 70.00;
        double roubles = 500;
        int dollars = 0;

        double rate;

        Random random = new Random();

        private void refreshUI()
        {
            avalDlbl.Text = dollars.ToString();
            avalRlbl.Text = roubles.ToString();
        }

        private void restartGame()
        {

            gameIsRunning = true;

            rate = startRate;

            roubles = 500;
            dollars = 0;
            daysSpent = 0;

            startGameBtn.Text = "RESTART GAME!";
            refreshUI();

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = daysSpent + 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, rate);
        }





        private void nextDayBtn_Click(object sender, EventArgs e)
        {
            if (gameIsRunning)
            {
                if (daysSpent > 20)
                {
                    chart1.ChartAreas[0].AxisX.Minimum = daysSpent - 20;
                }
                rate = (rate * (1 + k * (random.NextDouble() - 0.5))) >= 0 ? rate * (1 + k * (random.NextDouble() - 0.5)) : 0.01;
                chart1.ChartAreas[0].AxisX.Maximum = daysSpent + 1;
                chart1.Series[0].Points.AddXY(++daysSpent, rate);
                refreshUI();
            }
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void setStartPriceBtn_Click(object sender, EventArgs e)
        {
            startRate = (double)edRate.Value;
        }

        private void buy1Dollar_Click(object sender, EventArgs e)
        {
            if (gameIsRunning && roubles - rate >= 0)
            {
                dollars++;
                roubles -= rate;
                refreshUI();
            }
        }

        private void sell1Dollar_Click(object sender, EventArgs e)
        {
            if (gameIsRunning && dollars > 0)
            {
                dollars--;
                roubles += rate;
                refreshUI();
            }
        }
    }
}
