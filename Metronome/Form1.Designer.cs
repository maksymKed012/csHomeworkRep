namespace Metronome
{
    partial class MetronomeForm
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
            this.QuaterNotes = new System.Windows.Forms.RadioButton();
            this.EightNotes = new System.Windows.Forms.RadioButton();
            this.EightNoteTriplets = new System.Windows.Forms.RadioButton();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.TempoBar = new System.Windows.Forms.TrackBar();
            this.TempoBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.NumericUpDown();
            this.BarsCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TempoBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // QuaterNotes
            // 
            this.QuaterNotes.AutoSize = true;
            this.QuaterNotes.Checked = true;
            this.QuaterNotes.Location = new System.Drawing.Point(31, 12);
            this.QuaterNotes.Name = "QuaterNotes";
            this.QuaterNotes.Size = new System.Drawing.Size(86, 17);
            this.QuaterNotes.TabIndex = 0;
            this.QuaterNotes.TabStop = true;
            this.QuaterNotes.Text = "Quater notes";
            this.QuaterNotes.UseVisualStyleBackColor = true;
            this.QuaterNotes.CheckedChanged += new System.EventHandler(this.QuaterNotes_CheckedChanged);
            // 
            // EightNotes
            // 
            this.EightNotes.AutoSize = true;
            this.EightNotes.Location = new System.Drawing.Point(122, 12);
            this.EightNotes.Name = "EightNotes";
            this.EightNotes.Size = new System.Drawing.Size(69, 17);
            this.EightNotes.TabIndex = 1;
            this.EightNotes.Text = "8th notes";
            this.EightNotes.UseVisualStyleBackColor = true;
            this.EightNotes.CheckedChanged += new System.EventHandler(this.EightNotes_CheckedChanged);
            // 
            // EightNoteTriplets
            // 
            this.EightNoteTriplets.AutoSize = true;
            this.EightNoteTriplets.Location = new System.Drawing.Point(209, 12);
            this.EightNoteTriplets.Name = "EightNoteTriplets";
            this.EightNoteTriplets.Size = new System.Drawing.Size(97, 17);
            this.EightNoteTriplets.TabIndex = 2;
            this.EightNoteTriplets.Text = "8th note triplets";
            this.EightNoteTriplets.UseVisualStyleBackColor = true;
            this.EightNoteTriplets.CheckedChanged += new System.EventHandler(this.EightNoteTriplets_CheckedChanged);
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(41, 302);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(231, 111);
            this.StartStopButton.TabIndex = 3;
            this.StartStopButton.Text = "START/STOP";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStop_Click);
            this.StartStopButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartStop_MClick);
            // 
            // TempoBar
            // 
            this.TempoBar.Location = new System.Drawing.Point(41, 249);
            this.TempoBar.Name = "TempoBar";
            this.TempoBar.Size = new System.Drawing.Size(231, 45);
            this.TempoBar.TabIndex = 4;
            this.TempoBar.Scroll += new System.EventHandler(this.TempoBar_Scroll);
            // 
            // TempoBox
            // 
            this.TempoBox.Location = new System.Drawing.Point(100, 223);
            this.TempoBox.Name = "TempoBox";
            this.TempoBox.Size = new System.Drawing.Size(121, 20);
            this.TempoBox.TabIndex = 5;
            this.TempoBox.TextChanged += new System.EventHandler(this.Tempo_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(100, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Location = new System.Drawing.Point(31, 68);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(120, 20);
            this.Timer.TabIndex = 7;
            this.Timer.ValueChanged += new System.EventHandler(this.Timer_ValueChanged);
            // 
            // BarsCount
            // 
            this.BarsCount.Location = new System.Drawing.Point(31, 116);
            this.BarsCount.Name = "BarsCount";
            this.BarsCount.Size = new System.Drawing.Size(120, 20);
            this.BarsCount.TabIndex = 8;
            this.BarsCount.ValueChanged += new System.EventHandler(this.Bars_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Timer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bars";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MetronomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarsCount);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TempoBox);
            this.Controls.Add(this.TempoBar);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.EightNoteTriplets);
            this.Controls.Add(this.EightNotes);
            this.Controls.Add(this.QuaterNotes);
            this.Name = "MetronomeForm";
            this.Text = "Metronome";
            this.Load += new System.EventHandler(this.MetronomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TempoBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton QuaterNotes;
        private System.Windows.Forms.RadioButton EightNotes;
        private System.Windows.Forms.RadioButton EightNoteTriplets;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.TrackBar TempoBar;
        private System.Windows.Forms.TextBox TempoBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown Timer;
        private System.Windows.Forms.NumericUpDown BarsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

