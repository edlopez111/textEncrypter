using Encrypter.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string key = txtSecretw1.Text;
            string text = txtText1.Text;

            if(key.Length == 16 && key.Length > 0)
            {
                if(text.Length > 0)
                {
                    txtEncrypted.Text = Utils.Encrypt(key, text);
                }
                else
                {
                    MessageBox.Show("Text can't be empty", "Encrypter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Secret Key too short, expect at least 16 characters or above","Encrypter",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCopyE_Click(object sender, EventArgs e)
        {
            Utils.toClipboard(txtEncrypted.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string key = txtSecretw2.Text;
            string text = txtText2.Text;

            if(key.Length == 16 && key.Length > 0)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    txtDecrypted.Text = Utils.Decrypt(key,text);
                }
                else
                {
                    MessageBox.Show("Encrypted text can't be empty", "Encrypter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Secret Key too short, expect at least 16 characters or above", "Encrypter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopy2_Click(object sender, EventArgs e)
        {
            Utils.toClipboard(txtDecrypted.Text);
        }
    }
}
