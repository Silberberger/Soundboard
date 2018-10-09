using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Soundboard.Controls;
using System.IO;

namespace Soundboard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control cntrl in tabControl1.TabPages)
            {
                foreach(Control ctrls in cntrl.Controls)
                { 
                if (ctrls is PlayerControl pc) 
                    {
                        pc.clearPathBox();
                    }
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveTabPage1_Click(object sender, EventArgs e)
        {

            foreach (Control cntrl in tabControl1.TabPages)
            {
                foreach (Control ctrls in cntrl.Controls)
                {
                    if (ctrls is PlayerControl pc)
                    {
                        pc.savePathBox();
                    }
                }

            }
            //using (StreamWriter objWriter = new StreamWriter(file_name, true))
            //{
            //    objWriter.WriteLine(playerControl1.tbPath.Text);
            //    objWriter.WriteLine(playerControl2.tbPath.Text);
            //    objWriter.WriteLine(playerControl3.tbPath.Text);
            //    objWriter.WriteLine(playerControl4.tbPath.Text);
            //}
        }

        private void btnLoadTabPage1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Funktioniert noch nicht richtig, wird gefixed");
            //foreach (Control cntrl in tabControl1.TabPages)
            //{
            //    foreach (Control ctrls in cntrl.Controls)
            //    {
            //        if (ctrls is PlayerControl pc)
            //        {
            //            var plyrTag = pc.PlayerTag;
            //            pc.loadPathBox(plyrTag);
            //        }
            //    }

            //}
            //{
            //    loadPathBox();
            //}
        }
    }
}
