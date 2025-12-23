using Tyuiu.PisarevMA.Sprint6.Review.V11.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Review.V11
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelRight_PMA = new Panel();
            panel1 = new Panel();
            buttonDone_PMA = new Button();
            groupBoxRes_PMA = new GroupBox();
            textBoxResultat_PMA = new TextBox();
            groupBoxOut_PMA = new GroupBox();
            dataGridViewOut_PMA = new DataGridView();
            splitterOne_PMA = new Splitter();
            panelLeft_PMA = new Panel();
            groupBoxIn_PMA = new GroupBox();
            groupBoxVarL_PMA = new GroupBox();
            textBoxDigitalL_PMA = new TextBox();
            buttonGeneration_PMA = new Button();
            groupBoxVarK_PMA = new GroupBox();
            textBoxDigitalK_PMA = new TextBox();
            groupBoxVarC_PMA = new GroupBox();
            textBoxDigitalC_PMA = new TextBox();
            groupBoxVarN2_PMA = new GroupBox();
            textBoxDigitalN2_PMA = new TextBox();
            groupBoxVarN1_PMA = new GroupBox();
            textBoxDigitalN1_PMA = new TextBox();
            groupBoxVarM_PMA = new GroupBox();
            textBoxDigitalM_PMA = new TextBox();
            groupBoxVarN_PMA = new GroupBox();
            textBoxDigitalN_PMA = new TextBox();
            panelCenter_PMA = new Panel();
            groupBoxUslovie_PMA = new GroupBox();
            textBoxUslovie_PMA = new TextBox();
            panelRight_PMA.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxRes_PMA.SuspendLayout();
            groupBoxOut_PMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_PMA).BeginInit();
            panelLeft_PMA.SuspendLayout();
            groupBoxIn_PMA.SuspendLayout();
            groupBoxVarL_PMA.SuspendLayout();
            groupBoxVarK_PMA.SuspendLayout();
            groupBoxVarC_PMA.SuspendLayout();
            groupBoxVarN2_PMA.SuspendLayout();
            groupBoxVarN1_PMA.SuspendLayout();
            groupBoxVarM_PMA.SuspendLayout();
            groupBoxVarN_PMA.SuspendLayout();
            panelCenter_PMA.SuspendLayout();
            groupBoxUslovie_PMA.SuspendLayout();
            SuspendLayout();
            // 
            // panelRight_PMA
            // 
            panelRight_PMA.Controls.Add(panel1);
            panelRight_PMA.Controls.Add(groupBoxOut_PMA);
            panelRight_PMA.Dock = DockStyle.Fill;
            panelRight_PMA.Location = new Point(450, 93);
            panelRight_PMA.Margin = new Padding(2, 3, 2, 3);
            panelRight_PMA.Name = "panelRight_PMA";
            panelRight_PMA.Size = new Size(483, 426);
            panelRight_PMA.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDone_PMA);
            panel1.Controls.Add(groupBoxRes_PMA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 318);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 108);
            panel1.TabIndex = 1;
            // 
            // buttonDone_PMA
            // 
            buttonDone_PMA.Enabled = false;
            buttonDone_PMA.Location = new Point(281, 35);
            buttonDone_PMA.Margin = new Padding(2, 3, 2, 3);
            buttonDone_PMA.Name = "buttonDone_PMA";
            buttonDone_PMA.Size = new Size(94, 27);
            buttonDone_PMA.TabIndex = 14;
            buttonDone_PMA.Text = "Выполнить";
            buttonDone_PMA.UseVisualStyleBackColor = true;
            buttonDone_PMA.Click += buttonDone_PMA_Click;
            // 
            // groupBoxRes_PMA
            // 
            groupBoxRes_PMA.Controls.Add(textBoxResultat_PMA);
            groupBoxRes_PMA.Location = new Point(20, 22);
            groupBoxRes_PMA.Margin = new Padding(2, 3, 2, 3);
            groupBoxRes_PMA.Name = "groupBoxRes_PMA";
            groupBoxRes_PMA.Padding = new Padding(2, 3, 2, 3);
            groupBoxRes_PMA.Size = new Size(239, 48);
            groupBoxRes_PMA.TabIndex = 13;
            groupBoxRes_PMA.TabStop = false;
            groupBoxRes_PMA.Text = "Результат";
            // 
            // textBoxResultat_PMA
            // 
            textBoxResultat_PMA.BackColor = SystemColors.ControlLight;
            textBoxResultat_PMA.Location = new Point(7, 20);
            textBoxResultat_PMA.Margin = new Padding(2, 3, 2, 3);
            textBoxResultat_PMA.Name = "textBoxResultat_PMA";
            textBoxResultat_PMA.Size = new Size(229, 23);
            textBoxResultat_PMA.TabIndex = 2;
            // 
            // groupBoxOut_PMA
            // 
            groupBoxOut_PMA.Controls.Add(dataGridViewOut_PMA);
            groupBoxOut_PMA.Dock = DockStyle.Top;
            groupBoxOut_PMA.Location = new Point(0, 0);
            groupBoxOut_PMA.Margin = new Padding(2, 3, 2, 3);
            groupBoxOut_PMA.Name = "groupBoxOut_PMA";
            groupBoxOut_PMA.Padding = new Padding(2, 3, 2, 3);
            groupBoxOut_PMA.Size = new Size(483, 318);
            groupBoxOut_PMA.TabIndex = 1;
            groupBoxOut_PMA.TabStop = false;
            groupBoxOut_PMA.Text = "Вывод";
            // 
            // dataGridViewOut_PMA
            // 
            dataGridViewOut_PMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_PMA.ColumnHeadersVisible = false;
            dataGridViewOut_PMA.Dock = DockStyle.Fill;
            dataGridViewOut_PMA.Location = new Point(2, 19);
            dataGridViewOut_PMA.Margin = new Padding(2, 3, 2, 3);
            dataGridViewOut_PMA.Name = "dataGridViewOut_PMA";
            dataGridViewOut_PMA.RowHeadersVisible = false;
            dataGridViewOut_PMA.RowHeadersWidth = 51;
            dataGridViewOut_PMA.RowTemplate.Height = 24;
            dataGridViewOut_PMA.Size = new Size(479, 296);
            dataGridViewOut_PMA.TabIndex = 0;
            // 
            // splitterOne_PMA
            // 
            splitterOne_PMA.Location = new Point(448, 93);
            splitterOne_PMA.Margin = new Padding(2, 3, 2, 3);
            splitterOne_PMA.Name = "splitterOne_PMA";
            splitterOne_PMA.Size = new Size(2, 426);
            splitterOne_PMA.TabIndex = 12;
            splitterOne_PMA.TabStop = false;
            // 
            // panelLeft_PMA
            // 
            panelLeft_PMA.Controls.Add(groupBoxIn_PMA);
            panelLeft_PMA.Dock = DockStyle.Left;
            panelLeft_PMA.Location = new Point(0, 93);
            panelLeft_PMA.Margin = new Padding(2, 3, 2, 3);
            panelLeft_PMA.Name = "panelLeft_PMA";
            panelLeft_PMA.Size = new Size(448, 426);
            panelLeft_PMA.TabIndex = 11;
            // 
            // groupBoxIn_PMA
            // 
            groupBoxIn_PMA.Controls.Add(groupBoxVarL_PMA);
            groupBoxIn_PMA.Controls.Add(buttonGeneration_PMA);
            groupBoxIn_PMA.Controls.Add(groupBoxVarK_PMA);
            groupBoxIn_PMA.Controls.Add(groupBoxVarC_PMA);
            groupBoxIn_PMA.Controls.Add(groupBoxVarN2_PMA);
            groupBoxIn_PMA.Controls.Add(groupBoxVarN1_PMA);
            groupBoxIn_PMA.Controls.Add(groupBoxVarM_PMA);
            groupBoxIn_PMA.Controls.Add(groupBoxVarN_PMA);
            groupBoxIn_PMA.Dock = DockStyle.Fill;
            groupBoxIn_PMA.Location = new Point(0, 0);
            groupBoxIn_PMA.Margin = new Padding(2, 3, 2, 3);
            groupBoxIn_PMA.Name = "groupBoxIn_PMA";
            groupBoxIn_PMA.Padding = new Padding(2, 3, 2, 3);
            groupBoxIn_PMA.Size = new Size(448, 426);
            groupBoxIn_PMA.TabIndex = 0;
            groupBoxIn_PMA.TabStop = false;
            groupBoxIn_PMA.Text = "Ввод";
            // 
            // groupBoxVarL_PMA
            // 
            groupBoxVarL_PMA.Controls.Add(textBoxDigitalL_PMA);
            groupBoxVarL_PMA.Location = new Point(238, 276);
            groupBoxVarL_PMA.Margin = new Padding(2, 3, 2, 3);
            groupBoxVarL_PMA.Name = "groupBoxVarL_PMA";
            groupBoxVarL_PMA.Padding = new Padding(2, 3, 2, 3);
            groupBoxVarL_PMA.Size = new Size(169, 54);
            groupBoxVarL_PMA.TabIndex = 13;
            groupBoxVarL_PMA.TabStop = false;
            groupBoxVarL_PMA.Text = "Введите значение L:";
            // 
            // textBoxDigitalL_PMA
            // 
            textBoxDigitalL_PMA.BackColor = SystemColors.ControlLight;
            textBoxDigitalL_PMA.Location = new Point(6, 29);
            textBoxDigitalL_PMA.Margin = new Padding(2, 3, 2, 3);
            textBoxDigitalL_PMA.Name = "textBoxDigitalL_PMA";
            textBoxDigitalL_PMA.Size = new Size(159, 23);
            textBoxDigitalL_PMA.TabIndex = 2;
            // 
            // buttonGeneration_PMA
            // 
            buttonGeneration_PMA.Location = new Point(265, 346);
            buttonGeneration_PMA.Margin = new Padding(2, 3, 2, 3);
            buttonGeneration_PMA.Name = "buttonGeneration_PMA";
            buttonGeneration_PMA.Size = new Size(163, 33);
            buttonGeneration_PMA.TabIndex = 13;
            buttonGeneration_PMA.Text = "Сгенерировать матрицу";
            buttonGeneration_PMA.UseVisualStyleBackColor = true;
            buttonGeneration_PMA.Click += buttonGeneration_PMA_Click;
            // 
            // groupBoxVarK_PMA
            // 
            groupBoxVarK_PMA.Controls.Add(textBoxDigitalK_PMA);
            groupBoxVarK_PMA.Location = new Point(24, 276);
            groupBoxVarK_PMA.Margin = new Padding(2, 3, 2, 3);
            groupBoxVarK_PMA.Name = "groupBoxVarK_PMA";
            groupBoxVarK_PMA.Padding = new Padding(2, 3, 2, 3);
            groupBoxVarK_PMA.Size = new Size(169, 54);
            groupBoxVarK_PMA.TabIndex = 12;
            groupBoxVarK_PMA.TabStop = false;
            groupBoxVarK_PMA.Text = "Введите значение K:";
            // 
            // textBoxDigitalK_PMA
            // 
            textBoxDigitalK_PMA.BackColor = SystemColors.ControlLight;
            textBoxDigitalK_PMA.Location = new Point(6, 29);
            textBoxDigitalK_PMA.Margin = new Padding(2, 3, 2, 3);
            textBoxDigitalK_PMA.Name = "textBoxDigitalK_PMA";
            textBoxDigitalK_PMA.Size = new Size(159, 23);
            textBoxDigitalK_PMA.TabIndex = 2;
            // 
            // groupBoxVarC_PMA
            // 
            groupBoxVarC_PMA.Controls.Add(textBoxDigitalC_PMA);
            groupBoxVarC_PMA.Location = new Point(142, 198);
            groupBoxVarC_PMA.Margin = new Padding(2, 3, 2, 3);
            groupBoxVarC_PMA.Name = "groupBoxVarC_PMA";
            groupBoxVarC_PMA.Padding = new Padding(2, 3, 2, 3);
            groupBoxVarC_PMA.Size = new Size(169, 54);
            groupBoxVarC_PMA.TabIndex = 11;
            groupBoxVarC_PMA.TabStop = false;
            groupBoxVarC_PMA.Text = "Введите строка C:";
            // 
            // textBoxDigitalC_PMA
            // 
            textBoxDigitalC_PMA.BackColor = SystemColors.ControlLight;
            textBoxDigitalC_PMA.Location = new Point(6, 29);
            textBoxDigitalC_PMA.Margin = new Padding(2, 3, 2, 3);
            textBoxDigitalC_PMA.Name = "textBoxDigitalC_PMA";
            textBoxDigitalC_PMA.Size = new Size(159, 23);
            textBoxDigitalC_PMA.TabIndex = 2;
            // 
            // groupBoxVarN2_PMA
            // 
            groupBoxVarN2_PMA.Controls.Add(textBoxDigitalN2_PMA);
            groupBoxVarN2_PMA.Location = new Point(238, 117);
            groupBoxVarN2_PMA.Margin = new Padding(2, 3, 2, 3);
            groupBoxVarN2_PMA.Name = "groupBoxVarN2_PMA";
            groupBoxVarN2_PMA.Padding = new Padding(2, 3, 2, 3);
            groupBoxVarN2_PMA.Size = new Size(169, 63);
            groupBoxVarN2_PMA.TabIndex = 11;
            groupBoxVarN2_PMA.TabStop = false;
            groupBoxVarN2_PMA.Text = "Введите начало диапазона n2:";
            // 
            // textBoxDigitalN2_PMA
            // 
            textBoxDigitalN2_PMA.BackColor = SystemColors.ControlLight;
            textBoxDigitalN2_PMA.Location = new Point(6, 37);
            textBoxDigitalN2_PMA.Margin = new Padding(2, 3, 2, 3);
            textBoxDigitalN2_PMA.Name = "textBoxDigitalN2_PMA";
            textBoxDigitalN2_PMA.Size = new Size(159, 23);
            textBoxDigitalN2_PMA.TabIndex = 2;
            // 
            // groupBoxVarN1_PMA
            // 
            groupBoxVarN1_PMA.Controls.Add(textBoxDigitalN1_PMA);
            groupBoxVarN1_PMA.Location = new Point(24, 117);
            groupBoxVarN1_PMA.Margin = new Padding(2, 3, 2, 3);
            groupBoxVarN1_PMA.Name = "groupBoxVarN1_PMA";
            groupBoxVarN1_PMA.Padding = new Padding(2, 3, 2, 3);
            groupBoxVarN1_PMA.Size = new Size(169, 63);
            groupBoxVarN1_PMA.TabIndex = 10;
            groupBoxVarN1_PMA.TabStop = false;
            groupBoxVarN1_PMA.Text = "Введите начало диапазона n1:";
            // 
            // textBoxDigitalN1_PMA
            // 
            textBoxDigitalN1_PMA.BackColor = SystemColors.ControlLight;
            textBoxDigitalN1_PMA.Location = new Point(6, 37);
            textBoxDigitalN1_PMA.Margin = new Padding(2, 3, 2, 3);
            textBoxDigitalN1_PMA.Name = "textBoxDigitalN1_PMA";
            textBoxDigitalN1_PMA.Size = new Size(159, 23);
            textBoxDigitalN1_PMA.TabIndex = 2;
            // 
            // groupBoxVarM_PMA
            // 
            groupBoxVarM_PMA.Controls.Add(textBoxDigitalM_PMA);
            groupBoxVarM_PMA.Location = new Point(238, 31);
            groupBoxVarM_PMA.Margin = new Padding(2, 3, 2, 3);
            groupBoxVarM_PMA.Name = "groupBoxVarM_PMA";
            groupBoxVarM_PMA.Padding = new Padding(2, 3, 2, 3);
            groupBoxVarM_PMA.Size = new Size(169, 63);
            groupBoxVarM_PMA.TabIndex = 9;
            groupBoxVarM_PMA.TabStop = false;
            groupBoxVarM_PMA.Text = "Введите количество столбцов:";
            // 
            // textBoxDigitalM_PMA
            // 
            textBoxDigitalM_PMA.BackColor = SystemColors.ControlLight;
            textBoxDigitalM_PMA.Location = new Point(6, 37);
            textBoxDigitalM_PMA.Margin = new Padding(2, 3, 2, 3);
            textBoxDigitalM_PMA.Name = "textBoxDigitalM_PMA";
            textBoxDigitalM_PMA.Size = new Size(159, 23);
            textBoxDigitalM_PMA.TabIndex = 2;
            // 
            // groupBoxVarN_PMA
            // 
            groupBoxVarN_PMA.Controls.Add(textBoxDigitalN_PMA);
            groupBoxVarN_PMA.Location = new Point(24, 31);
            groupBoxVarN_PMA.Margin = new Padding(2, 3, 2, 3);
            groupBoxVarN_PMA.Name = "groupBoxVarN_PMA";
            groupBoxVarN_PMA.Padding = new Padding(2, 3, 2, 3);
            groupBoxVarN_PMA.Size = new Size(169, 63);
            groupBoxVarN_PMA.TabIndex = 8;
            groupBoxVarN_PMA.TabStop = false;
            groupBoxVarN_PMA.Text = "Введите количество строк:";
            // 
            // textBoxDigitalN_PMA
            // 
            textBoxDigitalN_PMA.BackColor = SystemColors.ControlLight;
            textBoxDigitalN_PMA.Location = new Point(6, 37);
            textBoxDigitalN_PMA.Margin = new Padding(2, 3, 2, 3);
            textBoxDigitalN_PMA.Name = "textBoxDigitalN_PMA";
            textBoxDigitalN_PMA.Size = new Size(159, 23);
            textBoxDigitalN_PMA.TabIndex = 2;
            // 
            // panelCenter_PMA
            // 
            panelCenter_PMA.Controls.Add(groupBoxUslovie_PMA);
            panelCenter_PMA.Dock = DockStyle.Top;
            panelCenter_PMA.Location = new Point(0, 0);
            panelCenter_PMA.Margin = new Padding(2, 3, 2, 3);
            panelCenter_PMA.Name = "panelCenter_PMA";
            panelCenter_PMA.Size = new Size(933, 93);
            panelCenter_PMA.TabIndex = 10;
            // 
            // groupBoxUslovie_PMA
            // 
            groupBoxUslovie_PMA.Controls.Add(textBoxUslovie_PMA);
            groupBoxUslovie_PMA.Dock = DockStyle.Fill;
            groupBoxUslovie_PMA.Location = new Point(0, 0);
            groupBoxUslovie_PMA.Margin = new Padding(2, 3, 2, 3);
            groupBoxUslovie_PMA.Name = "groupBoxUslovie_PMA";
            groupBoxUslovie_PMA.Padding = new Padding(2, 3, 2, 3);
            groupBoxUslovie_PMA.Size = new Size(933, 93);
            groupBoxUslovie_PMA.TabIndex = 9;
            groupBoxUslovie_PMA.TabStop = false;
            groupBoxUslovie_PMA.Text = "Условие";
            // 
            // textBoxUslovie_PMA
            // 
            textBoxUslovie_PMA.BorderStyle = BorderStyle.None;
            textBoxUslovie_PMA.Dock = DockStyle.Fill;
            textBoxUslovie_PMA.Location = new Point(2, 19);
            textBoxUslovie_PMA.Margin = new Padding(2);
            textBoxUslovie_PMA.Multiline = true;
            textBoxUslovie_PMA.Name = "textBoxUslovie_PMA";
            textBoxUslovie_PMA.ReadOnly = true;
            textBoxUslovie_PMA.Size = new Size(929, 71);
            textBoxUslovie_PMA.TabIndex = 0;
            textBoxUslovie_PMA.TabStop = false;
            textBoxUslovie_PMA.Text = resources.GetString("textBoxUslovie_PMA.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panelRight_PMA);
            Controls.Add(splitterOne_PMA);
            Controls.Add(panelLeft_PMA);
            Controls.Add(panelCenter_PMA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Спринт 6 | SprintReview | Вариант 11 | Писарев М. А.";
            Load += FormMain_Load;
            panelRight_PMA.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBoxRes_PMA.ResumeLayout(false);
            groupBoxRes_PMA.PerformLayout();
            groupBoxOut_PMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_PMA).EndInit();
            panelLeft_PMA.ResumeLayout(false);
            groupBoxIn_PMA.ResumeLayout(false);
            groupBoxVarL_PMA.ResumeLayout(false);
            groupBoxVarL_PMA.PerformLayout();
            groupBoxVarK_PMA.ResumeLayout(false);
            groupBoxVarK_PMA.PerformLayout();
            groupBoxVarC_PMA.ResumeLayout(false);
            groupBoxVarC_PMA.PerformLayout();
            groupBoxVarN2_PMA.ResumeLayout(false);
            groupBoxVarN2_PMA.PerformLayout();
            groupBoxVarN1_PMA.ResumeLayout(false);
            groupBoxVarN1_PMA.PerformLayout();
            groupBoxVarM_PMA.ResumeLayout(false);
            groupBoxVarM_PMA.PerformLayout();
            groupBoxVarN_PMA.ResumeLayout(false);
            groupBoxVarN_PMA.PerformLayout();
            panelCenter_PMA.ResumeLayout(false);
            groupBoxUslovie_PMA.ResumeLayout(false);
            groupBoxUslovie_PMA.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Panel panelRight_PMA;
        private Panel panel1;
        private Button buttonDone_PMA;
        private GroupBox groupBoxRes_PMA;
        private TextBox textBoxResultat_PMA;
        private GroupBox groupBoxOut_PMA;
        private DataGridView dataGridViewOut_PMA;
        private Splitter splitterOne_PMA;
        private Panel panelLeft_PMA;
        private GroupBox groupBoxIn_PMA;
        private GroupBox groupBoxVarL_PMA;
        private TextBox textBoxDigitalL_PMA;
        private Button buttonGeneration_PMA;
        private GroupBox groupBoxVarK_PMA;
        private TextBox textBoxDigitalK_PMA;
        private GroupBox groupBoxVarC_PMA;
        private TextBox textBoxDigitalC_PMA;
        private GroupBox groupBoxVarN2_PMA;
        private TextBox textBoxDigitalN2_PMA;
        private GroupBox groupBoxVarN1_PMA;
        private TextBox textBoxDigitalN1_PMA;
        private GroupBox groupBoxVarM_PMA;
        private TextBox textBoxDigitalM_PMA;
        private GroupBox groupBoxVarN_PMA;
        private TextBox textBoxDigitalN_PMA;
        private Panel panelCenter_PMA;
        private GroupBox groupBoxUslovie_PMA;
        private TextBox textBoxUslovie_PMA;
    }
}