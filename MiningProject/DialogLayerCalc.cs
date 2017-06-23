using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiningProject.Models;


namespace MiningProject
{
    public partial class DialogLayerCalc : Form
    {
        public DialogLayerCalc()
        {
            InitializeComponent();
        }

        string[,] array = new string[14, 9];
        string p;

        public DialogLayerCalc(List<LayersCalculation> change, string name)
        {
            var ch = change;

            for (int i = 0; i < 6; i++)
            {
                array[0, i] = ch[i].C1.ToString();
                array[1, i] = ch[i].C2.ToString();
                array[2, i] = ch[i].C3.ToString();
                array[3, i] = ch[i].C4.ToString();
                array[4, i] = ch[i].C5.ToString();
                array[5, i] = ch[i].C6.ToString();
            }
            p = name;

            InitializeComponent();
        }


        private void DialogLayerCalc_Load(object sender, EventArgs e)
        {
            dGV_Layer.Columns.Add("col1", "Y");
            dGV_Layer.Columns.Add("col2", "Ad");
            dGV_Layer.Columns.Add("col3", "Y");
            dGV_Layer.Columns.Add("col4", "Ad");
            dGV_Layer.Columns.Add("col5", "Y");
            dGV_Layer.Columns.Add("col6", "Ad");

            dGV_Layer.RowCount = 7;
            dGV_Layer.AllowUserToAddRows = false;
            dGV_Layer.RowHeadersWidth = 80;
            dGV_Layer.Rows[0].HeaderCell.Value = "<1,3";
            dGV_Layer.Rows[1].HeaderCell.Value = "1,3-1,4";
            dGV_Layer.Rows[2].HeaderCell.Value = "1,4-1,5";
            dGV_Layer.Rows[3].HeaderCell.Value = "1,5-1,6";
            dGV_Layer.Rows[4].HeaderCell.Value = "1,6-1,8";
            dGV_Layer.Rows[5].HeaderCell.Value = ">1,8";

            for (var j = 0; j < 6; j++)
            {
                for (var i = 2; i < 6; i++)
                {
                    dGV_Layer.Rows[j].Cells[i].Style.BackColor = Color.AliceBlue;
                    dGV_Layer.Rows[j].Cells[i].ReadOnly = true;
                }
            }

            try
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                        dGV_Layer[j, i].Value = array[j, i];
                }
                tBClass.Text = p;
            }
            catch { }

            foreach (DataGridViewColumn column in dGV_Layer.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dGV_Layer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dGV_Layer.ColumnHeadersHeight = dGV_Layer.ColumnHeadersHeight * 3;
            dGV_Layer.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dGV_Layer.CellPainting += new DataGridViewCellPaintingEventHandler(dGV_Layer_CellPainting);
            dGV_Layer.Paint += new PaintEventHandler(dGV_Layer_Paint);

            dGV_Layer.Scroll += new ScrollEventHandler(dGV_Layer_Scroll);
            dGV_Layer.ColumnWidthChanged += new DataGridViewColumnEventHandler(dGV_Layer_ColumnWidthChanged);

        }

        private void dGV_Layer_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dGV_Layer_Paint(object sender, PaintEventArgs e)
        {
            string first = "Суммарные фракции";

            string[] second = { "Элементарные", "Всплывшие", "Потонувшие" };
            for (int j = 0; j < dGV_Layer.ColumnCount;)
            {
                var r1 = dGV_Layer.GetCellDisplayRectangle(j, -1, true);
                int w2 = dGV_Layer.GetCellDisplayRectangle(j + 1, -1, true).Width;
                r1.X += 1;
                r1.Y += dGV_Layer.ColumnHeadersHeight / 3;
                r1.Width = r1.Width + w2 - 2;
                r1.Height = r1.Height / 3 - 2;
                if (j == 0)
                {
                    r1.Y = 3;
                    r1.Height = r1.Height * 2;
                }
                e.Graphics.FillRectangle(new SolidBrush(dGV_Layer.ColumnHeadersDefaultCellStyle.BackColor), r1);
                var format = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(second[j / 2],
                dGV_Layer.ColumnHeadersDefaultCellStyle.Font,
                new SolidBrush(dGV_Layer.ColumnHeadersDefaultCellStyle.ForeColor), r1, format);
                j += 2;
            }

            var r0 = dGV_Layer.GetCellDisplayRectangle(2, -1, true);
            int w0 = 0;
            for (int i = 3; i < dGV_Layer.ColumnCount; i++)
            {
                w0 += dGV_Layer.GetCellDisplayRectangle(i, -1, true).Width;
            }
            r0.X += 1;
            r0.Y += 2;
            r0.Width = r0.Width + w0 - 2;
            r0.Height = r0.Height / 3 - 3;
            e.Graphics.FillRectangle(new SolidBrush(dGV_Layer.ColumnHeadersDefaultCellStyle.BackColor), r0);
            var format0 = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            e.Graphics.DrawString(first, dGV_Layer.ColumnHeadersDefaultCellStyle.Font,
            new SolidBrush(dGV_Layer.ColumnHeadersDefaultCellStyle.ForeColor), r0, format0);
        }

