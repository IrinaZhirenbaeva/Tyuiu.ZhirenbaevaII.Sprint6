using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZhirenbaevaII.Sprint6.Task1.V7.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint6.Task1.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
          


            

            
        }

        private void ButtonInfo_ZII_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИСТНб 23-1 Жиренбаева Ирина Ильгизовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonDone_ZII_Click(object sender, EventArgs e)
        {

            DataService ds = new DataService();


            {
                try
                {
                    int startStep = Convert.ToInt32(TextBoxStart_ZII.Text);
                    int stopStep = Convert.ToInt32(TextBoxStop_ZII.Text);
                    string strLine;
                    int len = ds.GetMassFunction(startStep, stopStep).Length;
                    double[] valueArray;
                    valueArray = new double[len];
                    valueArray = ds.GetMassFunction(startStep, stopStep);
                    TextBoxResult_ZII.Text = "";
                    TextBoxResult_ZII.AppendText("+----------+----------+" + Environment.NewLine);
                    TextBoxResult_ZII.AppendText("|     X    |   f(x)   |" + Environment.NewLine);
                    TextBoxResult_ZII.AppendText("+----------+----------+" + Environment.NewLine);
                    for (int i = 0; i <= len - 1; i++)
                    {
                        strLine = String.Format("|{0,6:d}    |  {1, 5:f2}   | ", startStep, valueArray[i]);
                        TextBoxResult_ZII.AppendText(strLine + Environment.NewLine);
                        startStep++;
                    }
                    TextBoxResult_ZII.AppendText("+----------+----------+" + Environment.NewLine);
                }
                catch
                {
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

    }
}
