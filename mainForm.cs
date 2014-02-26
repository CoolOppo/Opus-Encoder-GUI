using System;
using System.Windows.Forms;

namespace Opus_Encoder_GUI
{
    public partial class mainForm : Form
    {
        Form objConvertingDialog = new convertingDialog();
        public mainForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string space = " ";
            string doubleQuote = @"""";
            opusencProcess.StartInfo.Arguments = "--bitrate" + space + bitrateAdjuster.Value.ToString() + space + doubleQuote + openFileDialog1.FileName + doubleQuote + space + doubleQuote + openFileDialog1.FileName + ".opus" + doubleQuote; // Somebody fix this mess

            convertButton.Enabled = false;
            this.UseWaitCursor = true;
            objConvertingDialog.Show();

            opusencProcess.Start();
        }

        private void process1_Exited(object sender, EventArgs e)
        {
            objConvertingDialog.Hide();
            this.UseWaitCursor = false;
            MessageBox.Show("Converting finished!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && convertButton.Enabled == false)
            {
                convertButton.Enabled = true;
            }
            else if (textBox1.Text.Length <= 0 && convertButton.Enabled == true)
            {
                convertButton.Enabled = false;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
