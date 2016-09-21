using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImportableMixed
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.Description = "Geben Sie das gewünschte Verzeichniss an!";
            lbCurrentDirectory.Text = folderBrowserDialog1.SelectedPath;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            progressBar1.Visible = true;
            MainProgram.ReadFromCsv(folderBrowserDialog1.SelectedPath,rbDotTireYes.Checked);
            progressBar1.Maximum = MainProgram.Tires.Length * 4;
            progressBar1.Value = MainProgram.Tires.Length;
            MainProgram.CheckWidth();
            progressBar1.Value += MainProgram.Tires.Length;
            MainProgram.Tires = MainProgram.CalculationPrice(MainProgram.Tires);
            progressBar1.Value += MainProgram.Tires.Length;
           

            MainProgram.Write(folderBrowserDialog1.SelectedPath);
            progressBar1.Value = progressBar1.Maximum;
            lbCountFiles.Text = Convert.ToString(Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*", SearchOption.TopDirectoryOnly).Length);
            Thread.Sleep(2000);
            progressBar1.Visible = false;
        }



        private void btChangeDirectoryCsv_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbCurrentDirectory.Text = folderBrowserDialog1.SelectedPath;
                lbCountFiles.Text = Convert.ToString(Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*", SearchOption.TopDirectoryOnly).Length);
            }

        }
    }
}
