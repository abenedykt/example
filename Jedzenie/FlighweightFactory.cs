using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Food.Abstract;
using Food.Default;
using Food.Kantyna;
using Food.Ludovisko;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace Food
{
    internal class FlighweightFactory
    {
        public AbstractFactory CreateFactory(string place)
        {
            switch (place)
            {
                case "kantyna":
                    return new KantynaFactory();
                case "ludovisko":
                    return new LudoviskoFactory();
                //case "novege":
                //    return new NoVegeFactory();
            }
            return new NullableFactory();
        }
    }

    internal class Factory
    {
        public LicenceChain GetLicenceChain()
        {
            return new LicenceChain();
        }
    }

    internal class LicenceChain
    {
        private IResponsibility _chain;

        public LicenceChain()
        {
            var resp1 = new LicenceIsNotEmpty();
            var resp3 = new LicenceIsNotEmpty();
            var resp4 = new KeyIsValid();

            resp1.Next = resp3;
            
            resp3.Next = resp4;

            _chain = resp1;
        }

        public bool Validate(string file)
        {
            var text = File.ReadAllText(file);
            var licence = JsonConvert.DeserializeObject<LicenceFile>(text);

            var item = _chain;
            do
            {
                if (item.Execute(licence) == false) return false;
                
                item = item.Next;
            } while (item.Next != null);

            return true;
        }
    }

    public class LicenceFile
    {
        public Licence Licence { get; set; }
        public string Key { get; set; }
    }

    public class Licence
    {
        public string Client { get; set; }
    }

    internal class KeyIsValid : IResponsibility
    {
        public IResponsibility Next { get; set; }
        public bool Execute(LicenceFile licence)
        {
            return licence.Key == CreateMD5(licence.Licence.Client);
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

    internal class LicenceIsNotEmpty : IResponsibility
    {
        public IResponsibility Next { get; set; }
        public bool Execute(LicenceFile licence)
        {
            if (string.IsNullOrEmpty(licence.Licence.Client))
            {
                return false;
            }

            return true;
        }
    }

    internal interface IResponsibility
    {
        IResponsibility Next { get; }
        bool Execute(LicenceFile licence);
    }

    
}