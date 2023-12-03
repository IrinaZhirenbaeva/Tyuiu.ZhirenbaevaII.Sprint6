
namespace Tyuiu.ZhirenbaevaII.Sprint6.Task0.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCond_ZII = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZII = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_ZII = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_ZII = new System.Windows.Forms.GroupBox();
            this.labelVarX_ZII = new System.Windows.Forms.Label();
            this.textBoxVarX_ZII = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_ZII = new System.Windows.Forms.GroupBox();
            this.textBoxResult_ZII = new System.Windows.Forms.TextBox();
            this.labelResult_ZII = new System.Windows.Forms.Label();
            this.buttonDone_ZII = new System.Windows.Forms.Button();
            this.buttonInfo_ZII = new System.Windows.Forms.Button();
            this.groupBoxCond_ZII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_ZII)).BeginInit();
            this.groupBoxInput_ZII.SuspendLayout();
            this.groupBoxOutput_ZII.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCond_ZII
            // 
            this.groupBoxCond_ZII.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBoxCond_ZII.Controls.Add(this.textBoxTask_ZII);
            this.groupBoxCond_ZII.Controls.Add(this.pictureBoxFormula_ZII);
            this.groupBoxCond_ZII.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCond_ZII.Location = new System.Drawing.Point(3, 12);
            this.groupBoxCond_ZII.Name = "groupBoxCond_ZII";
            this.groupBoxCond_ZII.Size = new System.Drawing.Size(785, 252);
            this.groupBoxCond_ZII.TabIndex = 0;
            this.groupBoxCond_ZII.TabStop = false;
            this.groupBoxCond_ZII.Text = "Условие";
            // 
            // textBoxTask_ZII
            // 
            this.textBoxTask_ZII.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTask_ZII.Enabled = false;
            this.textBoxTask_ZII.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_ZII.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_ZII.Multiline = true;
            this.textBoxTask_ZII.Name = "textBoxTask_ZII";
            this.textBoxTask_ZII.ReadOnly = true;
            this.textBoxTask_ZII.Size = new System.Drawing.Size(558, 208);
            this.textBoxTask_ZII.TabIndex = 1;
            this.textBoxTask_ZII.Text = "Дано выражение вычислить его значение при x = 3.\r\nОкруглить до трёх знаков после " +
    "запятой.";
            this.textBoxTask_ZII.TextChanged += new System.EventHandler(this.textBoxTask_ZII_TextChanged);
            // 
            // pictureBoxFormula_ZII
            // 
            this.pictureBoxFormula_ZII.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_ZII.Image")));
            this.pictureBoxFormula_ZII.Location = new System.Drawing.Point(600, 75);
            this.pictureBoxFormula_ZII.Name = "pictureBoxFormula_ZII";
            this.pictureBoxFormula_ZII.Size = new System.Drawing.Size(158, 86);
            this.pictureBoxFormula_ZII.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFormula_ZII.TabIndex = 1;
            this.pictureBoxFormula_ZII.TabStop = false;
            // 
            // groupBoxInput_ZII
            // 
            this.groupBoxInput_ZII.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBoxInput_ZII.Controls.Add(this.labelVarX_ZII);
            this.groupBoxInput_ZII.Controls.Add(this.textBoxVarX_ZII);
            this.groupBoxInput_ZII.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_ZII.Location = new System.Drawing.Point(12, 270);
            this.groupBoxInput_ZII.Name = "groupBoxInput_ZII";
            this.groupBoxInput_ZII.Size = new System.Drawing.Size(481, 99);
            this.groupBoxInput_ZII.TabIndex = 2;
            this.groupBoxInput_ZII.TabStop = false;
            this.groupBoxInput_ZII.Text = "Ввод данных";
            // 
            // labelVarX_ZII
            // 
            this.labelVarX_ZII.AutoSize = true;
            this.labelVarX_ZII.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVarX_ZII.Location = new System.Drawing.Point(6, 21);
            this.labelVarX_ZII.Name = "labelVarX_ZII";
            this.labelVarX_ZII.Size = new System.Drawing.Size(84, 16);
            this.labelVarX_ZII.TabIndex = 0;
            this.labelVarX_ZII.Text = "Переменная X:";
            // 
            // textBoxVarX_ZII
            // 
            this.textBoxVarX_ZII.Location = new System.Drawing.Point(6, 40);
            this.textBoxVarX_ZII.Name = "textBoxVarX_ZII";
            this.textBoxVarX_ZII.Size = new System.Drawing.Size(100, 25);
            this.textBoxVarX_ZII.TabIndex = 1;
            // 
            // groupBoxOutput_ZII
            // 
            this.groupBoxOutput_ZII.Controls.Add(this.textBoxResult_ZII);
            this.groupBoxOutput_ZII.Controls.Add(this.labelResult_ZII);
            this.groupBoxOutput_ZII.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_ZII.Location = new System.Drawing.Point(514, 272);
            this.groupBoxOutput_ZII.Name = "groupBoxOutput_ZII";
            this.groupBoxOutput_ZII.Size = new System.Drawing.Size(256, 108);
            this.groupBoxOutput_ZII.TabIndex = 2;
            this.groupBoxOutput_ZII.TabStop = false;
            this.groupBoxOutput_ZII.Text = "Вывод данных";
            this.groupBoxOutput_ZII.Enter += new System.EventHandler(this.groupBoxOutput_ZII_Enter);
            // 
            // textBoxResult_ZII
            // 
            this.textBoxResult_ZII.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult_ZII.Location = new System.Drawing.Point(6, 48);
            this.textBoxResult_ZII.Multiline = true;
            this.textBoxResult_ZII.Name = "textBoxResult_ZII";
            this.textBoxResult_ZII.ReadOnly = true;
            this.textBoxResult_ZII.Size = new System.Drawing.Size(118, 24);
            this.textBoxResult_ZII.TabIndex = 2;
            // 
            // labelResult_ZII
            // 
            this.labelResult_ZII.BackColor = System.Drawing.Color.GhostWhite;
            this.labelResult_ZII.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult_ZII.Location = new System.Drawing.Point(6, 19);
            this.labelResult_ZII.Name = "labelResult_ZII";
            this.labelResult_ZII.Size = new System.Drawing.Size(118, 26);
            this.labelResult_ZII.TabIndex = 1;
            this.labelResult_ZII.Text = "Результат:";
            // 
            // buttonDone_ZII
            // 
            this.buttonDone_ZII.AutoEllipsis = true;
            this.buttonDone_ZII.BackColor = System.Drawing.Color.MistyRose;
            this.buttonDone_ZII.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_ZII.ForeColor = System.Drawing.Color.Black;
            this.buttonDone_ZII.Location = new System.Drawing.Point(603, 386);
            this.buttonDone_ZII.Name = "buttonDone_ZII";
            this.buttonDone_ZII.Size = new System.Drawing.Size(185, 52);
            this.buttonDone_ZII.TabIndex = 4;
            this.buttonDone_ZII.Text = "Выполнить";
            this.buttonDone_ZII.UseVisualStyleBackColor = false;
            this.buttonDone_ZII.Click += new System.EventHandler(this.buttonDone_ZII_Click);
            // 
            // buttonInfo_ZII
            // 
            this.buttonInfo_ZII.BackColor = System.Drawing.Color.MistyRose;
            this.buttonInfo_ZII.Location = new System.Drawing.Point(545, 386);
            this.buttonInfo_ZII.Name = "buttonInfo_ZII";
            this.buttonInfo_ZII.Size = new System.Drawing.Size(52, 52);
            this.buttonInfo_ZII.TabIndex = 5;
            this.buttonInfo_ZII.Text = "?";
            this.buttonInfo_ZII.UseVisualStyleBackColor = false;
            this.buttonInfo_ZII.Click += new System.EventHandler(this.buttonInfo_ZII_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo_ZII);
            this.Controls.Add(this.buttonDone_ZII);
            this.Controls.Add(this.groupBoxOutput_ZII);
            this.Controls.Add(this.groupBoxInput_ZII);
            this.Controls.Add(this.groupBoxCond_ZII);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 0 | Вариант 8 | Жиренбаева И.И";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCond_ZII.ResumeLayout(false);
            this.groupBoxCond_ZII.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_ZII)).EndInit();
            this.groupBoxInput_ZII.ResumeLayout(false);
            this.groupBoxInput_ZII.PerformLayout();
            this.groupBoxOutput_ZII.ResumeLayout(false);
            this.groupBoxOutput_ZII.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.GroupBox groupBoxCond_ZII;
            private System.Windows.Forms.PictureBox pictureBoxFormula_ZII;
            private System.Windows.Forms.TextBox textBoxTask_ZII;
            private System.Windows.Forms.GroupBox groupBoxInput_ZII;
            private System.Windows.Forms.Label labelVarX_ZII;
            private System.Windows.Forms.TextBox textBoxVarX_ZII;
            private System.Windows.Forms.GroupBox groupBoxOutput_ZII;
            private System.Windows.Forms.Label labelResult_ZII;
            private System.Windows.Forms.TextBox textBoxResult_ZII;
            private System.Windows.Forms.Button buttonDone_ZII;
            private System.Windows.Forms.Button buttonInfo_ZII;
        
    }
}