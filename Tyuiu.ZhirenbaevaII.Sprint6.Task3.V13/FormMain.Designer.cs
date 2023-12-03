
namespace Tyuiu.ZhirenbaevaII.Sprint6.Task3.V13
{
    partial class FormMain
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
            this.groupBoxCondition_ZII = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_ZII = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_ZII = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_ZII = new System.Windows.Forms.GroupBox();
            this.textBoxResult_ZII = new System.Windows.Forms.TextBox();
            this.buttonHelp_ZII = new System.Windows.Forms.Button();
            this.buttonToDo_ZII = new System.Windows.Forms.Button();
            this.groupBoxCondition_ZII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_ZII)).BeginInit();
            this.groupBoxResult_ZII.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_ZII
            // 
            this.groupBoxCondition_ZII.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBoxCondition_ZII.Controls.Add(this.textBoxCondition_ZII);
            this.groupBoxCondition_ZII.Location = new System.Drawing.Point(10, 11);
            this.groupBoxCondition_ZII.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCondition_ZII.Name = "groupBoxCondition_ZII";
            this.groupBoxCondition_ZII.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCondition_ZII.Size = new System.Drawing.Size(206, 275);
            this.groupBoxCondition_ZII.TabIndex = 0;
            this.groupBoxCondition_ZII.TabStop = false;
            this.groupBoxCondition_ZII.Text = "Условие";
            // 
            // textBoxCondition_ZII
            // 
            this.textBoxCondition_ZII.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_ZII.Location = new System.Drawing.Point(4, 42);
            this.textBoxCondition_ZII.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCondition_ZII.Multiline = true;
            this.textBoxCondition_ZII.Name = "textBoxCondition_ZII";
            this.textBoxCondition_ZII.ReadOnly = true;
            this.textBoxCondition_ZII.Size = new System.Drawing.Size(198, 152);
            this.textBoxCondition_ZII.TabIndex = 0;
            this.textBoxCondition_ZII.Text = "Дана матрица 5 на 5\r\n -7   34  -2  25  5\r\n-16 -12  30 -3 17\r\n  3  -15  12  5  -5\r" +
    "\n 17   22 -3  32 -11\r\n  9    28  1  -9  -2\r\nВыполнить сортировку по возрастанию " +
    "\r\nво втором столбце  ";
            // 
            // dataGridViewMatrix_ZII
            // 
            this.dataGridViewMatrix_ZII.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridViewMatrix_ZII.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_ZII.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_ZII.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMatrix_ZII.Location = new System.Drawing.Point(20, 42);
            this.dataGridViewMatrix_ZII.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMatrix_ZII.Name = "dataGridViewMatrix_ZII";
            this.dataGridViewMatrix_ZII.ReadOnly = true;
            this.dataGridViewMatrix_ZII.RowHeadersVisible = false;
            this.dataGridViewMatrix_ZII.RowHeadersWidth = 51;
            this.dataGridViewMatrix_ZII.RowTemplate.Height = 24;
            this.dataGridViewMatrix_ZII.Size = new System.Drawing.Size(291, 290);
            this.dataGridViewMatrix_ZII.TabIndex = 1;
            // 
            // groupBoxResult_ZII
            // 
            this.groupBoxResult_ZII.Controls.Add(this.textBoxResult_ZII);
            this.groupBoxResult_ZII.Controls.Add(this.dataGridViewMatrix_ZII);
            this.groupBoxResult_ZII.Location = new System.Drawing.Point(225, 11);
            this.groupBoxResult_ZII.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxResult_ZII.Name = "groupBoxResult_ZII";
            this.groupBoxResult_ZII.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxResult_ZII.Size = new System.Drawing.Size(330, 345);
            this.groupBoxResult_ZII.TabIndex = 2;
            this.groupBoxResult_ZII.TabStop = false;
            this.groupBoxResult_ZII.Text = "Вывод данных";
            // 
            // textBoxResult_ZII
            // 
            this.textBoxResult_ZII.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_ZII.Location = new System.Drawing.Point(20, 18);
            this.textBoxResult_ZII.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult_ZII.Name = "textBoxResult_ZII";
            this.textBoxResult_ZII.ReadOnly = true;
            this.textBoxResult_ZII.Size = new System.Drawing.Size(100, 13);
            this.textBoxResult_ZII.TabIndex = 2;
            this.textBoxResult_ZII.Text = "Результат:";
            // 
            // buttonHelp_ZII
            // 
            this.buttonHelp_ZII.Location = new System.Drawing.Point(10, 291);
            this.buttonHelp_ZII.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHelp_ZII.Name = "buttonHelp_ZII";
            this.buttonHelp_ZII.Size = new System.Drawing.Size(82, 65);
            this.buttonHelp_ZII.TabIndex = 3;
            this.buttonHelp_ZII.Text = "Справка";
            this.buttonHelp_ZII.UseVisualStyleBackColor = true;
            this.buttonHelp_ZII.Click += new System.EventHandler(this.buttonHelp_ZII_Click);
            // 
            // buttonToDo_ZII
            // 
            this.buttonToDo_ZII.Location = new System.Drawing.Point(96, 291);
            this.buttonToDo_ZII.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonToDo_ZII.Name = "buttonToDo_ZII";
            this.buttonToDo_ZII.Size = new System.Drawing.Size(119, 65);
            this.buttonToDo_ZII.TabIndex = 4;
            this.buttonToDo_ZII.Text = "Выполнить";
            this.buttonToDo_ZII.UseVisualStyleBackColor = true;
            this.buttonToDo_ZII.Click += new System.EventHandler(this.buttonToDo_ZII_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 366);
            this.Controls.Add(this.buttonToDo_ZII);
            this.Controls.Add(this.buttonHelp_ZII);
            this.Controls.Add(this.groupBoxResult_ZII);
            this.Controls.Add(this.groupBoxCondition_ZII);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 13 |Жиренбаева И.И ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_ZII.ResumeLayout(false);
            this.groupBoxCondition_ZII.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_ZII)).EndInit();
            this.groupBoxResult_ZII.ResumeLayout(false);
            this.groupBoxResult_ZII.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_ZII;
        private System.Windows.Forms.TextBox textBoxCondition_ZII;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_ZII;
        private System.Windows.Forms.GroupBox groupBoxResult_ZII;
        private System.Windows.Forms.TextBox textBoxResult_ZII;
        private System.Windows.Forms.Button buttonHelp_ZII;
        private System.Windows.Forms.Button buttonToDo_ZII;
    }
}