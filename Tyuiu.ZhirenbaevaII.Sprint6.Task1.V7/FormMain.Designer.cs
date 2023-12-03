
using System;

namespace Tyuiu.ZhirenbaevaII.Sprint6.Task1.V7
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
            this.GroupBoxCond_ZII = new System.Windows.Forms.GroupBox();
            this.TextBoxTask_ZII = new System.Windows.Forms.TextBox();
            this.GroupBoxInput_ZII = new System.Windows.Forms.GroupBox();
            this.TextBoxStop_ZII = new System.Windows.Forms.TextBox();
            this.TextBoxStart_ZII = new System.Windows.Forms.TextBox();
            this.LabelStop_ZII = new System.Windows.Forms.Label();
            this.LabelStart_ZII = new System.Windows.Forms.Label();
            this.ButtonInfo_ZII = new System.Windows.Forms.Button();
            this.ButtonDone_ZII = new System.Windows.Forms.Button();
            this.GroupBoxOutput_ZII = new System.Windows.Forms.GroupBox();
            this.TextBoxResult_ZII = new System.Windows.Forms.TextBox();
            this.LabelResult_ZII = new System.Windows.Forms.Label();
            this.GroupBoxCond_ZII.SuspendLayout();
            this.GroupBoxInput_ZII.SuspendLayout();
            this.GroupBoxOutput_ZII.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxCond_ZII
            // 
            this.GroupBoxCond_ZII.Controls.Add(this.TextBoxTask_ZII);
            this.GroupBoxCond_ZII.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxCond_ZII.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxCond_ZII.Name = "GroupBoxCond_ZII";
            this.GroupBoxCond_ZII.Size = new System.Drawing.Size(571, 307);
            this.GroupBoxCond_ZII.TabIndex = 0;
            this.GroupBoxCond_ZII.TabStop = false;
            this.GroupBoxCond_ZII.Text = "Условие";
            // 
            // TextBoxTask_ZII
            // 
            this.TextBoxTask_ZII.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTask_ZII.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTask_ZII.Location = new System.Drawing.Point(19, 35);
            this.TextBoxTask_ZII.Multiline = true;
            this.TextBoxTask_ZII.Name = "TextBoxTask_ZII";
            this.TextBoxTask_ZII.ReadOnly = true;
            this.TextBoxTask_ZII.Size = new System.Drawing.Size(531, 245);
            this.TextBoxTask_ZII.TabIndex = 0;
            this.TextBoxTask_ZII.TabStop = false;
            this.TextBoxTask_ZII.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы." +
    "";
            // 
            // GroupBoxInput_ZII
            // 
            this.GroupBoxInput_ZII.Controls.Add(this.TextBoxStop_ZII);
            this.GroupBoxInput_ZII.Controls.Add(this.TextBoxStart_ZII);
            this.GroupBoxInput_ZII.Controls.Add(this.LabelStop_ZII);
            this.GroupBoxInput_ZII.Controls.Add(this.LabelStart_ZII);
            this.GroupBoxInput_ZII.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxInput_ZII.Location = new System.Drawing.Point(12, 325);
            this.GroupBoxInput_ZII.Name = "GroupBoxInput_ZII";
            this.GroupBoxInput_ZII.Size = new System.Drawing.Size(318, 113);
            this.GroupBoxInput_ZII.TabIndex = 1;
            this.GroupBoxInput_ZII.TabStop = false;
            this.GroupBoxInput_ZII.Text = "Ввод данных";
            // 
            // TextBoxStop_ZII
            // 
            this.TextBoxStop_ZII.Location = new System.Drawing.Point(162, 72);
            this.TextBoxStop_ZII.Name = "TextBoxStop_ZII";
            this.TextBoxStop_ZII.Size = new System.Drawing.Size(133, 35);
            this.TextBoxStop_ZII.TabIndex = 3;
            // 
            // TextBoxStart_ZII
            // 
            this.TextBoxStart_ZII.Location = new System.Drawing.Point(11, 72);
            this.TextBoxStart_ZII.Name = "TextBoxStart_ZII";
            this.TextBoxStart_ZII.Size = new System.Drawing.Size(132, 35);
            this.TextBoxStart_ZII.TabIndex = 2;
            // 
            // LabelStop_ZII
            // 
            this.LabelStop_ZII.AutoSize = true;
            this.LabelStop_ZII.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStop_ZII.Location = new System.Drawing.Point(158, 35);
            this.LabelStop_ZII.Name = "LabelStop_ZII";
            this.LabelStop_ZII.Size = new System.Drawing.Size(119, 24);
            this.LabelStop_ZII.TabIndex = 1;
            this.LabelStop_ZII.Text = "Конец шага:";
            // 
            // LabelStart_ZII
            // 
            this.LabelStart_ZII.AutoSize = true;
            this.LabelStart_ZII.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStart_ZII.Location = new System.Drawing.Point(7, 35);
            this.LabelStart_ZII.Name = "LabelStart_ZII";
            this.LabelStart_ZII.Size = new System.Drawing.Size(117, 24);
            this.LabelStart_ZII.TabIndex = 0;
            this.LabelStart_ZII.Text = "Старт шага:";
            // 
            // ButtonInfo_ZII
            // 
            this.ButtonInfo_ZII.BackColor = System.Drawing.Color.Indigo;
            this.ButtonInfo_ZII.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInfo_ZII.Location = new System.Drawing.Point(336, 349);
            this.ButtonInfo_ZII.Name = "ButtonInfo_ZII";
            this.ButtonInfo_ZII.Size = new System.Drawing.Size(101, 83);
            this.ButtonInfo_ZII.TabIndex = 2;
            this.ButtonInfo_ZII.Text = "Справка";
            this.ButtonInfo_ZII.UseVisualStyleBackColor = false;
            this.ButtonInfo_ZII.Click += new System.EventHandler(this.ButtonInfo_ZII_Click);
            // 
            // ButtonDone_ZII
            // 
            this.ButtonDone_ZII.BackColor = System.Drawing.Color.Indigo;
            this.ButtonDone_ZII.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDone_ZII.Location = new System.Drawing.Point(443, 349);
            this.ButtonDone_ZII.Name = "ButtonDone_ZII";
            this.ButtonDone_ZII.Size = new System.Drawing.Size(140, 83);
            this.ButtonDone_ZII.TabIndex = 3;
            this.ButtonDone_ZII.Text = "Выполнить";
            this.ButtonDone_ZII.UseVisualStyleBackColor = false;
            this.ButtonDone_ZII.Click += new System.EventHandler(this.ButtonDone_ZII_Click);
            // 
            // GroupBoxOutput_ZII
            // 
            this.GroupBoxOutput_ZII.Controls.Add(this.TextBoxResult_ZII);
            this.GroupBoxOutput_ZII.Controls.Add(this.LabelResult_ZII);
            this.GroupBoxOutput_ZII.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxOutput_ZII.Location = new System.Drawing.Point(589, 12);
            this.GroupBoxOutput_ZII.Name = "GroupBoxOutput_ZII";
            this.GroupBoxOutput_ZII.Size = new System.Drawing.Size(262, 426);
            this.GroupBoxOutput_ZII.TabIndex = 4;
            this.GroupBoxOutput_ZII.TabStop = false;
            this.GroupBoxOutput_ZII.Text = "Вывод данных";
            // 
            // TextBoxResult_ZII
            // 
            this.TextBoxResult_ZII.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxResult_ZII.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxResult_ZII.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TextBoxResult_ZII.Location = new System.Drawing.Point(22, 62);
            this.TextBoxResult_ZII.Multiline = true;
            this.TextBoxResult_ZII.Name = "TextBoxResult_ZII";
            this.TextBoxResult_ZII.ReadOnly = true;
            this.TextBoxResult_ZII.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxResult_ZII.Size = new System.Drawing.Size(225, 358);
            this.TextBoxResult_ZII.TabIndex = 3;
            // 
            // LabelResult_ZII
            // 
            this.LabelResult_ZII.AutoSize = true;
            this.LabelResult_ZII.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelResult_ZII.Location = new System.Drawing.Point(18, 35);
            this.LabelResult_ZII.Name = "LabelResult_ZII";
            this.LabelResult_ZII.Size = new System.Drawing.Size(108, 24);
            this.LabelResult_ZII.TabIndex = 2;
            this.LabelResult_ZII.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.GroupBoxOutput_ZII);
            this.Controls.Add(this.ButtonDone_ZII);
            this.Controls.Add(this.ButtonInfo_ZII);
            this.Controls.Add(this.GroupBoxInput_ZII);
            this.Controls.Add(this.GroupBoxCond_ZII);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 7 |Жиренбаева И.И ";
            this.GroupBoxCond_ZII.ResumeLayout(false);
            this.GroupBoxCond_ZII.PerformLayout();
            this.GroupBoxInput_ZII.ResumeLayout(false);
            this.GroupBoxInput_ZII.PerformLayout();
            this.GroupBoxOutput_ZII.ResumeLayout(false);
            this.GroupBoxOutput_ZII.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxCond_ZII;
        private System.Windows.Forms.TextBox TextBoxTask_ZII;
        private System.Windows.Forms.GroupBox GroupBoxInput_ZII;
        private System.Windows.Forms.Label LabelStart_ZII;
        private System.Windows.Forms.TextBox TextBoxStop_ZII;
        private System.Windows.Forms.TextBox TextBoxStart_ZII;
        private System.Windows.Forms.Label LabelStop_ZII;
        private System.Windows.Forms.Button ButtonInfo_ZII;
        private System.Windows.Forms.Button ButtonDone_ZII;
        private System.Windows.Forms.GroupBox GroupBoxOutput_ZII;
        private System.Windows.Forms.TextBox TextBoxResult_ZII;
        private System.Windows.Forms.Label LabelResult_ZII;
    }
}
