using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Drawing;
using Microsoft.Win32;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace StartButton_Fix
{
    public partial class Form1 : Form
    {

        public int ButtonLocation { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void RepairStartMenu()
        {
            try
            {
                if (ButtonLocation == -1 ||  ButtonLocation > 1)
                {
                    MessageBox.Show("You must select the buttons current Location" + Environment.NewLine + "Is the button currently on left or is in centered?",
                   "Current Button Location not selected", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); progressBar1.Value = 0; return;
                }

                progressBar1.Value = 1;


                int OriginalValue = ButtonLocation;
                
                // Open the registry key
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);

                switch (ButtonLocation)
                {
                    case 0:
                        //original Button is in the center change to left and then back to 0
                        OriginalValue = 1; break;

                    case 1:
                        //original Button is on the Left change to Center and then back to 1
                        OriginalValue = 0; break;

                    default:
                        break;
                }


                if (key != null)
                {
                    // Set the TaskbarAl value to 0 (left alignment) or 1 for right Alignment
                   
                    key.SetValue("TaskbarAl", OriginalValue, RegistryValueKind.DWord);
                    key.Close();

                    //
                    Thread.Sleep(1000); // Delay for 1000 milliseconds (1 seconds)
                    progressBar1.Value = 2;
                    RegistryKey key1 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);
                    key1.SetValue("TaskbarAl", ButtonLocation, RegistryValueKind.DWord);
                    key1.Close();

                    Thread.Sleep(1000); // Delay for 1000 milliseconds (1 seconds)
                    progressBar1.Value = 3;
                    ButtonLocation = -1;
                    MessageBox.Show("The button should now work!", "Repair has completed.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    progressBar1.Value = 0;
                }

            }
            catch (Exception ex)
            {
                ButtonLocation = -1;
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btnLeft_CheckedChanged(object sender, EventArgs e)
        {

            ButtonLocation = 0;
        } 

        private void btnCenter_CheckedChanged(object sender, EventArgs e)
        {
            ButtonLocation = 1;

        }

        private void btnReapirStartButton_Click(object sender, EventArgs e)
        {
            RepairStartMenu();
        }
    }
}
