using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeXarTweaker
{
    public partial class downloads : Form
    {
        public downloads()
        {
            InitializeComponent();
        }

        private void DisablePowersaving_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/977950699650441277/979097250464694292/MSI_util_v3.exe", "MSI_util_v3.exe");
            File.SetAttributes(@"MSI_util_v3.exe", File.GetAttributes(@"MSI_util_v3.exe") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "MSI_util_v3.exe";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"MSI_util_v3.exe"))
            {
                File.Delete(@"MSI_util_v3.exe");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/977950699650441277/979097265740333157/Autoruns.exe", "Autoruns.exe");
            File.SetAttributes(@"Autoruns.exe", File.GetAttributes(@"Autoruns.exe") | FileAttributes.Hidden);

            Process process = new Process();
            process.StartInfo.FileName = "Autoruns.exe";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"Autoruns.exe"))
            {
                File.Delete(@"Autoruns.exe");
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id Discord.Discord";
            Process.Start(installProgram).WaitForExit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id Discord.Discord";
            Process.Start(installProgram).WaitForExit();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id VideoLAN.VLC";
            Process.Start(installProgram).WaitForExit();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id Google.Chrome";
            Process.Start(installProgram).WaitForExit();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id Mozilla.Firefox";
            Process.Start(installProgram).WaitForExit();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id BraveSoftware.BraveBrowser";
            Process.Start(installProgram).WaitForExit();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id EpicGames.EpicGamesLauncher";
            Process.Start(installProgram).WaitForExit();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id Valve.Steam";
            Process.Start(installProgram).WaitForExit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/DownloadNvProfile.bat", "DownloadNvProfile.bat");
            File.SetAttributes(@"DownloadNvProfile.bat", File.GetAttributes(@"DownloadNvProfile.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "DownloadNvProfile.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"DownloadNvProfile.bat"))
            {
                File.Delete(@"DownloadNvProfile.bat");
            }

            string message = "Nvidia Control Panel Tweaks Applied!";
            MessageBox.Show(message);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Delete file after it finishes
            if (File.Exists(@"NVCleanstall_1.13.0.exe"))
            {
                File.Delete(@"NVCleanstall_1.13.0.exe");
            }

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/878261383710511124/1264032545893388288/NVCleanstall_1.16.0.exe?ex=669c658b&is=669b140b&hm=05f4e6bd9a63d3926fa69cfb8dfe4bbedc86a1efe00b70a7473e50d0906c9a74&", "NVCleanstall_1.13.0.exe");
            File.SetAttributes(@"NVCleanstall_1.13.0.exe", File.GetAttributes(@"NVCleanstall_1.16.0.exe") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "NVCleanstall_1.13.0.exe";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

        }
    }
}
