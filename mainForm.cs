using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Opus_Encoder_GUI
{
    public partial class MainForm : Form
    {
        readonly ConvertingDialog _objConvertingDialog = new ConvertingDialog();

        public MainForm()
        {
            InitializeComponent();
        }

        void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
        }

        void convertButton_Click(object sender, EventArgs e)
        {
            StartConverting();
        }

        void StartConverting()
        {
            const string space = " ";
            const string doubleQuote = "\"";
            opusencProcess.StartInfo.Arguments = "--bitrate" + space + bitrateAdjuster.Value + space + doubleQuote + openFileDialog1.FileName + doubleQuote + space + doubleQuote + openFileDialog1.FileName + ".opus" + doubleQuote;
            opusencProcess.Start();
            _objConvertingDialog.ShowDialog(this);
        }

        void process1_Exited(object sender, EventArgs e)
        {
            _objConvertingDialog.Hide();
        }

        void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && convertButton.Enabled == false)
            {
                convertButton.Enabled = true;
            }
            else if (textBox1.Text.Length <= 0 && convertButton.Enabled)
            {
                convertButton.Enabled = false;
            }
        }

        void mainForm_Load(object sender, EventArgs e)
        {
        }
    }
}