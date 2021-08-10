
namespace AnydeskHelperUI
{
    partial class Settings
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
            this.txtPath = new MetroFramework.Controls.MetroTextBox();
            this.btnShowDialog = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgBox = new System.Windows.Forms.OpenFileDialog();
            this.rdAtHome = new MetroFramework.Controls.MetroRadioButton();
            this.rdAtOffice = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            // 
            // 
            // 
            this.txtPath.CustomButton.Image = null;
            this.txtPath.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.txtPath.CustomButton.Name = "";
            this.txtPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPath.CustomButton.TabIndex = 1;
            this.txtPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPath.CustomButton.UseSelectable = true;
            this.txtPath.CustomButton.Visible = false;
            this.txtPath.Lines = new string[] {
        "C:\\Program Files (x86)\\AnyDesk\\AnyDesk.exe"};
            this.txtPath.Location = new System.Drawing.Point(55, 72);
            this.txtPath.MaxLength = 32767;
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPath.SelectedText = "";
            this.txtPath.SelectionLength = 0;
            this.txtPath.SelectionStart = 0;
            this.txtPath.ShortcutsEnabled = true;
            this.txtPath.Size = new System.Drawing.Size(291, 23);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "C:\\Program Files (x86)\\AnyDesk\\AnyDesk.exe";
            this.txtPath.UseSelectable = true;
            this.txtPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(352, 72);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(97, 23);
            this.btnShowDialog.TabIndex = 1;
            this.btnShowDialog.Text = "Bul";
            this.btnShowDialog.UseSelectable = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(352, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(226, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Ayndesk\'in kurulu olduğu yolu seçiniz.";
            // 
            // dgBox
            // 
            this.dgBox.FileName = "openFileDialog1";
            // 
            // rdAtHome
            // 
            this.rdAtHome.AutoSize = true;
            this.rdAtHome.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdAtHome.Location = new System.Drawing.Point(55, 171);
            this.rdAtHome.Name = "rdAtHome";
            this.rdAtHome.Size = new System.Drawing.Size(134, 19);
            this.rdAtHome.TabIndex = 4;
            this.rdAtHome.Text = "Evden çalışıyorum";
            this.rdAtHome.UseSelectable = true;
            this.rdAtHome.CheckedChanged += new System.EventHandler(this.rdAtHome_CheckedChanged);
            // 
            // rdAtOffice
            // 
            this.rdAtOffice.AutoSize = true;
            this.rdAtOffice.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdAtOffice.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rdAtOffice.Location = new System.Drawing.Point(219, 171);
            this.rdAtOffice.Name = "rdAtOffice";
            this.rdAtOffice.Size = new System.Drawing.Size(89, 19);
            this.rdAtOffice.TabIndex = 5;
            this.rdAtOffice.Text = "Ofisteyim";
            this.rdAtOffice.UseSelectable = true;
            this.rdAtOffice.CheckedChanged += new System.EventHandler(this.rdAtOffice_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 617);
            this.Controls.Add(this.rdAtOffice);
            this.Controls.Add(this.rdAtHome);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.txtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtPath;
        private MetroFramework.Controls.MetroButton btnShowDialog;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.OpenFileDialog dgBox;
        private MetroFramework.Controls.MetroRadioButton rdAtHome;
        private MetroFramework.Controls.MetroRadioButton rdAtOffice;
    }
}