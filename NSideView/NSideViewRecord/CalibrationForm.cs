using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace NSideViewRecord
{
    public partial class CalibrationForm : Telerik.WinControls.UI.ShapedForm
    {
        public CalibrationForm()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.DefaultExt = "*.txt";
            fd.ShowDialog();
            pathCalibrationTxtBox.Text = fd.FileName;
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();

            start.WorkingDirectory = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            start.Arguments = "\"" + pathCalibrationTxtBox.Text + "\"" + " 9 6 2.5";
            start.FileName = "Calibration.exe";
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = false;
            Process.Start(start);

            this.Hide();
        }
    }
}
