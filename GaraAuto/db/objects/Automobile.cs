﻿using System.Collections.Generic;

namespace GaraAuto.db.objects
{
    public class Automobile : DatabaseObject<Automobile>
    {
        private static List<Automobile> automobile = new List<Automobile>();

        public int id;
        public string nrInmatriculare;
        public TipAutomobil tipAutomobil;
        
        public override void create()
        {
            DatabaseManager.getInstance().CreateAutomobile(this);
        }

        public override void read()
        {
            DatabaseManager.getInstance().ReadAutomobile(this);
        }

        public override void update()
        {
            DatabaseManager.getInstance().UpdateAutomobile(this);
        }

        public override void delete()
        {
            DatabaseManager.getInstance().DeleteAutomobile(this);
        }

        public override List<Automobile> getAll()
        {
            automobile = DatabaseManager.getInstance().GetAllAutomobile();
            return automobile;
        }
    }
}