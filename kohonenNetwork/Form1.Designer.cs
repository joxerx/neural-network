namespace kohonenNetwork
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
            this.numClusters = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.selfTrain = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numParams = new System.Windows.Forms.NumericUpDown();
            this.selfOrganise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numClusters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParams)).BeginInit();
            this.SuspendLayout();
            // 
            // numClusters
            // 
            this.numClusters.Location = new System.Drawing.Point(188, 7);
            this.numClusters.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numClusters.Name = "numClusters";
            this.numClusters.Size = new System.Drawing.Size(120, 23);
            this.numClusters.TabIndex = 0;
            this.numClusters.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кластеров";
            // 
            // selfTrain
            // 
            this.selfTrain.Location = new System.Drawing.Point(12, 7);
            this.selfTrain.Name = "selfTrain";
            this.selfTrain.Size = new System.Drawing.Size(100, 23);
            this.selfTrain.TabIndex = 2;
            this.selfTrain.Text = "Распределить";
            this.selfTrain.UseVisualStyleBackColor = true;
            this.selfTrain.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputBox
            // 
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputBox.Location = new System.Drawing.Point(0, 36);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(672, 305);
            this.outputBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Параметров";
            // 
            // numParams
            // 
            this.numParams.Location = new System.Drawing.Point(395, 7);
            this.numParams.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numParams.Name = "numParams";
            this.numParams.Size = new System.Drawing.Size(120, 23);
            this.numParams.TabIndex = 5;
            this.numParams.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // selfOrganise
            // 
            this.selfOrganise.Location = new System.Drawing.Point(521, 7);
            this.selfOrganise.Name = "selfOrganise";
            this.selfOrganise.Size = new System.Drawing.Size(139, 23);
            this.selfOrganise.TabIndex = 6;
            this.selfOrganise.Text = "Самоорганизация";
            this.selfOrganise.UseVisualStyleBackColor = true;
            this.selfOrganise.Click += new System.EventHandler(this.selfOrganise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 341);
            this.Controls.Add(this.selfOrganise);
            this.Controls.Add(this.numParams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.selfTrain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numClusters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numClusters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numClusters;
        private Label label1;
        private Button selfTrain;
        private TextBox outputBox;
        private Label label2;
        private NumericUpDown numParams;
        private Button selfOrganise;
    }
}