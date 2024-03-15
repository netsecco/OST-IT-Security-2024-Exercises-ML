namespace SYMENC_ModesXor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxKexH_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKexH.Text.Length == 2)
            {
                byte b = utils.Helpers.HexToByte(textBoxKexH.Text);
                textBoxKeyB.Text = utils.Helpers.ByteToBin(b);
            }
        }

        private void textBoxCTH1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCTH1.Text.Length == 2)
            {
                byte b = utils.Helpers.HexToByte(textBoxCTH1.Text);
                textBoxCTB1.Text = utils.Helpers.ByteToBin(b);
            }
        }

        private void buttonEnc1_Click(object sender, EventArgs e)
        {
            byte key = utils.Helpers.HexToByte(textBoxKexH.Text);
            byte clearText1 = utils.Helpers.HexToByte(textBoxCTH1.Text);
            byte result = utils.Helpers.Xor(clearText1, key);
            textBoxSTH1.Text = utils.Helpers.ByteToHex(result);
            textBoxSTB1.Text = utils.Helpers.ByteToBin(result);
        }

        private void buttonDec1_Click(object sender, EventArgs e)
        {
            byte key = utils.Helpers.HexToByte(textBoxKexH.Text);
            byte secureText1 = utils.Helpers.HexToByte(textBoxSTH1.Text);
            byte result = utils.Helpers.Xor(secureText1, key);
            textBoxDecH1.Text = utils.Helpers.ByteToHex(result);

        }

        private void buttonEnc2_Click(object sender, EventArgs e)
        {
            byte key = utils.Helpers.HexToByte(textBoxKexH.Text);
            byte clearText2 = utils.Helpers.HexToByte(textBoxCTH2.Text);
            byte result = utils.Helpers.Xor(clearText2, key);
            textBoxSTH2.Text = utils.Helpers.ByteToHex(result);
            textBoxSTB2.Text = utils.Helpers.ByteToBin(result);
        }

        private void buttonDec2_Click(object sender, EventArgs e)
        {
            byte key = utils.Helpers.HexToByte(textBoxKexH.Text);
            byte secureText2 = utils.Helpers.HexToByte(textBoxSTH2.Text);
            byte result = utils.Helpers.Xor(secureText2, key);
            textBoxDecH2.Text = utils.Helpers.ByteToHex(result);
        }

        private void textBoxCTH2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCTH2.Text.Length == 2)
            {
                byte b = utils.Helpers.HexToByte(textBoxCTH2.Text);
                textBoxCTB2.Text = utils.Helpers.ByteToBin(b);
            }
        }

        private void buttonEncCBC_Click(object sender, EventArgs e)
        {
            // key and IV
            byte key = utils.Helpers.HexToByte(textBoxKexH.Text);
            byte IV = utils.Helpers.HexToByte(textBoxIV.Text);
            // block 1
            byte clearText1 = utils.Helpers.HexToByte(textBoxCTH1.Text);
            // XOR Block 1 with IV
            byte chainedBlock1 = utils.Helpers.Xor(clearText1, IV);
            byte encryptedBlock1 = encrypt(chainedBlock1, key);
            textBoxSTH1.Text = utils.Helpers.ByteToHex(encryptedBlock1);
            textBoxSTB1.Text = utils.Helpers.ByteToBin(encryptedBlock1);
            // block 2
            byte clearText2 = utils.Helpers.HexToByte(textBoxCTH2.Text);
            // XOR Block 2 with encrypted block 1
            byte chainedBlock2 = utils.Helpers.Xor(clearText2, encryptedBlock1);
            byte encryptedBlock2 = encrypt(chainedBlock2, key);
            textBoxSTH2.Text = utils.Helpers.ByteToHex(encryptedBlock2);
            textBoxSTB2.Text = utils.Helpers.ByteToBin(encryptedBlock2);
        }

        private void buttonDecCBC_Click(object sender, EventArgs e)
        {
            // key and IV
            byte key = utils.Helpers.HexToByte(textBoxKexH.Text);
            byte IV = utils.Helpers.HexToByte(textBoxIV.Text);
            // block 1
            byte secureText1 = utils.Helpers.HexToByte(textBoxSTH1.Text);
            byte chainedBlock1 = decrypt(secureText1, key);
            // XOR chained Block 1 with IV
            byte decryptedBlock1 = utils.Helpers.Xor(chainedBlock1, IV);
            textBoxDecH1.Text = utils.Helpers.ByteToHex(decryptedBlock1);
            // block 2
            byte secureText2 = utils.Helpers.HexToByte(textBoxSTH2.Text);
            // XOR chained Block 2 with encrypted block 1
            byte chainedBlock2 = utils.Helpers.Xor(secureText2, secureText1);
            byte decryptedBlock2 = decrypt(chainedBlock2, key);

            textBoxDecH2.Text = utils.Helpers.ByteToHex(decryptedBlock2);
        }

        private byte encrypt(byte data, byte key)
        {
            return utils.Helpers.Xor(data, key);
        }

        private byte decrypt(byte data, byte key)
        {
            return utils.Helpers.Xor(data, key);
        }
    }
}