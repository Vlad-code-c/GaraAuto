using System.Collections.Generic;
using System.Threading;

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
            DatabaseManager.getInstance().CreateLocalitate(this);
        }

        public override void read()
        {
            Localitate localitate = DatabaseManager.getInstance().ReadLocalitate(this);
            if (localitate != null)
            {
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
    }
}