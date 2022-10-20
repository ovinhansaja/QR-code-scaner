using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;

namespace Attendance_Maker
{
    public partial class Scaner : Form
    {
        public Scaner()
        {
            InitializeComponent();
        }

        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;
        SqlConnection con;
        SqlCommand cmd;

        private void btn_form_close_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();

            Application.Exit();
        }

        private void btn_form_mini_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();

            this.WindowState = FormWindowState.Minimized;
        }

        private void Scaner_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filter)
                cmb_device.Items.Add(filterInfo.Name);
            cmb_device.SelectedIndex = 0;
            
            con = new SqlConnection("Data Source=LAPTOP-RR2SNHCT;Initial Catalog=Vision_Education_Institute;Integrated Security=True");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();

            Close();
            Home obj = new Home();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_index.Clear();
            
            captureDevice = new VideoCaptureDevice(filter[cmb_device.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            QRscaner.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (QRscaner.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)QRscaner.Image);
                if (result != null)
                {
                    txt_index.Text = result.ToString();
                    try
                    {
                        con.Open();

                        if (rb_student.Checked == true)
                        {
                            cmd = new SqlCommand("Insert into Students_Attendence (Student_No) values ('" + txt_index.Text + "')", con);
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                                MessageBox.Show(this, "Attendence marked for Student ID : " + txt_index.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show(this, "Cannot mark attendence, Try again", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (rb_teacher.Checked == true)
                        {
                            cmd = new SqlCommand("Insert into Teachers_Attendence (Teacher_No) values ('" + txt_index.Text + "')", con);
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                                MessageBox.Show(this, "Attendence marked for Teacher ID : " + txt_index.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show(this, "Cannot mark attendence, Try again", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (rb_staff.Checked == true)
                        {
                            cmd = new SqlCommand("Insert into Staff_Attendence (Staff_No) values ('" + txt_index.Text + "')", con);
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                                MessageBox.Show(this, "Attendence marked for Staff ID : " + txt_index.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show(this, "Cannot mark attendence, Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(this, "Plese select who you are", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                        cmd.Dispose();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show(this, "Scan a valid QR Code", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show(this, "Please Scan Your QR Code", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show(this, "Your QR Code is out of Range", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this, "Please try again", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    timer.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }
    }
}
