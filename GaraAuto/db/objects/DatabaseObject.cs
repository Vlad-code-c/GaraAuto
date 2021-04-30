using System;
using System.Collections.Generic;

namespace GaraAuto.db.objects
{
    abstract public class DatabaseObject<T>
    {
        public abstract void create();
        public abstract void read();
        public abstract void update();
        public abstract void delete();
        
        public abstract List<T> getAll();
    }
}