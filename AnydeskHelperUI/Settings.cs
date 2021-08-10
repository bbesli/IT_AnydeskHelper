using AnydeskHelperUI.Abstract;
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

namespace AnydeskHelperUI
{
    public partial class Settings : Form
    {
        ICommands _cmd;
        public Settings(ICommands cmd)
        {
            InitializeComponent();
            _cmd = cmd;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            var status = File.ReadAllText("Settings\\vpnconnectionstatus");
            switch (status)
            {
                case "0":
                    rdAtHome.Checked = true;
                    break;
                case "1":
                    rdAtOffice.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            dgBox.ShowDialog();
            txtPath.Text = dgBox.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _cmd.SetPath(txtPath.Text);
            MessageBox.Show("Kaydedildi.","BİLGİ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void rdAtHome_CheckedChanged(object sender, EventArgs e)
        {
            _cmd.CreateVPNSettings("0");
        }

        private void rdAtOffice_CheckedChanged(object sender, EventArgs e)
        {
            _cmd.CreateVPNSettings("1");
        }
    }
}
