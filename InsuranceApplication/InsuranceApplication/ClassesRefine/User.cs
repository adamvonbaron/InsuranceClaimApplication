/* adam 2017-02-01 User.cs */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApplication.ClassesRefine
{
    public class User
    {
        //Automatic Properties
        public string FirstName;
        public string LastName;
        public string Birthday;
        public string UserName;
        public string Password;
        public string Phonenumber;
        public int Rank;
        Classes.libsql database = new Classes.libsql();

        public User(string firstname, string lastname, string username, string password,
                    string birthday, string phonenumber, int rank)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.UserName = username;
            this.Birthday = birthday;
            this.Phonenumber = phonenumber;
            this.Rank = rank;
            this.Password = password;
            //this.Salt = new byte[32];
            //System.Security.Cryptography.RNGCryptoServiceProvider.Create().GetBytes(Salt);

            //// Convert the plain string pwd into bytes
            //byte[] plainTextBytes = System.Text.UnicodeEncoding.Unicode.GetBytes(password);
            //// Append salt to pwd before hashing
            //byte[] combinedBytes = new byte[plainTextBytes.Length + Salt.Length];
            //System.Buffer.BlockCopy(plainTextBytes, 0, combinedBytes, 0, plainTextBytes.Length);
            //System.Buffer.BlockCopy(Salt, 0, combinedBytes, plainTextBytes.Length, Salt.Length);

            //// Create hash for the pwd+salt
            //System.Security.Cryptography.HashAlgorithm hashAlgo = new System.Security.Cryptography.SHA256Managed();
            //byte[] hash = hashAlgo.ComputeHash(combinedBytes);

            //// Append the salt to the hash
            //byte[] hashPlusSalt = new byte[hash.Length + Salt.Length];
            //System.Buffer.BlockCopy(hash, 0, hashPlusSalt, 0, hash.Length);
            //System.Buffer.BlockCopy(Salt, 0, hashPlusSalt, hash.Length, Salt.Length);

            //this.Password = Encoding.UTF8.GetString(hashPlusSalt);
        }

        //methods
        public User Login(string username, string password)
        {
            int rank;
            try
            {
                database.ValidateUser(UserName, Password);
                rank = database.GetRank(UserName);
                switch (rank)
                {
                    //case 1:
                    //return new Admin(FirstName, LastName, UserName, Password, Rank);
                    case 2:
                        return new FinanceManager();
                    //case 3:
                    //return new ClientManager();
                    case 4:
                        return new Client(FirstName, LastName, UserName, 
                                          Password, Birthday, Phonenumber, Rank);
                }
                return new User("", "", "", "", "", "", -1);
            }
            catch (Exception ex)
            {
                return new User("", "", "", "", "", "", -1);
            }
        }

        public override string ToString()
        {
            return String.Format(@"First Name: {0}\nLast Name: {1}\nUsername: {2}\nPassword: {3}\n
                           Birthday: {4}\nPhone Number: {5}", this.FirstName, this.LastName,
                                   this.UserName, this.Password, this.Birthday, this.Phonenumber);
        }
    }
}
