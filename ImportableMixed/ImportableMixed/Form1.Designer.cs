namespace ImportableMixed
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbDirectory = new System.Windows.Forms.Label();
            this.lbHowMuch = new System.Windows.Forms.Label();
            this.lbLastImport = new System.Windows.Forms.Label();
            this.btDownloadCsv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btGenerateCsv = new System.Windows.Forms.Button();
            this.btUploadCsv = new System.Windows.Forms.Button();
            this.btChangeCsvDirectory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFtpPortNr = new System.Windows.Forms.TextBox();
            this.tbNamesserver = new System.Windows.Forms.TextBox();
            this.tbFtpUsername = new System.Windows.Forms.TextBox();
            this.tbFtpPassword = new System.Windows.Forms.TextBox();
            this.cbFtpType = new System.Windows.Forms.ComboBox();
            this.btTryConnection = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDotTireYes = new System.Windows.Forms.RadioButton();
            this.rbDotTireNo = new System.Windows.Forms.RadioButton();
            this.lbCurrentDirectory = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbExportYes = new System.Windows.Forms.RadioButton();
            this.rbExportNo = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbTimestampYes = new System.Windows.Forms.RadioButton();
            this.rbTimestampNo = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.lbCountFiles = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbExportLastTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(18, 374);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(890, 139);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(15, 15);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(126, 17);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "Csv-Informationen:";
            // 
            // lbDirectory
            // 
            this.lbDirectory.AutoSize = true;
            this.lbDirectory.Location = new System.Drawing.Point(31, 46);
            this.lbDirectory.Name = "lbDirectory";
            this.lbDirectory.Size = new System.Drawing.Size(192, 17);
            this.lbDirectory.TabIndex = 2;
            this.lbDirectory.Text = "Derzeitiges CSV-Verzeichnis:";
            // 
            // lbHowMuch
            // 
            this.lbHowMuch.AutoSize = true;
            this.lbHowMuch.Location = new System.Drawing.Point(31, 76);
            this.lbHowMuch.Name = "lbHowMuch";
            this.lbHowMuch.Size = new System.Drawing.Size(132, 17);
            this.lbHowMuch.TabIndex = 3;
            this.lbHowMuch.Text = "Anzahl CSV-Datein:";
            // 
            // lbLastImport
            // 
            this.lbLastImport.AutoSize = true;
            this.lbLastImport.Location = new System.Drawing.Point(31, 109);
            this.lbLastImport.Name = "lbLastImport";
            this.lbLastImport.Size = new System.Drawing.Size(225, 17);
            this.lbLastImport.TabIndex = 4;
            this.lbLastImport.Text = "Zuletzt stattgefundener Import am:";
            // 
            // btDownloadCsv
            // 
            this.btDownloadCsv.Location = new System.Drawing.Point(148, 311);
            this.btDownloadCsv.Name = "btDownloadCsv";
            this.btDownloadCsv.Size = new System.Drawing.Size(200, 36);
            this.btDownloadCsv.TabIndex = 5;
            this.btDownloadCsv.Text = "CSV-Datei downloaden";
            this.btDownloadCsv.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Csv-Aktionen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "DOT-Reifen löschen:";
            // 
            // btGenerateCsv
            // 
            this.btGenerateCsv.Location = new System.Drawing.Point(258, 269);
            this.btGenerateCsv.Name = "btGenerateCsv";
            this.btGenerateCsv.Size = new System.Drawing.Size(200, 36);
            this.btGenerateCsv.TabIndex = 9;
            this.btGenerateCsv.Text = "CSV-Datei generieren";
            this.btGenerateCsv.UseVisualStyleBackColor = true;
            this.btGenerateCsv.Click += new System.EventHandler(this.button2_Click);
            // 
            // btUploadCsv
            // 
            this.btUploadCsv.Location = new System.Drawing.Point(545, 276);
            this.btUploadCsv.Name = "btUploadCsv";
            this.btUploadCsv.Size = new System.Drawing.Size(172, 36);
            this.btUploadCsv.TabIndex = 10;
            this.btUploadCsv.Text = "CSV-Datei uploaden";
            this.btUploadCsv.UseVisualStyleBackColor = true;
            // 
            // btChangeCsvDirectory
            // 
            this.btChangeCsvDirectory.Location = new System.Drawing.Point(40, 269);
            this.btChangeCsvDirectory.Name = "btChangeCsvDirectory";
            this.btChangeCsvDirectory.Size = new System.Drawing.Size(200, 36);
            this.btChangeCsvDirectory.TabIndex = 11;
            this.btChangeCsvDirectory.Text = "CSV-Verzeichniss wechseln";
            this.btChangeCsvDirectory.UseVisualStyleBackColor = true;
            this.btChangeCsvDirectory.Click += new System.EventHandler(this.btChangeDirectoryCsv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nur geänderte Datensätze exportieren:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Import Zeitstempel einfügen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "FTP-Upload";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Port Nr.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "FTP-Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(559, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nameserver:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Username:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(559, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Password:";
            // 
            // tbFtpPortNr
            // 
            this.tbFtpPortNr.Location = new System.Drawing.Point(661, 48);
            this.tbFtpPortNr.Name = "tbFtpPortNr";
            this.tbFtpPortNr.Size = new System.Drawing.Size(170, 22);
            this.tbFtpPortNr.TabIndex = 26;
            // 
            // tbNamesserver
            // 
            this.tbNamesserver.Location = new System.Drawing.Point(662, 111);
            this.tbNamesserver.Name = "tbNamesserver";
            this.tbNamesserver.Size = new System.Drawing.Size(170, 22);
            this.tbNamesserver.TabIndex = 27;
            // 
            // tbFtpUsername
            // 
            this.tbFtpUsername.Location = new System.Drawing.Point(662, 138);
            this.tbFtpUsername.Name = "tbFtpUsername";
            this.tbFtpUsername.Size = new System.Drawing.Size(170, 22);
            this.tbFtpUsername.TabIndex = 28;
            // 
            // tbFtpPassword
            // 
            this.tbFtpPassword.Location = new System.Drawing.Point(662, 165);
            this.tbFtpPassword.Name = "tbFtpPassword";
            this.tbFtpPassword.Size = new System.Drawing.Size(170, 22);
            this.tbFtpPassword.TabIndex = 29;
            // 
            // cbFtpType
            // 
            this.cbFtpType.FormattingEnabled = true;
            this.cbFtpType.Location = new System.Drawing.Point(662, 78);
            this.cbFtpType.Name = "cbFtpType";
            this.cbFtpType.Size = new System.Drawing.Size(170, 24);
            this.cbFtpType.TabIndex = 30;
            // 
            // btTryConnection
            // 
            this.btTryConnection.Location = new System.Drawing.Point(739, 276);
            this.btTryConnection.Name = "btTryConnection";
            this.btTryConnection.Size = new System.Drawing.Size(152, 36);
            this.btTryConnection.TabIndex = 31;
            this.btTryConnection.Text = "Try-Connection";
            this.btTryConnection.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(559, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "CSV-Filename:";
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(662, 193);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(170, 22);
            this.tbFilename.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbDotTireYes);
            this.panel1.Controls.Add(this.rbDotTireNo);
            this.panel1.Location = new System.Drawing.Point(309, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 29);
            this.panel1.TabIndex = 37;
            // 
            // rbDotTireYes
            // 
            this.rbDotTireYes.AutoSize = true;
            this.rbDotTireYes.Location = new System.Drawing.Point(3, 3);
            this.rbDotTireYes.Name = "rbDotTireYes";
            this.rbDotTireYes.Size = new System.Drawing.Size(44, 21);
            this.rbDotTireYes.TabIndex = 12;
            this.rbDotTireYes.TabStop = true;
            this.rbDotTireYes.Text = "Ja";
            this.rbDotTireYes.UseVisualStyleBackColor = true;
            // 
            // rbDotTireNo
            // 
            this.rbDotTireNo.AutoSize = true;
            this.rbDotTireNo.Location = new System.Drawing.Point(67, 3);
            this.rbDotTireNo.Name = "rbDotTireNo";
            this.rbDotTireNo.Size = new System.Drawing.Size(58, 21);
            this.rbDotTireNo.TabIndex = 13;
            this.rbDotTireNo.TabStop = true;
            this.rbDotTireNo.Text = "Nein";
            this.rbDotTireNo.UseVisualStyleBackColor = true;
            // 
            // lbCurrentDirectory
            // 
            this.lbCurrentDirectory.AutoSize = true;
            this.lbCurrentDirectory.Location = new System.Drawing.Point(301, 46);
            this.lbCurrentDirectory.Name = "lbCurrentDirectory";
            this.lbCurrentDirectory.Size = new System.Drawing.Size(46, 17);
            this.lbCurrentDirectory.TabIndex = 36;
            this.lbCurrentDirectory.Text = "TEMP";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbExportYes);
            this.panel2.Controls.Add(this.rbExportNo);
            this.panel2.Location = new System.Drawing.Point(309, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 29);
            this.panel2.TabIndex = 39;
            // 
            // rbExportYes
            // 
            this.rbExportYes.AutoSize = true;
            this.rbExportYes.Location = new System.Drawing.Point(3, 3);
            this.rbExportYes.Name = "rbExportYes";
            this.rbExportYes.Size = new System.Drawing.Size(44, 21);
            this.rbExportYes.TabIndex = 12;
            this.rbExportYes.TabStop = true;
            this.rbExportYes.Text = "Ja";
            this.rbExportYes.UseVisualStyleBackColor = true;
            // 
            // rbExportNo
            // 
            this.rbExportNo.AutoSize = true;
            this.rbExportNo.Location = new System.Drawing.Point(67, 3);
            this.rbExportNo.Name = "rbExportNo";
            this.rbExportNo.Size = new System.Drawing.Size(58, 21);
            this.rbExportNo.TabIndex = 13;
            this.rbExportNo.TabStop = true;
            this.rbExportNo.Text = "Nein";
            this.rbExportNo.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbTimestampYes);
            this.panel3.Controls.Add(this.rbTimestampNo);
            this.panel3.Location = new System.Drawing.Point(309, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 29);
            this.panel3.TabIndex = 41;
            // 
            // rbTimestampYes
            // 
            this.rbTimestampYes.AutoSize = true;
            this.rbTimestampYes.Location = new System.Drawing.Point(3, 3);
            this.rbTimestampYes.Name = "rbTimestampYes";
            this.rbTimestampYes.Size = new System.Drawing.Size(44, 21);
            this.rbTimestampYes.TabIndex = 12;
            this.rbTimestampYes.TabStop = true;
            this.rbTimestampYes.Text = "Ja";
            this.rbTimestampYes.UseVisualStyleBackColor = true;
            // 
            // rbTimestampNo
            // 
            this.rbTimestampNo.AutoSize = true;
            this.rbTimestampNo.Location = new System.Drawing.Point(67, 3);
            this.rbTimestampNo.Name = "rbTimestampNo";
            this.rbTimestampNo.Size = new System.Drawing.Size(58, 21);
            this.rbTimestampNo.TabIndex = 13;
            this.rbTimestampNo.TabStop = true;
            this.rbTimestampNo.Text = "Nein";
            this.rbTimestampNo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(315, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 17);
            this.label13.TabIndex = 40;
            // 
            // lbCountFiles
            // 
            this.lbCountFiles.AutoSize = true;
            this.lbCountFiles.Location = new System.Drawing.Point(301, 76);
            this.lbCountFiles.Name = "lbCountFiles";
            this.lbCountFiles.Size = new System.Drawing.Size(46, 17);
            this.lbCountFiles.TabIndex = 42;
            this.lbCountFiles.Text = "TEMP";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(309, 420);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(301, 34);
            this.progressBar1.TabIndex = 43;
            // 
            // lbExportLastTime
            // 
            this.lbExportLastTime.AutoSize = true;
            this.lbExportLastTime.Location = new System.Drawing.Point(301, 109);
            this.lbExportLastTime.Name = "lbExportLastTime";
            this.lbExportLastTime.Size = new System.Drawing.Size(46, 17);
            this.lbExportLastTime.TabIndex = 44;
            this.lbExportLastTime.Text = "TEMP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 522);
            this.Controls.Add(this.lbExportLastTime);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbCountFiles);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbCurrentDirectory);
            this.Controls.Add(this.tbFilename);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btTryConnection);
            this.Controls.Add(this.cbFtpType);
            this.Controls.Add(this.tbFtpPassword);
            this.Controls.Add(this.tbFtpUsername);
            this.Controls.Add(this.tbNamesserver);
            this.Controls.Add(this.tbFtpPortNr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btChangeCsvDirectory);
            this.Controls.Add(this.btUploadCsv);
            this.Controls.Add(this.btGenerateCsv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDownloadCsv);
            this.Controls.Add(this.lbLastImport);
            this.Controls.Add(this.lbHowMuch);
            this.Controls.Add(this.lbDirectory);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "CsvEdit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbDirectory;
        private System.Windows.Forms.Label lbHowMuch;
        private System.Windows.Forms.Label lbLastImport;
        private System.Windows.Forms.Button btDownloadCsv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGenerateCsv;
        private System.Windows.Forms.Button btUploadCsv;
        private System.Windows.Forms.Button btChangeCsvDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbFtpPortNr;
        private System.Windows.Forms.TextBox tbNamesserver;
        private System.Windows.Forms.TextBox tbFtpUsername;
        private System.Windows.Forms.TextBox tbFtpPassword;
        private System.Windows.Forms.ComboBox cbFtpType;
        private System.Windows.Forms.Button btTryConnection;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDotTireYes;
        private System.Windows.Forms.RadioButton rbDotTireNo;
        private System.Windows.Forms.Label lbCurrentDirectory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbExportYes;
        private System.Windows.Forms.RadioButton rbExportNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbTimestampYes;
        private System.Windows.Forms.RadioButton rbTimestampNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbCountFiles;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbExportLastTime;
    }
}

