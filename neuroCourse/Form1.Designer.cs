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
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
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
            this.mainSplitContainer.Size = new System.Drawing.Size(800, 450);
            this.mainSplitContainer.SplitterDistance = 229;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // learningSpeed
            // 
            this.learningSpeed.DecimalPlaces = 4;
            this.learningSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.learningSpeed.Location = new System.Drawing.Point(141, 94);
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
            this.learningSpeed.Size = new System.Drawing.Size(83, 23);
            this.learningSpeed.TabIndex = 9;
            this.learningSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numCategories
            // 
            this.numCategories.Location = new System.Drawing.Point(141, 67);
            this.numCategories.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCategories.Name = "numCategories";
            this.numCategories.Size = new System.Drawing.Size(83, 23);
            this.numCategories.TabIndex = 8;
            this.numCategories.Value = new decimal(new int[] {
            2,
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
            this.numEpochs.Location = new System.Drawing.Point(141, 41);
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
            this.numEpochs.Size = new System.Drawing.Size(83, 23);
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
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Скорость обучения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество категорий";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество эпох";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Обработать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // trainBtn
            // 
            this.trainBtn.Location = new System.Drawing.Point(11, 150);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Size = new System.Drawing.Size(213, 23);
            this.trainBtn.TabIndex = 2;
            this.trainBtn.Text = "Обучить";
            this.trainBtn.UseVisualStyleBackColor = true;
            this.trainBtn.Click += new System.EventHandler(this.trainBtn_Click);
            // 
            // choseTrainsetBtn
            // 
            this.choseTrainsetBtn.Location = new System.Drawing.Point(149, 11);
            this.choseTrainsetBtn.Name = "choseTrainsetBtn";
            this.choseTrainsetBtn.Size = new System.Drawing.Size(75, 23);
            this.choseTrainsetBtn.TabIndex = 1;
            this.choseTrainsetBtn.Text = "Выбрать";
            this.choseTrainsetBtn.UseVisualStyleBackColor = true;
            this.choseTrainsetBtn.Click += new System.EventHandler(this.choseTrainsetBtn_Click);
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(3, 12);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.ReadOnly = true;
            this.filePathBox.Size = new System.Drawing.Size(140, 23);
            this.filePathBox.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(565, 448);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
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
    }
}