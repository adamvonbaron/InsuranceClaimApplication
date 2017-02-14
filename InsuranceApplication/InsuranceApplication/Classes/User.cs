/* adam 2017-02-01 User.cs */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApplication.Classes {
    [Serializable]
    class User {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Birthday { get; set; }

        public string Phonenumber { get; set; }

        private byte[] Salt { get; set; }

        public int Rank { get; set; }

        //public string creation { get; set;}

        //public int claims { get; set;}

        /* key */
        //public long id { get; set;}

        //constructor
        public User(string firstname, string lastname, string username, string password,
                    string birthday, string phonenumber, int rank)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.UserName = username;
            this.Birthday = birthday;
            this.Phonenumber = phonenumber;
            this.Rank = rank;

            this.Salt = new byte[32];
            System.Security.Cryptography.RNGCryptoServiceProvider.Create().GetBytes(Salt);

            // Convert the plain string pwd into bytes
            byte[] plainTextBytes = System.Text.UnicodeEncoding.Unicode.GetBytes(password);
            // Append salt to pwd before hashing
            byte[] combinedBytes = new byte[plainTextBytes.Length + Salt.Length];
            System.Buffer.BlockCopy(plainTextBytes, 0, combinedBytes, 0, plainTextBytes.Length);
            System.Buffer.BlockCopy(Salt, 0, combinedBytes, plainTextBytes.Length, Salt.Length);

            // Create hash for the pwd+salt
            System.Security.Cryptography.HashAlgorithm hashAlgo = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = hashAlgo.ComputeHash(combinedBytes);

            // Append the salt to the hash
            byte[] hashPlusSalt = new byte[hash.Length + Salt.Length];
            System.Buffer.BlockCopy(hash, 0, hashPlusSalt, 0, hash.Length);
            System.Buffer.BlockCopy(Salt, 0, hashPlusSalt, hash.Length, Salt.Length);

            this.Password = Encoding.UTF8.GetString(hashPlusSalt);
        }

        //methods
        public void login(string username, string password)
        {

        }

        public override string ToString() {
            return String.Format(@"First Name: {0}\nLast Name: {1}\nUsername: {2}\nPassword: {3}\n
                                   Birthday: {4}\nPhone Number: {5}", this.FirstName, this.LastName,
                                   this.UserName, this.Password, this.Birthday, this.Phonenumber);
        }
    }
}
