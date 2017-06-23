namespace MiningProject
{
    partial class CurvCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.Del_B_Class = new System.Windows.Forms.Button();
            this.Edit_B_Class = new System.Windows.Forms.Button();
            this.Add_B_Class = new System.Windows.Forms.Button();
            this.cB_Layer = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGVLC = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Del_B = new System.Windows.Forms.Button();
            this.Edit_B = new System.Windows.Forms.Button();
            this.Add_B = new System.Windows.Forms.Button();
            this.dGVCalcs = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVTasks = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLC)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCalcs)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Del_B_Class);
            this.panel1.Controls.Add(this.Edit_B_Class);
            this.panel1.Controls.Add(this.Add_B_Class);
            this.panel1.Controls.Add(this.cB_Layer);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.GroupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 512);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(536, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(437, 330);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Выбор класса:";
            // 
            // Del_B_Class
            // 
            this.Del_B_Class.Location = new System.Drawing.Point(533, 486);
            this.Del_B_Class.Name = "Del_B_Class";
            this.Del_B_Class.Size = new System.Drawing.Size(128, 23);
            this.Del_B_Class.TabIndex = 23;
            this.Del_B_Class.Text = "Удалить";
            this.Del_B_Class.UseVisualStyleBackColor = true;
            this.Del_B_Class.Click += new System.EventHandler(this.Del_B_Class_Click);
            // 
            // Edit_B_Class
            // 
            this.Edit_B_Class.Location = new System.Drawing.Point(533, 457);
            this.Edit_B_Class.Name = "Edit_B_Class";
            this.Edit_B_Class.Size = new System.Drawing.Size(128, 23);
            this.Edit_B_Class.TabIndex = 22;
            this.Edit_B_Class.Text = "Изменить";
            this.Edit_B_Class.UseVisualStyleBackColor = true;
            this.Edit_B_Class.Click += new System.EventHandler(this.Edit_B_Class_Click);
            // 
            // Add_B_Class
            // 
            this.Add_B_Class.Location = new System.Drawing.Point(533, 428);
            this.Add_B_Class.Name = "Add_B_Class";
            this.Add_B_Class.Size = new System.Drawing.Size(128, 23);
            this.Add_B_Class.TabIndex = 21;
            this.Add_B_Class.Text = "Добавить";
            this.Add_B_Class.UseVisualStyleBackColor = true;
            this.Add_B_Class.Click += new System.EventHandler(this.Add_B_Class_Click);
            // 
            // cB_Layer
            // 
            this.cB_Layer.FormattingEnabled = true;
            this.cB_Layer.Location = new System.Drawing.Point(533, 401);
            this.cB_Layer.Name = "cB_Layer";
            this.cB_Layer.Size = new System.Drawing.Size(240, 21);
            this.cB_Layer.TabIndex = 6;
            this.cB_Layer.SelectedIndexChanged += new System.EventHandler(this.cB_Layer_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dGVLC);
            this.groupBox3.Location = new System.Drawing.Point(3, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 227);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Классы";
            // 
            // dGVLC
            // 
            this.dGVLC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLC.Location = new System.Drawing.Point(8, 19);
            this.dGVLC.Name = "dGVLC";
            this.dGVLC.ReadOnly = true;
            this.dGVLC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVLC.Size = new System.Drawing.Size(510, 202);
            this.dGVLC.TabIndex = 0;
            this.dGVLC.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGVLC_CellPainting);
            this.dGVLC.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dGVLC_ColumnWidthChanged);
            this.dGVLC.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dGVLC_Scroll);
            this.dGVLC.Paint += new System.Windows.Forms.PaintEventHandler(this.dGVLC_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Del_B);
            this.groupBox2.Controls.Add(this.Edit_B);
            this.groupBox2.Controls.Add(this.Add_B);
            this.groupBox2.Controls.Add(this.dGVCalcs);
            this.groupBox2.Location = new System.Drawing.Point(3, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 155);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расчеты";
            // 
            // Del_B
            // 
            this.Del_B.Location = new System.Drawing.Point(388, 11);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(128, 23);
            this.Del_B.TabIndex = 3;
            this.Del_B.Text = "Удалить";
            this.Del_B.UseVisualStyleBackColor = true;
            this.Del_B.Click += new System.EventHandler(this.Del_B_Click);
            // 
            // Edit_B
            // 
            this.Edit_B.Location = new System.Drawing.Point(254, 11);
            this.Edit_B.Name = "Edit_B";
            this.Edit_B.Size = new System.Drawing.Size(128, 23);
            this.Edit_B.TabIndex = 2;
            this.Edit_B.Text = "Изменить";
            this.Edit_B.UseVisualStyleBackColor = true;
            this.Edit_B.Click += new System.EventHandler(this.Edit_B_Click);
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(120, 11);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(128, 23);
            this.Add_B.TabIndex = 1;
            this.Add_B.Text = "Добавить";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // dGVCalcs
            // 
            this.dGVCalcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCalcs.Location = new System.Drawing.Point(6, 40);
            this.dGVCalcs.Name = "dGVCalcs";
            this.dGVCalcs.ReadOnly = true;
            this.dGVCalcs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVCalcs.Size = new System.Drawing.Size(510, 103);
            this.dGVCalcs.TabIndex = 0;
            this.dGVCalcs.CurrentCellChanged += new System.EventHandler(this.dGVCalcs_CurrentCellChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.dGVTasks);
            this.GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(524, 134);
            this.GroupBox1.TabIndex = 18;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Задачи";
            // 
            // dGVTasks
            // 
            this.dGVTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTasks.Location = new System.Drawing.Point(6, 19);
            this.dGVTasks.Name = "dGVTasks";
            this.dGVTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVTasks.Size = new System.Drawing.Size(510, 103);
            this.dGVTasks.TabIndex = 0;
            this.dGVTasks.CurrentCellChanged += new System.EventHandler(this.dGVTasks_CurrentCellChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.button1.Location = new System.Drawing.Point(898, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CurvCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 536);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CurvCalc";
            this.Text = "CurvCalc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CurvCalc_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCalcs)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.DataGridView dGVTasks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGVCalcs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dGVLC;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Edit_B;
        private System.Windows.Forms.Button Del_B;
        private System.Windows.Forms.ComboBox cB_Layer;
        private System.Windows.Forms.Button Del_B_Class;
        private System.Windows.Forms.Button Edit_B_Class;
        private System.Windows.Forms.Button Add_B_Class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}