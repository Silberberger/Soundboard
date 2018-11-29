namespace Soundboard.Controls
{
    partial class PlayerControlWithContext
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPlayAudio = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiChooseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiRenameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiPickButtonColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(16, 62);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(162, 22);
            this.tbPath.TabIndex = 7;
            this.tbPath.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPlayAudio
            // 
            this.btnPlayAudio.ContextMenuStrip = this.contextMenuStrip1;
            this.btnPlayAudio.Location = new System.Drawing.Point(3, 3);
            this.btnPlayAudio.Name = "btnPlayAudio";
            this.btnPlayAudio.Size = new System.Drawing.Size(78, 48);
            this.btnPlayAudio.TabIndex = 5;
            this.btnPlayAudio.Text = "No File..";
            this.btnPlayAudio.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiChooseFile,
            this.tsiDeleteFile,
            this.toolStripSeparator1,
            this.tsiRenameButton,
            this.tsiPickButtonColor});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(235, 106);
            // 
            // tsiChooseFile
            // 
            this.tsiChooseFile.Name = "tsiChooseFile";
            this.tsiChooseFile.Size = new System.Drawing.Size(234, 24);
            this.tsiChooseFile.Text = "Audiodatei auswählen...";
            // 
            // tsiDeleteFile
            // 
            this.tsiDeleteFile.Name = "tsiDeleteFile";
            this.tsiDeleteFile.Size = new System.Drawing.Size(234, 24);
            this.tsiDeleteFile.Text = "Audiodatei löschen";
            // 
            // tsiRenameButton
            // 
            this.tsiRenameButton.Name = "tsiRenameButton";
            this.tsiRenameButton.Size = new System.Drawing.Size(234, 24);
            this.tsiRenameButton.Text = "Button umbennen";
            this.tsiRenameButton.Click += new System.EventHandler(this.tsiRenameButton_Click);
            // 
            // tsiPickButtonColor
            // 
            this.tsiPickButtonColor.Name = "tsiPickButtonColor";
            this.tsiPickButtonColor.Size = new System.Drawing.Size(234, 24);
            this.tsiPickButtonColor.Text = "Button umfärben";
            this.tsiPickButtonColor.Click += new System.EventHandler(this.tsiPickButtonColor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // PlayerControlWithContext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnPlayAudio);
            this.Name = "PlayerControlWithContext";
            this.Size = new System.Drawing.Size(83, 54);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnPlayAudio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsiChooseFile;
        private System.Windows.Forms.ToolStripMenuItem tsiDeleteFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsiRenameButton;
        private System.Windows.Forms.ToolStripMenuItem tsiPickButtonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
