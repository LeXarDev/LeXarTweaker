using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeXarTweaker
{
    public partial class windows : Form
    {
        public windows()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/878261383710511124/1264044846319144993/PowerSaving_Disable.bat?ex=669c7100&is=669b1f80&hm=c67ca870589a2d8fe3f8eb099413d6c740f83ffb647bf09db0de5261a84e2687&t", "DisablePowerSaving.bat");
            File.SetAttributes(@"DisablePowerSaving.bat", File.GetAttributes(@"DisablePowerSaving.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "DisablePowerSaving.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"DisablePowerSaving.bat"))
            {
                File.Delete(@"DisablePowerSaving.bat");
            }

            string message = "Powersaving Disabled!";
            MessageBox.Show(message);
        }

        private void powerplan_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/ImportPowerPlan.bat", "ImportPowerPlan.bat");
            File.SetAttributes(@"ImportPowerPlan.bat", File.GetAttributes(@"ImportPowerPlan.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "ImportPowerPlan.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"ImportPowerPlan.bat"))
            {
                File.Delete(@"ImportPowerPlan.bat");
            }

            string message = "Quickboost PowerPlan Applied!";
            MessageBox.Show(message);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/DisableTelemetry.bat", "DisableTelemetry.bat");
            File.SetAttributes(@"DisableTelemetry.bat", File.GetAttributes(@"DisableTelemetry.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "DisableTelemetry.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"DisableTelemetry.bat"))
            {
                File.Delete(@"DisableTelemetry.bat");
            }


            string message = "Start-up Telemetry Disabled!";
            MessageBox.Show(message);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Mouse", "MouseSpeed", 0, RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Mouse", "MouseThreshold1", 0, RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Mouse", "MouseThreshold2", 0, RegistryValueKind.String);

            string message = "Mouse Acceleration Disabled!";
            MessageBox.Show(message);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "NoLazyMode", 1, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "NetworkThrottlingIndex", 10, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "SystemResponsiveness", 10, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "GPU Priority", 18, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Priority", 6, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Scheduling Category", "High", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "SFIO Priority", "High", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\GraphicsDrivers", "HwSchMode", 2, RegistryValueKind.DWord);
            string message = "System Profile Tweaks Applied!";
            MessageBox.Show(message);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/FSE.bat", "FSE.bat");
            File.SetAttributes(@"FSE.bat", File.GetAttributes(@"FSE.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "FSE.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"FSE.bat"))
            {
                File.Delete(@"FSE.bat");
            }

            string message = "Full-screen Optimization Enabled & Xbox gamebar Disabled!";
            MessageBox.Show(message);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/TimerResolutionService.bat", "TimerResolutionService.bat");
            File.SetAttributes(@"TimerResolutionService.bat", File.GetAttributes(@"TimerResolutionService.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "TimerResolutionService.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"TimerResolutionService.bat"))
            {
                File.Delete(@"TimerResolutionService.bat");
            }

            string message = "Timer Res Service Installed!";
            MessageBox.Show(message);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/DisableServices.bat", "DisableServices.bat");
            File.SetAttributes(@"DisableServices.bat", File.GetAttributes(@"DisableServices.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "DisableServices.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"DisableServices.bat"))
            {
                File.Delete(@"DisableServices.bat");
            }

            string message = "Unnecessary Services Disabled!";
            MessageBox.Show(message);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/TaskManager.bat", "TaskManager.bat");
            File.SetAttributes(@"TaskManager.bat", File.GetAttributes(@"TaskManager.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "TaskManager.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"TaskManager.bat"))
            {
                File.Delete(@"TaskManager.bat");
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/Remove%20preinstalled.bat", "removepreinstalled.bat");
            File.SetAttributes(@"removepreinstalled.bat", File.GetAttributes(@"removepreinstalled.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "removepreinstalled.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"removepreinstalled.bat"))
            {
                File.Delete(@"removepreinstalled.bat");
            }

            string message = "Pre-installed Apps Removed!";
            MessageBox.Show(message);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/ApplyAllTweaks.bat", "ApplyAllTweaks.bat");
            File.SetAttributes(@"ApplyAllTweaks.bat", File.GetAttributes(@"ApplyAllTweaks.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "ApplyAllTweaks.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"ApplyAllTweaks.bat"))
            {
                File.Delete(@"ApplyAllTweaks.bat");
            }
        }

        private void windows_Load(object sender, EventArgs e)
        {

        }
    }
}
