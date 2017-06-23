using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiningProject.Concrete;
using MiningProject.Models;

namespace MiningProject
{
    public partial class Main : Form
    {
        private EFRepository repository = new EFRepository();

        public Main()
        {
            InitializeComponent();
        }

        private void M_btn1_Click(object sender, EventArgs e)
        {
            DataInput Module = new DataInput()
            {
                Text = "Ввод данных \"Задачи и угольные пласты\""
            };
            Hide();
            if (Module.ShowDialog() == DialogResult.Abort)
            {
                Module.Close();
                Show();
            }
        }

        private void M_btn2_Click(object sender, EventArgs e)
        {
            CurvCalc Module = new CurvCalc()
            {
                Text = "Расчеты фракционного анализа"
            };
            Hide();
            if (Module.ShowDialog() == DialogResult.Abort)
            {
                Show();
            }
        }
    }
}
