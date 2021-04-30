using System.Collections.Generic;

namespace GaraAuto.db.objects
{
    public class Traseu : DatabaseObject<Traseu>
    {
        private static List<Traseu> trasee = new List<Traseu>();

        public int id_traseu;
        public string denumire;
        public Localitate localitate_inceput;
        public Localitate localitate_sfarsit;

        
        public override void create()
        {
            DatabaseManager.getInstance().CreateTraseu(this);
        }

        public override void read()
        {
            DatabaseManager.getInstance().ReadTraseu(this);
        }

        public override void update()
        {
            DatabaseManager.getInstance().UpdateTraseu(this);
        }

        public override void delete()
        {
            DatabaseManager.getInstance().DeleteTraseu(this);
        }

        public override List<Traseu> getAll()
        {
            trasee = DatabaseManager.getInstance().GetAllTraseu();
            return trasee;
        }
    }
}