using System;
using System.Collections.Generic;

namespace GaraAuto.db.objects
{
    public class Raion : DatabaseObject<Raion>
    {
        private static List<Raion> raioane = new List<Raion>();
        
        public int Id { get; set; }
        public string Nume { get; set; } = "%";
        
        public override void create()
        {
            Raion raion = DatabaseManager.getInstance().CreateRaion(this);
            if (raion != null)
            {
                this.Id = raion.Id;
                this.Nume = raion.Nume;
            }
        }

        public override void read()
        {
            Raion raion = DatabaseManager.getInstance().ReadRaion(this);
            this.Nume = raion.Nume;
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

        public override string ToString()
        {
            return "id: " + Id + ", nume: " + Nume;
        }
    }
}