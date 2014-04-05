namespace Opus_Encoder_GUI
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			textBox1 = new System.Windows.Forms.TextBox();
			button1 = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			bitrateAdjuster = new System.Windows.Forms.NumericUpDown();
			convertButton = new System.Windows.Forms.Button();
			opusencProcess = new System.Diagnostics.Process();
			openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(bitrateAdjuster)).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new System.Drawing.Point(12, 12);
			textBox1.Name = "textBox1";
			textBox1.ReadOnly = true;
			textBox1.Size = new System.Drawing.Size(120, 20);
			textBox1.TabIndex = 0;
			textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
			// 
			// button1
			// 
			button1.Location = new System.Drawing.Point(138, 10);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "Browse...";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Enabled = false;
			label1.Location = new System.Drawing.Point(92, 35);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(40, 13);
			label1.TabIndex = 2;
			label1.Text = "Bitrate:";
			// 
			// bitrateAdjuster
			// 
			bitrateAdjuster.Location = new System.Drawing.Point(53, 51);
			bitrateAdjuster.Maximum = new decimal(new int[] {
						256,
						0,
						0,
						0});
			bitrateAdjuster.Minimum = new decimal(new int[] {
						6,
						0,
						0,
						0});
			bitrateAdjuster.Name = "bitrateAdjuster";
			bitrateAdjuster.Size = new System.Drawing.Size(120, 20);
			bitrateAdjuster.TabIndex = 3;
			bitrateAdjuster.Value = new decimal(new int[] {
						32,
						0,
						0,
						0});
			// 
			// convertButton
			// 
			convertButton.Enabled = false;
			convertButton.Location = new System.Drawing.Point(75, 77);
			convertButton.Name = "convertButton";
			convertButton.Size = new System.Drawing.Size(75, 23);
			convertButton.TabIndex = 4;
			convertButton.Text = "Convert";
			convertButton.UseVisualStyleBackColor = true;
			convertButton.Click += new System.EventHandler(convertButton_Click);
			// 
			// opusencProcess
			// 
			opusencProcess.EnableRaisingEvents = true;
			opusencProcess.StartInfo.CreateNoWindow = true;
			opusencProcess.StartInfo.Domain = "";
			opusencProcess.StartInfo.ErrorDialog = true;
			opusencProcess.StartInfo.FileName = "opus-tools-0.1.8\\opusenc.exe";
			opusencProcess.StartInfo.LoadUserProfile = false;
			opusencProcess.StartInfo.Password = null;
			opusencProcess.StartInfo.StandardErrorEncoding = null;
			opusencProcess.StartInfo.StandardOutputEncoding = null;
			opusencProcess.StartInfo.UserName = "";
			opusencProcess.StartInfo.UseShellExecute = false;
			opusencProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			opusencProcess.SynchronizingObject = this;
			opusencProcess.Exited += new System.EventHandler(process1_Exited);
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			openFileDialog1.Filter = "Audio Files (*.wav, *.aiff, *.flac, *.ogg)|*.wav;*.aiff;*.flac;*.ogg";
			openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(openFileDialog1_FileOk);
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(234, 105);
			Controls.Add(convertButton);
			Controls.Add(bitrateAdjuster);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(textBox1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			MaximizeBox = false;
			Name = "MainForm";
			Text = "Opus Encoder";
			Load += new System.EventHandler(mainForm_Load);
			((System.ComponentModel.ISupportInitialize)(bitrateAdjuster)).EndInit();
			ResumeLayout(false);
			PerformLayout();

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

