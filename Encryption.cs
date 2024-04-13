using System;
using System.Security.Cryptography;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace BITS24_C23
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }

        private void encrypt()
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(RsaKeyTxt.Text);

                    byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(InputTxt.Text), false);

                    OutputTxt.Text = (Convert.ToBase64String(encryptedData));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption error: " + ex.Message);
            }
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            encrypt();
        }
    }
}
