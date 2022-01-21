using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DualSenseAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private Mem memLib = new Mem();

        private int processID;
        private bool processOpen = false;

        private bool validNumber = false;
        private int temporaryNumb = 0;

        public struct Controller
        {
            public enum Types
            {
                Normal = 1,
                Hard = 2,
            }
            public struct WriteController
            {
                public static void SetRightTrigger(Controller.Types type)
                {
                        var MyIni = new IniFile(@"C:\DualsenseX_GameTriggers.txt");

                    switch (type)
                    {
                        case Controller.Types.Normal: 
                            MyIni.Write("RightTrigger", "Normal");
                            break;
                        case Controller.Types.Hard:
                            MyIni.Write("RightTrigger", "Hard");
                            break;
                    }
                }
            }
        }


        private void findProcessID()
        {
            processID = memLib.GetProcIdFromName("re5dx9"); //Gets process ID
            processOpen = memLib.OpenProcess(processID);

            if (processID > 0)
            {
                procIdLabel.Invoke((MethodInvoker)delegate
                {
                    procIdLabel.Text = processID.ToString();
                    procIdLabel.ForeColor = Color.Lime;
                });

                gameProcessNameLabel.Invoke((MethodInvoker)delegate {
                    gameProcessNameLabel.Text = "re5dx9.exe";
                    gameProcessNameLabel.ForeColor = Color.Lime;
                });
            }
            else
            {
                procIdLabel.Invoke((MethodInvoker)delegate
                {
                    procIdLabel.Text = "Process ID Not Found";
                    procIdLabel.ForeColor = Color.Red;
                });

                gameProcessNameLabel.Invoke((MethodInvoker)delegate {
                    gameProcessNameLabel.Text = "N/A";
                    gameProcessNameLabel.ForeColor = Color.Red;
                });
            }

            if (processOpen)
            {

                procOpenLabel.Invoke((MethodInvoker)delegate
                {
                    procOpenLabel.Text = "JOGO ENCONTRADO";
                    procOpenLabel.ForeColor = Color.Lime;
                });

            }
            else
            {
                procOpenLabel.Invoke((MethodInvoker)delegate
                {
                    procOpenLabel.Text = "N/A";
                    procOpenLabel.ForeColor = Color.Red;
                });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            findProcessID();

            if (!processOpen)
            {
                MessageBox.Show("Falha ao encontrar o processo do jogo 're5dx9.exe'");
                Thread.Sleep(1000);
                return;
            }
        }

        private void ResidentEvil5Steam()
        {
            var MyIni = new IniFile(@"C:\DualsenseX_GameTriggers.txt");

            int ammo = memLib.ReadInt("re5dx9.exe+00DA2604,84,238,CE4,5C,36C,0,F40");
            // MyIni.Write("RightTrigger", "Resistance");
            MyIni.Write("LeftTrigger", "Resistance");
            MyIni.Write("ForceLeftTrigger", "(4)(2)");

            if (ammo > 0)
            {
                Controller.WriteController.SetRightTrigger(Controller.Types.Hard);
              //  MyIni.Write("RightTrigger", "SemiAutomaticGun");
               // MyIni.Write("ForceLeftTrigger", "(2)(5)(2)");
            }
            else
                Controller.WriteController.SetRightTrigger(Controller.Types.Normal);

            Console.WriteLine("municao: " + ammo);
        }

        private void OnTime_Tick(object sender, EventArgs e)
        {
            if (!processOpen)
                return;
            if (gameList.SelectedIndex < 0)
                return;
            if (gameList.SelectedItem.ToString() == "Resident Evil 5 (Steam)")
                ResidentEvil5Steam();

            
        }
    }
}
