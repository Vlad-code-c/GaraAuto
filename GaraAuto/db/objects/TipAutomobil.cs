using System.Collections.Generic;

namespace GaraAuto.db.objects
{
    public class TipAutomobil : DatabaseObject<TipAutomobil>
    {
        private static List<TipAutomobil> automobile = new List<TipAutomobil>();

        public int id;
        public string denumire = "%";
        public int nrLocuri;
        
        
        public override void create()
        {
            TipAutomobil tipAutomobil = DatabaseManager.getInstance().CreateTipAutomobil(this);
            if (tipAutomobil != null)
            {
                this.id = tipAutomobil.id;
                this.denumire = tipAutomobil.denumire;
                this.nrLocuri = tipAutomobil.nrLocuri;
            }
        }

        public override void read()
        {
            TipAutomobil tipAutomobil = DatabaseManager.getInstance().ReadTipAutomobil(this);
            if (tipAutomobil != null)
            {
                this.id = tipAutomobil.id;
                this.denumire = tipAutomobil.denumire;
                this.nrLocuri = tipAutomobil.nrLocuri;
            }
            else
            {
                this.id = -1;
            }
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