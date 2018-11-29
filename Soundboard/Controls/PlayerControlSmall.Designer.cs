namespace Soundboard.Controls
{
    partial class PlayerControlSmall
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
            this.tbPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnStopAudio = new System.Windows.Forms.Button();
            this.btnPlayAudio = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiChooseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonUmbennenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(12, 47);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(162, 22);
            this.tbPath.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = "C:\\\\";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(101, 19);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(36, 22);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(10, 0);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(119, 17);
            this.lblFilename.TabIndex = 4;
            this.lblFilename.Text = "Keine Soundfile...";
            // 
            // btnStopAudio
            // 
            this.btnStopAudio.Image = global::Soundboard.Properties.Resources.Stop_16x;
            this.btnStopAudio.Location = new System.Drawing.Point(57, 20);
            this.btnStopAudio.Name = "btnStopAudio";
            this.btnStopAudio.Size = new System.Drawing.Size(38, 21);
            this.btnStopAudio.TabIndex = 1;
            this.btnStopAudio.UseVisualStyleBackColor = true;
            this.btnStopAudio.Click += new System.EventHandler(this.btnStopAudio_Click);
            // 
            // btnPlayAudio
            // 
            this.btnPlayAudio.Image = global::Soundboard.Properties.Resources.PlayVideo_16x;
            this.btnPlayAudio.Location = new System.Drawing.Point(13, 20);
            this.btnPlayAudio.Name = "btnPlayAudio";
            this.btnPlayAudio.Size = new System.Drawing.Size(38, 21);
            this.btnPlayAudio.TabIndex = 0;
            this.btnPlayAudio.Text = "\r\n";
            this.btnPlayAudio.UseVisualStyleBackColor = true;
            this.btnPlayAudio.Click += new System.EventHandler(this.btnPlayAudio_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiChooseFile,
            this.tsiDeleteFile,
            this.buttonUmbennenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(235, 76);
            // 
            // tsiChooseFile
            // 
            this.tsiChooseFile.Name = "tsiChooseFile";
            this.tsiChooseFile.Size = new System.Drawing.Size(234, 24);
            this.tsiChooseFile.Text = "Audiodatei auswählen...";
            this.tsiChooseFile.Click += new System.EventHandler(this.tsiChooseFile_Click);
            // 
            // tsiDeleteFile
            // 
            this.tsiDeleteFile.Name = "tsiDeleteFile";
            this.tsiDeleteFile.Size = new System.Drawing.Size(234, 24);
            this.tsiDeleteFile.Text = "Audiodatei löschen";
            this.tsiDeleteFile.Click += new System.EventHandler(this.tsiDeleteFile_Click);
            // 
            // buttonUmbennenToolStripMenuItem
            // 
            this.buttonUmbennenToolStripMenuItem.Name = "buttonUmbennenToolStripMenuItem";
            this.buttonUmbennenToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.buttonUmbennenToolStripMenuItem.Text = "Button umbennen";
            // 
            // PlayerControlSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnStopAudio);
            this.Controls.Add(this.btnPlayAudio);
            this.Name = "PlayerControlSmall";
            this.Size = new System.Drawing.Size(149, 47);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayAudio;
        private System.Windows.Forms.Button btnStopAudio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblFilename;
        public System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsiChooseFile;
        private System.Windows.Forms.ToolStripMenuItem tsiDeleteFile;
        private System.Windows.Forms.ToolStripMenuItem buttonUmbennenToolStripMenuItem;
    }
}

