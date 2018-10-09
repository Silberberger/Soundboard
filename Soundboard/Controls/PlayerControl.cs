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
    public partial class PlayerControl : UserControl
    {

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

        public PlayerControl()
        {
            InitializeComponent();

            
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
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
                    lblFilename.Text = System.IO.Path.GetFileName(file);
                }
                catch (IOException)
                {
                }

            }
        }

            private void btnPlayAudio_Click(object sender, EventArgs e)
            {
                if (tbPath.Text != null)
                { 
                    try
                    {

                    this.waveOut = new WaveOut(); 
                    this.mp3FileReader = new Mp3FileReader(tbPath.Text);
                    this.waveOut.Init(mp3FileReader);
                    this.waveOut.Play();
                    this.waveOut.PlaybackStopped += OnPlaybackStopped;
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine(ex.Message);
                    }
                }
                else
                {

                MessageBox.Show("Du musst zuerst eine Audiofile auswählen, du Maske!");

                }


            }

        private void btnStopAudio_Click(object sender, EventArgs e)
        {
            OnPlaybackStopped(this, e );

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
            lblFilename.Text = "Keine Soundfile...";
        }

        public void savePathBox()
        {
            string file_name = "C:\\SoundboardSave.txt";

            try
            {
                using (StreamWriter objWriter = new StreamWriter(file_name, true))
                {
                    //objWriter.WriteLine(PlayerTag + " " + tbPath.Text);
                    objWriter.WriteLine(tbPath.Text);
                    objWriter.WriteLine(",");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //public void loadPathBox(string plyrTg)
        //{
        //    try
        //    {
        //        using (StreamReader reader = File.OpenText("C:\\"))
        //        {
        //            foreach (var line in File.ReadAllLines("C:\\"))
        //            {
        //                var lineCount = File.ReadLines(@"C:\\").Count();

        //                if (lineCount.ToString() == plyrTg)
        //                {
        //                    tbPath.Text = reader.ReadLine();
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

    }
}


