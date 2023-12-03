using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZhirenbaevaII.Sprint6.Task0.V8.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint6.Task0.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_ZII_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_ZII.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_ZII.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_ZII_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИСТНб 23-1 Жиренбаева Ирина Ильгизовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxVarX_ZII_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void groupBoxOutput_ZII_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxTask_ZII_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
