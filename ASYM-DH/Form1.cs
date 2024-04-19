namespace ASYM_DH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSendPGtoBob_Click(object sender, EventArgs e)
        {
            textBoxBobP.Text = textBoxAliceP.Text;
            textBoxBobG.Text = textBoxAliceG.Text;
        }

        private UInt64 powerSaM(UInt64 b, UInt64 e, UInt64 modulus)
        {
            UInt64 result = b;
            UInt64 mask = ((UInt64)0x01 << 63);

            // find first bit set in e
            for (int i = 0; i < 63; i++)
            {
                if ((e & mask) > 0) // e AND mask
                {
                    mask = (mask >> 1);
                    break;
                }
                mask = (mask >> 1);
            }

            while (mask > 0)
            {
                result = result * result % modulus;
                if ((e & mask) > 0) // bit set
                {
                    result = result * b % modulus;
                }
                mask = (mask >> 1);
            }
            return result;
        }

        private void buttonAliceCalcA_Click(object sender, EventArgs e)
        {
            UInt64 p, g, a;
            if (parseAlice(out p, out g, out a))
            {
                UInt64 A = powerSaM(g, a, p);
                textBoxAlice_A.Text = A.ToString();
            }

        }

        private bool TryTextToUInt64(string text, out UInt64 value)
        {
            return UInt64.TryParse(text, out value);
        }

        private bool parseAlice(out UInt64 p, out UInt64 g, out UInt64 a)
        {
            p = 0; g = 0; a = 0;

            if (TryTextToUInt64(textBoxAliceP.Text, out p))
            {
                if (TryTextToUInt64(textBoxAliceG.Text, out g))
                {
                    if (TryTextToUInt64(textBoxAliceA.Text, out a))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool parseAliceForKey(out UInt64 p, out UInt64 B, out UInt64 a)
        {
            p = 0; B = 0; a = 0;

            if (TryTextToUInt64(textBoxAliceP.Text, out p))
            {
                if (TryTextToUInt64(textBoxAlice_B.Text, out B))
                {
                    if (TryTextToUInt64(textBoxAliceA.Text, out a))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool parseBob(out UInt64 p, out UInt64 g, out UInt64 b)
        {
            p = 0; g = 0; b = 0;

            if (TryTextToUInt64(textBoxBobP.Text, out p))
            {
                if (TryTextToUInt64(textBoxBobG.Text, out g))
                {
                    if (TryTextToUInt64(textBoxBobB.Text, out b))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool parseBobForKey(out UInt64 p, out UInt64 A, out UInt64 b)
        {
            p = 0; A = 0; b = 0;

            if (TryTextToUInt64(textBoxBobP.Text, out p))
            {
                if (TryTextToUInt64(textBoxBob_A.Text, out A))
                {
                    if (TryTextToUInt64(textBoxBobB.Text, out b))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void buttonBobCalcB_Click(object sender, EventArgs e)
        {
            UInt64 p, g, b;
            if (parseBob(out p, out g, out b))
            {
                UInt64 B = powerSaM(g, b, p);
                textBoxBob_B.Text = B.ToString();
            }

        }

        private void buttonSendAtoBob_Click(object sender, EventArgs e)
        {
            textBoxBob_A.Text = textBoxAlice_A.Text;
        }

        private void buttonSendBtoAlice_Click(object sender, EventArgs e)
        {
            textBoxAlice_B.Text = textBoxBob_B.Text;
        }

        private void buttonAliceCalcKey_Click(object sender, EventArgs e)
        {
            UInt64 p, B, a;
            if (parseAliceForKey(out p, out B, out a))
            {
                UInt64 key = powerSaM(B, a, p);
                textBoxAliceK.Text = key.ToString();
            }
        }

        private void buttonBobCalcKey_Click(object sender, EventArgs e)
        {
            UInt64 p, A, b;
            if (parseBobForKey(out p, out A, out b))
            {
                UInt64 key = powerSaM(A, b, p);
                textBoxBobKey.Text = key.ToString();
            }
        }
    }
}