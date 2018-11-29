using NAudio.Wave;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Soundboard.Controls
{
    public partial class PlayerControlWithContext : UserControl
    {
        public PlayerControlWithContext()
        {
            InitializeComponent();
        }

        string file = "";
        private IWavePlayer waveOut;
        private Mp3FileReader mp3FileReader;

        [Browsable(true)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        private string m_playerTag = "PLAYER";

        public string PlayerTag
        {
            get { return m_playerTag; }
            set
            {
                m_playerTag = value;
            }
        }


        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            pickAudioFile();


        }

        private void btnPlayAudio_Click(object sender, EventArgs e)
        {

    }

    private void btnStopAudio_Click(object sender, EventArgs e)
        {
            OnPlaybackStopped(this, e);

        }

        private void OnPlaybackStopped(object sender, EventArgs e)
        {
            try
            {
                this.waveOut.Dispose();
                this.mp3FileReader.Dispose();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        public void clearPathBox()
        {
            tbPath.Clear();
        btnPlayAudio.Text = "No file..";
        }

        public void savePathBox(string saveFilePath)
        {
            try
            {
                using (StreamWriter objWriter = new StreamWriter(saveFilePath, true))
                {

                    //objWriter.WriteLine(PlayerTag + " " + tbPath.Text);
                    objWriter.WriteLine(tbPath.Text);
                    //objWriter.WriteLine(",");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void loadPathBox(StreamReader sr, string lines)
        {
            try
            {
                if (lines != "")//(sr.ReadLine() != "")
                {
                    tbPath.Text = lines; //sr.ReadLine();
                    btnPlayAudio.Text = System.IO.Path.GetFileName(tbPath.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pickAudioFile()
        {
            int size = -1;
            openFileDialog1.Filter = ("Mp3|*.mp3|Alle|*.*");
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    tbPath.Text = file;
                    btnPlayAudio.Text = System.IO.Path.GetFileName(file); 

            }
                catch (IOException)
                {
                }

            }
        }

        private void tsiChooseFile_Click(object sender, EventArgs e)
        {
            pickAudioFile();
        }

        private void tsiDeleteFile_Click(object sender, EventArgs e)
        {
            clearPathBox();
        }

        private void tsiRenameButton_Click(object sender, EventArgs e)
        {

            var showDialog = this.ShowDialog("Button Name", "Rename the selected button");
            btnPlayAudio.Text = showDialog;
        }

        private void tsiPickButtonColor_Click(object sender, EventArgs e)
        {
              ColorDialog colorDlg = new ColorDialog();
                colorDlg.AllowFullOpen = true;
                colorDlg.AnyColor = true;

                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    btnPlayAudio.BackColor = colorDlg.Color;
                }


            }


        public string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 150;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.ShowDialog();
            return textBox.Text;
        }



    }
}



