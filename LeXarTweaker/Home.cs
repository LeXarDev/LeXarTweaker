using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;

namespace LeXarTweaker
{

    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private async void Home_Load(object sender, EventArgs e)
        {
            // Check server status when the app first opens
            bool isOnline = await CheckServerStatusAsync();
            UpdateStatusLabel(isOnline);

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async Task<bool> CheckServerStatusAsync()
        {
            const string hostNameOrAddress = "1.1.1.1";

            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = await ping.SendPingAsync(hostNameOrAddress, 500); // 500ms timeout
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
            // Ensure UI update runs on the UI thread
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateStatusLabel(isOnline)));
                return;
            }

            lblStatus.Text = isOnline ? "Online" : "Offline";
            lblStatus.ForeColor = isOnline ? System.Drawing.Color.FromArgb(33, 230, 197) : System.Drawing.Color.FromArgb(240, 89, 69);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HidePictureBox();
            ShowFormInPanel(new ping()); // Replace 'PingForm' with your actual form class
        }

        private void b_home_Click(object sender, EventArgs e)
        {
            HidePictureBox();
            ShowFormInPanel(new Home()); // Replace with your actual form class
        }

        private void ShowFormInPanel(Form form)
        {
            if (form == null) return;

            HideCurrentPanelForms();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            showpanel.Controls.Add(form);
            form.Show();
        }

        private void HideCurrentPanelForms()
        {
            showpanel.Controls.Clear();
        }

        private void HidePictureBox()
        {
            pictureBox1.Visible = false;
        }

        // Remove these if not used
        private void showpanel_Paint(object sender, PaintEventArgs e)
        {
            // Handle the Paint event here if needed
        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {
            // Handle the Paint event here if needed
        }

        private void b_windows_Click(object sender, EventArgs e)
        {
            HidePictureBox();
            ShowFormInPanel(new windows()); // Replace with your actual form class
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            HidePictureBox();
            ShowFormInPanel(new downloads()); // Replace with your actual form class
        }


        public DiscordRpcClient client;


        void Initialize()
        {
            var timer = new System.Timers.Timer(150);
            timer.Elapsed += (sender, args) => { client.Invoke(); };
            timer.Start();
            client.Invoke();
            client = new DiscordRpcClient("1264062995722670091");

            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                Details = "Example Project",
                State = "csharp example",
                Assets = new Assets()
                {
                    LargeImageKey = "large",
                    LargeImageText = "Lachee's Discord IPC Library",
                    SmallImageKey = "image_small"
                }
            });
        }
    }
}