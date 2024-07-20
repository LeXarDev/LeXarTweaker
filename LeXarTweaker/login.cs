using System;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeXarTweaker
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            progressbar1.Visible = false; // Hide the progress bar initially
        }

        // login api
        public static api KeyAuthApp = new api(
            name: "lexartweaker", // Application Name
            ownerid: "c1uCBrxfPW", // Owner ID
            secret: "bef1e298661c4d64324085ef6619759f39fb56d01107f4681897eee9140ec41e", // Application Secret
            version: "1.0" // Application Version
        );

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void login_Load(object sender, EventArgs e)
        {
            progressbar1.Visible = false;

            if (Properties.Settings.Default.rememberMe)
            {
                username.Text = Properties.Settings.Default.username;
                password.Text = Properties.Settings.Default.password;
                checkbox.Checked = true;
            }

            // Perform the server check when the app first opens
            bool isOnline = await Task.Run(() => pingStatus());
            UpdateStatusLabel(isOnline);
        }

        private async void signin_Click_1(object sender, EventArgs e)
        {
            // Show the progress bar
            progressbar1.Visible = true;

            // Simulate progress bar activity
            for (int i = 0; i <= 100; i += 20) // Adjust the increment as needed
            {
                progressbar1.Value = i;
                await Task.Delay(100); // Simulate a delay (non-blocking)
            }

            await Task.Run(() =>
            {
                KeyAuthApp.init();
                KeyAuthApp.check();
                KeyAuthApp.login(username.Text, password.Text);
            });

            if (KeyAuthApp.response.success)
            {
                Home form = new Home();
                form.Show();
                this.Hide();
            }
            else
            {
                progressbar1.Visible = false;
                // Optionally, display an error in a status label
            }
        }

        private void progressbar1_ValueChanged(object sender, EventArgs e)
        {
            // Add your logic for progress bar value change here
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            // Add your logic for username text change here
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            // Add your logic for password text change here
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                Properties.Settings.Default.username = username.Text;
                Properties.Settings.Default.password = password.Text;
                Properties.Settings.Default.rememberMe = true;
            }
            else
            {
                Properties.Settings.Default.username = string.Empty;
                Properties.Settings.Default.password = string.Empty;
                Properties.Settings.Default.rememberMe = false;
            }
            Properties.Settings.Default.Save();
        }

        private bool pingStatus()
        {
            string hostNameOrAddress = "1.1.1.1";

            try
            {
                using (Ping p = new Ping())
                {
                    PingReply reply = p.Send(hostNameOrAddress, 500); // 500ms timeout
                    return reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }

        private void UpdateStatusLabel(bool isOnline)
        {
            if (isOnline)
            {
                lblStatus.Text = "Online";
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(33, 230, 197);
            }
            else
            {
                lblStatus.Text = "Offline";
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(240, 89, 69);
            }
        }
    }
}
