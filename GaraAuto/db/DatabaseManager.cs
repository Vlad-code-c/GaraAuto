using System;
using System.Collections.Generic;
using GaraAuto.db.objects;

namespace GaraAuto.db
{
    public class DatabaseManager
    {
        private static DatabaseManager instance;
        private DbUser user = new DbUser("default", "default");

        private DatabaseManager(DbUser user)
        {
            if (user != null)
            {
                this.user = user;
            }
        }

        public static DatabaseManager getInstance(DbUser user = null)
        {
            if (instance == null)
            {
                instance = new DatabaseManager(user);
            }

            return instance;
        }


        #region Localitate

        public void CreateLocalitate(Localitate localitate)
        {
            throw new NotImplementedException();
            //if raion exists, use it
            //else, create new raion
        }

        public Localitate ReadLocalitate(Localitate localitate)
        {
            throw new NotImplementedException();
        }

        public void UpdateLocalitate(Localitate localitate)
        {
            throw new NotImplementedException();
        }

        public void DeleteLocalitate(Localitate localitate)
        {
            throw new NotImplementedException();
        }

        public List<Localitate> GetAllLocal()
        {
            throw new NotImplementedException();
        }

        #endregion
        
        
        #region Raion

        public void CreateRaion(Raion raion)
        {
            throw new NotImplementedException();
        }

        public Localitate ReadRaion(Raion raion)
        {
            throw new NotImplementedException();
        }

        public void UpdateRaion(Raion raion)
        {
            throw new NotImplementedException();
        }

        public void DeleteRaion(Raion raion)
        {
            throw new NotImplementedException();
        }

        public List<Raion> GetAllRaion()
        {
            throw new NotImplementedException();
        }

        #endregion
        
        
        #region TipAutomobil

        public void CreateTipAutomobil(TipAutomobil tipAutomobil)
        {
            throw new NotImplementedException();
        }

        public Localitate ReadTipAutomobil(TipAutomobil tipAutomobil)
        {
            throw new NotImplementedException();
        }

        public void UpdateTipAutomobil(TipAutomobil tipAutomobil)
        {
            throw new NotImplementedException();
        }

        public void DeleteTipAutomobil(TipAutomobil tipAutomobil)
        {
            throw new NotImplementedException();
        }

        public List<TipAutomobil> GetAllTipAutomobil()
        {
            throw new NotImplementedException();
        }

        #endregion
        
        
        #region Automobile

        public void CreateAutomobile(Automobile Automobil)
        {
            throw new NotImplementedException();
        }

        public Localitate ReadAutomobile(Automobile Automobil)
        {
            throw new NotImplementedException();
        }

        public void UpdateAutomobile(Automobile Automobil)
        {
            throw new NotImplementedException();
        }

        public void DeleteAutomobile(Automobile Automobil)
        {
            throw new NotImplementedException();
        }

        public List<Automobile> GetAllAutomobile()
        {
            throw new NotImplementedException();
        }

        #endregion
        
        
        #region Pasageri

        public void CreatePasager(Pasager pasager)
        {
            throw new NotImplementedException();
        }

        public Localitate ReadPasager(Pasager pasager)
        {
            throw new NotImplementedException();
        }

        public void UpdatePasager(Pasager pasager)
        {
            throw new NotImplementedException();
        }

        public void DeletePasager(Pasager pasager)
        {
            throw new NotImplementedException();
        }

        public List<Pasager> GetAllPasager()
        {
            throw new NotImplementedException();
        }

        #endregion
       
        
        #region Traseu

        public void CreateTraseu(Traseu traseu)
        {
            throw new NotImplementedException();
        }

        public Localitate ReadTraseu(Traseu traseu)
        {
            throw new NotImplementedException();
        }

        public void UpdateTraseu(Traseu traseu)
        {
            throw new NotImplementedException();
        }

        public void DeleteTraseu(Traseu traseu)
        {
            throw new NotImplementedException();
        }

        public List<Traseu> GetAllTraseu()
        {
            throw new NotImplementedException();
        }

        #endregion
        
        
        #region Cursa

        public void CreateCursa(Cursa cursa)
        {
            throw new NotImplementedException();
        }

        public Localitate ReadCursa(Cursa cursa)
        {
            throw new NotImplementedException();
        }

        public void UpdateCursa(Cursa cursa)
        {
            throw new NotImplementedException();
        }

        public void DeleteCursa(Cursa cursa)
        {
            throw new NotImplementedException();
        }

        public List<Cursa> GetAllCursa()
        {
            throw new NotImplementedException();
        }

        #endregion
        
        
        #region LocuriOcupate

        public void CreateLocuriOcupate(LocuriOcupate locuriOcupate)
        {
            throw new NotImplementedException();
        }

        public Localitate ReadLocuriOcupate(LocuriOcupate locuriOcupate)
        {
            throw new NotImplementedException();
        }

        public void UpdateLocuriOcupate(LocuriOcupate locuriOcupate)
        {
            throw new NotImplementedException();
        }

        public void DeleteLocuriOcupate(LocuriOcupate locuriOcupate)
        {
            throw new NotImplementedException();
        }

        public List<LocuriOcupate> GetAllLocuriOcupate()
        {
            throw new NotImplementedException();
        }

        #endregion
        
    }
}