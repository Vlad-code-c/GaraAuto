using System.Collections.Generic;

namespace GaraAuto.db.objects
{
    public class TipAutomobil : DatabaseObject<TipAutomobil>
    {
        private static List<TipAutomobil> automobile = new List<TipAutomobil>();

        public int id;
        public string denumire;
        public int nrLocuri;
        
        
        public override void create()
        {
            DatabaseManager.getInstance().CreateTipAutomobil(this);
        }

        public override void read()
        {
            DatabaseManager.getInstance().ReadTipAutomobil(this);
        }

        public override void update()
        {
            DatabaseManager.getInstance().UpdateTipAutomobil(this);
        }

        public override void delete()
        {
            DatabaseManager.getInstance().DeleteTipAutomobil(this);
        }

        public override List<TipAutomobil> getAll()
        {
            automobile = DatabaseManager.getInstance().GetAllTipAutomobil();
            return automobile;
        }
    }
}