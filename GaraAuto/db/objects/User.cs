using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace GaraAuto.db.objects
{
    [Serializable]
    public class User
    {
        public static User currenLoggedUser
        {
            internal set;
            get;
        }

        public int id_user;
        public string email;
        private string password;
        public string Password
        {
            set 
            {
                password = crypt(value);
            }
            get
            {
                return password;
            }
        }

        public bool keepIn;

        public List<Roles> roles;
        private static string SERIALIZE_PATH = "user3.dat"; 

        public User()
        {
            Deserialize();
        }

        public void create()
        {
            User user = DatabaseManager.getInstance().CreateUser(this);
            if (user != null)
            {
                this.id_user = user.id_user;
                currenLoggedUser = this;

                if (this.keepIn)
                {
                    Serialize();
                }
            }
        }

        public void read()
        {
            User user = DatabaseManager.getInstance().ReadUser(this);
            if (user != null)
            {
                this.id_user = user.id_user;
                currenLoggedUser = this;
                
                if (this.keepIn)
                {
                    Serialize();
                }
            }
        }

        public void update()
        {
            throw new NotImplementedException();
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public List<User> getAll()
        {
            throw new NotImplementedException();
        }


        public bool isAdmin()
        {
            return roles.Contains(Roles.ADMIN);
        }
        public bool isModerator()
        {
            return roles.Contains(Roles.MODERATOR);
        }
        public bool isDeveloper()
        {
            return roles.Contains(Roles.DEVELOPER);
        }

        private static void Serialize()
        {
            Stream stream = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(SERIALIZE_PATH, FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, currenLoggedUser);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // throw;
            }
            if (stream != null)
            {
                stream.Close();
            }
        }

        private static void Deserialize()
        {
            Stream stream = null;
            try
            {
                stream = new FileStream(SERIALIZE_PATH, FileMode.Open, FileAccess.Read);
                User user = (User) new BinaryFormatter().Deserialize(stream);
                stream.Close();
             
                currenLoggedUser = user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // throw;
            }

            if (stream != null)
            {
                stream.Close();
            }
        }

        public static void logout()
        {
            try
            {
                 File.Delete(SERIALIZE_PATH);
                 currenLoggedUser = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // throw;
            }
        } 

        private string crypt(string password)
        {
            return Encryptor.MD5Hash(password);
        }

    }
}