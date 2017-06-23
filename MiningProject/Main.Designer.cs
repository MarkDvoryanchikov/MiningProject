namespace MiningProject
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_panel = new System.Windows.Forms.Panel();
            this.m_btn2 = new System.Windows.Forms.Button();
            this.m_btn1 = new System.Windows.Forms.Button();
            this.m_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_panel
            // 
            this.m_panel.Controls.Add(this.m_btn2);
            this.m_panel.Controls.Add(this.m_btn1);
            this.m_panel.Location = new System.Drawing.Point(12, 12);
            this.m_panel.Name = "m_panel";
            this.m_panel.Size = new System.Drawing.Size(375, 346);
            this.m_panel.TabIndex = 0;
            // 
            // m_btn2
            // 
            this.m_btn2.Location = new System.Drawing.Point(34, 60);
            this.m_btn2.Name = "m_btn2";
            this.m_btn2.Size = new System.Drawing.Size(305, 33);
            this.m_btn2.TabIndex = 1;
            this.m_btn2.Text = "Расчеты фракционного анализа";
            this.m_btn2.UseVisualStyleBackColor = true;
            this.m_btn2.Click += new System.EventHandler(this.M_btn2_Click);
            // 
            // m_btn1
            // 
            this.m_btn1.Location = new System.Drawing.Point(34, 21);
            this.m_btn1.Name = "m_btn1";
            this.m_btn1.Size = new System.Drawing.Size(305, 33);
            this.m_btn1.TabIndex = 0;
            this.m_btn1.Text = "Ввод данных \"Задачи и угольные пласты\"";
            this.m_btn1.UseVisualStyleBackColor = true;
            this.m_btn1.Click += new System.EventHandler(this.M_btn1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 370);
            this.Controls.Add(this.m_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "MiningProject";
            this.m_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_panel;
        private System.Windows.Forms.Button m_btn1;
        private System.Windows.Forms.Button m_btn2;
    }
}

