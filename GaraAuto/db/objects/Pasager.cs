using System.Collections.Generic;

namespace GaraAuto.db.objects
{
    public class Pasager : DatabaseObject<Pasager>
    {
        private static List<Pasager> pasageri = new List<Pasager>();

        public long idnp;
        public string nume_prenume = "%";
        public int birth_year;
        
        public override void create()
        {
            Pasager pasager = DatabaseManager.getInstance().CreatePasager(this);
            if (pasager != null)
            {
                this.nume_prenume = pasager.nume_prenume;
                this.birth_year = pasager.birth_year;
            }
        }

        public override void read()
        {
            Pasager pasager = DatabaseManager.getInstance().ReadPasager(this);
            if (pasager != null)
            {
                this.nume_prenume = pasager.nume_prenume;
                this.birth_year = pasager.birth_year;
            }
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