using System.Security.Cryptography;
using System.Text;

namespace dotnet
{
    public static class Hasher
    {
        public static string Make_Hash_SHA256(this string word)
        {
            var wordBytes = Encoding.UTF8.GetBytes(word);

            using (var mySHA256 = SHA256.Create())
            {
                var hashBytes = mySHA256.ComputeHash(wordBytes);
                var builder = new StringBuilder();  
                for (int i = 0; i < hashBytes.Length; i++)  
                {  
                    builder.Append(hashBytes[i].ToString("x2"));  
                }  
                return builder.ToString();  
            }
        }
    }
}