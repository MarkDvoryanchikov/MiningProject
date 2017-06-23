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
    public partial class DataInput : Form
    {
        public DataInput()
        {
            InitializeComponent();
        }
        private EFRepository repository = new EFRepository();
        int currow = 0;

        private void DataInput_Load(object sender, EventArgs e)
        {
            LoadTasks();
            LoadTasks();
            Add_B.Enabled = false;
            Edit_B.Enabled = false;

            dGVTasks_CurrentCellChanged(sender, e);
        }

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
                Del_B.Enabled = true;
            }
            else Del_B.Enabled = false;
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            try
            {
                repository.AddMyTask(new MyTask()
                {
                    TaskName = TBTask.Text,
                    Time = DateTime.Now,
                });
                TBTask.Text = "";
                LoadTasks();
            }
            catch
            {
                MessageBox.Show("Для создания введите имя задачи", "Ошибка");
            }
         }

        private void Edit_B_Click(object sender, EventArgs e)
        {
            try
            {
                var mytask = dGVTasks.CurrentRow.DataBoundItem as MyTask;
                repository.AddMyTask(new MyTask()
                {
                    PK_Task = mytask.PK_Task,
                    TaskName = TBTask.Text,
                    Time = mytask.Time,
                });
                currow = dGVTasks.CurrentRow.Index;
                TBTask.Text = "";
                LoadTasks();
            }
            catch
            {
                if (TBTask != null)
                    MessageBox.Show("Для изменения не выбрано новое имя задачи", "Ошибка");
                else
                    MessageBox.Show("Для изменения отсутствует выделенная задача", "Ошибка");
            }
        }

        private void Del_B_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить выбранную задачу? Все связанные с ней расчеты также будут удалены.", "Удаление задачи", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var del = dGVTasks.CurrentRow.DataBoundItem as MyTask;
                    repository.RemoveMyTask(del);
                    LoadTasks();
                }
                catch
                {
                    //MessageBox.Show("Для удаления отсутствует выделенная задача", "Ошибка");
                }
            }
        }

        private void TBTask_TextChanged(object sender, EventArgs e)
        {
            if (TBTask.Text != "")
            {
                Add_B.Enabled = true;
                Edit_B.Enabled = true;
            }
            else
            {
                Add_B.Enabled = false;
                Edit_B.Enabled = false;
            }
        }

        /// <summary>
        /// Работа с пластами угля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void Add_B_Layer_Click(object sender, EventArgs e)
        {
            DialogLayer Dialog = new DialogLayer()
            {
                Text = "Создание пласта"
            };
            var mytask = dGVTasks.CurrentRow.DataBoundItem as MyTask;
            int numLayer;
            try ////////////////////Некрасиво /переделать
            {
                numLayer = repository.Layers.Where(c => c.MyTask == mytask.PK_Task).Max(a => a.Numberlayer);
            }
            catch
            {
                numLayer = 0;
            }
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(Dialog.dGV_Layer.Rows[0].Cells[0].Value.ToString());
                repository.AddLayer(new Layer()
                {
                    MyTask = mytask.PK_Task,
                    Numberlayer = numLayer + 1,
                    NameLayer = Dialog.tBLayerName.Text,
                    C1 = Convert.ToDouble(Dialog.dGV_Layer.Rows[0].Cells[0].Value.ToString()),
                    C2 = Convert.ToDouble(Dialog.dGV_Layer.Rows[0].Cells[1].Value.ToString()),
                });
                
                for (var i = 1; i < 8; i++)
                {
                    repository.AddLayer(new Layer()
                    {
                        MyTask = mytask.PK_Task,
                        Numberlayer = numLayer + 1,
                        NameLayer = Dialog.tBLayerName.Text,
                        C1 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[0].Value.ToString()),
                        C2 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[1].Value.ToString()),
                        C3 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[2].Value.ToString()),
                        C4 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[3].Value.ToString()),
                        C5 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[4].Value.ToString()),
                        C6 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[5].Value.ToString()),
                        C7 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[6].Value.ToString()),
                        C8 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[7].Value.ToString()),
                        C9 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[8].Value.ToString()),
                        C10 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[9].Value.ToString()),
                        C11 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[10].Value.ToString()),
                        C12 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[11].Value.ToString()),
                        C13 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[12].Value.ToString()),
                        C14 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[13].Value.ToString()),
                    });
                }
                
                repository.AddLayer(new Layer()
                {
                    MyTask = mytask.PK_Task,
                    Numberlayer = numLayer + 1,
                    NameLayer = Dialog.tBLayerName.Text,
                    C1 = Convert.ToDouble(Dialog.dGV_Layer.Rows[8].Cells[0].Value.ToString()),
                    C2 = Convert.ToDouble(Dialog.dGV_Layer.Rows[8].Cells[1].Value.ToString()),
                });
            }
            dGVTasks_CurrentCellChanged(sender, e);
        }

        private void Edit_B_Layer_Click(object sender, EventArgs e)
        {
            try
            {
                var nameChange = cB_Layer.Text;
                var change = repository.Layers.Where(n => n.NameLayer == nameChange).ToList();

                DialogLayer Dialog = new DialogLayer(change, nameChange)
                {
                    Text = "Изменение пласта"
                };
                
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(Dialog.dGV_Layer.Rows[0].Cells[0].Value.ToString());
                    repository.AddLayer(new Layer()
                    {
                        PK_Layer = change[0].PK_Layer,
                        MyTask = change[0].MyTask,
                        Numberlayer = change[0].Numberlayer,
                        NameLayer = Dialog.tBLayerName.Text,
                        C1 = Convert.ToDouble(Dialog.dGV_Layer.Rows[0].Cells[0].Value.ToString()),
                        C2 = Convert.ToDouble(Dialog.dGV_Layer.Rows[0].Cells[1].Value.ToString()),
                    });

                    for (var i = 1; i < 8; i++)
                    {
                        repository.AddLayer(new Layer()
                        {
                            PK_Layer = change[i].PK_Layer,
                            MyTask = change[i].MyTask,
                            Numberlayer = change[i].Numberlayer,
                            NameLayer = Dialog.tBLayerName.Text,
                            C1 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[0].Value.ToString()),
                            C2 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[1].Value.ToString()),
                            C3 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[2].Value.ToString()),
                            C4 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[3].Value.ToString()),
                            C5 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[4].Value.ToString()),
                            C6 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[5].Value.ToString()),
                            C7 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[6].Value.ToString()),
                            C8 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[7].Value.ToString()),
                            C9 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[8].Value.ToString()),
                            C10 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[9].Value.ToString()),
                            C11 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[10].Value.ToString()),
                            C12 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[11].Value.ToString()),
                            C13 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[12].Value.ToString()),
                            C14 = Convert.ToDouble(Dialog.dGV_Layer.Rows[i].Cells[13].Value.ToString()),
                        });
                    }

                    repository.AddLayer(new Layer()
                    {
                        PK_Layer = change[8].PK_Layer,
                        MyTask = change[8].MyTask,
                        Numberlayer = change[8].Numberlayer,
                        NameLayer = Dialog.tBLayerName.Text,
                        C1 = Convert.ToDouble(Dialog.dGV_Layer.Rows[8].Cells[0].Value.ToString()),
                        C2 = Convert.ToDouble(Dialog.dGV_Layer.Rows[8].Cells[1].Value.ToString()),
                    });
                }
                dGVTasks_CurrentCellChanged(sender, e);
            }
            catch
            {
                MessageBox.Show("Не получилось изменить угольный пласт", "Ошибка");
            }
        }

        private void Del_B_Layer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить выбранный угольный пласт? Связанные с ним расчеты фракционного анализа будут также удалены.", "Удаление угольного пласта", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var nameDel = cB_Layer.Text;
                    var del = repository.Layers.Where(n => n.NameLayer == nameDel).ToList();
                    foreach (var d in del)
                        repository.RemoveLayer(d);
                    dGVTasks_CurrentCellChanged(sender, e);
                }
                catch
                {
                    //MessageBox.Show("Для удаления отсутствует выделенная задача", "Ошибка");
                }
            }
        }

        private void cB_Layer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLayer();
        }

        private void LoadLayer()
        {
            dGVLayers.DataSource = repository.Layers.Where(c=>c.NameLayer == cB_Layer.Text).ToList();

            dGVLayers.Columns[5].HeaderCell.Value = "Y";
            dGVLayers.Columns[6].HeaderCell.Value = "Ad";
            dGVLayers.Columns[7].HeaderCell.Value = "Y";
            dGVLayers.Columns[8].HeaderCell.Value = "Ad";
            dGVLayers.Columns[9].HeaderCell.Value = "Y";
            dGVLayers.Columns[10].HeaderCell.Value = "Ad";
            dGVLayers.Columns[11].HeaderCell.Value = "Y";
            dGVLayers.Columns[12].HeaderCell.Value = "Ad";
            dGVLayers.Columns[13].HeaderCell.Value = "Y";
            dGVLayers.Columns[14].HeaderCell.Value = "Ad";
            dGVLayers.Columns[15].HeaderCell.Value = "Y";
            dGVLayers.Columns[16].HeaderCell.Value = "Ad";
            dGVLayers.Columns[17].HeaderCell.Value = "Y";
            dGVLayers.Columns[18].HeaderCell.Value = "Ad";

            dGVLayers.Columns[0].Visible = dGVLayers.Columns[1].Visible = dGVLayers.Columns[2].Visible
                = dGVLayers.Columns[3].Visible = dGVLayers.Columns[4].Visible = false;


            dGVLayers.AllowUserToAddRows = false;
            dGVLayers.RowHeadersWidth = 80;
            dGVLayers.Rows[0].HeaderCell.Value = ">100";
            dGVLayers.Rows[1].HeaderCell.Value = "50-100";
            dGVLayers.Rows[2].HeaderCell.Value = "25-50";
            dGVLayers.Rows[3].HeaderCell.Value = "13-25";
            dGVLayers.Rows[4].HeaderCell.Value = "6-13";
            dGVLayers.Rows[5].HeaderCell.Value = "3-6";
            dGVLayers.Rows[6].HeaderCell.Value = "1-3";
            dGVLayers.Rows[7].HeaderCell.Value = "0,5-1";
            dGVLayers.Rows[8].HeaderCell.Value = "0-0,5";


            for (var i = 7; i < 19; i++)
            {
                dGVLayers.Rows[0].Cells[i].Style.BackColor = Color.Pink;
                dGVLayers.Rows[0].Cells[i].ReadOnly = true;
                dGVLayers.Rows[8].Cells[i].Style.BackColor = Color.Pink;
                dGVLayers.Rows[8].Cells[i].ReadOnly = true;
            }

            dGVLayers.Columns[5].Width = 55;
            dGVLayers.Columns[6].Width = 55;
            for (var j = 5; j < dGVLayers.ColumnCount; j++)
            {

                dGVLayers.Columns[j].Width = 45;
            }


            foreach (DataGridViewColumn column in dGVLayers.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dGVLayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dGVLayers.ColumnHeadersHeight = 60;
            dGVLayers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dGVLayers.CellPainting += new DataGridViewCellPaintingEventHandler(dGVLayers_CellPainting);
            dGVLayers.Paint += new PaintEventHandler(dGVLayers_Paint);

            dGVLayers.Scroll += new ScrollEventHandler(dGVLayers_Scroll);
            dGVLayers.ColumnWidthChanged += new DataGridViewColumnEventHandler(dGVLayers_ColumnWidthChanged);
        }

        private void dGVTasks_CurrentCellChanged(object sender, EventArgs e)
        {

            if (dGVTasks.CurrentRow != null)
            {
                dGVLayers.Visible = true;
                var mytask = dGVTasks.CurrentRow.DataBoundItem as MyTask;
                var x = repository.Layers.Where(c => c.MyTask == mytask.PK_Task).GroupBy(i => i.NameLayer).Select(g => g.First()).Select(n => n.NameLayer).ToList();
                Edit_B_Layer.Enabled = true;
                Del_B_Layer.Enabled = true;
                cB_Layer.Enabled = true;
                cB_Layer.DataSource = x;
                if (x.Count() < 1)
                {
                    cB_Layer.Text = "";
                    dGVLayers.DataSource = new object();
                    Edit_B_Layer.Enabled = false;
                    Del_B_Layer.Enabled = false;
                    cB_Layer.Enabled = false;
                }
            }
        }

        private void dGVLayers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dGVLayers_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                string[] second = { "Ситовый состав", "<1.3", "1.3-1.4", "1.4-1.5", "1.5-1.6", "1.6-1.8", ">1.8" };
                for (int j = 5; j < dGVLayers.ColumnCount;)
                {
                    var r1 = dGVLayers.GetCellDisplayRectangle(j, -1, true);
                    int w2 = dGVLayers.GetCellDisplayRectangle(j + 1, -1, true).Width;
                    r1.X += 1;
                    r1.Y += dGVLayers.ColumnHeadersHeight / 3;
                    r1.Width = r1.Width + w2 - 2;
                    r1.Height = r1.Height / 3 - 2;
                    if (j == 5)
                    {
                        r1.Y = 3;
                        r1.Height = r1.Height * 2;
                    }
                    e.Graphics.FillRectangle(new SolidBrush(dGVLayers.ColumnHeadersDefaultCellStyle.BackColor), r1);
                    var format = new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    e.Graphics.DrawString(second[((j-5) / 2)],
                    dGVLayers.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(dGVLayers.ColumnHeadersDefaultCellStyle.ForeColor), r1, format);
                    j += 2;
                }
            }
            catch { }

            try
            {
                string first = "Фракционный состав";

                var r0 = dGVLayers.GetCellDisplayRectangle(7, -1, true);
                int w0 = 0;
                for (int i = 7; i < dGVLayers.ColumnCount-1; i++)
                {
                    w0 += dGVLayers.GetCellDisplayRectangle(i, -1, true).Width;
                }
                r0.X += 1;
                r0.Y += 2;
                r0.Width = r0.Width + w0 - 2;
                r0.Height = r0.Height / 3 - 3;
                e.Graphics.FillRectangle(new SolidBrush(dGVLayers.ColumnHeadersDefaultCellStyle.BackColor), r0);
                var format0 = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(first, dGVLayers.ColumnHeadersDefaultCellStyle.Font,
                new SolidBrush(dGVLayers.ColumnHeadersDefaultCellStyle.ForeColor), r0, format0);
            }
            catch { }
        }

        private void dGVLayers_Scroll(object sender, ScrollEventArgs e)
        {
            var rtHeader = dGVLayers.DisplayRectangle;
            rtHeader.Height = dGVLayers.ColumnHeadersHeight / 3 * 2;
            dGVLayers.Invalidate(rtHeader);
        }

        private void dGVLayers_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            var rtHeader = dGVLayers.DisplayRectangle;
            rtHeader.Height = dGVLayers.ColumnHeadersHeight / 3 * 2;    //Заголовки занимают 2/3 высоты header
            dGVLayers.Invalidate(rtHeader);
        }

        private void DataInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form main = Application.OpenForms[0];
            main.Show();
        }
    }
}
