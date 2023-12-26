using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Security.Principal;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using System.Management;


using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;

namespace Launcher
{
    
    public partial class Form1 : Form
    {

        
        





        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        public Form1()
        {
            InitializeComponent();
            InitialiseCPUCounter();
            InitializeRAMCounter();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            kir.Text = "Welcome" + " " + Environment.UserName;
            string hwid = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001", "HwProfileGuid", null).ToString();

            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\OverGame");
            key.SetValue("UserName", textBox1);
            key.SetValue("Setting2", "Status:");
            key.Close();
            label5.Text = "HwID:" + " " + hwid;

            
                                                                                                               

        }
        private void InitialiseCPUCounter()
        {
            cpuCounter = new PerformanceCounter(
            "Processor",
            "% Processor Time",
            "_Total",
            true
            );
        }

        private void InitializeRAMCounter()
        {
            ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ServerIP = "127.0.0.1";
            
            string GTAPath = Registry.CurrentUser.OpenSubKey(@"Software\\SAMP").GetValue("gta_sa_exe").ToString();
            GTAPath = GTAPath.Substring(0, GTAPath.LastIndexOf(@"\") + 1);
            string[] ImaCheat1 = Directory.GetDirectories(GTAPath, "cleo");
            string[] ImaCheat2 = Directory.GetFiles(GTAPath, "CLEO.asi");
            string[] ImaCheat3 = Directory.GetFiles(GTAPath, "d3d9.dll");
            string[] ImaCheat4 = Directory.GetFiles(GTAPath, "SAMPFUNCS.asi");
            string[] ImaCheat5 = Directory.GetDirectories(GTAPath, "mod_sa");
            string[] ImaCheat6 = Directory.GetDirectories(GTAPath, "OverLight_Mod");
            string[] ImaCheat7 = Directory.GetFiles(GTAPath, "vorbishooked.dll");
            string[] ImaCheat8 = Directory.GetFiles(GTAPath, "modloader");
            string[] ImaCheat9 = Directory.GetFiles(GTAPath, "CustomSAA2");
            string[] ImaCheat10 = Directory.GetFiles(GTAPath, "ImVehFt");
     
            string[] ImaCheat12 = Directory.GetFiles(GTAPath, "moadloader.asi");
            string[] ImaCheat13 = Directory.GetFiles(GTAPath, "DSOUND.dll");

            if (((ImaCheat1.Length > 0) || (ImaCheat2.Length > 0)) || ((ImaCheat3.Length > 0) || (ImaCheat4.Length > 0)))
            {
                MessageBox.Show("Ilegal Mod Detected", "Ilegal Mod Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((ImaCheat5.Length > 0) || (ImaCheat6.Length > 0))
            {
                MessageBox.Show("Ilegal Mod Detected", "Ilegal Mod Detected", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (ImaCheat7.Length < 0)
            {
                MessageBox.Show("Launcher Error", "You Are Not Using Launcher", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (ImaCheat8.Length < 0)
            {
                MessageBox.Show("Launcher Error", "You Are Not Using Launcher", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (ImaCheat9.Length < 0)
            {
                MessageBox.Show("Launcher Error", "You Are Not Using Launcher", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (ImaCheat9.Length < 0)
            {
                MessageBox.Show("Launcher Error", "You Are Not Using Launcher", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (ImaCheat10.Length < 0)
            {
                MessageBox.Show("Launcher Error", "You Are Not Using Launcher", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (ImaCheat12.Length < 0)
            {
                MessageBox.Show("Launcher Error", "You Are Not Using Launcher", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (ImaCheat13.Length < 0)
            {
                MessageBox.Show("Launcher Error", "You Are Not Using Launcher", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
               Registry.CurrentUser.OpenSubKey(@"Software\SAMP", true).SetValue("PlayerName", textBox1.Text);
                Process.Start(GTAPath + "samp.exe", ServerIP + "");

            }
            

    }

       private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {

            
            //System.IO.File.WriteAllText(@"C:\Users\Ariyanpishro\Documents\GTA San Andreas User Files\SAMP\sa-mp.cfg", data);
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {




           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "CPU Usage: " +
            Convert.ToInt32(cpuCounter.NextValue()).ToString() + "%";


            label3.Text = "RAM Usage:" + " " + Convert.ToInt32(ramCounter.NextValue()).ToString() + "Mb";


            // Print the user name to the console
            Ping p = new Ping();
            PingReply r;
            string s;
            s = "127.0.0.1";
            r = p.Send(s);

            if (r.Status == IPStatus.Success)
            {
                label6.Text = "Ping Server: "+  r.RoundtripTime.ToString() + " ms" + "\n";
            }

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }













}