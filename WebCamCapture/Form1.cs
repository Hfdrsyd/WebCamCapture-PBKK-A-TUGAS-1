using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;

namespace WebCamCapture
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice videoSource;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo deviceList in captureDevice)
            {
                comboBoxWebCamList.Items.Add(deviceList.Name);
            }
            comboBoxWebCamList.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
            videoSource = new VideoCaptureDevice(captureDevice[comboBoxWebCamList.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "save image as";
            saveFileDialog.Filter = "Image files (*.jpg, *.png) | ,*.jpg,*.png";
            ImageFormat format = ImageFormat.Png;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }
                pictureBox2.Image.Save(saveFileDialog.FileName, format);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
                pictureBox2.Image = null;
                pictureBox2.Invalidate();
            }
            Application.Exit(null);
        }
    }
}