namespace MiningProject
{
    partial class DialogLayerCalc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGV_Layer = new System.Windows.Forms.DataGridView();
            this.Cancel_B_Layer = new System.Windows.Forms.Button();
            this.OK_B_Layer = new System.Windows.Forms.Button();
            this.tBClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Layer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dGV_Layer);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 232);
            this.panel1.TabIndex = 1;
            // 
            // dGV_Layer
            // 
            this.dGV_Layer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Layer.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Layer.Location = new System.Drawing.Point(3, 25);
            this.dGV_Layer.Name = "dGV_Layer";
            this.dGV_Layer.Size = new System.Drawing.Size(683, 204);
            this.dGV_Layer.TabIndex = 0;
            this.dGV_Layer.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGV_Layer_CellPainting);
            this.dGV_Layer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Layer_CellValueChanged);
            this.dGV_Layer.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dGV_Layer_ColumnWidthChanged);
            this.dGV_Layer.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dGV_Layer_EditingControlShowing);
            this.dGV_Layer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dGV_Layer_Scroll);
            this.dGV_Layer.Paint += new System.Windows.Forms.PaintEventHandler(this.dGV_Layer_Paint);
            // 
            // Cancel_B_Layer
            // 
            this.Cancel_B_Layer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B_Layer.Location = new System.Drawing.Point(626, 250);
            this.Cancel_B_Layer.Name = "Cancel_B_Layer";
            this.Cancel_B_Layer.Size = new System.Drawing.Size(75, 23);
            this.Cancel_B_Layer.TabIndex = 3;
            this.Cancel_B_Layer.Text = "Отмена";
            this.Cancel_B_Layer.UseVisualStyleBackColor = true;
            // 
            // OK_B_Layer
            // 
            this.OK_B_Layer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B_Layer.Location = new System.Drawing.Point(545, 250);
            this.OK_B_Layer.Name = "OK_B_Layer";
            this.OK_B_Layer.Size = new System.Drawing.Size(75, 23);
            this.OK_B_Layer.TabIndex = 4;
            this.OK_B_Layer.Text = "ОК";
            this.OK_B_Layer.UseVisualStyleBackColor = true;
            // 
            // tBClass
            // 
            this.tBClass.Location = new System.Drawing.Point(117, 252);
            this.tBClass.Name = "tBClass";
            this.tBClass.Size = new System.Drawing.Size(217, 20);
            this.tBClass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название класса:";
            // 
            // DialogLayerCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBClass);
            this.Controls.Add(this.OK_B_Layer);
            this.Controls.Add(this.Cancel_B_Layer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DialogLayerCalc";
            this.Text = "DialogLayerCalc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogLayerCalc_FormClosing);
            this.Load += new System.EventHandler(this.DialogLayerCalc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Layer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dGV_Layer;
        private System.Windows.Forms.Button Cancel_B_Layer;
        private System.Windows.Forms.Button OK_B_Layer;
        internal System.Windows.Forms.TextBox tBClass;
        private System.Windows.Forms.Label label1;
    }
}