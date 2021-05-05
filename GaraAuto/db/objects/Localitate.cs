using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace GaraAuto.db.objects
{
    public class Localitate : DatabaseObject<Localitate>
    {
        private static List<Localitate> localitati = new List<Localitate>();

        public int id;
        public string name;
        public Raion raion;
        
        public override void create()
        {
            Localitate localitate = DatabaseManager.getInstance().CreateLocalitate(this);
            if (localitate != null)
            {
                this.id = localitate.id;
                this.name = localitate.name;
                this.raion = localitate.raion;
            }
        }

        public override void read()
        {
            Localitate localitate = DatabaseManager.getInstance().ReadLocalitate(this);
            if (localitate != null)
            {
                id = localitate.id;
                name = localitate.name;
                raion = localitate.raion;
            }
        }

        public override void update()
        {
            DatabaseManager.getInstance().UpdateLocalitate(this);
        }

        public override void delete()
        {
            DatabaseManager.getInstance().DeleteLocalitate(this);
        }

        public override List<Localitate> getAll()
        {
            localitati = DatabaseManager.getInstance().GetAllLocal();
            return localitati;
        }

        public override string ToString()
        {
            return "id: " + id + ", name: " + name + ", raion: " + raion.ToString();
        }
    }
}