using System.Collections.Generic;

namespace GaraAuto.db.objects
{
    public class Pasager : DatabaseObject<Pasager>
    {
        private static List<Pasager> pasageri = new List<Pasager>();

        public long idnp;
        public string nume_prenume;
        public int birth_year;
        
        public override void create()
        {
            DatabaseManager.getInstance().CreatePasager(this);
        }

        public override void read()
        {
            DatabaseManager.getInstance().ReadPasager(this);
        }

        public override void update()
        {
            DatabaseManager.getInstance().UpdatePasager(this);
        }

        public override void delete()
        {
            DatabaseManager.getInstance().DeletePasager(this);
        }

        public override List<Pasager> getAll()
        {
            pasageri = DatabaseManager.getInstance().GetAllPasager();
            return pasageri;
        }
    }
}