
namespace Летняя_Практика
{
    partial class Form1
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
            this.EM = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.iter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EM
            // 
            this.EM.BackColor = System.Drawing.Color.White;
            this.EM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EM.ForeColor = System.Drawing.Color.Maroon;
            this.EM.Location = new System.Drawing.Point(740, 206);
            this.EM.Name = "EM";
            this.EM.Size = new System.Drawing.Size(205, 93);
            this.EM.TabIndex = 0;
            this.EM.Text = "Метод Эйлера";
            this.EM.UseVisualStyleBackColor = false;
            this.EM.Click += new System.EventHandler(this.BTN_EM);
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.White;
            this.ClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearAll.ForeColor = System.Drawing.Color.Maroon;
            this.ClearAll.Location = new System.Drawing.Point(740, 343);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(205, 93);
            this.ClearAll.TabIndex = 8;
            this.ClearAll.Text = "Очистить график";
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.Click += new System.EventHandler(this.BTN_Clear);
            // 
            // iter
            // 
            this.iter.BackColor = System.Drawing.Color.White;
            this.iter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iter.ForeColor = System.Drawing.Color.Maroon;
            this.iter.Location = new System.Drawing.Point(740, 140);
            this.iter.Name = "iter";
            this.iter.Size = new System.Drawing.Size(205, 27);
            this.iter.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(740, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 93);
            this.label3.TabIndex = 15;
            this.label3.Text = "Введите количество итераций";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(740, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 93);
            this.label1.TabIndex = 17;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(977, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iter);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.EM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Летняя практика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button button1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button EM;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.TextBox iter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox h;
        private System.Windows.Forms.Label curStep;
        private System.Windows.Forms.Label label1;
    }
}

