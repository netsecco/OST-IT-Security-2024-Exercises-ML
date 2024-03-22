using System.Security.Cryptography;
using utils;

namespace SYMENC_AES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            byte[] key = utils.Helpers.HexStringToByteArray(textBoxKey.Text);
            byte[] iv = utils.Helpers.HexStringToByteArray(textBoxIV.Text);

            AesCryptor.init();
            AesCryptor.Key = key;
            AesCryptor.IV = iv;
            byte[] cipherText = AesCryptor.encrypt(textBoxCleartext.Text);
            textBoxCipherText.Text = utils.Helpers.Base64Encode(cipherText);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            byte[] key = utils.Helpers.HexStringToByteArray(textBoxKey.Text);
            byte[] iv = utils.Helpers.HexStringToByteArray(textBoxIV.Text);

            AesCryptor.init();
            AesCryptor.Key = key;
            AesCryptor.IV = iv;

            byte[] cipherText = utils.Helpers.Base64Decode(textBoxCipherText.Text);

            string clearText = AesCryptor.decrypt(cipherText);

            textBoxDecryptedText.Text = clearText;

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            byte[] key = keyFromPassword(password, 16);
            textBoxKey.Text = utils.Helpers.ByteArrayToHexString(key);
        }

        private byte[] keyFromPassword(string password, int length)
        {
            byte[] salt = { 0x44, 0x6f, 0x7d, 0x22 };
            Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, salt, 1000);
            return key.GetBytes(length);

        }

        private void buttonCrack_Click(object sender, EventArgs e)
        {
            byte[] key = utils.Helpers.HexStringToByteArray(textBoxKey.Text);
            byte[] iv = utils.Helpers.HexStringToByteArray(textBoxIV.Text);
            byte[] cipherText = utils.Helpers.Base64Decode(textBoxCipherText.Text);

            AesCryptor.init();
            string clearText = AesCryptor.crack(cipherText, iv, ref key);
            textBoxDecryptedText.Text = clearText;
            textBoxKey.Text = utils.Helpers.ByteArrayToHexString(key);
        }

        private void backgroundWorkerCrack_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}