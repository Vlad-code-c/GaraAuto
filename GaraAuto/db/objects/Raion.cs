using System;
using System.Collections.Generic;

namespace GaraAuto.db.objects
{
    public class Raion : DatabaseObject<Raion>
    {
        private static List<Raion> raioane = new List<Raion>();
        
        public int Id { get; set; }
        public string Nume { get; set; }
        
        public override void create()
        {
            DatabaseManager.getInstance().CreateRaion(this);
        }

        public override void read()
        {
            DatabaseManager.getInstance().ReadRaion(this);
        }

        public override void update()
        {
            DatabaseManager.getInstance().UpdateRaion(this);
        }

        public override void delete()
        {
            DatabaseManager.getInstance().DeleteRaion(this);
        }

        public override List<Raion> getAll()
        {
            raioane = DatabaseManager.getInstance().GetAllRaion();
            return raioane;
        }
    }
}