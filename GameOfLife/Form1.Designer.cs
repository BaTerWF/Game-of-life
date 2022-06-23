namespace GameOfLife
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.nudDesity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.startBotton = new System.Windows.Forms.Button();
            this.stopBotton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nudDepopulation = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudOverpop = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverpop)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.nudOverpop);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.nudDepopulation);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.stopBotton);
            this.splitContainer1.Panel1.Controls.Add(this.startBotton);
            this.splitContainer1.Panel1.Controls.Add(this.nudDesity);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nudResolution);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1003, 421);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 417);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution";
            // 
            // nudResolution
            // 
            this.nudResolution.Location = new System.Drawing.Point(14, 30);
            this.nudResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.Size = new System.Drawing.Size(120, 22);
            this.nudResolution.TabIndex = 1;
            this.nudResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudResolution.ValueChanged += new System.EventHandler(this.nudResolution_ValueChanged);
            // 
            // nudDesity
            // 
            this.nudDesity.Location = new System.Drawing.Point(14, 93);
            this.nudDesity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDesity.Name = "nudDesity";
            this.nudDesity.Size = new System.Drawing.Size(120, 22);
            this.nudDesity.TabIndex = 3;
            this.nudDesity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDesity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Density";
            // 
            // startBotton
            // 
            this.startBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBotton.Location = new System.Drawing.Point(14, 239);
            this.startBotton.Name = "startBotton";
            this.startBotton.Size = new System.Drawing.Size(120, 23);
            this.startBotton.TabIndex = 4;
            this.startBotton.Text = "Start";
            this.startBotton.UseVisualStyleBackColor = true;
            this.startBotton.Click += new System.EventHandler(this.startBotton_Click);
            // 
            // stopBotton
            // 
            this.stopBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBotton.Location = new System.Drawing.Point(14, 269);
            this.stopBotton.Name = "stopBotton";
            this.stopBotton.Size = new System.Drawing.Size(120, 23);
            this.stopBotton.TabIndex = 5;
            this.stopBotton.Text = "Stop";
            this.stopBotton.UseVisualStyleBackColor = true;
            this.stopBotton.Click += new System.EventHandler(this.stopBotton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nudDepopulation
            // 
            this.nudDepopulation.Location = new System.Drawing.Point(14, 150);
            this.nudDepopulation.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudDepopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDepopulation.Name = "nudDepopulation";
            this.nudDepopulation.Size = new System.Drawing.Size(120, 22);
            this.nudDepopulation.TabIndex = 7;
            this.nudDepopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDepopulation.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Depopulation";
            // 
            // nudOverpop
            // 
            this.nudOverpop.Location = new System.Drawing.Point(14, 205);
            this.nudOverpop.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudOverpop.Name = "nudOverpop";
            this.nudOverpop.Size = new System.Drawing.Size(120, 22);
            this.nudOverpop.TabIndex = 9;
            this.nudOverpop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudOverpop.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Overpopulation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 421);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverpop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button stopBotton;
        private System.Windows.Forms.Button startBotton;
        private System.Windows.Forms.NumericUpDown nudDesity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown nudOverpop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDepopulation;
        private System.Windows.Forms.Label label3;
    }
}

