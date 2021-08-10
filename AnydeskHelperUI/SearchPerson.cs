using AnydeskHelperUI.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnydeskHelperUI
{
    public partial class SearchPerson : Form
    {
        bool checkboxControl = true;
        ICommands _cmd;
        HomeAgentEntities entities = new HomeAgentEntities();
        public SearchPerson(ICommands cmd)
        {
            InitializeComponent();
            _cmd = cmd;
            this.Load += SearchPerson_Load;
        }

        public bool CheckForVPNInterface()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                NetworkInterface[] interfaces =
    NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface Interface in interfaces)
                {
                    // This is the OpenVPN driver for windows. 
                    if (Interface.Description.Contains("Fortinet SSL VPN Virtual Ethernet Adapter")
                      && Interface.OperationalStatus == OperationalStatus.Up)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private void SearchPerson_Load(object sender, EventArgs e)
        {
            if (File.ReadAllText("Settings\\vpnconnectionstatus") == "0")
            {
                if (CheckForVPNInterface())
                {
                    FillTextboxAndCmbBox();
                }
                else
                {
                    MessageBox.Show("VPN'e bağlanmalısınız.");
                }
            }
            else
            {
                FillTextboxAndCmbBox();
            }

        }

        private void FillTextboxAndCmbBox()
        {
            foreach (var location in entities.forms)
            {
                if (!cmbLocation.Items.Contains(location.lokasyon))
                {
                    cmbLocation.Items.Add(location.lokasyon);
                }
            }

            cmbSearch.Items.Add(AutoCompleteSource.CustomSource);

            txtSearchPerson.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            foreach (var item in entities.forms)
            {
                if (item.anyDeskId != null)
                {
                    txtSearchPerson.AutoCompleteCustomSource.Add(item.adiSoyadi+"#"+ " Anydesk: " + item.anyDeskId+"#"+
                        " Lokasyon: "+item.lokasyon+"\t # \t"+" Proje: "+item.musteri+"  ");
                }
            }

            cmbSearch.SelectedIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchPerson.AutoCompleteSource = (AutoCompleteSource)cmbSearch.SelectedItem;
        }

        private void txtSearchPerson_ButtonClick(object sender, EventArgs e)
        {
            lblLocation.Text = TakeInformationFromTextbox("Lokasyon:").Substring(0,9);
            lblAnydeskId.Text = TakeInformationFromTextbox("Anydesk:").Substring(0, 9);
            lblProject.Text = TakeInformationFromTextbox("Proje:");
            Connection();
        }

        private void txtSearchPerson_ButtonClick_1(object sender, EventArgs e)
        {
            lblLocation.Text = TakeInformationFromTextbox("Lokasyon:").Substring(0, 9);
            lblAnydeskId.Text = TakeInformationFromTextbox("Anydesk:").Substring(0, 9);
            lblProject.Text = TakeInformationFromTextbox("Proje:");
            Connection();
        }

        private void txtSearchPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblLocation.Text = TakeInformationFromTextbox("Lokasyon:").Substring(0, 9);
                lblAnydeskId.Text = TakeInformationFromTextbox("Anydesk:").Substring(0, 9);
                lblProject.Text = TakeInformationFromTextbox("Proje:");
                Connection();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void rdDirectConnection_CheckedChanged(object sender, EventArgs e)
        {
            checkboxControl = false;
            txtPassword.Visible = false;
        }

        private void rdPasswordConnection_CheckedChanged(object sender, EventArgs e)
        {
            checkboxControl = true;
            txtPassword.Visible = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            lblLocation.Text = TakeInformationFromTextbox("Lokasyon:").Substring(0, 9);
            lblAnydeskId.Text = TakeInformationFromTextbox("Anydesk:").Substring(0, 9);
            lblProject.Text = TakeInformationFromTextbox("Proje:");
            Connection();
        }

        private void Connection()
        {
            switch (checkboxControl)
            {
                case true:
                    _cmd.CreateBatFile(txtPassword.Text, lblAnydeskId.Text);
                    _cmd.ProcessStart("Settings\\connectionWithPassword.bat");
                    //Process.Start(command);
                    break;
                case false:
                    _cmd.ProcessStart(_cmd.ReadAnydeskPath($"Settings\\settings"), $"{lblAnydeskId.Text}"); ;
                    break;
                default:
                    break;
            }
        }

        public string TakeInformationFromTextbox(string textForSearch)
        {
            string toBeSearched = $" {textForSearch} ";
            int ix = txtSearchPerson.Text.IndexOf(toBeSearched);

            if (ix != -1)
            {
                string code = txtSearchPerson.Text.Substring(ix + toBeSearched.Length);
                return code;
            }
            return string.Empty;
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchPerson.AutoCompleteCustomSource.Clear();
            cmbSearch.Items.Add(AutoCompleteSource.CustomSource);

            txtSearchPerson.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            foreach (var item in entities.forms)
            {
                if (item.anyDeskId != null && item.lokasyon == cmbLocation.SelectedItem.ToString())
                {
                    txtSearchPerson.AutoCompleteCustomSource.Add(item.adiSoyadi + " Anydesk: " + item.anyDeskId);
                }
            }

            cmbSearch.SelectedIndex = 0;
        }

        private void txtPassword_ButtonClick(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "\"\\DESKTOP-P00ONJP\\C$\\t.txt\"";
            MessageBox.Show(path);
            //Process.Start(path);
        }
    }
}
