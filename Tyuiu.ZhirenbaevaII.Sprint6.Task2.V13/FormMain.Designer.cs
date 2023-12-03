
namespace Tyuiu.ZhirenbaevaII.Sprint6.Task2.V13
{
    partial class FormMain
    {
     

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
            this.groupBoxCondition_ZII = new System.Windows.Forms.GroupBox();
            this.pictureBoxCondition_ZII = new System.Windows.Forms.PictureBox();
            this.groupBoxResult_ZII = new System.Windows.Forms.GroupBox();
            this.labelResult_ZII = new System.Windows.Forms.Label();
            this.dataGridViewFunction_ZII = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxVars_ZII = new System.Windows.Forms.GroupBox();
            this.textBoxStop_ZII = new System.Windows.Forms.TextBox();
            this.textBoxStart_ZII = new System.Windows.Forms.TextBox();
            this.labelStop_ZII = new System.Windows.Forms.Label();
            this.labelStart_ZII = new System.Windows.Forms.Label();
            this.buttonHelp_ZII = new System.Windows.Forms.Button();
            this.buttonDone_ZII = new System.Windows.Forms.Button();
            this.chartFunction_ZII = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition_ZII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_ZII)).BeginInit();
            this.groupBoxResult_ZII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_ZII)).BeginInit();
            this.groupBoxVars_ZII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZII)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_ZII
            // 
            this.groupBoxCondition_ZII.Controls.Add(this.pictureBoxCondition_ZII);
            this.groupBoxCondition_ZII.Location = new System.Drawing.Point(10, 11);
            this.groupBoxCondition_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCondition_ZII.Name = "groupBoxCondition_ZII";
            this.groupBoxCondition_ZII.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCondition_ZII.Size = new System.Drawing.Size(524, 252);
            this.groupBoxCondition_ZII.TabIndex = 1;
            this.groupBoxCondition_ZII.TabStop = false;
            this.groupBoxCondition_ZII.Text = "Условие";
            // 
            // pictureBoxCondition_ZII
            // 
            this.pictureBoxCondition_ZII.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCondition_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCondition_ZII.Name = "pictureBoxCondition_ZII";
            this.pictureBoxCondition_ZII.Size = new System.Drawing.Size(524, 54);
            this.pictureBoxCondition_ZII.TabIndex = 0;
            this.pictureBoxCondition_ZII.TabStop = false;
            // 
            // groupBoxResult_ZII
            // 
            this.groupBoxResult_ZII.Controls.Add(this.chartFunction_ZII);
            this.groupBoxResult_ZII.Controls.Add(this.labelResult_ZII);
            this.groupBoxResult_ZII.Controls.Add(this.dataGridViewFunction_ZII);
            this.groupBoxResult_ZII.Location = new System.Drawing.Point(538, 11);
            this.groupBoxResult_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_ZII.Name = "groupBoxResult_ZII";
            this.groupBoxResult_ZII.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_ZII.Size = new System.Drawing.Size(474, 345);
            this.groupBoxResult_ZII.TabIndex = 2;
            this.groupBoxResult_ZII.TabStop = false;
            this.groupBoxResult_ZII.Text = "Вывод данных";
            // 
            // labelResult_ZII
            // 
            this.labelResult_ZII.AutoSize = true;
            this.labelResult_ZII.Location = new System.Drawing.Point(4, 23);
            this.labelResult_ZII.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult_ZII.Name = "labelResult_ZII";
            this.labelResult_ZII.Size = new System.Drawing.Size(62, 13);
            this.labelResult_ZII.TabIndex = 1;
            this.labelResult_ZII.Text = "Результат:";
            // 
            // dataGridViewFunction_ZII
            // 
            this.dataGridViewFunction_ZII.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_ZII.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewFunction_ZII.Location = new System.Drawing.Point(4, 41);
            this.dataGridViewFunction_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFunction_ZII.Name = "dataGridViewFunction_ZII";
            this.dataGridViewFunction_ZII.RowHeadersVisible = false;
            this.dataGridViewFunction_ZII.RowHeadersWidth = 51;
            this.dataGridViewFunction_ZII.RowTemplate.Height = 24;
            this.dataGridViewFunction_ZII.Size = new System.Drawing.Size(127, 298);
            this.dataGridViewFunction_ZII.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(X)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 65;
            // 
            // groupBoxVars_ZII
            // 
            this.groupBoxVars_ZII.Controls.Add(this.textBoxStop_ZII);
            this.groupBoxVars_ZII.Controls.Add(this.textBoxStart_ZII);
            this.groupBoxVars_ZII.Controls.Add(this.labelStop_ZII);
            this.groupBoxVars_ZII.Controls.Add(this.labelStart_ZII);
            this.groupBoxVars_ZII.Location = new System.Drawing.Point(10, 268);
            this.groupBoxVars_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxVars_ZII.Name = "groupBoxVars_ZII";
            this.groupBoxVars_ZII.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxVars_ZII.Size = new System.Drawing.Size(196, 81);
            this.groupBoxVars_ZII.TabIndex = 3;
            this.groupBoxVars_ZII.TabStop = false;
            this.groupBoxVars_ZII.Text = "Ввод данных";
            // 
            // textBoxStop_ZII
            // 
            this.textBoxStop_ZII.Location = new System.Drawing.Point(106, 33);
            this.textBoxStop_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStop_ZII.Name = "textBoxStop_ZII";
            this.textBoxStop_ZII.Size = new System.Drawing.Size(76, 20);
            this.textBoxStop_ZII.TabIndex = 3;
            // 
            // textBoxStart_ZII
            // 
            this.textBoxStart_ZII.Location = new System.Drawing.Point(8, 34);
            this.textBoxStart_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStart_ZII.Name = "textBoxStart_ZII";
            this.textBoxStart_ZII.Size = new System.Drawing.Size(76, 20);
            this.textBoxStart_ZII.TabIndex = 2;
            // 
            // labelStop_ZII
            // 
            this.labelStop_ZII.AutoSize = true;
            this.labelStop_ZII.Location = new System.Drawing.Point(104, 18);
            this.labelStop_ZII.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStop_ZII.Name = "labelStop_ZII";
            this.labelStop_ZII.Size = new System.Drawing.Size(69, 13);
            this.labelStop_ZII.TabIndex = 1;
            this.labelStop_ZII.Text = "Конец шага:";
            // 
            // labelStart_ZII
            // 
            this.labelStart_ZII.AutoSize = true;
            this.labelStart_ZII.Location = new System.Drawing.Point(5, 18);
            this.labelStart_ZII.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStart_ZII.Name = "labelStart_ZII";
            this.labelStart_ZII.Size = new System.Drawing.Size(67, 13);
            this.labelStart_ZII.TabIndex = 0;
            this.labelStart_ZII.Text = "Старт шага:";
            // 
            // buttonHelp_ZII
            // 
            this.buttonHelp_ZII.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_ZII.Location = new System.Drawing.Point(211, 280);
            this.buttonHelp_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_ZII.Name = "buttonHelp_ZII";
            this.buttonHelp_ZII.Size = new System.Drawing.Size(135, 76);
            this.buttonHelp_ZII.TabIndex = 4;
            this.buttonHelp_ZII.Text = "Справка";
            this.buttonHelp_ZII.UseVisualStyleBackColor = false;
            this.buttonHelp_ZII.Click += new System.EventHandler(this.buttonHelp_ZII_Click);
            // 
            // buttonDone_ZII
            // 
            this.buttonDone_ZII.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDone_ZII.Location = new System.Drawing.Point(358, 280);
            this.buttonDone_ZII.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_ZII.Name = "buttonDone_ZII";
            this.buttonDone_ZII.Size = new System.Drawing.Size(171, 76);
            this.buttonDone_ZII.TabIndex = 5;
            this.buttonDone_ZII.Text = "Выполнить";
            this.buttonDone_ZII.UseVisualStyleBackColor = false;
            this.buttonDone_ZII.Click += new System.EventHandler(this.buttonDone_ZII_Click);
            this.buttonDone_ZII.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_ZII_MouseDown);
            this.buttonDone_ZII.MouseEnter += new System.EventHandler(this.buttonDone_ZII_MouseEnter);
            this.buttonDone_ZII.MouseLeave += new System.EventHandler(this.buttonDone_ZII_MouseLeave);
            // 
            // chartFunction_ZII
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_ZII.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_ZII.Legends.Add(legend1);
            this.chartFunction_ZII.Location = new System.Drawing.Point(152, 23);
            this.chartFunction_ZII.Name = "chartFunction_ZII";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_ZII.Series.Add(series1);
            this.chartFunction_ZII.Size = new System.Drawing.Size(300, 300);
            this.chartFunction_ZII.TabIndex = 1;
            this.chartFunction_ZII.Text = "chart1";
            this.chartFunction_ZII.Click += new System.EventHandler(this.chart1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 366);
            this.Controls.Add(this.buttonDone_ZII);
            this.Controls.Add(this.buttonHelp_ZII);
            this.Controls.Add(this.groupBoxVars_ZII);
            this.Controls.Add(this.groupBoxResult_ZII);
            this.Controls.Add(this.groupBoxCondition_ZII);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 13 | Жиренбаева И.И";
            this.groupBoxCondition_ZII.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_ZII)).EndInit();
            this.groupBoxResult_ZII.ResumeLayout(false);
            this.groupBoxResult_ZII.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_ZII)).EndInit();
            this.groupBoxVars_ZII.ResumeLayout(false);
            this.groupBoxVars_ZII.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZII)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_ZII;
        private System.Windows.Forms.PictureBox pictureBoxCondition_ZII;
        private System.Windows.Forms.GroupBox groupBoxResult_ZII;
        private System.Windows.Forms.GroupBox groupBoxVars_ZII;
        private System.Windows.Forms.Label labelResult_ZII;
        private System.Windows.Forms.DataGridView dataGridViewFunction_ZII;
        private System.Windows.Forms.TextBox textBoxStop_ZII;
        private System.Windows.Forms.TextBox textBoxStart_ZII;
        private System.Windows.Forms.Label labelStop_ZII;
        private System.Windows.Forms.Label labelStart_ZII;
        private System.Windows.Forms.Button buttonHelp_ZII;
        private System.Windows.Forms.Button buttonDone_ZII;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZII;
    }
}

