using System;
using System.Collections.Generic;

namespace GaraAuto.db.objects
{
    public class LocuriOcupate : DatabaseObject<LocuriOcupate>
    {
        private static List<LocuriOcupate> locuriOcupate;

        public Cursa cursa;
        public Pasager pasager;
        
        public override void create()
        {
            DatabaseManager.getInstance().CreateLocuriOcupate(this);
        }

        public override void read()
        {
            DatabaseManager.getInstance().ReadLocuriOcupate(this);
        }

        public override void update()
        {
            DatabaseManager.getInstance().UpdateLocuriOcupate(this);
        }

        public override void delete()
        {
            DatabaseManager.getInstance().DeleteLocuriOcupate(this);
        }

        public override List<LocuriOcupate> getAll()
        {
            locuriOcupate = DatabaseManager.getInstance().GetAllLocuriOcupate();
            return locuriOcupate;
        }
    }
}