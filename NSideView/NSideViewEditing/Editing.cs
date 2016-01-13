using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.IO.Compression;

namespace NSideViewEditing
{
    public partial class Editing : Telerik.WinControls.UI.RadForm
    {
        OpenFileDialog fd = new OpenFileDialog();

        public Editing()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            fd.Multiselect = true;
            fd.ShowDialog();

            try
            {
                leftImagePicBox.Image = Image.FromFile(fd.FileNames[0].Remove(fd.FileNames[0].Length - 3, 3) + "png");
                rightImagePicBox.Image = Image.FromFile(fd.FileNames[1].Remove(fd.FileNames[1].Length - 3, 3) + "png");
            }
            catch
            {
                MessageBox.Show("You did not choose the appropriate extension of the images!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reconstructionBtn_Click(object sender, EventArgs e)
        {
            Process.Start("BuildViewEditor.exe");
        }

        private void stereoGcBtn_Click(object sender, EventArgs e)
        {
            StereoBMToolsVisibility(false);
            depthImagePicBox.Visible = true;

            if (leftImagePicBox.Image != null && rightImagePicBox.Image != null)
            {
                ProcessStartInfo start = new ProcessStartInfo();

                start.WorkingDirectory = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                start.Arguments = "\"" + fd.FileNames[0] + "\"" + " " + "\"" + fd.FileNames[1] + "\"" + " " + "\"" + Path.GetDirectoryName(fd.FileNames[0]) + @"\\" + "\"" + " " + "\"" + Path.GetDirectoryName(fd.FileNames[0]) + @"\\" + "\"";
                start.FileName = "StereoGC.exe"; 
                start.WindowStyle = ProcessWindowStyle.Hidden;
                start.CreateNoWindow = false;
                var p = Process.Start(start);

                progressBarProcess.Visible = true;

                while (!p.HasExited)
                {
                    Thread.Sleep(100);
                    if (progressBarProcess.Value == 100)
                    {
                        progressBarProcess.Value = 0;
                    }
                    progressBarProcess.PerformStep();
                }

                progressBarProcess.Visible = false;

                depthImagePicBox.Image = Image.FromFile(Path.GetDirectoryName(fd.FileNames[0]) + "\\Depth.png");
            }
            else
            {
                MessageBox.Show("You have not selected any images. Please, first select 2 images.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void stereoBmBtn_Click(object sender, EventArgs e)
        {
            depthImagePicBox.Visible = false;
            if (depthImageBMPicBox.Image != null)
            {
                var oldImage = depthImageBMPicBox.Image;
                depthImageBMPicBox.Image = null;
                ((IDisposable)oldImage).Dispose();
            }

            if (leftImagePicBox.Image != null && rightImagePicBox.Image != null)
            {
                ProcessStartInfo start = new ProcessStartInfo();

                start.WorkingDirectory = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                start.Arguments = fd.FileNames[0] + " " + fd.FileNames[1] + " " + Path.GetDirectoryName(fd.FileNames[0]) + @"\" + " " + Path.GetDirectoryName(fd.FileNames[0]) + @"\" + " " 
                    + preFilterSizeBtn.Text + " " + preFilterCapBtn.Text + " " + SADWindowSizeBtn.Text + " " + minDisparityBtn.Text + " " + numberOfDisparitiesBtn.Text + " " + textureThresholdBtn.Text + " " 
                    + uniquenessRatioBtn.Text + " " + speckleWindowSizeBtn.Text + " " + speckleRangeBtn.Text;
                start.FileName = "StereoBM.exe";
                start.WindowStyle = ProcessWindowStyle.Hidden;
                start.CreateNoWindow = false;
                var p = Process.Start(start);

                while (!p.HasExited)
                {
                    Thread.Sleep(100);
                }

                StereoBMToolsVisibility(true);
                depthImageBMPicBox.Image = Image.FromFile(Path.GetDirectoryName(fd.FileNames[0]) + "\\DepthBM.png");
            }
            else
            {
                MessageBox.Show("You have not selected any images. Please, first select 2 images.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void StereoBMToolsVisibility(bool value)
        {
            preFilterCapBtn.Visible = value;
            preFilterCapLbl.Visible = value;
            preFilterSizeBtn.Visible = value;
            preFilterSizeLbl.Visible = value;
            SADWindowSizeBtn.Visible = value;
            SADWindowSizeLbl.Visible = value;
            minDisparityBtn.Visible = value;
            minDisparityLbl.Visible = value;
            numberOfDisparitiesBtn.Visible = value;
            numberOfDisparitiesLbl.Visible = value;
            textureThresholdBtn.Visible = value;
            textureThresholdLbl.Visible = value;
            uniquenessRatioBtn.Visible = value;
            uniquenessRatioLbl.Visible = value;
            speckleWindowSizeBtn.Visible = value;
            speckleWindowSizeLbl.Visible = value;
            speckleRangeBtn.Visible = value;
            speckleRangeLbl.Visible = value;
            depthImageBMPicBox.Visible = value;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string importPath;
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Choose import directory";
                dlg.ShowNewFolderButton = true;
                DialogResult result = dlg.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    importPath = dlg.SelectedPath;
                    string date = DateTime.Now.ToString("ddMMyyyy-HHmmss");
                    string typeBin;

                    File.Copy(fd.FileNames[0].Replace(".ppm", ".png"), importPath + "\\" + date + "-color.jpg", true);

                    if (depthImageBMPicBox.Visible == true)
                    {
                        typeBin = "\\DepthBM.bin";
                    }
                    else
                    {
                        typeBin = "\\DepthBin.bin";
                    }

                    File.Copy(Path.GetDirectoryName(fd.FileNames[0]) + typeBin, importPath + "\\" + date + "-depth.bin", true);
                    SaveBinaryDepth(importPath + "\\" + date + "-depth.bin", importPath + "\\" + date + "-depth");
                    File.Delete(importPath + "\\" + date + "-depth.bin");

                    using (StreamWriter writeTransInfo = new StreamWriter(Path.Combine(importPath, date + "-trans.txt"), true))
                    {
                            writeTransInfo.Write("1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1");
                    }
                }
            }
        }

        void SaveBinaryDepth(string name, string fileName)
        {
            using (FileStream inFile = File.Open(name, FileMode.Open))
            {
                using (FileStream outFile =
                                File.Create(fileName + ".gz"))
                {
                    using (GZipStream Compress =
                        new GZipStream(outFile,
                        CompressionMode.Compress))
                    {
                        inFile.CopyTo(Compress);
                    }
                }
            }
        }
    }
}
