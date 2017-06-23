namespace MiningProject
{
    partial class DialogCalc
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
            this.tBNameCalc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBCalcAuto = new System.Windows.Forms.CheckBox();
            this.OK_B_Layer = new System.Windows.Forms.Button();
            this.Cancel_B_Layer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBNameCalc
            // 
            this.tBNameCalc.Location = new System.Drawing.Point(12, 25);
            this.tBNameCalc.Name = "tBNameCalc";
            this.tBNameCalc.Size = new System.Drawing.Size(246, 20);
            this.tBNameCalc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название расчета:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // cBCalcAuto
            // 
            this.cBCalcAuto.AutoSize = true;
            this.cBCalcAuto.Location = new System.Drawing.Point(12, 58);
            this.cBCalcAuto.Name = "cBCalcAuto";
            this.cBCalcAuto.Size = new System.Drawing.Size(251, 30);
            this.cBCalcAuto.TabIndex = 3;
            this.cBCalcAuto.Text = "Построить таблицы расчета  фракционного \r\nанализа на основе имеющихся пластов";
            this.cBCalcAuto.UseVisualStyleBackColor = true;
            // 
            // OK_B_Layer
            // 
            this.OK_B_Layer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B_Layer.Location = new System.Drawing.Point(135, 117);
            this.OK_B_Layer.Name = "OK_B_Layer";
            this.OK_B_Layer.Size = new System.Drawing.Size(75, 23);
            this.OK_B_Layer.TabIndex = 4;
            this.OK_B_Layer.Text = "ОК";
            this.OK_B_Layer.UseVisualStyleBackColor = true;
            // 
            // Cancel_B_Layer
            // 
            this.Cancel_B_Layer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B_Layer.Location = new System.Drawing.Point(216, 117);
            this.Cancel_B_Layer.Name = "Cancel_B_Layer";
            this.Cancel_B_Layer.Size = new System.Drawing.Size(75, 23);
            this.Cancel_B_Layer.TabIndex = 5;
            this.Cancel_B_Layer.Text = "Отмена";
            this.Cancel_B_Layer.UseVisualStyleBackColor = true;
            // 
            // DialogCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 152);
            this.Controls.Add(this.Cancel_B_Layer);
            this.Controls.Add(this.OK_B_Layer);
            this.Controls.Add(this.cBCalcAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBNameCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DialogCalc";
            this.Text = "DialogCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox tBNameCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.CheckBox cBCalcAuto;
        private System.Windows.Forms.Button OK_B_Layer;
        private System.Windows.Forms.Button Cancel_B_Layer;
    }
}