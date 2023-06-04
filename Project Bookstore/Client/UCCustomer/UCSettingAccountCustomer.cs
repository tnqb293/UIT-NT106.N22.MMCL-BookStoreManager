using Client.Class;
using Client.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UC
{
    public partial class UCSettingAccountCustomer : UserControl
    {
        static string userName;
        InfoChangePassword changepassword;
        InfoRecharge infoRecharege;
        private static double cardnumber;
        private static double serinumber;
        private IpConnection ipConnection = new IpConnection();
        public static UCSettingAccountCustomer instance;
        public UCSettingAccountCustomer(string username)
        {
            userName = username;
            instance = this;
            InitializeComponent();
        }
        private void tbBookNameAddBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            changepassword = new InfoChangePassword();
            string temp = tbReNewPassword.Text;
            changepassword.username = userName;
            changepassword.oldpassword = Encrypt(tbOldPassword.Text);
            changepassword.newpassword = Encrypt(tbNewPassword.Text);
            if (tbOldPassword != null && string.IsNullOrEmpty(tbOldPassword.Text)
                || tbNewPassword != null && string.IsNullOrEmpty(tbNewPassword.Text)
                || tbReNewPassword != null && string.IsNullOrEmpty(tbReNewPassword.Text))
            {
                this.Invoke(new Action(() => MessageBox.Show("Vui lòng nhập đủ thông tin")));
            }
            else if(temp !=  tbNewPassword.Text)
            {
                this.Invoke(new Action(() => MessageBox.Show("Mật khẩu mới của bạn không hợp lệ! Vui lòng kiểm tra lại.")));
            }
            else
            {
                try
                {
                    string message = "request|changepassword " + JsonConvert.SerializeObject(changepassword);
                    StringBuilder builder = ipConnection.ConnectToServer(message);
                    if(builder.ToString() == "password dose not exist")
                    {
                        this.Invoke(new Action(() => MessageBox.Show("Mật khẩu của bạn nhập không đúng. Vui lòng kiểm tra lại!")));
                    }
                    else if(builder.ToString() == "change password success")
                    {
                        this.Invoke(new Action(() => MessageBox.Show("Bạn đã đổi mật khẩu thành công!")));
                    }
                    else
                    {
                        this.Invoke(new Action(() => MessageBox.Show("Lỗi từ phía máy chủ!")));
                    }    
                }
                catch
                {
                    this.Invoke(new Action(() => MessageBox.Show("Máy chủ không phản hồi")));
                }
            }
        }
        //Mã hóa mật khẩu người dùng
        private string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UnicodeEncoding unicode = new UnicodeEncoding();
                byte[] data = md5.ComputeHash(unicode.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            infoRecharege = new InfoRecharge();
            infoRecharege.username = userName;
            infoRecharege.namecard = cbNameCard.Text;
            infoRecharege.valuecard = Int32.Parse(cbValueCard.Text.Replace(".", ""));
            infoRecharege.datetime = DateTime.Now;
            infoRecharege.serinumber = tbSeriNumber.Text;
            infoRecharege.cardnumber = tbCardNumber.Text;
            if (tbSeriNumber != null && string.IsNullOrEmpty(tbSeriNumber.Text)
                || tbCardNumber != null && string.IsNullOrEmpty(tbCardNumber.Text)
                || ((double.TryParse(tbCardNumber.Text, out double cardnumber) && tbCardNumber.Text.Length == 13) == false)
                || ((double.TryParse(tbSeriNumber.Text, out double serinumber) && tbSeriNumber.Text.Length == 11) == false))
            {
                this.Invoke(new Action(() => MessageBox.Show("Mã thẻ không hợp lệ vui lòng nhập lại. Mã thẻ gồm 13 số và số seri gồm 11 số!")));
            }
            else
            {
                try
                {
                    string message = "request|recharge " + JsonConvert.SerializeObject(infoRecharege);
                    StringBuilder builder = ipConnection.ConnectToServer(message);
                    string data = builder.ToString();
                    string[] splitData = data.Split(',');
                    if(data == "Card already exist")
                    {
                        this.Invoke(new Action(() => MessageBox.Show("Số thẻ hoặc số seri đã tồn tại. Vui lòng thử thẻ khác")));
                    }
                    else if (splitData[0] == "Successful recharge")
                    {
                        FMainCustomer.instance.lbtext.Text = splitData[1];
                        UCListBookCustomer form = new UCListBookCustomer(userName);
                        form.Refresh();
                        this.Invoke(new Action(() => MessageBox.Show("Nạp thẻ thành công!")));
                    }
                }
                catch
                {
                    this.Invoke(new Action(() => MessageBox.Show("Lỗi từ phía server")));
                }
            }
        }
    }
}
