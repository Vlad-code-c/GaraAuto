using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GaraAuto.db.objects
{
    public class User : DatabaseObject<User>
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

        public override void create()
        {
            User user = DatabaseManager.getInstance().CreateUser(this);
            if (user != null)
            {
                this.id_user = user.id_user;
                currenLoggedUser = this;
            }
        }

        public override void read()
        {
            User user = DatabaseManager.getInstance().ReadUser(this);
            if (user != null)
            {
                this.id_user = user.id_user;
                currenLoggedUser = this;
            }
        }

        public override void update()
        {
            throw new System.NotImplementedException();
        }

        public override void delete()
        {
            throw new System.NotImplementedException();
        }

        public override List<User> getAll()
        {
            throw new System.NotImplementedException();
        }


        public bool isAdmin()
        {
            return false;
        }
        public bool isModerator()
        {
            return false;
        }
        public bool isDeveloper()
        {
            return false;
        }

        private string crypt(string password)
        {
            return "__" + password + "__";
        }

    }
}