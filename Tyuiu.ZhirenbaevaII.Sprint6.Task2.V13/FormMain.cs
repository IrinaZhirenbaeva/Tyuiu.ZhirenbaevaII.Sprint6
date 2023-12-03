using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZhirenbaevaII.Sprint6.Task2.V13.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint6.Task2.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_ZII_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_ZII.Text);
                int stopStep = Convert.ToInt32(textBoxStop_ZII.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_ZII.Titles.Add("График функции");
                this.chartFunction_ZII.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_ZII.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_ZII.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_ZII.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_ZII_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_ZII.BackColor = Color.Red;
        }

        private void buttonDone_ZII_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_ZII.BackColor = Color.Blue;
        }

        private void buttonDone_ZII_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_ZII.BackColor = Color.Green;
        }

        private void buttonHelp_ZII_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИСТНб 23-1 Жиренбаева Ирина Ильгизовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}