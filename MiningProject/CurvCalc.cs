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
using System.Windows.Forms.DataVisualization.Charting;

namespace MiningProject
{
    public partial class CurvCalc : Form
    {
        public CurvCalc()
        {
            InitializeComponent();
            LoadTasks();
            LoadTasks();
        }

        private EFRepository repository = new EFRepository();
        int currow = 0;

        private void LoadTasks()
        {
            dGVTasks.DataSource = repository.MyTasks.OrderByDescending(c => c.Time).ToList();

            //dGVTasks.Sort(this.dGVTasks.Columns[2], ListSortDirection.Ascending);

            dGVTasks.Columns[0].Visible = dGVTasks.Columns[3].Visible = dGVTasks.Columns[4].Visible = false;
            dGVTasks.Columns[1].HeaderText = "Название задачи";
            dGVTasks.Columns[2].HeaderText = "Время создания";
            dGVTasks.Columns[1].Width = 200;
            dGVTasks.Columns[2].Width = 120;
            dGVTasks.ReadOnly = true;
            if (dGVTasks.CurrentCell != null)
            {
                dGVTasks.CurrentCell = dGVTasks.Rows[currow].Cells[1];

                LoadCalcs();
            }
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            DialogCalc Dialog = new DialogCalc()
            {
                Text = "Создание расчета"
            };
            var mytask = dGVTasks.CurrentRow.DataBoundItem as MyTask;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                //true - создать авторасчет, заменить на открытие формы с выбором процентов участия пластов в шихте
                if (Dialog.cBCalcAuto.Checked)
                {
                    repository.AddCalc(new Calc()
                    {
                        MyTask = mytask.PK_Task,
                        NameCalc = Dialog.tBNameCalc.Text,
                        Participation = "Без автопостроения"
                    });
                }
                else
                {
                    repository.AddCalc(new Calc()
                    {
                        MyTask = mytask.PK_Task,
                        NameCalc = Dialog.tBNameCalc.Text,
                        Participation = "Без автопостроения"
                    });
                }
            }
            LoadCalcs();
        }

