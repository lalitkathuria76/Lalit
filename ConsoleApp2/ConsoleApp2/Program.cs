using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  var tok = authEvent.AuthorizationToken;
            Decode("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImxhbGl0IiwianRpIjoiMjVhM2Q3OTgtZjQ1NC00ZDc0LTkxZjctZGU1NDA4ZjAwNzJmIiwiZXhwIjoxNTc1Mjc2OTM3LCJpc3MiOiJUTUhDQyIsImF1ZCI6IlRNSENDIn0.itoe1aHXHbKPi4uHMRDUQr3JczH9SyCajS9VBG-1NRw");
        }
        public static void Decode(string token)
        {
            Console.WriteLine(token);
        }
    }
}
