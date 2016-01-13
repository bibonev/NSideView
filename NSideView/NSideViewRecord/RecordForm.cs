using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Telerik.WinControls;
using AForge.Video;
using AForge.Video.DirectShow;

namespace NSideViewRecord
{
    public partial class RecordForm : Telerik.WinControls.UI.RadForm
    {
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSourceCam1 = null;
        private VideoCaptureDevice videoSourceCam2 = null;
        int countImage = 0;

        public RecordForm()
        {
            InitializeComponent();
        }

        private void getCamList()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cam1Cmb.Items.Clear();
                cam2Cmb.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    cam1Cmb.Items.Add(device.Name);
                    cam2Cmb.Items.Add(device.Name);
                }
                cam1Cmb.SelectedIndex = 0;
                if (cam1Cmb.Items.Count == 1)
                {
                    statusCamsLbl.Text = "Please, insert second camera";
                }
                else
                {
                    cam2Cmb.SelectedIndex = 1;
                }
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                cam1Cmb.Items.Add("No capture device on your system");
                cam2Cmb.Items.Add("No capture device on your system");
            }
        }

        private void controlCamsBtn_Click(object sender, EventArgs e)
        {
            if (controlCamsBtn.Text == "Start" && cam1Cmb.Items.Count > 1)
            {
                if (DeviceExist)
                {
                    videoSourceCam1 = new VideoCaptureDevice(videoDevices[cam1Cmb.SelectedIndex].MonikerString);
                    videoSourceCam2 = new VideoCaptureDevice(videoDevices[cam2Cmb.SelectedIndex].MonikerString);

                    videoSourceCam1.NewFrame += new NewFrameEventHandler(video_NewFrame);
                    videoSourceCam2.NewFrame += new NewFrameEventHandler(video_NewFrame2);
                    
                    CloseVideoSource();

                    videoSourceCam1.VideoResolution = videoSourceCam1.VideoCapabilities[6];
                    videoSourceCam1.Start();
                    videoSourceCam2.VideoResolution = videoSourceCam2.VideoCapabilities[6];
                    videoSourceCam2.Start();

                    statusCamsLbl.Text = "Device running...";
                    controlCamsBtn.Text = "&Stop";
                    timer1.Enabled = true;
                }
                else
                {
                    statusCamsLbl.Text = "Error: No Device selected.";
                }
            }
            else
            {
                if (videoSourceCam1 != null && videoSourceCam2 != null)
                {
                    timer1.Enabled = false;
                    CloseVideoSource();
                    statusCamsLbl.Text = "Device stopped.";
                    controlCamsBtn.Text = "Start";
                }
                else
                {
                    statusCamsLbl.Text = "Error: No Second Device selected.";
                }
            }
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = img;
        }

        private void video_NewFrame2(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pictureBox2.Image = img;
        }

        //close the device safely
        private void CloseVideoSource()
        {
            if (!(videoSourceCam1 == null) || !(videoSourceCam2 == null))
            {
                if (videoSourceCam1.IsRunning || videoSourceCam2.IsRunning)
                {
                    videoSourceCam1.SignalToStop();
                    videoSourceCam1 = null;
                    pictureBox1.Image = null;

                    videoSourceCam2.SignalToStop();
                    videoSourceCam2 = null;
                    pictureBox2.Image = null;
                }
            }
        }

        private void refreshCamsBtn_Click(object sender, EventArgs e)
        {
            getCamList();
        }

        private void captureBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(pathTxtBox.Text + countImage.ToString() + ".ppm", System.Drawing.Imaging.ImageFormat.Png);
            pictureBox1.Image.Save(pathTxtBox.Text + countImage.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);
            countImage++;
            pictureBox2.Image.Save(pathTxtBox.Text + countImage.ToString() + ".ppm", System.Drawing.Imaging.ImageFormat.Png);
            pictureBox2.Image.Save(pathTxtBox.Text + countImage.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);
            countImage++;
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.ShowDialog();
            pathTxtBox.Text = fd.FileName;
        }

        private void RecordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseVideoSource();
        }

        private void calibrationBtn_Click(object sender, EventArgs e)
        {
            CalibrationForm calib = new CalibrationForm();
            calib.Show();
        }
    }
}
