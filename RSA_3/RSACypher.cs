using System.Security.Cryptography;
using System.Text;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace RSA_3
{
    public partial class RSACypher : Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        private byte[] encryptedtext;
        private byte[] decryptedtext;
        public RSACypher()
        {
            InitializeComponent();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            int p = int.Parse(txtP.Text);
            int q = int.Parse(txtQ.Text);
            int eKey = int.Parse(txtE.Text);

            // Tính toán n = p * q
            int n = p * q;

            // Tính toán φ(n) = (p - 1)(q - 1)
            int phi = (p - 1) * (q - 1);

            // Tìm khóa bí mật d
            int d = FindPrivateKey(eKey, phi);

            // Mã hóa một đoạn tin nhắn
            string message = txtbox.Text;
            encryptedtext = Encrypt(message, eKey, n);

            // Hiển thị bản mã
            txtEncrypt.Text = Convert.ToBase64String(encryptedtext);

        }
        private void decryptBtn_Click(object sender, EventArgs e)
        {
            int p = int.Parse(txtP.Text);
            int q = int.Parse(txtQ.Text);
            int eKey = int.Parse(txtE.Text);

            // Tính toán n = p * q
            int n = p * q;

            // Tính toán φ(n) = (p - 1)(q - 1)
            int phi = (p - 1) * (q - 1);

            // Tìm khóa bí mật d
            int d = FindPrivateKey(eKey, phi);

            // Giải mã bản mã
            byte[] plainText = Decrypt(encryptedtext, d, n);

            // Hiển thị thông điệp gốc
            txtDecrypt.Text = Encoding.UTF8.GetString(plainText);
        }
        private byte[] Encrypt(string message, int e, int n)
        {
            // Chuyển đổi chuỗi thành mảng byte
            byte[] bytes = Encoding.UTF8.GetBytes(message);

            // Mã hóa từng byte trong mảng
            byte[] cipherText = new byte[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                cipherText[i] = (byte)(bytes[i] ^ e % n);
            }

            return cipherText;
        }
        private byte[] Decrypt(byte[] cipherText, int d, int n)
        {
            // Giải mã từng byte trong mảng
            byte[] plainText = new byte[cipherText.Length];
            for (int i = 0; i < cipherText.Length; i++)
            {
                plainText[i] = (byte)(cipherText[i] ^ d % n);
            }

            return plainText;
        }
        private int FindPrivateKey(int e, int phi)
        {
            // Khởi tạo giá trị ban đầu của d
            int d = 0;

            // Tìm d sao cho ed ≡ 1 (mod φ(n))
            while (d < phi)
            {
                if ((e * d) % phi == 1)
                {
                    return d;
                }

                d++;
            }

            throw new Exception("Không tìm thấy khóa bí mật");
        }
        private string GetKeyString(RSAParameters key)
        {
            StringBuilder sb = new StringBuilder();
            if (key.D == null)
            {
                BigInteger n = new BigInteger(key.Modulus.Reverse().ToArray());
                BigInteger e = new BigInteger(key.Exponent.Reverse().ToArray());

                // Ensure n and e are positive
                n = n.Sign < 0 ? BigInteger.Zero - n : n;
                e = e.Sign < 0 ? BigInteger.Zero - e : e;

                // Limit the number of digits to 6
                string formattedN = n.ToString().Substring(0, Math.Min(6, n.ToString().Length));
                string formattedE = e.ToString().Substring(0, Math.Min(6, e.ToString().Length));

                sb.AppendLine($"(n): {formattedN}");
                sb.AppendLine($"(e): {formattedE}");
            }
            else if (key.D != null)
            {
                BigInteger d = new BigInteger(key.D.Reverse().ToArray());
                BigInteger n = new BigInteger(key.Modulus.Reverse().ToArray());

                // Ensure d and e are positive
                d = d.Sign < 0 ? BigInteger.Zero - d : d;
                n = n.Sign < 0 ? BigInteger.Zero - n : n;

                // Limit the number of digits to 6
                string formattedD = d.ToString().Substring(0, Math.Min(6, d.ToString().Length));
                string formattedN = n.ToString().Substring(0, Math.Min(6, n.ToString().Length));

                sb.AppendLine($"(d): {formattedD}");
                sb.AppendLine($"(n): {formattedN}");
            }
            return sb.ToString();
        }
        private void btnGeneratePublicKey_Click(object sender, EventArgs e)
        {
            try
            {
                RSAParameters publicKey = RSA.ExportParameters(false);
                string publicKeyString = GetKeyString(publicKey);
                txtPublicKey.Text = publicKeyString;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating public key: {ex.Message}");
            }
        }

        private void btnGeneratePrivateKey_Click(object sender, EventArgs e)
        {
            try
            {
                RSAParameters privateKey = RSA.ExportParameters(true);
                string privateKeyString = GetKeyString(privateKey);
                txtPrivateKey.Text = privateKeyString;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating private key: {ex.Message}");
            }
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            txtEncrypt.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDecrypt.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtPublicKey.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtPrivateKey.Text = "";
        }
    }
}