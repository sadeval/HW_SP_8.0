using Microsoft.Win32;
using System;
using System.Windows.Forms;


namespace AppSettings
{
    public partial class Form1 : Form
    {
        private const string RegistryKeyPath = @"SOFTWARE\NoteApp\Settings";

        public Form1()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath);
                if (key != null)
                {
                    txtUserName.Text = key.GetValue("UserName", "").ToString();
                    chkRememberMe.Checked = Convert.ToBoolean(key.GetValue("RememberMe", false));
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке настроек: " + ex.Message);
            }
        }

        private void SaveSettings()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryKeyPath);
                if (key != null)
                {
                    key.SetValue("UserName", txtUserName.Text);
                    key.SetValue("RememberMe", chkRememberMe.Checked);
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении настроек: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            MessageBox.Show("Настройки сохранены.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

