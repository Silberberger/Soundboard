namespace Soundboard
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClearAllFiles = new System.Windows.Forms.Button();
            this.lblPoweredBy = new System.Windows.Forms.Label();
            this.lblMimon = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoadTabPage1 = new System.Windows.Forms.Button();
            this.btnSaveTabPage1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSaveNo = new System.Windows.Forms.RadioButton();
            this.rbSaveYes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.playerControl5 = new Soundboard.Controls.PlayerControl();
            this.playerControl9 = new Soundboard.Controls.PlayerControl();
            this.playerControl4 = new Soundboard.Controls.PlayerControl();
            this.playerControl2 = new Soundboard.Controls.PlayerControl();
            this.playerControl3 = new Soundboard.Controls.PlayerControl();
            this.playerControl1 = new Soundboard.Controls.PlayerControl();
            this.playerControl6 = new Soundboard.Controls.PlayerControl();
            this.playerControl7 = new Soundboard.Controls.PlayerControl();
            this.playerControl8 = new Soundboard.Controls.PlayerControl();
            this.playerControl15 = new Soundboard.Controls.PlayerControl();
            this.playerControl10 = new Soundboard.Controls.PlayerControl();
            this.playerControl11 = new Soundboard.Controls.PlayerControl();
            this.playerControl12 = new Soundboard.Controls.PlayerControl();
            this.playerControl13 = new Soundboard.Controls.PlayerControl();
            this.playerControl14 = new Soundboard.Controls.PlayerControl();
            this.playerControl16 = new Soundboard.Controls.PlayerControl();
            this.playerControl17 = new Soundboard.Controls.PlayerControl();
            this.playerControl18 = new Soundboard.Controls.PlayerControl();
            this.playerControl19 = new Soundboard.Controls.PlayerControl();
            this.playerControl20 = new Soundboard.Controls.PlayerControl();
            this.playerControl21 = new Soundboard.Controls.PlayerControl();
            this.playerControl22 = new Soundboard.Controls.PlayerControl();
            this.playerControl23 = new Soundboard.Controls.PlayerControl();
            this.playerControl24 = new Soundboard.Controls.PlayerControl();
            this.playerControl25 = new Soundboard.Controls.PlayerControl();
            this.playerControl26 = new Soundboard.Controls.PlayerControl();
            this.playerControl27 = new Soundboard.Controls.PlayerControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(721, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClearAllFiles
            // 
            this.btnClearAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearAllFiles.Location = new System.Drawing.Point(12, 471);
            this.btnClearAllFiles.Name = "btnClearAllFiles";
            this.btnClearAllFiles.Size = new System.Drawing.Size(128, 45);
            this.btnClearAllFiles.TabIndex = 7;
            this.btnClearAllFiles.Text = "Alle löschen";
            this.btnClearAllFiles.UseVisualStyleBackColor = true;
            this.btnClearAllFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPoweredBy
            // 
            this.lblPoweredBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPoweredBy.AutoSize = true;
            this.lblPoweredBy.Location = new System.Drawing.Point(295, 498);
            this.lblPoweredBy.Name = "lblPoweredBy";
            this.lblPoweredBy.Size = new System.Drawing.Size(251, 17);
            this.lblPoweredBy.TabIndex = 11;
            this.lblPoweredBy.Text = "Sponsored by NWO_Wizard and Apo. ";
            // 
            // lblMimon
            // 
            this.lblMimon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMimon.AutoSize = true;
            this.lblMimon.Location = new System.Drawing.Point(742, 512);
            this.lblMimon.Name = "lblMimon";
            this.lblMimon.Size = new System.Drawing.Size(113, 17);
            this.lblMimon.TabIndex = 12;
            this.lblMimon.Text = "Fuck you Mimon!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(861, 465);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnLoadTabPage1);
            this.tabPage1.Controls.Add(this.btnSaveTabPage1);
            this.tabPage1.Controls.Add(this.playerControl5);
            this.tabPage1.Controls.Add(this.playerControl9);
            this.tabPage1.Controls.Add(this.playerControl4);
            this.tabPage1.Controls.Add(this.playerControl2);
            this.tabPage1.Controls.Add(this.playerControl3);
            this.tabPage1.Controls.Add(this.playerControl1);
            this.tabPage1.Controls.Add(this.playerControl6);
            this.tabPage1.Controls.Add(this.playerControl7);
            this.tabPage1.Controls.Add(this.playerControl8);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(853, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Seite 1";
            // 
            // btnLoadTabPage1
            // 
            this.btnLoadTabPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTabPage1.Location = new System.Drawing.Point(8, 385);
            this.btnLoadTabPage1.Name = "btnLoadTabPage1";
            this.btnLoadTabPage1.Size = new System.Drawing.Size(128, 45);
            this.btnLoadTabPage1.TabIndex = 12;
            this.btnLoadTabPage1.Text = "Laden";
            this.btnLoadTabPage1.UseVisualStyleBackColor = true;
            this.btnLoadTabPage1.Click += new System.EventHandler(this.btnLoadTabPage1_Click);
            // 
            // btnSaveTabPage1
            // 
            this.btnSaveTabPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTabPage1.Location = new System.Drawing.Point(717, 380);
            this.btnSaveTabPage1.Name = "btnSaveTabPage1";
            this.btnSaveTabPage1.Size = new System.Drawing.Size(128, 45);
            this.btnSaveTabPage1.TabIndex = 11;
            this.btnSaveTabPage1.Text = "Speichern";
            this.btnSaveTabPage1.UseVisualStyleBackColor = true;
            this.btnSaveTabPage1.Click += new System.EventHandler(this.btnSaveTabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.playerControl15);
            this.tabPage2.Controls.Add(this.playerControl10);
            this.tabPage2.Controls.Add(this.playerControl11);
            this.tabPage2.Controls.Add(this.playerControl12);
            this.tabPage2.Controls.Add(this.playerControl13);
            this.tabPage2.Controls.Add(this.playerControl14);
            this.tabPage2.Controls.Add(this.playerControl16);
            this.tabPage2.Controls.Add(this.playerControl17);
            this.tabPage2.Controls.Add(this.playerControl18);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(853, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Seite 2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.playerControl19);
            this.tabPage3.Controls.Add(this.playerControl20);
            this.tabPage3.Controls.Add(this.playerControl21);
            this.tabPage3.Controls.Add(this.playerControl22);
            this.tabPage3.Controls.Add(this.playerControl23);
            this.tabPage3.Controls.Add(this.playerControl24);
            this.tabPage3.Controls.Add(this.playerControl25);
            this.tabPage3.Controls.Add(this.playerControl26);
            this.tabPage3.Controls.Add(this.playerControl27);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(853, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Seite 3";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tabSettings.Controls.Add(this.label5);
            this.tabSettings.Controls.Add(this.panel1);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(853, 436);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Einstellungen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(535, 55);
            this.label5.TabIndex = 5;
            this.label5.Text = "WORK IN PROGRESS";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbSaveNo);
            this.panel1.Controls.Add(this.rbSaveYes);
            this.panel1.Location = new System.Drawing.Point(8, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 192);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Speicherpfad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Speichern:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tabs speichern?";
            // 
            // rbSaveNo
            // 
            this.rbSaveNo.AutoSize = true;
            this.rbSaveNo.Checked = true;
            this.rbSaveNo.Location = new System.Drawing.Point(134, 76);
            this.rbSaveNo.Name = "rbSaveNo";
            this.rbSaveNo.Size = new System.Drawing.Size(58, 21);
            this.rbSaveNo.TabIndex = 3;
            this.rbSaveNo.TabStop = true;
            this.rbSaveNo.Text = "Nein";
            this.rbSaveNo.UseVisualStyleBackColor = true;
            // 
            // rbSaveYes
            // 
            this.rbSaveYes.AutoSize = true;
            this.rbSaveYes.Location = new System.Drawing.Point(53, 76);
            this.rbSaveYes.Name = "rbSaveYes";
            this.rbSaveYes.Size = new System.Drawing.Size(44, 21);
            this.rbSaveYes.TabIndex = 2;
            this.rbSaveYes.Text = "Ja";
            this.rbSaveYes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Einstellungen!";
            // 
            // playerControl5
            // 
            this.playerControl5.Location = new System.Drawing.Point(310, 137);
            this.playerControl5.Name = "playerControl5";
            this.playerControl5.PlayerTag = "5";
            this.playerControl5.Size = new System.Drawing.Size(225, 107);
            this.playerControl5.TabIndex = 4;
            // 
            // playerControl9
            // 
            this.playerControl9.Location = new System.Drawing.Point(608, 267);
            this.playerControl9.Name = "playerControl9";
            this.playerControl9.PlayerTag = "9";
            this.playerControl9.Size = new System.Drawing.Size(225, 107);
            this.playerControl9.TabIndex = 10;
            // 
            // playerControl4
            // 
            this.playerControl4.Location = new System.Drawing.Point(12, 137);
            this.playerControl4.Name = "playerControl4";
            this.playerControl4.PlayerTag = "4";
            this.playerControl4.Size = new System.Drawing.Size(225, 107);
            this.playerControl4.TabIndex = 3;
            // 
            // playerControl2
            // 
            this.playerControl2.Location = new System.Drawing.Point(310, 7);
            this.playerControl2.Name = "playerControl2";
            this.playerControl2.PlayerTag = "2";
            this.playerControl2.Size = new System.Drawing.Size(225, 107);
            this.playerControl2.TabIndex = 1;
            // 
            // playerControl3
            // 
            this.playerControl3.Location = new System.Drawing.Point(608, 7);
            this.playerControl3.Name = "playerControl3";
            this.playerControl3.PlayerTag = "3";
            this.playerControl3.Size = new System.Drawing.Size(225, 107);
            this.playerControl3.TabIndex = 2;
            // 
            // playerControl1
            // 
            this.playerControl1.Location = new System.Drawing.Point(12, 7);
            this.playerControl1.Name = "playerControl1";
            this.playerControl1.PlayerTag = "1";
            this.playerControl1.Size = new System.Drawing.Size(225, 107);
            this.playerControl1.TabIndex = 0;
            // 
            // playerControl6
            // 
            this.playerControl6.Location = new System.Drawing.Point(608, 137);
            this.playerControl6.Name = "playerControl6";
            this.playerControl6.PlayerTag = "6";
            this.playerControl6.Size = new System.Drawing.Size(225, 107);
            this.playerControl6.TabIndex = 5;
            // 
            // playerControl7
            // 
            this.playerControl7.Location = new System.Drawing.Point(12, 267);
            this.playerControl7.Name = "playerControl7";
            this.playerControl7.PlayerTag = "7";
            this.playerControl7.Size = new System.Drawing.Size(225, 107);
            this.playerControl7.TabIndex = 8;
            // 
            // playerControl8
            // 
            this.playerControl8.Location = new System.Drawing.Point(310, 267);
            this.playerControl8.Name = "playerControl8";
            this.playerControl8.PlayerTag = "8";
            this.playerControl8.Size = new System.Drawing.Size(225, 107);
            this.playerControl8.TabIndex = 9;
            // 
            // playerControl15
            // 
            this.playerControl15.Location = new System.Drawing.Point(12, 7);
            this.playerControl15.Name = "playerControl15";
            this.playerControl15.PlayerTag = "PLAYER";
            this.playerControl15.Size = new System.Drawing.Size(225, 107);
            this.playerControl15.TabIndex = 20;
            // 
            // playerControl10
            // 
            this.playerControl10.Location = new System.Drawing.Point(310, 137);
            this.playerControl10.Name = "playerControl10";
            this.playerControl10.PlayerTag = "PLAYER";
            this.playerControl10.Size = new System.Drawing.Size(225, 107);
            this.playerControl10.TabIndex = 15;
            // 
            // playerControl11
            // 
            this.playerControl11.Location = new System.Drawing.Point(608, 267);
            this.playerControl11.Name = "playerControl11";
            this.playerControl11.PlayerTag = "PLAYER";
            this.playerControl11.Size = new System.Drawing.Size(225, 107);
            this.playerControl11.TabIndex = 19;
            // 
            // playerControl12
            // 
            this.playerControl12.Location = new System.Drawing.Point(12, 137);
            this.playerControl12.Name = "playerControl12";
            this.playerControl12.PlayerTag = "PLAYER";
            this.playerControl12.Size = new System.Drawing.Size(225, 107);
            this.playerControl12.TabIndex = 14;
            // 
            // playerControl13
            // 
            this.playerControl13.Location = new System.Drawing.Point(310, 7);
            this.playerControl13.Name = "playerControl13";
            this.playerControl13.PlayerTag = "PLAYER";
            this.playerControl13.Size = new System.Drawing.Size(225, 107);
            this.playerControl13.TabIndex = 12;
            // 
            // playerControl14
            // 
            this.playerControl14.Location = new System.Drawing.Point(608, 7);
            this.playerControl14.Name = "playerControl14";
            this.playerControl14.PlayerTag = "PLAYER";
            this.playerControl14.Size = new System.Drawing.Size(225, 107);
            this.playerControl14.TabIndex = 13;
            // 
            // playerControl16
            // 
            this.playerControl16.Location = new System.Drawing.Point(608, 137);
            this.playerControl16.Name = "playerControl16";
            this.playerControl16.PlayerTag = "PLAYER";
            this.playerControl16.Size = new System.Drawing.Size(225, 107);
            this.playerControl16.TabIndex = 16;
            // 
            // playerControl17
            // 
            this.playerControl17.Location = new System.Drawing.Point(12, 267);
            this.playerControl17.Name = "playerControl17";
            this.playerControl17.PlayerTag = "PLAYER";
            this.playerControl17.Size = new System.Drawing.Size(225, 107);
            this.playerControl17.TabIndex = 17;
            // 
            // playerControl18
            // 
            this.playerControl18.Location = new System.Drawing.Point(310, 267);
            this.playerControl18.Name = "playerControl18";
            this.playerControl18.PlayerTag = "PLAYER";
            this.playerControl18.Size = new System.Drawing.Size(225, 107);
            this.playerControl18.TabIndex = 18;
            // 
            // playerControl19
            // 
            this.playerControl19.Location = new System.Drawing.Point(310, 137);
            this.playerControl19.Name = "playerControl19";
            this.playerControl19.PlayerTag = "PLAYER";
            this.playerControl19.Size = new System.Drawing.Size(225, 107);
            this.playerControl19.TabIndex = 15;
            // 
            // playerControl20
            // 
            this.playerControl20.Location = new System.Drawing.Point(608, 267);
            this.playerControl20.Name = "playerControl20";
            this.playerControl20.PlayerTag = "PLAYER";
            this.playerControl20.Size = new System.Drawing.Size(225, 107);
            this.playerControl20.TabIndex = 19;
            // 
            // playerControl21
            // 
            this.playerControl21.Location = new System.Drawing.Point(12, 137);
            this.playerControl21.Name = "playerControl21";
            this.playerControl21.PlayerTag = "PLAYER";
            this.playerControl21.Size = new System.Drawing.Size(225, 107);
            this.playerControl21.TabIndex = 14;
            // 
            // playerControl22
            // 
            this.playerControl22.Location = new System.Drawing.Point(310, 7);
            this.playerControl22.Name = "playerControl22";
            this.playerControl22.PlayerTag = "PLAYER";
            this.playerControl22.Size = new System.Drawing.Size(225, 107);
            this.playerControl22.TabIndex = 12;
            // 
            // playerControl23
            // 
            this.playerControl23.Location = new System.Drawing.Point(608, 7);
            this.playerControl23.Name = "playerControl23";
            this.playerControl23.PlayerTag = "PLAYER";
            this.playerControl23.Size = new System.Drawing.Size(225, 107);
            this.playerControl23.TabIndex = 13;
            // 
            // playerControl24
            // 
            this.playerControl24.Location = new System.Drawing.Point(12, 7);
            this.playerControl24.Name = "playerControl24";
            this.playerControl24.PlayerTag = "PLAYER";
            this.playerControl24.Size = new System.Drawing.Size(225, 107);
            this.playerControl24.TabIndex = 11;
            // 
            // playerControl25
            // 
            this.playerControl25.Location = new System.Drawing.Point(608, 137);
            this.playerControl25.Name = "playerControl25";
            this.playerControl25.PlayerTag = "PLAYER";
            this.playerControl25.Size = new System.Drawing.Size(225, 107);
            this.playerControl25.TabIndex = 16;
            // 
            // playerControl26
            // 
            this.playerControl26.Location = new System.Drawing.Point(12, 267);
            this.playerControl26.Name = "playerControl26";
            this.playerControl26.PlayerTag = "PLAYER";
            this.playerControl26.Size = new System.Drawing.Size(225, 107);
            this.playerControl26.TabIndex = 17;
            // 
            // playerControl27
            // 
            this.playerControl27.Location = new System.Drawing.Point(310, 267);
            this.playerControl27.Name = "playerControl27";
            this.playerControl27.PlayerTag = "PLAYER";
            this.playerControl27.Size = new System.Drawing.Size(225, 107);
            this.playerControl27.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblPoweredBy);
            this.Controls.Add(this.btnClearAllFiles);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMimon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "NWO Soundboard";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Soundboard.Controls.PlayerControl playerControl1;
        private Soundboard.Controls.PlayerControl playerControl2;
        private Soundboard.Controls.PlayerControl playerControl3;
        private Soundboard.Controls.PlayerControl playerControl4;
        private Soundboard.Controls.PlayerControl playerControl5;
        private Soundboard.Controls.PlayerControl playerControl6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClearAllFiles;
        private Controls.PlayerControl playerControl7;
        private Controls.PlayerControl playerControl8;
        private Controls.PlayerControl playerControl9;
        private System.Windows.Forms.Label lblPoweredBy;
        private System.Windows.Forms.Label lblMimon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.PlayerControl playerControl10;
        private Controls.PlayerControl playerControl11;
        private Controls.PlayerControl playerControl12;
        private Controls.PlayerControl playerControl13;
        private Controls.PlayerControl playerControl14;
        private Controls.PlayerControl playerControl16;
        private Controls.PlayerControl playerControl17;
        private Controls.PlayerControl playerControl18;
        private System.Windows.Forms.TabPage tabPage3;
        private Controls.PlayerControl playerControl19;
        private Controls.PlayerControl playerControl20;
        private Controls.PlayerControl playerControl21;
        private Controls.PlayerControl playerControl22;
        private Controls.PlayerControl playerControl23;
        private Controls.PlayerControl playerControl24;
        private Controls.PlayerControl playerControl25;
        private Controls.PlayerControl playerControl26;
        private Controls.PlayerControl playerControl27;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSaveNo;
        private System.Windows.Forms.RadioButton rbSaveYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveTabPage1;
        private System.Windows.Forms.Button btnLoadTabPage1;
        private Controls.PlayerControl playerControl15;
    }
}