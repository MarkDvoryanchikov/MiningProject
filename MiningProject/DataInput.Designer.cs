namespace MiningProject
{
    partial class DataInput
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
            this.dGVTasks = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cB_Layer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Del_B_Layer = new System.Windows.Forms.Button();
            this.Edit_B_Layer = new System.Windows.Forms.Button();
            this.dGVLayers = new System.Windows.Forms.DataGridView();
            this.Add_B_Layer = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBTask = new System.Windows.Forms.TextBox();
            this.Del_B = new System.Windows.Forms.Button();
            this.Edit_B = new System.Windows.Forms.Button();
            this.Add_B = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTasks)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLayers)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVTasks
            // 
            this.dGVTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTasks.Location = new System.Drawing.Point(6, 19);
            this.dGVTasks.Name = "dGVTasks";
            this.dGVTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVTasks.Size = new System.Drawing.Size(510, 118);
            this.dGVTasks.TabIndex = 0;
            this.dGVTasks.CurrentCellChanged += new System.EventHandler(this.dGVTasks_CurrentCellChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.GroupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 494);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cB_Layer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Del_B_Layer);
            this.groupBox2.Controls.Add(this.Edit_B_Layer);
            this.groupBox2.Controls.Add(this.dGVLayers);
            this.groupBox2.Controls.Add(this.Add_B_Layer);
            this.groupBox2.Location = new System.Drawing.Point(3, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 316);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пласты";
            // 
            // cB_Layer
            // 
            this.cB_Layer.FormattingEnabled = true;
            this.cB_Layer.Location = new System.Drawing.Point(90, 12);
            this.cB_Layer.Name = "cB_Layer";
            this.cB_Layer.Size = new System.Drawing.Size(278, 21);
            this.cB_Layer.TabIndex = 5;
            this.cB_Layer.SelectedIndexChanged += new System.EventHandler(this.cB_Layer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выбор пласта";
            // 
            // Del_B_Layer
            // 
            this.Del_B_Layer.Location = new System.Drawing.Point(572, 11);
            this.Del_B_Layer.Name = "Del_B_Layer";
            this.Del_B_Layer.Size = new System.Drawing.Size(93, 23);
            this.Del_B_Layer.TabIndex = 2;
            this.Del_B_Layer.Text = "Удалить";
            this.Del_B_Layer.UseVisualStyleBackColor = true;
            this.Del_B_Layer.Click += new System.EventHandler(this.Del_B_Layer_Click);
            // 
            // Edit_B_Layer
            // 
            this.Edit_B_Layer.Location = new System.Drawing.Point(473, 11);
            this.Edit_B_Layer.Name = "Edit_B_Layer";
            this.Edit_B_Layer.Size = new System.Drawing.Size(93, 23);
            this.Edit_B_Layer.TabIndex = 1;
            this.Edit_B_Layer.Text = "Изменить";
            this.Edit_B_Layer.UseVisualStyleBackColor = true;
            this.Edit_B_Layer.Click += new System.EventHandler(this.Edit_B_Layer_Click);
            // 
            // dGVLayers
            // 
            this.dGVLayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLayers.Location = new System.Drawing.Point(6, 40);
            this.dGVLayers.Name = "dGVLayers";
            this.dGVLayers.ReadOnly = true;
            this.dGVLayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVLayers.Size = new System.Drawing.Size(728, 270);
            this.dGVLayers.TabIndex = 0;
            this.dGVLayers.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGVLayers_CellPainting);
            this.dGVLayers.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dGVLayers_ColumnWidthChanged);
            this.dGVLayers.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dGVLayers_Scroll);
            this.dGVLayers.Paint += new System.Windows.Forms.PaintEventHandler(this.dGVLayers_Paint);
            // 
            // Add_B_Layer
            // 
            this.Add_B_Layer.Location = new System.Drawing.Point(374, 11);
            this.Add_B_Layer.Name = "Add_B_Layer";
            this.Add_B_Layer.Size = new System.Drawing.Size(93, 23);
            this.Add_B_Layer.TabIndex = 0;
            this.Add_B_Layer.Text = "Добавить";
            this.Add_B_Layer.UseVisualStyleBackColor = true;
            this.Add_B_Layer.Click += new System.EventHandler(this.Add_B_Layer_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.TBTask);
            this.GroupBox1.Controls.Add(this.Del_B);
            this.GroupBox1.Controls.Add(this.Edit_B);
            this.GroupBox1.Controls.Add(this.dGVTasks);
            this.GroupBox1.Controls.Add(this.Add_B);
            this.GroupBox1.Location = new System.Drawing.Point(3, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(740, 149);
            this.GroupBox1.TabIndex = 17;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Задачи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название задачи";
            // 
            // TBTask
            // 
            this.TBTask.Location = new System.Drawing.Point(525, 30);
            this.TBTask.Name = "TBTask";
            this.TBTask.Size = new System.Drawing.Size(203, 20);
            this.TBTask.TabIndex = 3;
            this.TBTask.TextChanged += new System.EventHandler(this.TBTask_TextChanged);
            // 
            // Del_B
            // 
            this.Del_B.Location = new System.Drawing.Point(595, 114);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(133, 23);
            this.Del_B.TabIndex = 2;
            this.Del_B.Text = "Удалить";
            this.Del_B.UseVisualStyleBackColor = true;
            this.Del_B.Click += new System.EventHandler(this.Del_B_Click);
            // 
            // Edit_B
            // 
            this.Edit_B.Location = new System.Drawing.Point(595, 85);
            this.Edit_B.Name = "Edit_B";
            this.Edit_B.Size = new System.Drawing.Size(133, 23);
            this.Edit_B.TabIndex = 1;
            this.Edit_B.Text = "Изменить";
            this.Edit_B.UseVisualStyleBackColor = true;
            this.Edit_B.Click += new System.EventHandler(this.Edit_B_Click);
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(595, 56);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(133, 23);
            this.Add_B.TabIndex = 0;
            this.Add_B.Text = "Добавить";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.button1.Location = new System.Drawing.Point(668, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DataInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 518);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DataInput";
            this.Text = "DataInput";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataInput_FormClosing);
            this.Load += new System.EventHandler(this.DataInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTasks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLayers)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVTasks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button Del_B;
        private System.Windows.Forms.Button Edit_B;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBTask;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Del_B_Layer;
        private System.Windows.Forms.Button Edit_B_Layer;
        private System.Windows.Forms.DataGridView dGVLayers;
        private System.Windows.Forms.Button Add_B_Layer;
        private System.Windows.Forms.ComboBox cB_Layer;
    }
}