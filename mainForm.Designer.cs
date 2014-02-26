namespace Opus_Encoder_GUI
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bitrateAdjuster = new System.Windows.Forms.NumericUpDown();
            this.convertButton = new System.Windows.Forms.Button();
            this.opusencProcess = new System.Diagnostics.Process();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateAdjuster)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bitrate:";
            // 
            // bitrateAdjuster
            // 
            this.bitrateAdjuster.Location = new System.Drawing.Point(53, 51);
            this.bitrateAdjuster.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.bitrateAdjuster.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.bitrateAdjuster.Name = "bitrateAdjuster";
            this.bitrateAdjuster.Size = new System.Drawing.Size(120, 20);
            this.bitrateAdjuster.TabIndex = 3;
            this.bitrateAdjuster.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // convertButton
            // 
            this.convertButton.Enabled = false;
            this.convertButton.Location = new System.Drawing.Point(75, 77);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // opusencProcess
            // 
            this.opusencProcess.EnableRaisingEvents = true;
            this.opusencProcess.StartInfo.CreateNoWindow = true;
            this.opusencProcess.StartInfo.Domain = "";
            this.opusencProcess.StartInfo.ErrorDialog = true;
            this.opusencProcess.StartInfo.FileName = "opus-tools-0.1.8\\opusenc.exe";
            this.opusencProcess.StartInfo.LoadUserProfile = false;
            this.opusencProcess.StartInfo.Password = null;
            this.opusencProcess.StartInfo.StandardErrorEncoding = null;
            this.opusencProcess.StartInfo.StandardOutputEncoding = null;
            this.opusencProcess.StartInfo.UserName = "";
            this.opusencProcess.StartInfo.UseShellExecute = false;
            this.opusencProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            this.opusencProcess.SynchronizingObject = this;
            this.opusencProcess.Exited += new System.EventHandler(this.process1_Exited);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Audio Files (*.wav, *.aiff, *.flac, *.ogg)|*.wav;*.aiff;*.flac;*.ogg";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 111);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.bitrateAdjuster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Opus Encoder";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bitrateAdjuster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown bitrateAdjuster;
        private System.Windows.Forms.Button convertButton;
        private System.Diagnostics.Process opusencProcess;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

