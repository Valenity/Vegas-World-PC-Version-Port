using System;
using System.Linq;
using System.Windows.Forms;
using DiscordRPC;

namespace VegasWorld
{
    public partial class Game : Form
    {
        DiscordRpcClient nuts = new DiscordRpcClient("999916904770719846");
        
        bool restart;
        public Game()
        {
            InitializeComponent();
            EO.WebBrowser.Runtime.AddLicense("Kb114+30EO2s3OmxGeCm3MGz8M5nzunz7fGo7vf2HaF3s7P9FOKe5ff2EL112PD9GvZ3s+X1D5+t8PT26KF+xrLUE/Go5Omzy5+v3PYEFO6ntKbC461pmaTA6bto2PD9GvZ3s/MDD+SrwPL3Gp+d2Pj26KFpqbPC3a5rp7XIzZ+v3PYEFO6ntKbC46FotcAEFOan2PgGHeR36d7SGeWawbMKFOervtrI9eBysO3XErx2s7MEFOan2PgGHeR3s7P9FOKe5ff26XXj7fQQ7azcws0X6Jzc8gQQyJ21tMbbtnCttcbcs3Wm8PoO5Kfq6doP");
            EO.Base.Runtime.EnableEOWP = true;
            EO.Base.Runtime.EnableCrashReport = false;
            nuts.Initialize();
            nuts.Invoke();
            nuts.UpdateState("Gambling (Responsibly!)");
            nuts.UpdateStartTime(DateTime.UtcNow);
            nuts.UpdateLargeAsset("vegas");
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            nuts.SetPresence(nuts.CurrentPresence);
            this.Hide();
            // if the program is already open, send a messagebox
            System.Diagnostics.Process[] nut;
            if (System.Diagnostics.Process.GetProcessesByName("Vegas World").Count() > 1)
            {
                nut = System.Diagnostics.Process.GetProcessesByName("Vegas World");
                DialogResult dialogResult = MessageBox.Show("Do you want to restart?", "Vegas World Already Running!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    restart = true;
                    /// close nut
                    foreach (System.Diagnostics.Process p in nut)
                    {
                        p.CloseMainWindow();
                    }
                    // open VegasWorld.exe
                    System.Diagnostics.Process.Start("Vegas World.exe");
                }
                Environment.Exit(0);
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            guna2Panel1.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            nuts.Deinitialize();
            nuts.Dispose();
            if (restart == true)
            {
                // reopen the program
                System.Diagnostics.Process.Start("VegasWorld.exe");
            }
        }
    }
}
