namespace MiningProject
{
    partial class DialogLayer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGV_Layer = new System.Windows.Forms.DataGridView();
            this.OK_B_Layer = new System.Windows.Forms.Button();
            this.Cancel_B_Layer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBLayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Layer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dGV_Layer);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 299);
            this.panel1.TabIndex = 0;
            // 
            // dGV_Layer
            // 
            this.dGV_Layer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Layer.Location = new System.Drawing.Point(3, 25);
            this.dGV_Layer.Name = "dGV_Layer";
            this.dGV_Layer.Size = new System.Drawing.Size(732, 271);
            this.dGV_Layer.TabIndex = 0;
            this.dGV_Layer.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGV_Layer_CellPainting);
            this.dGV_Layer.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dGV_Layer_ColumnWidthChanged);
            this.dGV_Layer.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dGV_Layer_EditingControlShowing);
            this.dGV_Layer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dGV_Layer_Scroll);
            this.dGV_Layer.Paint += new System.Windows.Forms.PaintEventHandler(this.dGV_Layer_Paint);
            this.dGV_Layer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dGV_Layer_KeyUp);
            // 
            // OK_B_Layer
            // 
            this.OK_B_Layer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B_Layer.Location = new System.Drawing.Point(551, 317);
            this.OK_B_Layer.Name = "OK_B_Layer";
            this.OK_B_Layer.Size = new System.Drawing.Size(75, 23);
            this.OK_B_Layer.TabIndex = 1;
            this.OK_B_Layer.Text = "ОК";
            this.OK_B_Layer.UseVisualStyleBackColor = true;
            // 
            // Cancel_B_Layer
            // 
            this.Cancel_B_Layer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B_Layer.Location = new System.Drawing.Point(672, 317);
            this.Cancel_B_Layer.Name = "Cancel_B_Layer";
            this.Cancel_B_Layer.Size = new System.Drawing.Size(75, 23);
            this.Cancel_B_Layer.TabIndex = 2;
            this.Cancel_B_Layer.Text = "Отмена";
            this.Cancel_B_Layer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя пласта:";
            // 
            // tBLayerName
            // 
            this.tBLayerName.Location = new System.Drawing.Point(319, 318);
            this.tBLayerName.Name = "tBLayerName";
            this.tBLayerName.Size = new System.Drawing.Size(226, 20);
            this.tBLayerName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Итого:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 317);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(53, 20);
            this.textBox2.TabIndex = 7;
            // 
            // DialogLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 356);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBLayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_B_Layer);
            this.Controls.Add(this.OK_B_Layer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DialogLayer";
            this.Text = "Layer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogLayer_FormClosing);
            this.Load += new System.EventHandler(this.DialogLayer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Layer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dGV_Layer;
        private System.Windows.Forms.Button OK_B_Layer;
        private System.Windows.Forms.Button Cancel_B_Layer;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox tBLayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}