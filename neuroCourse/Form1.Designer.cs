namespace neuroCourse
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.numParameters = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.learningSpeed = new System.Windows.Forms.NumericUpDown();
            this.numCategories = new System.Windows.Forms.NumericUpDown();
            this.numEpochs = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trainBtn = new System.Windows.Forms.Button();
            this.choseTrainsetBtn = new System.Windows.Forms.Button();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEpochs)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.numParameters);
            this.mainSplitContainer.Panel1.Controls.Add(this.label4);
            this.mainSplitContainer.Panel1.Controls.Add(this.learningSpeed);
            this.mainSplitContainer.Panel1.Controls.Add(this.numCategories);
            this.mainSplitContainer.Panel1.Controls.Add(this.numEpochs);
            this.mainSplitContainer.Panel1.Controls.Add(this.label3);
            this.mainSplitContainer.Panel1.Controls.Add(this.label2);
            this.mainSplitContainer.Panel1.Controls.Add(this.label1);
            this.mainSplitContainer.Panel1.Controls.Add(this.button1);
            this.mainSplitContainer.Panel1.Controls.Add(this.trainBtn);
            this.mainSplitContainer.Panel1.Controls.Add(this.choseTrainsetBtn);
            this.mainSplitContainer.Panel1.Controls.Add(this.filePathBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.textBox1);
            this.mainSplitContainer.Size = new System.Drawing.Size(914, 600);
            this.mainSplitContainer.SplitterDistance = 261;
            this.mainSplitContainer.SplitterWidth = 5;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // numParameters
            // 
            this.numParameters.Location = new System.Drawing.Point(170, 180);
            this.numParameters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numParameters.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numParameters.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numParameters.Name = "numParameters";
            this.numParameters.Size = new System.Drawing.Size(95, 27);
            this.numParameters.TabIndex = 11;
            this.numParameters.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Количество параметров";
            // 
            // learningSpeed
            // 
            this.learningSpeed.DecimalPlaces = 4;
            this.learningSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.learningSpeed.Location = new System.Drawing.Point(161, 125);
            this.learningSpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.learningSpeed.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.learningSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.learningSpeed.Name = "learningSpeed";
            this.learningSpeed.Size = new System.Drawing.Size(95, 27);
            this.learningSpeed.TabIndex = 9;
            this.learningSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numCategories
            // 
            this.numCategories.Location = new System.Drawing.Point(161, 89);
            this.numCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCategories.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCategories.Name = "numCategories";
            this.numCategories.Size = new System.Drawing.Size(95, 27);
            this.numCategories.TabIndex = 8;
            this.numCategories.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numEpochs
            // 
            this.numEpochs.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEpochs.Location = new System.Drawing.Point(161, 55);
            this.numEpochs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numEpochs.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numEpochs.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEpochs.Name = "numEpochs";
            this.numEpochs.Size = new System.Drawing.Size(95, 27);
            this.numEpochs.TabIndex = 7;
            this.numEpochs.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Скорость обучения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество категорий";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество эпох";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 291);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Обработать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // trainBtn
            // 
            this.trainBtn.Location = new System.Drawing.Point(13, 236);
            this.trainBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Size = new System.Drawing.Size(243, 31);
            this.trainBtn.TabIndex = 2;
            this.trainBtn.Text = "Обучить";
            this.trainBtn.UseVisualStyleBackColor = true;
            this.trainBtn.Click += new System.EventHandler(this.trainBtn_Click);
            // 
            // choseTrainsetBtn
            // 
            this.choseTrainsetBtn.Location = new System.Drawing.Point(170, 15);
            this.choseTrainsetBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choseTrainsetBtn.Name = "choseTrainsetBtn";
            this.choseTrainsetBtn.Size = new System.Drawing.Size(86, 31);
            this.choseTrainsetBtn.TabIndex = 1;
            this.choseTrainsetBtn.Text = "Выбрать";
            this.choseTrainsetBtn.UseVisualStyleBackColor = true;
            this.choseTrainsetBtn.Click += new System.EventHandler(this.choseTrainsetBtn_Click);
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(3, 16);
            this.filePathBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.ReadOnly = true;
            this.filePathBox.Size = new System.Drawing.Size(159, 27);
            this.filePathBox.TabIndex = 0;
            this.filePathBox.Text = "C:\\Users\\user\\Desktop\\neuroCourse\\neuroCourse\\bin\\Debug\\net7.0-windows\\trainset.t" +
    "xt";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(646, 598);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.mainSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEpochs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer mainSplitContainer;
        private Button button1;
        private Button trainBtn;
        private Button choseTrainsetBtn;
        private TextBox filePathBox;
        private TextBox textBox1;
        private NumericUpDown learningSpeed;
        private NumericUpDown numCategories;
        private NumericUpDown numEpochs;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numParameters;
        private Label label4;
    }
}