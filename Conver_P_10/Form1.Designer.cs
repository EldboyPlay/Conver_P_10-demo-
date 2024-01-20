namespace Conver_P_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNumber = new TextBox();
            comboBoxBase = new ComboBox();
            labelEnterNumber = new Label();
            label1 = new Label();
            buttonConvert = new Button();
            labelResult = new Label();
            textBoxResult = new TextBox();
            label2 = new Label();
            ToolStripMenuItem = new MenuStrip();
            exitMenuItem_Click = new ToolStripMenuItem();
            historyMenuItem_Click = new ToolStripMenuItem();
            helpMenuItem_Click = new ToolStripMenuItem();
            buttonCopy_Click = new Button();
            ToolStripMenuItem.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(110, 40);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(123, 23);
            textBoxNumber.TabIndex = 0;
            // 
            // comboBoxBase
            // 
            comboBoxBase.FormattingEnabled = true;
            comboBoxBase.Location = new Point(233, 73);
            comboBoxBase.Name = "comboBoxBase";
            comboBoxBase.Size = new Size(78, 23);
            comboBoxBase.TabIndex = 1;
            // 
            // labelEnterNumber
            // 
            labelEnterNumber.AutoSize = true;
            labelEnterNumber.Location = new Point(22, 43);
            labelEnterNumber.Name = "labelEnterNumber";
            labelEnterNumber.Size = new Size(90, 15);
            labelEnterNumber.TabIndex = 2;
            labelEnterNumber.Text = "Введите число:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 76);
            label1.Name = "label1";
            label1.Size = new Size(211, 15);
            label1.TabIndex = 3;
            label1.Text = "Выберите основание системы (2-16):";
            // 
            // buttonConvert
            // 
            buttonConvert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonConvert.Location = new Point(151, 165);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(158, 53);
            buttonConvert.TabIndex = 4;
            buttonConvert.Text = "Конвертировать";
            buttonConvert.UseVisualStyleBackColor = true;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelResult.Location = new Point(21, 111);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(90, 21);
            labelResult.TabIndex = 5;
            labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(108, 109);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(123, 29);
            textBoxResult.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 5.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(346, 240);
            label2.Name = "label2";
            label2.Size = new Size(87, 10);
            label2.TabIndex = 11;
            label2.Text = "Версия программы: v.1.0";
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.BackColor = SystemColors.ControlLight;
            ToolStripMenuItem.Items.AddRange(new ToolStripItem[] { exitMenuItem_Click, historyMenuItem_Click, helpMenuItem_Click });
            ToolStripMenuItem.Location = new Point(0, 0);
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(436, 24);
            ToolStripMenuItem.TabIndex = 12;
            ToolStripMenuItem.Text = "menuStrip1";
            // 
            // exitMenuItem_Click
            // 
            exitMenuItem_Click.Name = "exitMenuItem_Click";
            exitMenuItem_Click.Size = new Size(54, 20);
            exitMenuItem_Click.Text = "Выход";
            exitMenuItem_Click.Click += exitMenuItem_Click_Click;
            // 
            // historyMenuItem_Click
            // 
            historyMenuItem_Click.Name = "historyMenuItem_Click";
            historyMenuItem_Click.Size = new Size(66, 20);
            historyMenuItem_Click.Text = "История";
            historyMenuItem_Click.Click += historyMenuItem_Click_Click;
            // 
            // helpMenuItem_Click
            // 
            helpMenuItem_Click.Name = "helpMenuItem_Click";
            helpMenuItem_Click.Size = new Size(65, 20);
            helpMenuItem_Click.Text = "Справка";
            helpMenuItem_Click.Click += helpMenuItem_Click_Click;
            // 
            // buttonCopy_Click
            // 
            buttonCopy_Click.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonCopy_Click.Location = new Point(154, 223);
            buttonCopy_Click.Name = "buttonCopy_Click";
            buttonCopy_Click.Size = new Size(152, 23);
            buttonCopy_Click.TabIndex = 13;
            buttonCopy_Click.Text = "Копировать результат";
            buttonCopy_Click.UseVisualStyleBackColor = true;
            buttonCopy_Click.Click += buttonCopy_Click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 253);
            Controls.Add(buttonCopy_Click);
            Controls.Add(ToolStripMenuItem);
            Controls.Add(label2);
            Controls.Add(textBoxResult);
            Controls.Add(labelResult);
            Controls.Add(buttonConvert);
            Controls.Add(label1);
            Controls.Add(labelEnterNumber);
            Controls.Add(comboBoxBase);
            Controls.Add(textBoxNumber);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Конвертор Conver_P_10";
            ToolStripMenuItem.ResumeLayout(false);
            ToolStripMenuItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumber;
        private ComboBox comboBoxBase;
        private Label labelEnterNumber;
        private Label label1;
        private Button buttonConvert;
        private Label labelResult;
        private TextBox textBoxResult;
        private Label label2;
        private MenuStrip ToolStripMenuItem;
        private ToolStripMenuItem exitMenuItem_Click;
        private ToolStripMenuItem historyMenuItem_Click;
        private ToolStripMenuItem helpMenuItem_Click;
        private Button buttonCopy_Click;
    }
}