        private void Edit_B_Click(object sender, EventArgs e)
        {
            var change = dGVCalcs.CurrentRow.DataBoundItem as Calc;
            string name = change.NameCalc.ToString(),
                   part = change.Participation.ToString();
            DialogCalc Dialog = new DialogCalc(name, part)
            {
                Text = "Изменение расчета"
            };
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                repository.AddCalc(new Calc()
                {
                    PK_Calc = change.PK_Calc,
                    MyTask = change.MyTask,
                    NameCalc = Dialog.tBNameCalc.Text,
                    Participation = "Без автопостроения"
                });
            }
            LoadCalcs();
        }

        private void Del_B_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить выбранный расчет?", "Удаление расчета", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var del = dGVCalcs.CurrentRow.DataBoundItem as Calc;
                    repository.RemoveCalc(del);
                    LoadTasks();
                    dGVTasks_CurrentCellChanged(sender, e);
                }
                catch
                {
                    //MessageBox.Show("Для удаления отсутствует выделенная задача", "Ошибка");
                }
            }
        }

        private void dGVTasks_CurrentCellChanged(object sender, EventArgs e)
        {
            LoadCalcs();
            if (dGVTasks.CurrentCell != null)
            {
                if (dGVCalcs.CurrentCell != null)
                    Add_B_Class.Enabled = true;
                else
                    Add_B_Class.Enabled = false;
            }
        }

        private void LoadCalcs()
        {
            Add_B_Class.Enabled = true;
            if (dGVTasks.CurrentRow != null)
            {
                var mytask = dGVTasks.CurrentRow.DataBoundItem as MyTask;
                dGVCalcs.DataSource = repository.Calcs.Where(c => c.MyTask == mytask.PK_Task).ToList();

                dGVCalcs.Columns[0].Visible = dGVCalcs.Columns[1].Visible = dGVCalcs.Columns[2].Visible
                     = dGVCalcs.Columns[5].Visible = false;

                dGVCalcs.Columns[3].HeaderCell.Value = "Название расчета";
                dGVCalcs.Columns[4].HeaderCell.Value = "Участие пластов";
                dGVCalcs.Columns[3].Width = 150;
                dGVCalcs.Columns[4].Width = 280;
                Add_B.Enabled = true;
            }
            else
            {
                Add_B.Enabled = false;
                Edit_B.Enabled = false;
                Del_B.Enabled = false;
                Add_B_Class.Enabled = false;
                Edit_B_Class.Enabled = false;
                Del_B_Class.Enabled = false;

            }
            LoadLayersCalc();
        }

        private void Add_B_Class_Click(object sender, EventArgs e)
        {
            DialogLayerCalc Dialog = new DialogLayerCalc()
            {
                Text = "Создание класса расчета"
            };
            var calca = dGVCalcs.CurrentRow.DataBoundItem as Calc;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                for (var i = 0; i < 6; i++)
                {
                    repository.AddLayersCalculations(new LayersCalculation()
                    {
                        Calc = calca.PK_Calc,
                        Class = Dialog.tBClass.Text,
                        C1 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[0].Value.ToString()),
                        C2 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[1].Value.ToString()),
                        C3 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[2].Value.ToString()),
                        C4 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[3].Value.ToString()),
                        C5 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[4].Value.ToString()),
                        C6 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[5].Value.ToString()),
                    });
                }
            }
            LoadLayersCalc();
        }

        private void LoadLayersCalc()
        {
            if (dGVCalcs.CurrentRow != null)
            {
                var calc = dGVCalcs.CurrentRow.DataBoundItem as Calc;
                var clss = repository.LayersCalculations.Where(c => c.Calc == calc.PK_Calc).Where(n =>n.Class == cB_Layer.Text).ToList();
                dGVLC.DataSource = clss;
                drawChart(clss);
                var x = repository.LayersCalculations.Where(c => c.Calc == calc.PK_Calc).GroupBy(i => i.Class).Select(g => g.First()).Select(n => n.Class).ToList();
                cB_Layer.DataSource = x;

                dGVLCStyle();

                Edit_B.Enabled = true;
                Del_B.Enabled = true;
                cB_Layer.Enabled = true;
                if (x.Count() < 1)
                {
                    cB_Layer.Text = "";
                    dGVLC.DataSource = new object();
                    drawChart();
                    Edit_B_Class.Enabled = false;
                    Del_B_Class.Enabled = false;
                    cB_Layer.Enabled = false;
                }
            }
            else
            {
                Edit_B_Class.Enabled = false;
                Del_B_Class.Enabled = false;
                cB_Layer.Text = "";
                dGVLC.DataSource = new object();
                drawChart();
                Edit_B.Enabled = false;
                Del_B.Enabled = false;
                cB_Layer.Enabled = false;
            }
        }

        private void Edit_B_Class_Click(object sender, EventArgs e)
        {
            try
            {
                var nameChange = cB_Layer.Text;
                var change = repository.LayersCalculations.Where(n => n.Class == nameChange).ToList();

                DialogLayerCalc Dialog = new DialogLayerCalc(change, nameChange)
                {
                    Text = "Изменение пласта"
                };

                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    for (var i = 0; i < 6; i++)
                    {
                        repository.AddLayersCalculations(new LayersCalculation()
                        {
                            PK_LayersCalculation = change[i].PK_LayersCalculation,
                            Calc = change[i].Calc,
                            Class = Dialog.tBClass.Text,
                            C1 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[0].Value.ToString()),
                            C2 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[1].Value.ToString()),
                            C3 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[2].Value.ToString()),
                            C4 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[3].Value.ToString()),
                            C5 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[4].Value.ToString()),
                            C6 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[5].Value.ToString()),
                        });
                    }
                }

                cB_Layer_SelectedIndexChanged(sender, e);
            }
            catch
            {
                MessageBox.Show("Не получилось изменить класс", "Ошибка");
            }
        }

        private void Del_B_Class_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить выбранный класс?", "Удаление угольного пласта", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var nameDel = cB_Layer.Text;
                    var del = repository.LayersCalculations.Where(n => n.Class == nameDel).ToList();
                    foreach (var d in del)
                        repository.RemoveLayersCalculation(d);
                    dGVCalcs_CurrentCellChanged(sender, e);
                }
                catch
                {
                }
            }
        }

        private void cB_Layer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dGVCalcs.CurrentRow != null)
            {
                var calc = dGVCalcs.CurrentRow.DataBoundItem as Calc;
                
                var clss = repository.LayersCalculations.Where(c => c.Calc == calc.PK_Calc).Where(n => n.Class == cB_Layer.Text).ToList();
                dGVLC.DataSource = clss;
                dGVLCStyle();
                drawChart(clss);
                Add_B_Class.Enabled = true;
            }
            else
            {
                Add_B_Class.Enabled = false;
            }

        }

        private void dGVCalcs_CurrentCellChanged(object sender, EventArgs e)
        {
            LoadLayersCalc();
        }

        private void CurvCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form main = Application.OpenForms[0];
            main.Show();
        }

        private void dGVLCStyle()
        {
            try
            {
                dGVLC.Columns[0].Visible = dGVLC.Columns[1].Visible = dGVLC.Columns[2].Visible
                    = dGVLC.Columns[3].Visible = false;

                dGVLC.Columns[4].HeaderCell.Value = "Y";
                dGVLC.Columns[5].HeaderCell.Value = "Ad";
                dGVLC.Columns[6].HeaderCell.Value = "Y";
                dGVLC.Columns[7].HeaderCell.Value = "Ad";
                dGVLC.Columns[8].HeaderCell.Value = "Y";
                dGVLC.Columns[9].HeaderCell.Value = "Ad";

                dGVLC.Columns[7].DefaultCellStyle.Format = "n2";
                dGVLC.Columns[9].DefaultCellStyle.Format = "n2";

                dGVLC.AllowUserToAddRows = false;
                dGVLC.RowHeadersWidth = 80;
                dGVLC.Rows[0].HeaderCell.Value = "<1,3";
                dGVLC.Rows[1].HeaderCell.Value = "1,3-1,4";
                dGVLC.Rows[2].HeaderCell.Value = "1,4-1,5";
                dGVLC.Rows[3].HeaderCell.Value = "1,5-1,6";
                dGVLC.Rows[4].HeaderCell.Value = "1,6-1,8";
                dGVLC.Rows[5].HeaderCell.Value = ">1,8";


                for (var j = 4; j < dGVLC.ColumnCount; j++)
                {
                    dGVLC.Columns[j].Width = 71;
                }


                Edit_B_Class.Enabled = true;
                Del_B_Class.Enabled = true;



                foreach (DataGridViewColumn column in dGVLC.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                dGVLC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dGVLC.ColumnHeadersHeight = 60;
                dGVLC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                dGVLC.CellPainting += new DataGridViewCellPaintingEventHandler(dGVLC_CellPainting);
                dGVLC.Paint += new PaintEventHandler(dGVLC_Paint);

                dGVLC.Scroll += new ScrollEventHandler(dGVLC_Scroll);
                dGVLC.ColumnWidthChanged += new DataGridViewColumnEventHandler(dGVLC_ColumnWidthChanged);
            }
            catch { }
        }

        private void dGVLC_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                var r2 = e.CellBounds;
                r2.Y += e.CellBounds.Height / 3;
                r2.Height = e.CellBounds.Height / 3;
                e.PaintBackground(r2, true);
                e.PaintContent(r2);
                e.Handled = true;
            }
        }

        private void dGVLC_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                string first = "Суммарные фракции";

                string[] second = { "Элементарные", "Всплывшие", "Потонувшие" };
                for (int j = 4; j < dGVLC.ColumnCount;)
                {
                    var r1 = dGVLC.GetCellDisplayRectangle(j, -1, true);
                    int w2 = dGVLC.GetCellDisplayRectangle(j + 1, -1, true).Width;
                    r1.X += 1;
                    r1.Y += dGVLC.ColumnHeadersHeight / 3;
                    r1.Width = r1.Width + w2 - 2;
                    r1.Height = r1.Height / 3 - 2;
                    if (j == 4)
                    {
                        r1.Y = 3;
                        r1.Height = r1.Height * 2;
                    }
                    e.Graphics.FillRectangle(new SolidBrush(dGVLC.ColumnHeadersDefaultCellStyle.BackColor), r1);
                    var format = new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    e.Graphics.DrawString(second[(j - 4) / 2],
                    dGVLC.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(dGVLC.ColumnHeadersDefaultCellStyle.ForeColor), r1, format);
                    j += 2;
                }

                var r0 = dGVLC.GetCellDisplayRectangle(6, -1, true);
                int w0 = 0;
                for (int i = 6; i < dGVLC.ColumnCount - 1; i++)
                {
                    w0 += dGVLC.GetCellDisplayRectangle(i, -1, true).Width;
                }
                r0.X += 1;
                r0.Y += 2;
                r0.Width = r0.Width + w0 - 2;
                r0.Height = r0.Height / 3 - 3;
                e.Graphics.FillRectangle(new SolidBrush(dGVLC.ColumnHeadersDefaultCellStyle.BackColor), r0);
                var format0 = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(first, dGVLC.ColumnHeadersDefaultCellStyle.Font,
                new SolidBrush(dGVLC.ColumnHeadersDefaultCellStyle.ForeColor), r0, format0);
            }
            catch { }
        }

        private void dGVLC_Scroll(object sender, ScrollEventArgs e)
        {
            var rtHeader = dGVLC.DisplayRectangle;
            rtHeader.Height = dGVLC.ColumnHeadersHeight / 3 * 2;
            dGVLC.Invalidate(rtHeader);
        }

        private void dGVLC_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            var rtHeader = dGVLC.DisplayRectangle;
            rtHeader.Height = dGVLC.ColumnHeadersHeight / 3 * 2;    
            dGVLC.Invalidate(rtHeader);
        }

        private void drawChart()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            panel2.Visible = true;
        }

        private void drawChart(List<LayersCalculation> clss)
        {
            panel2.Visible = false;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[0].LegendText = "элементарных фракций";
            chart1.Series[1].LegendText = "всплывших фракций";
            chart1.Series[2].LegendText = "потонувших фракций";
            chart1.Series[3].LegendText = "плотности";

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 100;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisX.Interval = 10;
            chart1.ChartAreas[0].AxisY.Interval = 10;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[2].BorderWidth = 2;
            chart1.Series[3].BorderWidth = 2;


            var inData = clss;
            chart1.Series[0].Points.AddXY(3, 0+100);
            chart1.Series[1].Points.AddXY(3, 0+100);


            double miniHelp = 0;
            double [] ab = { 90, 70, 50, 30, 10};
            int i = 0;
            foreach (var en in inData)
            {
                //элементарные фракции
                chart1.Series[0].Points.AddXY(en.C2, -((en.C3-miniHelp)/2+miniHelp)+100);
                miniHelp = en.C3;
                //всплывшие фракции
                chart1.Series[1].Points.AddXY(en.C4, -en.C3+100);

                //потонувшие фракции
                chart1.Series[2].Points.AddXY(en.C6, -(100 - en.C5) + 100);

                //плотности
                if (i < 5)
                {
                    chart1.Series[3].Points.AddXY(ab[i], -en.C3+100);
                    i++;
                }
            }
            chart1.Series[2].Points.AddXY(96, -100+100);
            chart1.Series[0].Points.AddXY(96, -100+100);


            for (int j = 0; j < chart1.Series[0].Points.Count; j++)
            {
                DataPoint dp = chart1.Series[0].Points[j];
                dp.ToolTip = string.Format($"Кривая элементарных фракций - \nAd: {dp.XValue} Y: {-dp.YValues[0] + 100}");
            }
            for (int j = 0; j < chart1.Series[1].Points.Count; j++)
            {
                DataPoint dp = chart1.Series[1].Points[j];
                dp.ToolTip = string.Format($"Кривая всплывших фракций - \nAd: {dp.XValue} Y: {-dp.YValues[0] + 100}");
            }
            for (int j = 0; j < chart1.Series[2].Points.Count; j++)
            {
                DataPoint dp = chart1.Series[2].Points[j];
                dp.ToolTip = string.Format($"Кривая потонувших фракций - \nAd: {dp.XValue} Y: {-dp.YValues[0] + 100}");
            }
            for (int j = 0; j < chart1.Series[3].Points.Count; j++)
            {
                DataPoint dp = chart1.Series[3].Points[j];
                dp.ToolTip = string.Format($"Кривая плотности - \nAd: {dp.XValue} Y: {-dp.YValues[0] + 100}");
            }

        }



    private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            switch (e.HitTestResult.ChartElementType)
            {
                case ChartElementType.Axis:
                case ChartElementType.TickMarks:
                    HitTestResult result = chart1.HitTest(e.X, e.Y, ChartElementType.DataPoint);
                    if (result.ChartElementType == ChartElementType.DataPoint)
                    {
                        e.Text = result.Series.Points[result.PointIndex].ToolTip;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
