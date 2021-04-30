using System.Collections.Generic;

namespace GaraAuto.db.objects
{
    public class Cursa : DatabaseObject<Cursa>
    {
        private static List<Cursa> curse = new List<Cursa>();

        public int id_cursa;
        public Traseu traseu;
        public Automobile Automobile;
        
        public override void create()
        {
            DatabaseManager.getInstance().CreateCursa(this);
        }

        public override void read()
        {
            DatabaseManager.getInstance().ReadCursa(this);
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
    }
}