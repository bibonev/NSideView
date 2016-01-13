using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Diagnostics;
using System.IO;

namespace NSideViewMain
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("NSideViewRecord.exe");
            }
            catch
            {
            }
        }

        private void edittingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("NSideViewEditing.exe");
            }
            catch (Exception)
            {
                
            }   
        }

        private void visualizeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo start = new ProcessStartInfo();

                start.WorkingDirectory = "";
                start.Arguments = "";
                start.FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments, Environment.SpecialFolderOption.Create), "NSideViewExport");
                start.WindowStyle = ProcessWindowStyle.Maximized;
                start.CreateNoWindow = false;

                using (Process proc = Process.Start(start)) { }
            }
            catch
            {
            }
        }
    }
}
