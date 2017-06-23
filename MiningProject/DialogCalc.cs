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
    }
}
