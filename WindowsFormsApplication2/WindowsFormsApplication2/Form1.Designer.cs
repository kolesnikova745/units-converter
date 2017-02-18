namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.convertButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.lengthInitGroupBox = new System.Windows.Forms.GroupBox();
            this.dmInitRadioButton = new System.Windows.Forms.RadioButton();
            this.cmInitRadioButton = new System.Windows.Forms.RadioButton();
            this.mInitRadioButton = new System.Windows.Forms.RadioButton();
            this.kmInitRadioButton = new System.Windows.Forms.RadioButton();
            this.mmInitRadioButton = new System.Windows.Forms.RadioButton();
            this.lengthResGroupBox = new System.Windows.Forms.GroupBox();
            this.kmResRadioButton = new System.Windows.Forms.RadioButton();
            this.mResRadioButton = new System.Windows.Forms.RadioButton();
            this.dmResRadioButton = new System.Windows.Forms.RadioButton();
            this.cmResRadioButton = new System.Windows.Forms.RadioButton();
            this.mmResRadioButton = new System.Windows.Forms.RadioButton();
            this.massInitGroupBox = new System.Windows.Forms.GroupBox();
            this.tInitRadioButton = new System.Windows.Forms.RadioButton();
            this.centnerInitRadioButton = new System.Windows.Forms.RadioButton();
            this.kgInitRadioButton = new System.Windows.Forms.RadioButton();
            this.gInitRadioButton = new System.Windows.Forms.RadioButton();
            this.massResGroupBox = new System.Windows.Forms.GroupBox();
            this.tResRadioButton = new System.Windows.Forms.RadioButton();
            this.centnerResRadioButton = new System.Windows.Forms.RadioButton();
            this.kgResRadioButton = new System.Windows.Forms.RadioButton();
            this.gResRadioButton = new System.Windows.Forms.RadioButton();
            this.timeInitGroupBox = new System.Windows.Forms.GroupBox();
            this.hourInitRadioButton = new System.Windows.Forms.RadioButton();
            this.minInitRadioButton = new System.Windows.Forms.RadioButton();
            this.secInitRadioButton = new System.Windows.Forms.RadioButton();
            this.timeResGroupBox = new System.Windows.Forms.GroupBox();
            this.hourResRadioButton = new System.Windows.Forms.RadioButton();
            this.minResRadioButton = new System.Windows.Forms.RadioButton();
            this.secResRadioButton = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lengthInitGroupBox.SuspendLayout();
            this.lengthResGroupBox.SuspendLayout();
            this.massInitGroupBox.SuspendLayout();
            this.massResGroupBox.SuspendLayout();
            this.timeInitGroupBox.SuspendLayout();
            this.timeResGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Location = new System.Drawing.Point(277, 73);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(171, 33);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Перевести";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 47);
            this.inputTextBox.MaxLength = 20;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(303, 20);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите исходное значение";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(276, 112);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(172, 37);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить операцию";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результат";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(418, 47);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(277, 20);
            this.resultTextBox.TabIndex = 6;
            this.resultTextBox.TextChanged += new System.EventHandler(this.resultTextBox_TextChanged);
            // 
            // lengthInitGroupBox
            // 
            this.lengthInitGroupBox.Controls.Add(this.dmInitRadioButton);
            this.lengthInitGroupBox.Controls.Add(this.cmInitRadioButton);
            this.lengthInitGroupBox.Controls.Add(this.mInitRadioButton);
            this.lengthInitGroupBox.Controls.Add(this.kmInitRadioButton);
            this.lengthInitGroupBox.Controls.Add(this.mmInitRadioButton);
            this.lengthInitGroupBox.Location = new System.Drawing.Point(12, 150);
            this.lengthInitGroupBox.Name = "lengthInitGroupBox";
            this.lengthInitGroupBox.Size = new System.Drawing.Size(290, 43);
            this.lengthInitGroupBox.TabIndex = 10;
            this.lengthInitGroupBox.TabStop = false;
            this.lengthInitGroupBox.Text = "Исходная длина";
            this.lengthInitGroupBox.Enter += new System.EventHandler(this.lengthInitgroupBox_Enter);
            // 
            // dmInitRadioButton
            // 
            this.dmInitRadioButton.AutoSize = true;
            this.dmInitRadioButton.Location = new System.Drawing.Point(113, 19);
            this.dmInitRadioButton.Name = "dmInitRadioButton";
            this.dmInitRadioButton.Size = new System.Drawing.Size(39, 17);
            this.dmInitRadioButton.TabIndex = 9;
            this.dmInitRadioButton.TabStop = true;
            this.dmInitRadioButton.Text = "дм";
            this.dmInitRadioButton.UseVisualStyleBackColor = true;
            // 
            // cmInitRadioButton
            // 
            this.cmInitRadioButton.AutoSize = true;
            this.cmInitRadioButton.Location = new System.Drawing.Point(67, 20);
            this.cmInitRadioButton.Name = "cmInitRadioButton";
            this.cmInitRadioButton.Size = new System.Drawing.Size(39, 17);
            this.cmInitRadioButton.TabIndex = 8;
            this.cmInitRadioButton.TabStop = true;
            this.cmInitRadioButton.Text = "см";
            this.cmInitRadioButton.UseVisualStyleBackColor = true;
            // 
            // mInitRadioButton
            // 
            this.mInitRadioButton.AutoSize = true;
            this.mInitRadioButton.Location = new System.Drawing.Point(158, 19);
            this.mInitRadioButton.Name = "mInitRadioButton";
            this.mInitRadioButton.Size = new System.Drawing.Size(33, 17);
            this.mInitRadioButton.TabIndex = 0;
            this.mInitRadioButton.TabStop = true;
            this.mInitRadioButton.Text = "м";
            this.mInitRadioButton.UseVisualStyleBackColor = true;
            // 
            // kmInitRadioButton
            // 
            this.kmInitRadioButton.AutoSize = true;
            this.kmInitRadioButton.Location = new System.Drawing.Point(197, 19);
            this.kmInitRadioButton.Name = "kmInitRadioButton";
            this.kmInitRadioButton.Size = new System.Drawing.Size(39, 17);
            this.kmInitRadioButton.TabIndex = 1;
            this.kmInitRadioButton.TabStop = true;
            this.kmInitRadioButton.Text = "км";
            this.kmInitRadioButton.UseVisualStyleBackColor = true;
            // 
            // mmInitRadioButton
            // 
            this.mmInitRadioButton.AutoSize = true;
            this.mmInitRadioButton.Location = new System.Drawing.Point(20, 19);
            this.mmInitRadioButton.Name = "mmInitRadioButton";
            this.mmInitRadioButton.Size = new System.Drawing.Size(41, 17);
            this.mmInitRadioButton.TabIndex = 7;
            this.mmInitRadioButton.TabStop = true;
            this.mmInitRadioButton.Text = "мм";
            this.mmInitRadioButton.UseVisualStyleBackColor = true;
            // 
            // lengthResGroupBox
            // 
            this.lengthResGroupBox.Controls.Add(this.kmResRadioButton);
            this.lengthResGroupBox.Controls.Add(this.mResRadioButton);
            this.lengthResGroupBox.Controls.Add(this.dmResRadioButton);
            this.lengthResGroupBox.Controls.Add(this.cmResRadioButton);
            this.lengthResGroupBox.Controls.Add(this.mmResRadioButton);
            this.lengthResGroupBox.Location = new System.Drawing.Point(418, 153);
            this.lengthResGroupBox.Name = "lengthResGroupBox";
            this.lengthResGroupBox.Size = new System.Drawing.Size(277, 40);
            this.lengthResGroupBox.TabIndex = 11;
            this.lengthResGroupBox.TabStop = false;
            this.lengthResGroupBox.Text = "Конечная длина";
            // 
            // kmResRadioButton
            // 
            this.kmResRadioButton.AutoSize = true;
            this.kmResRadioButton.Location = new System.Drawing.Point(193, 17);
            this.kmResRadioButton.Name = "kmResRadioButton";
            this.kmResRadioButton.Size = new System.Drawing.Size(39, 17);
            this.kmResRadioButton.TabIndex = 13;
            this.kmResRadioButton.TabStop = true;
            this.kmResRadioButton.Text = "км";
            this.kmResRadioButton.UseVisualStyleBackColor = true;
            // 
            // mResRadioButton
            // 
            this.mResRadioButton.AutoSize = true;
            this.mResRadioButton.Location = new System.Drawing.Point(154, 17);
            this.mResRadioButton.Name = "mResRadioButton";
            this.mResRadioButton.Size = new System.Drawing.Size(33, 17);
            this.mResRadioButton.TabIndex = 12;
            this.mResRadioButton.TabStop = true;
            this.mResRadioButton.Text = "м";
            this.mResRadioButton.UseVisualStyleBackColor = true;
            // 
            // dmResRadioButton
            // 
            this.dmResRadioButton.AutoSize = true;
            this.dmResRadioButton.Location = new System.Drawing.Point(109, 17);
            this.dmResRadioButton.Name = "dmResRadioButton";
            this.dmResRadioButton.Size = new System.Drawing.Size(39, 17);
            this.dmResRadioButton.TabIndex = 11;
            this.dmResRadioButton.TabStop = true;
            this.dmResRadioButton.Text = "дм";
            this.dmResRadioButton.UseVisualStyleBackColor = true;
            // 
            // cmResRadioButton
            // 
            this.cmResRadioButton.AutoSize = true;
            this.cmResRadioButton.Location = new System.Drawing.Point(64, 17);
            this.cmResRadioButton.Name = "cmResRadioButton";
            this.cmResRadioButton.Size = new System.Drawing.Size(39, 17);
            this.cmResRadioButton.TabIndex = 10;
            this.cmResRadioButton.TabStop = true;
            this.cmResRadioButton.Text = "см";
            this.cmResRadioButton.UseVisualStyleBackColor = true;
            // 
            // mmResRadioButton
            // 
            this.mmResRadioButton.AutoSize = true;
            this.mmResRadioButton.Location = new System.Drawing.Point(17, 17);
            this.mmResRadioButton.Name = "mmResRadioButton";
            this.mmResRadioButton.Size = new System.Drawing.Size(41, 17);
            this.mmResRadioButton.TabIndex = 2;
            this.mmResRadioButton.TabStop = true;
            this.mmResRadioButton.Text = "мм";
            this.mmResRadioButton.UseVisualStyleBackColor = true;
            // 
            // massInitGroupBox
            // 
            this.massInitGroupBox.Controls.Add(this.tInitRadioButton);
            this.massInitGroupBox.Controls.Add(this.centnerInitRadioButton);
            this.massInitGroupBox.Controls.Add(this.kgInitRadioButton);
            this.massInitGroupBox.Controls.Add(this.gInitRadioButton);
            this.massInitGroupBox.Location = new System.Drawing.Point(13, 206);
            this.massInitGroupBox.Name = "massInitGroupBox";
            this.massInitGroupBox.Size = new System.Drawing.Size(288, 41);
            this.massInitGroupBox.TabIndex = 12;
            this.massInitGroupBox.TabStop = false;
            this.massInitGroupBox.Text = "Исходная масса";
            this.massInitGroupBox.Enter += new System.EventHandler(this.massInitGroupBox_Enter);
            // 
            // tInitRadioButton
            // 
            this.tInitRadioButton.AutoSize = true;
            this.tInitRadioButton.Location = new System.Drawing.Point(136, 19);
            this.tInitRadioButton.Name = "tInitRadioButton";
            this.tInitRadioButton.Size = new System.Drawing.Size(30, 17);
            this.tInitRadioButton.TabIndex = 3;
            this.tInitRadioButton.TabStop = true;
            this.tInitRadioButton.Text = "т";
            this.tInitRadioButton.UseVisualStyleBackColor = true;
            // 
            // centnerInitRadioButton
            // 
            this.centnerInitRadioButton.AutoSize = true;
            this.centnerInitRadioButton.Location = new System.Drawing.Point(99, 19);
            this.centnerInitRadioButton.Name = "centnerInitRadioButton";
            this.centnerInitRadioButton.Size = new System.Drawing.Size(31, 17);
            this.centnerInitRadioButton.TabIndex = 2;
            this.centnerInitRadioButton.TabStop = true;
            this.centnerInitRadioButton.Text = "ц";
            this.centnerInitRadioButton.UseVisualStyleBackColor = true;
            // 
            // kgInitRadioButton
            // 
            this.kgInitRadioButton.AutoSize = true;
            this.kgInitRadioButton.Location = new System.Drawing.Point(57, 18);
            this.kgInitRadioButton.Name = "kgInitRadioButton";
            this.kgInitRadioButton.Size = new System.Drawing.Size(36, 17);
            this.kgInitRadioButton.TabIndex = 1;
            this.kgInitRadioButton.TabStop = true;
            this.kgInitRadioButton.Text = "кг";
            this.kgInitRadioButton.UseVisualStyleBackColor = true;
            // 
            // gInitRadioButton
            // 
            this.gInitRadioButton.AutoSize = true;
            this.gInitRadioButton.Location = new System.Drawing.Point(19, 18);
            this.gInitRadioButton.Name = "gInitRadioButton";
            this.gInitRadioButton.Size = new System.Drawing.Size(30, 17);
            this.gInitRadioButton.TabIndex = 0;
            this.gInitRadioButton.TabStop = true;
            this.gInitRadioButton.Text = "г";
            this.gInitRadioButton.UseVisualStyleBackColor = true;
            // 
            // massResGroupBox
            // 
            this.massResGroupBox.Controls.Add(this.tResRadioButton);
            this.massResGroupBox.Controls.Add(this.centnerResRadioButton);
            this.massResGroupBox.Controls.Add(this.kgResRadioButton);
            this.massResGroupBox.Controls.Add(this.gResRadioButton);
            this.massResGroupBox.Location = new System.Drawing.Point(418, 206);
            this.massResGroupBox.Name = "massResGroupBox";
            this.massResGroupBox.Size = new System.Drawing.Size(276, 40);
            this.massResGroupBox.TabIndex = 13;
            this.massResGroupBox.TabStop = false;
            this.massResGroupBox.Text = "Конечная масса";
            // 
            // tResRadioButton
            // 
            this.tResRadioButton.AutoSize = true;
            this.tResRadioButton.Location = new System.Drawing.Point(121, 19);
            this.tResRadioButton.Name = "tResRadioButton";
            this.tResRadioButton.Size = new System.Drawing.Size(30, 17);
            this.tResRadioButton.TabIndex = 3;
            this.tResRadioButton.TabStop = true;
            this.tResRadioButton.Text = "т";
            this.tResRadioButton.UseVisualStyleBackColor = true;
            // 
            // centnerResRadioButton
            // 
            this.centnerResRadioButton.AutoSize = true;
            this.centnerResRadioButton.Location = new System.Drawing.Point(84, 19);
            this.centnerResRadioButton.Name = "centnerResRadioButton";
            this.centnerResRadioButton.Size = new System.Drawing.Size(31, 17);
            this.centnerResRadioButton.TabIndex = 2;
            this.centnerResRadioButton.TabStop = true;
            this.centnerResRadioButton.Text = "ц";
            this.centnerResRadioButton.UseVisualStyleBackColor = true;
            // 
            // kgResRadioButton
            // 
            this.kgResRadioButton.AutoSize = true;
            this.kgResRadioButton.Location = new System.Drawing.Point(42, 19);
            this.kgResRadioButton.Name = "kgResRadioButton";
            this.kgResRadioButton.Size = new System.Drawing.Size(36, 17);
            this.kgResRadioButton.TabIndex = 1;
            this.kgResRadioButton.TabStop = true;
            this.kgResRadioButton.Text = "кг";
            this.kgResRadioButton.UseVisualStyleBackColor = true;
            // 
            // gResRadioButton
            // 
            this.gResRadioButton.AutoSize = true;
            this.gResRadioButton.Location = new System.Drawing.Point(6, 19);
            this.gResRadioButton.Name = "gResRadioButton";
            this.gResRadioButton.Size = new System.Drawing.Size(30, 17);
            this.gResRadioButton.TabIndex = 0;
            this.gResRadioButton.TabStop = true;
            this.gResRadioButton.Text = "г";
            this.gResRadioButton.UseVisualStyleBackColor = true;
            // 
            // timeInitGroupBox
            // 
            this.timeInitGroupBox.Controls.Add(this.hourInitRadioButton);
            this.timeInitGroupBox.Controls.Add(this.minInitRadioButton);
            this.timeInitGroupBox.Controls.Add(this.secInitRadioButton);
            this.timeInitGroupBox.Location = new System.Drawing.Point(14, 262);
            this.timeInitGroupBox.Name = "timeInitGroupBox";
            this.timeInitGroupBox.Size = new System.Drawing.Size(287, 40);
            this.timeInitGroupBox.TabIndex = 14;
            this.timeInitGroupBox.TabStop = false;
            this.timeInitGroupBox.Text = "Исходный промежуток времени";
            this.timeInitGroupBox.Enter += new System.EventHandler(this.timeInitGroupBox_Enter);
            // 
            // hourInitRadioButton
            // 
            this.hourInitRadioButton.AutoSize = true;
            this.hourInitRadioButton.Location = new System.Drawing.Point(111, 17);
            this.hourInitRadioButton.Name = "hourInitRadioButton";
            this.hourInitRadioButton.Size = new System.Drawing.Size(30, 17);
            this.hourInitRadioButton.TabIndex = 2;
            this.hourInitRadioButton.TabStop = true;
            this.hourInitRadioButton.Text = "ч";
            this.hourInitRadioButton.UseVisualStyleBackColor = true;
            // 
            // minInitRadioButton
            // 
            this.minInitRadioButton.AutoSize = true;
            this.minInitRadioButton.Location = new System.Drawing.Point(56, 17);
            this.minInitRadioButton.Name = "minInitRadioButton";
            this.minInitRadioButton.Size = new System.Drawing.Size(45, 17);
            this.minInitRadioButton.TabIndex = 1;
            this.minInitRadioButton.TabStop = true;
            this.minInitRadioButton.Text = "мин";
            this.minInitRadioButton.UseVisualStyleBackColor = true;
            // 
            // secInitRadioButton
            // 
            this.secInitRadioButton.AutoSize = true;
            this.secInitRadioButton.Location = new System.Drawing.Point(13, 17);
            this.secInitRadioButton.Name = "secInitRadioButton";
            this.secInitRadioButton.Size = new System.Drawing.Size(31, 17);
            this.secInitRadioButton.TabIndex = 0;
            this.secInitRadioButton.TabStop = true;
            this.secInitRadioButton.Text = "с";
            this.secInitRadioButton.UseVisualStyleBackColor = true;
            // 
            // timeResGroupBox
            // 
            this.timeResGroupBox.Controls.Add(this.hourResRadioButton);
            this.timeResGroupBox.Controls.Add(this.minResRadioButton);
            this.timeResGroupBox.Controls.Add(this.secResRadioButton);
            this.timeResGroupBox.Location = new System.Drawing.Point(416, 262);
            this.timeResGroupBox.Name = "timeResGroupBox";
            this.timeResGroupBox.Size = new System.Drawing.Size(277, 39);
            this.timeResGroupBox.TabIndex = 15;
            this.timeResGroupBox.TabStop = false;
            this.timeResGroupBox.Text = "Конечный промежуток времени";
            // 
            // hourResRadioButton
            // 
            this.hourResRadioButton.AutoSize = true;
            this.hourResRadioButton.Location = new System.Drawing.Point(96, 17);
            this.hourResRadioButton.Name = "hourResRadioButton";
            this.hourResRadioButton.Size = new System.Drawing.Size(30, 17);
            this.hourResRadioButton.TabIndex = 2;
            this.hourResRadioButton.TabStop = true;
            this.hourResRadioButton.Text = "ч";
            this.hourResRadioButton.UseVisualStyleBackColor = true;
            // 
            // minResRadioButton
            // 
            this.minResRadioButton.AutoSize = true;
            this.minResRadioButton.Location = new System.Drawing.Point(45, 17);
            this.minResRadioButton.Name = "minResRadioButton";
            this.minResRadioButton.Size = new System.Drawing.Size(45, 17);
            this.minResRadioButton.TabIndex = 1;
            this.minResRadioButton.TabStop = true;
            this.minResRadioButton.Text = "мин";
            this.minResRadioButton.UseVisualStyleBackColor = true;
            // 
            // secResRadioButton
            // 
            this.secResRadioButton.AutoSize = true;
            this.secResRadioButton.Location = new System.Drawing.Point(8, 16);
            this.secResRadioButton.Name = "secResRadioButton";
            this.secResRadioButton.Size = new System.Drawing.Size(31, 17);
            this.secResRadioButton.TabIndex = 0;
            this.secResRadioButton.TabStop = true;
            this.secResRadioButton.Text = "с";
            this.secResRadioButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(300, 327);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 25);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(168, 21);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 403);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.timeResGroupBox);
            this.Controls.Add(this.timeInitGroupBox);
            this.Controls.Add(this.massResGroupBox);
            this.Controls.Add(this.massInitGroupBox);
            this.Controls.Add(this.lengthResGroupBox);
            this.Controls.Add(this.lengthInitGroupBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.convertButton);
            this.Name = "Form1";
            this.Text = "Конвертер единиц измерения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lengthInitGroupBox.ResumeLayout(false);
            this.lengthInitGroupBox.PerformLayout();
            this.lengthResGroupBox.ResumeLayout(false);
            this.lengthResGroupBox.PerformLayout();
            this.massInitGroupBox.ResumeLayout(false);
            this.massInitGroupBox.PerformLayout();
            this.massResGroupBox.ResumeLayout(false);
            this.massResGroupBox.PerformLayout();
            this.timeInitGroupBox.ResumeLayout(false);
            this.timeInitGroupBox.PerformLayout();
            this.timeResGroupBox.ResumeLayout(false);
            this.timeResGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.GroupBox lengthInitGroupBox;
        private System.Windows.Forms.RadioButton dmInitRadioButton;
        private System.Windows.Forms.RadioButton cmInitRadioButton;
        private System.Windows.Forms.RadioButton mInitRadioButton;
        private System.Windows.Forms.RadioButton kmInitRadioButton;
        private System.Windows.Forms.RadioButton mmInitRadioButton;
        private System.Windows.Forms.GroupBox lengthResGroupBox;
        private System.Windows.Forms.RadioButton kmResRadioButton;
        private System.Windows.Forms.RadioButton mResRadioButton;
        private System.Windows.Forms.RadioButton dmResRadioButton;
        private System.Windows.Forms.RadioButton cmResRadioButton;
        private System.Windows.Forms.RadioButton mmResRadioButton;
        private System.Windows.Forms.GroupBox massInitGroupBox;
        private System.Windows.Forms.RadioButton tInitRadioButton;
        private System.Windows.Forms.RadioButton centnerInitRadioButton;
        private System.Windows.Forms.RadioButton kgInitRadioButton;
        private System.Windows.Forms.RadioButton gInitRadioButton;
        private System.Windows.Forms.GroupBox massResGroupBox;
        private System.Windows.Forms.RadioButton tResRadioButton;
        private System.Windows.Forms.RadioButton centnerResRadioButton;
        private System.Windows.Forms.RadioButton kgResRadioButton;
        private System.Windows.Forms.RadioButton gResRadioButton;
        private System.Windows.Forms.GroupBox timeInitGroupBox;
        private System.Windows.Forms.RadioButton hourInitRadioButton;
        private System.Windows.Forms.RadioButton minInitRadioButton;
        private System.Windows.Forms.RadioButton secInitRadioButton;
        private System.Windows.Forms.GroupBox timeResGroupBox;
        private System.Windows.Forms.RadioButton hourResRadioButton;
        private System.Windows.Forms.RadioButton minResRadioButton;
        private System.Windows.Forms.RadioButton secResRadioButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

