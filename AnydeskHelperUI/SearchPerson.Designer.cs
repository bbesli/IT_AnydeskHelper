
namespace AnydeskHelperUI
{
    partial class SearchPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSearch = new MetroFramework.Controls.MetroComboBox();
            this.txtSearchPerson = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbLocation = new MetroFramework.Controls.MetroComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.rdPasswordConnection = new MetroFramework.Controls.MetroRadioButton();
            this.rdDirectConnection = new MetroFramework.Controls.MetroRadioButton();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.lblLocation = new MetroFramework.Controls.MetroLabel();
            this.lblAnydeskId = new MetroFramework.Controls.MetroLabel();
            this.lblProject = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(111)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.cmbSearch);
            this.panel1.Controls.Add(this.txtSearchPerson);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 90);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.ItemHeight = 23;
            this.cmbSearch.Location = new System.Drawing.Point(3, 35);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(66, 29);
            this.cmbSearch.TabIndex = 2;
            this.cmbSearch.UseSelectable = true;
            this.cmbSearch.Visible = false;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // txtSearchPerson
            // 
            this.txtSearchPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            // 
            // 
            // 
            this.txtSearchPerson.CustomButton.AccessibleName = "txtSearchButton";
            this.txtSearchPerson.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPerson.CustomButton.Image = global::AnydeskHelperUI.Properties.Resources.search;
            this.txtSearchPerson.CustomButton.Location = new System.Drawing.Point(357, 1);
            this.txtSearchPerson.CustomButton.Name = "";
            this.txtSearchPerson.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchPerson.CustomButton.TabIndex = 1;
            this.txtSearchPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchPerson.CustomButton.UseSelectable = true;
            this.txtSearchPerson.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchPerson.Lines = new string[0];
            this.txtSearchPerson.Location = new System.Drawing.Point(176, 35);
            this.txtSearchPerson.MaxLength = 32767;
            this.txtSearchPerson.Name = "txtSearchPerson";
            this.txtSearchPerson.PasswordChar = '\0';
            this.txtSearchPerson.PromptText = "Kişi Ara";
            this.txtSearchPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchPerson.SelectedText = "";
            this.txtSearchPerson.SelectionLength = 0;
            this.txtSearchPerson.SelectionStart = 0;
            this.txtSearchPerson.ShortcutsEnabled = true;
            this.txtSearchPerson.ShowButton = true;
            this.txtSearchPerson.Size = new System.Drawing.Size(545, 23);
            this.txtSearchPerson.TabIndex = 0;
            this.txtSearchPerson.UseSelectable = true;
            this.txtSearchPerson.WaterMark = "Kişi Ara";
            this.txtSearchPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchPerson.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtSearchPerson_ButtonClick_1);
            this.txtSearchPerson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchPerson_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(22, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Lokasyon Seçiniz: ";
            this.metroLabel1.Visible = false;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // cmbLocation
            // 
            this.cmbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.ItemHeight = 23;
            this.cmbLocation.Items.AddRange(new object[] {
            "KAYSERİ",
            "İSTANBUL"});
            this.cmbLocation.Location = new System.Drawing.Point(176, 18);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.PromptText = "SEÇİNİZ...";
            this.cmbLocation.Size = new System.Drawing.Size(286, 29);
            this.cmbLocation.TabIndex = 2;
            this.cmbLocation.UseSelectable = true;
            this.cmbLocation.Visible = false;
            this.cmbLocation.SelectedIndexChanged += new System.EventHandler(this.cmbLocation_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblProject);
            this.panel2.Controls.Add(this.lblAnydeskId);
            this.panel2.Controls.Add(this.lblLocation);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.rdPasswordConnection);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.cmbLocation);
            this.panel2.Controls.Add(this.rdDirectConnection);
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 527);
            this.panel2.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtPassword.CustomButton.BackColor = System.Drawing.Color.White;
            this.txtPassword.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.CustomButton.ForeColor = System.Drawing.Color.Blue;
            this.txtPassword.CustomButton.Image = global::AnydeskHelperUI.Properties.Resources.eye;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.UseVisualStyleBackColor = false;
            this.txtPassword.Lines = new string[] {
        "!P@ssWordADM!IST"};
            this.txtPassword.Location = new System.Drawing.Point(286, 308);
            this.txtPassword.MaximumSize = new System.Drawing.Size(1920, 23);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.ShowButton = true;
            this.txtPassword.Size = new System.Drawing.Size(163, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "!P@ssWordADM!IST";
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseCustomForeColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            this.txtPassword.Visible = false;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtPassword_ButtonClick);
            // 
            // rdPasswordConnection
            // 
            this.rdPasswordConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdPasswordConnection.AutoSize = true;
            this.rdPasswordConnection.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdPasswordConnection.Location = new System.Drawing.Point(176, 268);
            this.rdPasswordConnection.Name = "rdPasswordConnection";
            this.rdPasswordConnection.Size = new System.Drawing.Size(140, 25);
            this.rdPasswordConnection.TabIndex = 4;
            this.rdPasswordConnection.Text = "Şifreli bağlantı";
            this.rdPasswordConnection.UseSelectable = true;
            this.rdPasswordConnection.CheckedChanged += new System.EventHandler(this.rdPasswordConnection_CheckedChanged);
            // 
            // rdDirectConnection
            // 
            this.rdDirectConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdDirectConnection.AutoSize = true;
            this.rdDirectConnection.Checked = true;
            this.rdDirectConnection.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdDirectConnection.Location = new System.Drawing.Point(176, 229);
            this.rdDirectConnection.Name = "rdDirectConnection";
            this.rdDirectConnection.Size = new System.Drawing.Size(178, 25);
            this.rdDirectConnection.TabIndex = 3;
            this.rdDirectConnection.TabStop = true;
            this.rdDirectConnection.Text = "Doğrudan bağlantı";
            this.rdDirectConnection.UseSelectable = true;
            this.rdDirectConnection.CheckedChanged += new System.EventHandler(this.rdDirectConnection_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(126)))));
            this.btnConnect.Location = new System.Drawing.Point(603, 466);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(118, 49);
            this.btnConnect.Style = MetroFramework.MetroColorStyle.Green;
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "BAĞLAN";
            this.btnConnect.UseCustomBackColor = true;
            this.btnConnect.UseCustomForeColor = true;
            this.btnConnect.UseSelectable = true;
            this.btnConnect.UseStyleColors = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLocation.Location = new System.Drawing.Point(176, 84);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(98, 25);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "LOKASYON";
            // 
            // lblAnydeskId
            // 
            this.lblAnydeskId.AutoSize = true;
            this.lblAnydeskId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAnydeskId.Location = new System.Drawing.Point(176, 128);
            this.lblAnydeskId.Name = "lblAnydeskId";
            this.lblAnydeskId.Size = new System.Drawing.Size(108, 25);
            this.lblAnydeskId.TabIndex = 8;
            this.lblAnydeskId.Text = "ANYDESK_ID";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProject.Location = new System.Drawing.Point(176, 170);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(61, 25);
            this.lblProject.TabIndex = 9;
            this.lblProject.Text = "PROJE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(733, 617);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchPerson";
            this.Text = "SearchPerson";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox txtSearchPerson;
        private MetroFramework.Controls.MetroButton btnConnect;
        private MetroFramework.Controls.MetroComboBox cmbSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroRadioButton rdPasswordConnection;
        private MetroFramework.Controls.MetroRadioButton rdDirectConnection;
        private MetroFramework.Controls.MetroComboBox cmbLocation;
        private MetroFramework.Controls.MetroLabel lblProject;
        private MetroFramework.Controls.MetroLabel lblAnydeskId;
        private MetroFramework.Controls.MetroLabel lblLocation;
        private System.Windows.Forms.Button button1;
    }
}