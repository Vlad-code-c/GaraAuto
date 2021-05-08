using System.Collections.Generic;

namespace GaraAuto.db.objects
{
    public class Traseu : DatabaseObject<Traseu>
    {
        private static List<Traseu> trasee = new List<Traseu>();

        public int id_traseu;
        public Localitate localitate_inceput;

        public int distanta;
        public Localitate localitate_sfarsit;
        public string denumire => localitate_inceput.name + " - " + localitate_sfarsit.name;


        public override void create()
        {
            Traseu traseu = DatabaseManager.getInstance().CreateTraseu(this);
            if (traseu != null)
            {
                this.distanta = traseu.distanta;
                this.id_traseu = traseu.id_traseu;
                this.localitate_inceput = traseu.localitate_inceput;
                this.localitate_sfarsit = traseu.localitate_sfarsit;
            }
        }

        public override void read()
        {
            Traseu traseu = DatabaseManager.getInstance().ReadTraseu(this);
            if (traseu != null)
            {
                this.distanta = traseu.distanta;
                this.id_traseu = traseu.id_traseu;
                this.localitate_inceput = traseu.localitate_inceput;
                this.localitate_sfarsit = traseu.localitate_sfarsit;
            }
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

        public override string ToString()
        {
            return $"id: {id_traseu}, denumire: {denumire}, distanta: {distanta}";
        }
    }
}