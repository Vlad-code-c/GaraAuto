using System;
using System.Collections.Generic;

namespace GaraAuto.db.objects
{
    public class Cursa : DatabaseObject<Cursa>
    {
        private static List<Cursa> curse = new List<Cursa>();

        public int id_cursa;
        public string ora = "%";
        public Traseu traseu;
        public Automobile Automobile;
        
        public override void create()
        {
            Cursa cursa = DatabaseManager.getInstance().CreateCursa(this);
            if (cursa != null)
            {
                this.id_cursa = cursa.id_cursa;
                this.ora = cursa.ora;
                this.traseu = cursa.traseu;
                this.Automobile = cursa.Automobile;
            }
        }

        public override void read()
        {
            Cursa readCursa = DatabaseManager.getInstance().ReadCursa(this);
            if (readCursa != null)
            {
                this.id_cursa = readCursa.id_cursa;
                this.ora = readCursa.ora;
                this.traseu = readCursa.traseu;
                this.Automobile = readCursa.Automobile;
            }
        }

        public override void update()
        {
            DatabaseManager.getInstance().UpdateCursa(this);
        }

        public override void delete()
        {
            DatabaseManager.getInstance().DeleteCursa(this);
        }

        public override List<Cursa> getAll()
        {
            curse = DatabaseManager.getInstance().GetAllCursa();
            return curse;
        }

        public String toListString()
        {
            return this.traseu.denumire + " - " + this.Automobile.tipAutomobil.denumire + " - " + this.ora;
        }
    }
}