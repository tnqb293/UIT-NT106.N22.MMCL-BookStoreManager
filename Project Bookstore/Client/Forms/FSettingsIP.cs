using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Client.Forms
{
    public partial class FSettingsIP : Form
    {
        [Serializable]
        public class Settings
        {
            public int port { get; set; }
            public string ipAdd { get; set; }
            public Settings(int port, string ipAdd)
            {
                this.port = port;
                this.ipAdd = ipAdd;
            }
            public Settings() { }
        }
        public FSettingsIP()
        {
            InitializeComponent();
        }
        XmlSerializer xmlSerializer;
        FileStream fs;
        private void FSettingsIP_Load(object sender, EventArgs e)
        {
            xmlSerializer = new XmlSerializer(typeof(Settings));
            fs = new FileStream("settings.xml", FileMode.OpenOrCreate);
            try
            {
                Settings desSettings = (Settings)xmlSerializer.Deserialize(fs);
                tbIP.Text = desSettings.ipAdd.ToString();
                tbPort.Text = desSettings.port.ToString();
            }
            catch
            {
                tbIP.Text = "172.16.0.192";
                tbPort.Text = "8888";
                MessageBox.Show("Cannot load settings, default values was set");
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbIP.Text != null && tbPort.Text != null)
            {
                try
                {
                    Settings settings = new Settings(Convert.ToInt32(tbPort.Text), tbIP.Text);
                    try
                    {
                        xmlSerializer = new XmlSerializer(typeof(Settings));
                        fs = new FileStream("settings.xml", FileMode.OpenOrCreate);
                        xmlSerializer.Serialize(fs, settings);
                        fs.Close();
                        MessageBox.Show("Successfull");
                        FSettingsIP.ActiveForm.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Cannot save settings, try to reload application");
                    }
                }
                catch
                {
                    MessageBox.Show("Incorrect port or ip address");
                }
            }
            else
            {
                MessageBox.Show("Fill in all the fields");
            }
        }
    }
}
