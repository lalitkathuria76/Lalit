using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  var tok = authEvent.AuthorizationToken;
            Decode("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImxhbGl0IiwianRpIjoiMjVhM2Q3OTgtZjQ1NC00ZDc0LTkxZjctZGU1NDA4ZjAwNzJmIiwiZXhwIjoxNTc1Mjc2OTM3LCJpc3MiOiJUTUhDQyIsImF1ZCI6IlRNSENDIn0.itoe1aHXHbKPi4uHMRDUQr3JczH9SyCajS9VBG-1NRw");
        }
        public static void Decode(string token)
        {
            string[] parts = token.Split('.');
            string headerJson = parts[0];
            string payloadJson = parts[1];
            var crypto = parts[2];


           // JObject headerData = JObject.Parse(headerJson);


            //JObject payloadData = JObject.Parse(payloadJson);


            byte[] key = Encoding.UTF8.GetBytes("aaaaaaaaaaaaaaaaa");
            byte[] message = Encoding.UTF8.GetBytes(payloadJson);

            string sig =Convert.ToBase64String( HashHMAC(key, message))
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");

            Console.WriteLine(Encoding.UTF8.GetString(message));
            Console.WriteLine(sig);

            Console.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(crypto)));
            Console.Read();


            //  return payloadData.ToString();
        }

        private static byte[] HashHMAC(byte[] key, byte[] message)
        {
            var hash = new HMACSHA256(key);
            return hash.ComputeHash(message);
        }

    }
}
