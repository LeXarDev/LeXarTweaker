using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Drawing;

namespace LeXarTweaker
{
    public partial class ping : Form
    {
        private System.Windows.Forms.Timer pingTimer1;

        // Declare Image fields
        private Image greenImage;
        private Image orangeImage;
        private Image redImage;

        public ping()
        {
            InitializeComponent();
            InitializePingTimer();
            LoadPingImages();
            // Optionally set a default image or hide the PictureBox initially
            pictureBoxPingStatus.Image = greenImage; // or any default image
        }

        private void LoadPingImages()
        {
            // Load images from resources
            greenImage = Properties.Resources.green_image; // Replace with actual resource name
            orangeImage = Properties.Resources.orange_image; // Replace with actual resource name
            redImage = Properties.Resources.red_image; // Replace with actual resource name
        }

        private void ping_Load(object sender, EventArgs e)
        {
            // Optionally perform an initial ping here
            UpdatePing();
        }

        private void ea_ping_Click_1(object sender, EventArgs e)
        {
            // Perform a ping and update the label
            UpdatePing();
        }

        private void buttonrefresh_Click(object sender, EventArgs e)
        {
            // Perform a ping and update the label
            UpdatePing();
        }

        private void InitializePingTimer()
        {
            pingTimer = new System.Windows.Forms.Timer();
            pingTimer.Interval = 2000; // 2000 ms = 2 seconds
            pingTimer.Tick += new EventHandler(PingTimer_Tick);
            pingTimer.Start();
        }

        private void PingTimer_Tick(object sender, EventArgs e)
        {
            UpdatePing();
        }

        private void UpdatePing()
        {
            string host = "1.1.1.1"; // Replace with the host you want to ping
            try
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(host);

                if (reply.Status == IPStatus.Success)
                {
                    ea_ping.Text = $"PING: {reply.RoundtripTime} ms";

                    // Change the PictureBox image based on ping time
                    if (reply.RoundtripTime <= 50)
                    {
                        pictureBoxPingStatus.Image = greenImage;
                    }
                    else if (reply.RoundtripTime <= 70)
                    {
                        pictureBoxPingStatus.Image = orangeImage;
                    }
                    else
                    {
                        pictureBoxPingStatus.Image = redImage;
                    }
                }
                else
                {
                    ea_ping.Text = $"Ping to {host} failed.";
                    pictureBoxPingStatus.Image = redImage; // Show red image for failure
                }
            }
            catch (Exception ex)
            {
                ea_ping.Text = $"Ping failed: {ex.Message}";
                pictureBoxPingStatus.Image = redImage; // Show red image for exception
            }
        }
    }
}
