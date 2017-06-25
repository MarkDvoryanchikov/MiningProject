using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiningProject
{
    public partial class DialogCalc : Form
    {
        public DialogCalc(string name, string participation)
        {
            InitializeComponent();
            tBNameCalc.Text = name;
            if (participation == "Без автопостроения")
                cBCalcAuto.Checked = false;
            else
                cBCalcAuto.Checked = true;
        }

        public DialogCalc()
        {
            InitializeComponent();

        }

        private void DialogCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (tBNameCalc.Text == "")
                    {
                        throw new Exception("Введите название расчета");
                    }
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    MessageBox.Show("Неверный формат ввода");
                }
                catch (Exception E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message, "Ошибка");
                }
            }
        }

        private void OK_B_Layer_Click(object sender, EventArgs e)
        {

        }
    }
}
