using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace Food.Tests
{
    public class Md5Tests
    {
        [Fact]
        public void TestName()
        {
                Assert.Equal("1F0C1DD12E3C54023ACDF81A921238ED", CreateMD5("{client : \"ludovisko\"}"));
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}