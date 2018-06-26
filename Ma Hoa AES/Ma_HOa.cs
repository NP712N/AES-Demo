using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ma_Hoa_AES
{
    public partial class Ma_HOa : Form
    {
        Sec_AES aes = new Sec_AES();
        public Ma_HOa()
        {
            InitializeComponent();
        }

        private void cmdinfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là chương trình mã hóa - giải mã do P2share.com cung cấp ^^", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdreset1_Click(object sender, EventArgs e)
        {
            txtencr.Text = "";
            txtreencr.Text = "";
        }

        private void cmdreset2_Click(object sender, EventArgs e)
        {
            txtdecr.Text = "";
            txtrsdecr.Text = "";
        }

        private void cmdmahoa_Click(object sender, EventArgs e)
        {
            if (txtencr.Text != "")
            {
                try
                {
                    txtreencr.Text = aes.Encrypt(txtencr.Text,txtkey1.Text , 128);
                }
                catch
                {
                    MessageBox.Show("Không Mã Hóa được", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ô Nội Dung không được rỗng", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmddecr_Click(object sender, EventArgs e)
        {
            if (txtdecr.Text  != "")
            {
                try
                {
                    txtrsdecr.Text = aes.Decrypt(txtdecr.Text, txtkey2.Text, 128);
                }
                catch
                {
                    MessageBox.Show("Không Giải Mã được", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ô Nội Dung không được rỗng", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}