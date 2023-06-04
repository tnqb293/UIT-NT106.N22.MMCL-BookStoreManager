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

namespace Server.Forms
{
    public partial class FSetting : Form
    {
        public FSetting()
        {
            InitializeComponent();
        }
        [Serializable]
        public class Settings
        {
            public string ipaddr { get; set; }
            public int port { get; set; }
            public Settings(string ipaddr, int port)
            {
                this.ipaddr = ipaddr;
                this.port = port;
            }
            public Settings() { }
        }
        XmlSerializer xmlSerializer;
        FileStream fs;
        private void bSaveSettings_Click(object sender, EventArgs e)
        {
            if(tbIPAddress.Text != "" && tbPort.Text != "")
            {
                try
                {
                    Settings settings = new Settings(tbIPAddress.Text, Convert.ToInt32(tbPort.Text));
                    try
                    {
                        xmlSerializer = new XmlSerializer(typeof(FSetting.Settings));
                        fs = new FileStream("settings.xml", FileMode.OpenOrCreate);
                        xmlSerializer.Serialize(fs, settings);
                        fs.Close();
                        MessageBox.Show("Successful, reload the application for the changees to take effect");
                        FSetting.ActiveForm.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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

        private void FSetting_Load(object sender, EventArgs e)
        {
            xmlSerializer = new XmlSerializer(typeof(FSetting.Settings));
            fs = new FileStream("settings.xml", FileMode.OpenOrCreate);
            try
            {
                Settings desSettings = (Settings)xmlSerializer.Deserialize(fs);
                tbIPAddress.Text = desSettings.ipaddr.ToString();
                tbPort.Text = desSettings.port.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