        private void dGV_Layer_Scroll(object sender, ScrollEventArgs e)
        {
            var rtHeader = dGV_Layer.DisplayRectangle;
            rtHeader.Height = dGV_Layer.ColumnHeadersHeight / 3 * 2;
            dGV_Layer.Invalidate(rtHeader);
        }

        private void dGV_Layer_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            var rtHeader = dGV_Layer.DisplayRectangle;
            rtHeader.Height = dGV_Layer.ColumnHeadersHeight / 3 * 2;    //Заголовки занимают 2/3 высоты header
            dGV_Layer.Invalidate(rtHeader);
        }

        private void DialogLayerCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    double x;

                    for (var i = 0; i < 6; i++)
                    {
                        for (var j = 0; j < 6; j++)
                        {
                            if (dGV_Layer.Rows[j].Cells[i].Value == null)
                                throw new Exception("Заполните все поля таблицы");
                            else if (!double.TryParse(dGV_Layer.Rows[j].Cells[i].Value.ToString(), out x))
                                throw new Exception("Все значения должны быть числами");
                        }
                    }

                    if (tBClass.Text == "")
                    {
                        throw new Exception("Введите название класса");
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

        private void dGV_Layer_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(OnlyDigits);
        }


        private void OnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                if ((e.KeyChar != (char)Keys.Back) || (e.KeyChar != (char)Keys.Delete))
                { e.Handled = true; }
            }

        }

        private void dGV_Layer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            #region Суммарные всплывшие фракции
            try
            {
                dGV_Layer[2, 0].Value = Convert.ToDouble(dGV_Layer[0, 0].Value);
                dGV_Layer[2, 0].Style.BackColor = Color.AliceBlue;
            }
            catch
            {
                dGV_Layer[2, 0].Style.BackColor = Color.Pink;
            }
            for (var i = 1; i < 6; i++)
            {
                try
                {
                    dGV_Layer[2, i].Value = Convert.ToDouble(dGV_Layer[0, i].Value) + Convert.ToDouble(dGV_Layer[2, i - 1].Value);
                    dGV_Layer[2, i].Style.BackColor = Color.AliceBlue;
                }
                catch
                {
                    dGV_Layer[2, i].Style.BackColor = Color.Pink;
                }
            }
            try
            {
                dGV_Layer[3, 0].Value = Convert.ToDouble(dGV_Layer[1, 0].Value);
                dGV_Layer[3, 0].Style.BackColor = Color.AliceBlue;
            }
            catch
            {
                dGV_Layer[3, 0].Style.BackColor = Color.Pink;
            }
            for (var i = 1; i < 6; i++)
            {
                try
                {
                    dGV_Layer[3, i].Value =
                        (
                            (Convert.ToDouble(dGV_Layer[0, i - 1].Value) * Convert.ToDouble(dGV_Layer[1, i - 1].Value))                                                     
                        + 
                            (Convert.ToDouble(dGV_Layer[0, i].Value) * Convert.ToDouble(dGV_Layer[1, i].Value)
                            
                            )
                        )
                        /
                        (
                        Convert.ToDouble(dGV_Layer[0, i - 1].Value) + Convert.ToDouble(dGV_Layer[0, i].Value) 
                        );

                    dGV_Layer[3, i].Style.BackColor = Color.AliceBlue;
                }
                catch
                {
                    dGV_Layer[3, i].Style.BackColor = Color.Pink;
                }
            }
            #endregion

            #region Суммарные потонувшие фракции
            try
            {
                dGV_Layer[4, 5].Value = Convert.ToDouble(dGV_Layer[0, 5].Value);
                dGV_Layer[4, 5].Style.BackColor = Color.AliceBlue;
            }
            catch
            {
                dGV_Layer[4, 5].Style.BackColor = Color.Pink;
            }
            for (var i = 4; i > -1; i--)
            {
                try
                {
                    dGV_Layer[4, i].Value = Convert.ToDouble(dGV_Layer[4, i+1].Value) + Convert.ToDouble(dGV_Layer[0, i].Value);
                    dGV_Layer[4, i].Style.BackColor = Color.AliceBlue;
                }
                catch
                {
                    dGV_Layer[4, i].Style.BackColor = Color.Pink;
                }
            }

            try
            {
                dGV_Layer[5, 5].Value = Convert.ToDouble(dGV_Layer[1, 5].Value);
                dGV_Layer[5, 5].Style.BackColor = Color.AliceBlue;
            }
            catch
            {
                dGV_Layer[5, 5].Style.BackColor = Color.Pink;
            }
            for (var i = 4; i > -1; i--)
            {
                try
                {
                    dGV_Layer[5, i].Value =
                        (
                            (Convert.ToDouble(dGV_Layer[4, i + 1].Value) * Convert.ToDouble(dGV_Layer[5, i + 1].Value))
                        +
                            (Convert.ToDouble(dGV_Layer[0, i].Value) * Convert.ToDouble(dGV_Layer[1, i].Value))
                        )
                        /
                        (
                            Convert.ToDouble(dGV_Layer[4, i].Value)
                        );

                    dGV_Layer[5, i].Style.BackColor = Color.AliceBlue;
                }
                catch
                {
                    dGV_Layer[5, i].Style.BackColor = Color.Pink;
                }
            }
            #endregion; 
        }
    }
}
