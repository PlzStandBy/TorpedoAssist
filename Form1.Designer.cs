namespace TorpedoAssist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headRangeHead = new System.Windows.Forms.Label();
            this.headTargetSpeedHead = new System.Windows.Forms.Label();
            this.mastHeightLabel = new System.Windows.Forms.Label();
            this.mastHeightTextBox = new System.Windows.Forms.TextBox();
            this.linesNumberLabel = new System.Windows.Forms.Label();
            this.linesNumberTextBox = new System.Windows.Forms.TextBox();
            this.isZoomedBox = new System.Windows.Forms.CheckBox();
            this.calcRangeLabel = new System.Windows.Forms.Label();
            this.rangeValueLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lenghtTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.calcSpeedLabel = new System.Windows.Forms.Label();
            this.speedValueLabel = new System.Windows.Forms.Label();
            this.calculateRangeButton = new System.Windows.Forms.Button();
            this.calculateSpeedButton = new System.Windows.Forms.Button();
            this.targetNameHead = new System.Windows.Forms.Label();
            this.targetNameTextBox = new System.Windows.Forms.TextBox();
            this.notNecessaryLabel = new System.Windows.Forms.Label();
            this.calculationHistoryHead = new System.Windows.Forms.Label();
            this.historyTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.langLabel = new System.Windows.Forms.Label();
            this.ResetCLButton = new System.Windows.Forms.Button();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headRangeHead
            // 
            this.headRangeHead.AutoSize = true;
            this.headRangeHead.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headRangeHead.Location = new System.Drawing.Point(12, 53);
            this.headRangeHead.Name = "headRangeHead";
            this.headRangeHead.Size = new System.Drawing.Size(180, 18);
            this.headRangeHead.TabIndex = 0;
            this.headRangeHead.Text = "Дистанция до цели";
            // 
            // headTargetSpeedHead
            // 
            this.headTargetSpeedHead.AutoSize = true;
            this.headTargetSpeedHead.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headTargetSpeedHead.Location = new System.Drawing.Point(12, 204);
            this.headTargetSpeedHead.Name = "headTargetSpeedHead";
            this.headTargetSpeedHead.Size = new System.Drawing.Size(140, 18);
            this.headTargetSpeedHead.TabIndex = 1;
            this.headTargetSpeedHead.Text = "Скорость цели";
            // 
            // mastHeightLabel
            // 
            this.mastHeightLabel.AutoSize = true;
            this.mastHeightLabel.Location = new System.Drawing.Point(12, 77);
            this.mastHeightLabel.Name = "mastHeightLabel";
            this.mastHeightLabel.Size = new System.Drawing.Size(83, 13);
            this.mastHeightLabel.TabIndex = 2;
            this.mastHeightLabel.Text = "Высота мачты:";
            // 
            // mastHeightTextBox
            // 
            this.mastHeightTextBox.Location = new System.Drawing.Point(101, 74);
            this.mastHeightTextBox.Name = "mastHeightTextBox";
            this.mastHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.mastHeightTextBox.TabIndex = 3;
            this.mastHeightTextBox.Text = "0";
            // 
            // linesNumberLabel
            // 
            this.linesNumberLabel.AutoSize = true;
            this.linesNumberLabel.Location = new System.Drawing.Point(12, 105);
            this.linesNumberLabel.Name = "linesNumberLabel";
            this.linesNumberLabel.Size = new System.Drawing.Size(77, 13);
            this.linesNumberLabel.TabIndex = 4;
            this.linesNumberLabel.Text = "Кол-во рисок:";
            // 
            // linesNumberTextBox
            // 
            this.linesNumberTextBox.Location = new System.Drawing.Point(101, 102);
            this.linesNumberTextBox.Name = "linesNumberTextBox";
            this.linesNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.linesNumberTextBox.TabIndex = 5;
            this.linesNumberTextBox.Text = "0";
            // 
            // isZoomedBox
            // 
            this.isZoomedBox.AutoSize = true;
            this.isZoomedBox.Location = new System.Drawing.Point(15, 128);
            this.isZoomedBox.Name = "isZoomedBox";
            this.isZoomedBox.Size = new System.Drawing.Size(111, 17);
            this.isZoomedBox.TabIndex = 6;
            this.isZoomedBox.Text = "Есть увеличение";
            this.isZoomedBox.UseVisualStyleBackColor = true;
            // 
            // calcRangeLabel
            // 
            this.calcRangeLabel.AutoSize = true;
            this.calcRangeLabel.Location = new System.Drawing.Point(12, 181);
            this.calcRangeLabel.Name = "calcRangeLabel";
            this.calcRangeLabel.Size = new System.Drawing.Size(146, 13);
            this.calcRangeLabel.TabIndex = 7;
            this.calcRangeLabel.Text = "Рассчитанная дистанция = ";
            // 
            // rangeValueLabel
            // 
            this.rangeValueLabel.AutoSize = true;
            this.rangeValueLabel.Location = new System.Drawing.Point(155, 181);
            this.rangeValueLabel.Name = "rangeValueLabel";
            this.rangeValueLabel.Size = new System.Drawing.Size(13, 13);
            this.rangeValueLabel.TabIndex = 8;
            this.rangeValueLabel.Text = "0";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(12, 231);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(87, 13);
            this.lengthLabel.TabIndex = 9;
            this.lengthLabel.Text = "Длина цели (м):";
            // 
            // lenghtTextBox
            // 
            this.lenghtTextBox.Location = new System.Drawing.Point(101, 228);
            this.lenghtTextBox.Name = "lenghtTextBox";
            this.lenghtTextBox.Size = new System.Drawing.Size(100, 20);
            this.lenghtTextBox.TabIndex = 10;
            this.lenghtTextBox.Text = "0";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(12, 260);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(172, 13);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "Время на прохождение корпуса:";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(190, 257);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 12;
            this.timeTextBox.Text = "0";
            // 
            // calcSpeedLabel
            // 
            this.calcSpeedLabel.AutoSize = true;
            this.calcSpeedLabel.Location = new System.Drawing.Point(12, 308);
            this.calcSpeedLabel.Name = "calcSpeedLabel";
            this.calcSpeedLabel.Size = new System.Drawing.Size(107, 13);
            this.calcSpeedLabel.TabIndex = 13;
            this.calcSpeedLabel.Text = "Скорость в узлах = ";
            // 
            // speedValueLabel
            // 
            this.speedValueLabel.AutoSize = true;
            this.speedValueLabel.Location = new System.Drawing.Point(126, 308);
            this.speedValueLabel.Name = "speedValueLabel";
            this.speedValueLabel.Size = new System.Drawing.Size(13, 13);
            this.speedValueLabel.TabIndex = 14;
            this.speedValueLabel.Text = "0";
            // 
            // calculateRangeButton
            // 
            this.calculateRangeButton.Location = new System.Drawing.Point(15, 151);
            this.calculateRangeButton.Name = "calculateRangeButton";
            this.calculateRangeButton.Size = new System.Drawing.Size(155, 23);
            this.calculateRangeButton.TabIndex = 15;
            this.calculateRangeButton.Text = "Рассчитать дистанцию";
            this.calculateRangeButton.UseVisualStyleBackColor = true;
            this.calculateRangeButton.Click += new System.EventHandler(this.calculateRangeButton_Click);
            // 
            // calculateSpeedButton
            // 
            this.calculateSpeedButton.Location = new System.Drawing.Point(15, 282);
            this.calculateSpeedButton.Name = "calculateSpeedButton";
            this.calculateSpeedButton.Size = new System.Drawing.Size(153, 23);
            this.calculateSpeedButton.TabIndex = 16;
            this.calculateSpeedButton.Text = "Рассчитать скорость";
            this.calculateSpeedButton.UseVisualStyleBackColor = true;
            this.calculateSpeedButton.Click += new System.EventHandler(this.calculateSpeedButton_Click);
            // 
            // targetNameHead
            // 
            this.targetNameHead.AutoSize = true;
            this.targetNameHead.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetNameHead.Location = new System.Drawing.Point(12, 9);
            this.targetNameHead.Name = "targetNameHead";
            this.targetNameHead.Size = new System.Drawing.Size(99, 18);
            this.targetNameHead.TabIndex = 17;
            this.targetNameHead.Text = "Имя цели:";
            // 
            // targetNameTextBox
            // 
            this.targetNameTextBox.Location = new System.Drawing.Point(117, 7);
            this.targetNameTextBox.MaxLength = 16;
            this.targetNameTextBox.Name = "targetNameTextBox";
            this.targetNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.targetNameTextBox.TabIndex = 18;
            // 
            // notNecessaryLabel
            // 
            this.notNecessaryLabel.AutoSize = true;
            this.notNecessaryLabel.Location = new System.Drawing.Point(12, 30);
            this.notNecessaryLabel.Name = "notNecessaryLabel";
            this.notNecessaryLabel.Size = new System.Drawing.Size(119, 13);
            this.notNecessaryLabel.TabIndex = 19;
            this.notNecessaryLabel.Text = "(можно не указывать)";
            // 
            // calculationHistoryHead
            // 
            this.calculationHistoryHead.AutoSize = true;
            this.calculationHistoryHead.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculationHistoryHead.Location = new System.Drawing.Point(453, 9);
            this.calculationHistoryHead.Name = "calculationHistoryHead";
            this.calculationHistoryHead.Size = new System.Drawing.Size(171, 18);
            this.calculationHistoryHead.TabIndex = 20;
            this.calculationHistoryHead.Text = "История расчётов";
            // 
            // historyTextBox
            // 
            this.historyTextBox.AcceptsTab = true;
            this.historyTextBox.Location = new System.Drawing.Point(361, 30);
            this.historyTextBox.Multiline = true;
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ReadOnly = true;
            this.historyTextBox.Size = new System.Drawing.Size(342, 291);
            this.historyTextBox.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Русский",
            "English"});
            this.comboBox1.Location = new System.Drawing.Point(63, 330);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // langLabel
            // 
            this.langLabel.AutoSize = true;
            this.langLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.langLabel.Location = new System.Drawing.Point(12, 331);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(50, 16);
            this.langLabel.TabIndex = 23;
            this.langLabel.Text = "Язык:";
            // 
            // ResetCLButton
            // 
            this.ResetCLButton.Location = new System.Drawing.Point(586, 331);
            this.ResetCLButton.Name = "ResetCLButton";
            this.ResetCLButton.Size = new System.Drawing.Size(117, 23);
            this.ResetCLButton.TabIndex = 24;
            this.ResetCLButton.Text = "Очистить историю";
            this.ResetCLButton.UseVisualStyleBackColor = true;
            this.ResetCLButton.Click += new System.EventHandler(this.clearHistorybutton_Click);
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Location = new System.Drawing.Point(463, 331);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(117, 23);
            this.clearFieldsButton.TabIndex = 25;
            this.clearFieldsButton.Text = "Очистить поля";
            this.clearFieldsButton.UseVisualStyleBackColor = true;
            this.clearFieldsButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 361);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.ResetCLButton);
            this.Controls.Add(this.langLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.historyTextBox);
            this.Controls.Add(this.calculationHistoryHead);
            this.Controls.Add(this.notNecessaryLabel);
            this.Controls.Add(this.targetNameTextBox);
            this.Controls.Add(this.targetNameHead);
            this.Controls.Add(this.calculateSpeedButton);
            this.Controls.Add(this.calculateRangeButton);
            this.Controls.Add(this.speedValueLabel);
            this.Controls.Add(this.calcSpeedLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.lenghtTextBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.rangeValueLabel);
            this.Controls.Add(this.calcRangeLabel);
            this.Controls.Add(this.isZoomedBox);
            this.Controls.Add(this.linesNumberTextBox);
            this.Controls.Add(this.linesNumberLabel);
            this.Controls.Add(this.mastHeightTextBox);
            this.Controls.Add(this.mastHeightLabel);
            this.Controls.Add(this.headTargetSpeedHead);
            this.Controls.Add(this.headRangeHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(725, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(725, 400);
            this.Name = "Form1";
            this.Text = "TorpedoAssist 1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headRangeHead;
        private System.Windows.Forms.Label headTargetSpeedHead;
        private System.Windows.Forms.Label mastHeightLabel;
        private System.Windows.Forms.TextBox mastHeightTextBox;
        private System.Windows.Forms.Label linesNumberLabel;
        private System.Windows.Forms.TextBox linesNumberTextBox;
        private System.Windows.Forms.CheckBox isZoomedBox;
        private System.Windows.Forms.Label calcRangeLabel;
        private System.Windows.Forms.Label rangeValueLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lenghtTextBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label calcSpeedLabel;
        private System.Windows.Forms.Label speedValueLabel;
        private System.Windows.Forms.Button calculateRangeButton;
        private System.Windows.Forms.Button calculateSpeedButton;
        private System.Windows.Forms.Label targetNameHead;
        private System.Windows.Forms.TextBox targetNameTextBox;
        private System.Windows.Forms.Label notNecessaryLabel;
        private System.Windows.Forms.Label calculationHistoryHead;
        private System.Windows.Forms.TextBox historyTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label langLabel;
        private System.Windows.Forms.Button ResetCLButton;
        private System.Windows.Forms.Button clearFieldsButton;
    }
}

