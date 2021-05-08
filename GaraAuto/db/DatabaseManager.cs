using System;
using System.Collections.Generic;
using System.Data;
using GaraAuto.db.objects;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GaraAuto.db
{
    public class DatabaseManager
    {
        private static DatabaseManager instance;
        private DbUser user = new DbUser("defaultUser", "defaultPassword");

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

        private SqlConnection getConnection()
        {
            String connectionString = $"Server=Home-Pc, 1433;Database=GaraAuto;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            // connection.Open();

            return connection;
        }


        #region Localitate

        public Localitate CreateLocalitate(Localitate localitate)
        {
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    String queryReturn =
                        $"SELECT R.id, R.nume, L.id, L.nume FROM Localitate AS L, Raion AS R WHERE R.id = L.id_raion AND LOWER(L.nume) LIKE LOWER('{localitate.name}')";

                    connection.Open();

                    SqlCommand commandInsert = new SqlCommand("createLocalitate", connection);
                    commandInsert.CommandType = CommandType.StoredProcedure;
                    commandInsert.Parameters.Add("@numeLocalitate", SqlDbType.NVarChar).Value = localitate.name;
                    commandInsert.Parameters.Add("@numeRaion", SqlDbType.NVarChar).Value = localitate.raion.Nume;

                    SqlCommand commandSelect = new SqlCommand(queryReturn, connection);

                    commandInsert.ExecuteNonQuery();
                    SqlDataReader dataReader = commandSelect.ExecuteReader();
                    if (dataReader.Read())
                    {
                        int id_raion = (int) dataReader["R.id"];
                        string nume_raion = (string) dataReader["R.nume"];
                        int id_localitate = (int) dataReader["L.id"];
                        string nume_localit = (string) dataReader["L.nume"];


                        return new Localitate()
                        {
                            id = id_localitate,
                            name = nume_localit,
                            raion = new Raion()
                            {
                                Id = id_raion,
                                Nume = nume_raion
                            }
                        };
                    }
                }
            }
            catch (Exception e)
            {
                // ignored
            }

            return null;
        }

        public Localitate ReadLocalitate(Localitate localitate)
        {
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    String queryReturn =
                        $"SELECT L.id AS 'id_loc', L.nume AS 'nume_loc', R.id AS 'id_raion', R.nume AS 'nume_raion' FROM Raion AS R, Localitate AS L " +
                        $"WHERE R.Id = L.id_raion AND LOWER(L.nume) LIKE LOWER('{localitate.name}')";

                    connection.Open();


                    SqlCommand commandSelect = new SqlCommand(queryReturn, connection);

                    SqlDataReader dataReader = commandSelect.ExecuteReader();
                    if (dataReader.Read())
                    {
                        int id_raion = (int) dataReader["id_raion"];
                        string nume_raion = (string) dataReader["nume_raion"];
                        int id_localitate = (int) dataReader["id_loc"];
                        string nume_localit = (string) dataReader["nume_loc"];


                        Localitate localit = new Localitate()
                        {
                            id = id_localitate,
                            name = nume_localit,
                            raion = new Raion()
                            {
                                Id = id_raion,
                                Nume = nume_raion
                            }
                        };

                        // MessageBox.Show(localit.name);
                        return localit;
                    }
                }
            }
            catch (Exception e)
            {
                // MessageBox.Show(e.Message);
                throw;
            }

            return null;
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
            List<Localitate> localitati = new List<Localitate>();

            using (SqlConnection connection = getConnection())
            {
                String querySelect =
                    "SELECT L.id AS 'id_loc', L.nume AS 'nume_loc', R.id AS 'id_raion', R.nume AS 'nume_raion' FROM Raion AS R, Localitate AS L WHERE R.Id = L.id_raion";

                connection.Open();

                SqlCommand commandSelect = new SqlCommand(querySelect, connection);

                SqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                {
                    int id_loc = (int) dataReader["id_loc"];
                    string nume_loc = (string) dataReader["nume_loc"];
                    int id_raion = (int) dataReader["id_raion"];
                    string nume_raion = (string) dataReader["nume_raion"];

                    localitati.Add(new Localitate()
                    {
                        id = id_loc,
                        name = nume_loc,
                        raion = new Raion()
                        {
                            Id = id_raion,
                            Nume = nume_raion
                        }
                    });
                }
            }

            return localitati;
        }

        #endregion


        #region Raion

        public Raion CreateRaion(Raion raion)
        {
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    String queryInsert = $"INSERT INTO Raion(nume) VALUES ('{raion.Nume}');";
                    String queryReturn = $"SELECT Id, nume FROM Raion Where nume LIKE '{raion.Nume}'";

                    connection.Open();

                    SqlCommand commandInsert = new SqlCommand(queryInsert, connection);
                    SqlCommand commandSelect = new SqlCommand(queryReturn, connection);

                    commandInsert.ExecuteNonQuery();

                    SqlDataReader dataReader = commandSelect.ExecuteReader();
                    if (dataReader.Read())
                    {
                        int id_raion = (int) dataReader["Id"];
                        string nume_raion = (string) dataReader["nume"];

                        return new Raion()
                        {
                            Id = id_raion,
                            Nume = nume_raion
                        };
                    }
                }
            }
            catch (Exception e)
            {
                // ignored
            }

            return null;
        }

        public Raion ReadRaion(Raion raion)
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
            List<Raion> raioane = new List<Raion>();

            using (SqlConnection connection = getConnection())
            {
                String querySelect = "SELECT id, nume FROM Raion";

                connection.Open();

                SqlCommand commandSelect = new SqlCommand(querySelect, connection);

                SqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = (int) dataReader["id"];
                    string nume = (string) dataReader["nume"];
                    raioane.Add(new Raion()
                    {
                        Id = id,
                        Nume = nume
                    });
                }
            }

            return raioane;
        }

        #endregion


        #region TipAutomobil

        public TipAutomobil CreateTipAutomobil(TipAutomobil tipAutomobil)
        {
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    String queryInsert =
                        $"INSERT INTO TipAutomobil(denumire, nr_locuri) VALUES ('{tipAutomobil.denumire}', {tipAutomobil.nrLocuri})";
                    String queryReturn = $"SELECT id FROM TipAutomobil Where nume LIKE '{tipAutomobil.id}'";

                    connection.Open();

                    SqlCommand commandInsert = new SqlCommand(queryInsert, connection);
                    SqlCommand commandSelect = new SqlCommand(queryReturn, connection);

                    commandInsert.ExecuteNonQuery();

                    SqlDataReader dataReader = commandSelect.ExecuteReader();
                    if (dataReader.Read())
                    {
                        int id = (int) dataReader["id"];
                        string denumire = (string) dataReader["denumire"];
                        int nr_locuri = (int) dataReader["nr_locuri"];

                        return new TipAutomobil()
                        {
                            id = id,
                            denumire = denumire,
                            nrLocuri = nr_locuri
                        };
                    }
                }
            }
            catch (Exception e)
            {
                // ignored
            }

            return null;
        }

        public TipAutomobil ReadTipAutomobil(TipAutomobil tipAutomobil)
        {
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    String queryReturn =
                        $"SELECT id, denumire, nr_locuri FROM TipAutomobil WHERE Lower(denumire) LIKE LOWER('{tipAutomobil.denumire}')";

                    connection.Open();

                    SqlCommand commandSelect = new SqlCommand(queryReturn, connection);


                    SqlDataReader dataReader = commandSelect.ExecuteReader();
                    if (dataReader.Read())
                    {
                        int id = (int) dataReader["id"];
                        string denumire = (string) dataReader["denumire"];
                        int nr_locuri = (int) dataReader["nr_locuri"];

                        return new TipAutomobil()
                        {
                            id = id,
                            denumire = denumire,
                            nrLocuri = nr_locuri
                        };
                    }
                }
            }
            catch (Exception e)
            {
                // ignored
            }

            return null;
        }

        public void UpdateTipAutomobil(TipAutomobil tipAutomobil)
        {
            SqlConnection connection = getConnection();
            String queryInsert =
                $"UPDATE TipAutomobil SET denumire = '{tipAutomobil.denumire}', nr_locuri = {tipAutomobil.nrLocuri} WHERE id = {tipAutomobil.id}";

            connection.Open();

            SqlCommand commandInsert = new SqlCommand(queryInsert, connection);

            try
            {
                commandInsert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            connection.Close();
        }

        public void DeleteTipAutomobil(TipAutomobil tipAutomobil)
        {
            
            SqlConnection connection = getConnection();
            String queryInsert =
                $"DELETE FROM TipAutomobil WHERE id = {tipAutomobil.id}";

            connection.Open();

            SqlCommand commandInsert = new SqlCommand(queryInsert, connection);

            try
            {
                commandInsert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (e.Message.Contains("REFERENCE"))
                {
                    DialogResult dialogResult = MessageBox
                        .Show("Tipul nu a putut fi sters deoarece este folosit de catre alt tabel. Afiseaza eroarea?",
                            "Foreign Key Exception", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }

            connection.Close();
        }

        public List<TipAutomobil> GetAllTipAutomobil()
        {
            List<TipAutomobil> tipAutomobile = new List<TipAutomobil>();

            using (SqlConnection connection = getConnection())
            {
                String querySelect = "SELECT id, denumire, nr_locuri FROM TipAutomobil";

                connection.Open();

                SqlCommand commandSelect = new SqlCommand(querySelect, connection);

                SqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                {
                    tipAutomobile.Add(new TipAutomobil()
                    {
                        id = (int) dataReader["id"],
                        denumire = (string) dataReader["denumire"],
                        nrLocuri = (int) dataReader["nr_locuri"]
                    });
                }
            }

            return tipAutomobile;
        }

        #endregion


        #region Automobile

        public Automobile CreateAutomobile(Automobile Automobil)
        {
            SqlConnection connection = getConnection();
            String queryInsert =
                $"INSERT INTO Automobile(nr_inmatriculare, tip_automobil) VALUES ('{Automobil.nrInmatriculare}', {Automobil.tipAutomobil.id})";
            String queryReturn =
                "SELECT auto.id, auto.nr_inmatriculare, auto.tip_automobil, tip.denumire, tip.nr_locuri " +
                "FROM Automobile AS auto, TipAutomobil AS tip " +
                $"WHERE auto.tip_automobil = tip.id AND LOWER(auto.nr_inmatriculare) LIKE LOWER('{Automobil.nrInmatriculare}')";

            connection.Open();

            SqlCommand commandInsert = new SqlCommand(queryInsert, connection);
            SqlCommand commandSelect = new SqlCommand(queryReturn, connection);

            try
            {
                commandInsert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            SqlDataReader dataReader = commandSelect.ExecuteReader();

            if (dataReader.Read())
            {
                return new Automobile()
                {
                    id = (int) dataReader["id"],
                    nrInmatriculare = (string) dataReader["nr_inmatriculare"],
                    tipAutomobil = new TipAutomobil()
                    {
                        id = (int) dataReader["tip_automobil"],
                        denumire = (string) dataReader["denumire"],
                        nrLocuri = (int) dataReader["nr_locuri"]
                    }
                };
            }

            connection.Close();


            return null;
        }

        public Automobile ReadAutomobile(Automobile Automobil)
        {
            try
            {
                SqlConnection connection = getConnection();
                String queryReturn =
                    $"SELECT id, nr_inmatriculare, tip_automobil FROM Automobile WHERE nr_inmatriculare = '{Automobil.nrInmatriculare}' AND tip_automobil = {Automobil.tipAutomobil.id}";

                connection.Open();

                SqlCommand commandSelect = new SqlCommand(queryReturn, connection);


                SqlDataReader dataReader = commandSelect.ExecuteReader();
                if (dataReader.Read())
                {
                    return new Automobile()
                    {
                        id = (int) dataReader["id"],
                        nrInmatriculare = (string) dataReader["nr_inmatriculare"],
                        tipAutomobil = new TipAutomobil()
                        {
                            id = (int) dataReader["tip_automobil"],
                            denumire = (string) dataReader["denumire"],
                            nrLocuri = (int) dataReader["nr_locuri"]
                        }
                    };
                }

                connection.Close();
            }

            catch (Exception e)
            {
                // ignored
            }

            return null;
        }

        public void UpdateAutomobile(Automobile Automobil)
        {
            SqlConnection connection = getConnection();
            String queryInsert =
                $"UPDATE Automobile SET tip_automobil = {Automobil.tipAutomobil.id} WHERE nr_inmatriculare LIKE '{Automobil.nrInmatriculare}' ";

            connection.Open();

            SqlCommand commandInsert = new SqlCommand(queryInsert, connection);

            try
            {
                commandInsert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //Ignored
            }

            connection.Close();
        }

        public void DeleteAutomobile(Automobile Automobil)
        {
            SqlConnection connection = getConnection();
            String queryInsert =
                $"DELETE FROM Automobile WHERE nr_inmatriculare LIKE '{Automobil.nrInmatriculare}' ";

            connection.Open();

            SqlCommand commandInsert = new SqlCommand(queryInsert, connection);

            try
            {
                commandInsert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //Ignored
            }

            connection.Close();
        }

        public List<Automobile> GetAllAutomobile()
        {
            List<Automobile> automobile = new List<Automobile>();

            SqlConnection connection = getConnection();
            String querySelect =
                "SELECT auto.id, auto.nr_inmatriculare, auto.tip_automobil, tip.denumire, tip.nr_locuri " +
                "FROM Automobile AS auto, TipAutomobil AS tip " +
                "WHERE auto.tip_automobil = tip.id";

            connection.Open();

            SqlCommand commandSelect = new SqlCommand(querySelect, connection);

            SqlDataReader dataReader = commandSelect.ExecuteReader();
            while (dataReader.Read())
            {
                automobile.Add(new Automobile()
                {
                    id = (int) dataReader["id"],
                    nrInmatriculare = (string) dataReader["nr_inmatriculare"],
                    tipAutomobil = new TipAutomobil()
                    {
                        id = (int) dataReader["tip_automobil"],
                        denumire = (string) dataReader["denumire"],
                        nrLocuri = (int) dataReader["nr_locuri"]
                    }
                });
            }

            connection.Close();

            return automobile;
        }

        #endregion


        #region Pasageri

        public void CreatePasager(Pasager pasager)
        {
            using (SqlConnection connection = getConnection())
            {
                String queryInsert =
                    $"INSERT INTO Pasager(idnp, nume_prenume, birth_year) VALUES ({pasager.idnp}, '{pasager.nume_prenume}', {pasager.birth_year})";

                connection.Open();

                SqlCommand commandInsert = new SqlCommand(queryInsert, connection);

                try
                {
                    commandInsert.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Ignored
                }
            }
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
            List<Pasager> pasageri = new List<Pasager>();

            using (SqlConnection connection = getConnection())
            {
                String querySelect = "SELECT * FROM Pasager";

                connection.Open();

                SqlCommand commandSelect = new SqlCommand(querySelect, connection);

                SqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                {
                    pasageri.Add(new Pasager()
                    {
                        idnp = (long) dataReader["idnp"],
                        nume_prenume = (string) dataReader["nume_prenume"],
                        birth_year = (int) dataReader["birth_year"]
                    });
                }
            }

            return pasageri;
        }

        #endregion


        #region Traseu

        public Traseu CreateTraseu(Traseu traseu)
        {
            using (SqlConnection connection = getConnection())
            {
                String queryInsert =
                    $"INSERT INTO Traseu(id_localitate_inceput, id_localitate_sfarsit, distanta) VALUES ({traseu.localitate_inceput.id}, {traseu.localitate_sfarsit.id}, {traseu.distanta})";

                connection.Open();

                SqlCommand commandInsert = new SqlCommand(queryInsert, connection);

                try
                {
                    commandInsert.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //Ignored
                }
            }

            return ReadTraseu(traseu);
        }

        public Traseu ReadTraseu(Traseu traseu)
        {
            using (SqlConnection connection = getConnection())
            {
                String queryReturn =
                    "SELECT id_traseu, id_localitate_inceput, id_localitate_sfarsit, Localitate_inceput, Localitate_sfarsit, id_raion_inceput, nume_raion_inceput, id_raion_sfarsit, nume_raion_sfarsit, distanta FROM Traseu_Full" +
                    $" WHERE id_localitate_inceput = {traseu.localitate_inceput.id} AND id_localitate_sfarsit = {traseu.localitate_sfarsit.id}";

                connection.Open();

                SqlCommand commandSelect = new SqlCommand(queryReturn, connection);

                SqlDataReader dataReader = commandSelect.ExecuteReader();

                if (dataReader.Read())
                {
                    return new Traseu()
                    {
                        id_traseu = (int) dataReader["id_traseu"],
                        distanta = (int) dataReader["distanta"],
                        localitate_inceput = new Localitate()
                        {
                            id = (int) dataReader["id_localitate_inceput"],
                            name = (string) dataReader["Localitate_inceput"],
                            raion = new Raion()
                            {
                                Id = (int) dataReader["id_raion_inceput"],
                                Nume = (string) dataReader["nume_raion_inceput"]
                            }
                        },
                        localitate_sfarsit = new Localitate()
                        {
                            id = (int) dataReader["id_localitate_sfarsit"],
                            name = (string) dataReader["Localitate_sfarsit"],
                            raion = new Raion()
                            {
                                Id = (int) dataReader["id_raion_sfarsit"],
                                Nume = (string) dataReader["nume_raion_sfarsit"]
                            }
                        }
                    };
                }
            }

            return null;
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
            List<Traseu> trasee = new List<Traseu>();

            using (SqlConnection connection = getConnection())
            {
                String querySelect = "SELECT * FROM Traseu_Full";

                connection.Open();

                SqlCommand commandSelect = new SqlCommand(querySelect, connection);

                SqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                {
                    trasee.Add(new Traseu()
                    {
                        id_traseu = (int) dataReader["id_traseu"],
                        distanta = (int) dataReader["distanta"],
                        localitate_inceput = new Localitate()
                        {
                            id = (int) dataReader["id_localitate_inceput"],
                            name = (string) dataReader["Localitate_inceput"],
                            raion = new Raion()
                            {
                                Id = (int) dataReader["id_raion_inceput"],
                                Nume = (string) dataReader["nume_raion_inceput"]
                            }
                        },
                        localitate_sfarsit = new Localitate()
                        {
                            id = (int) dataReader["id_localitate_sfarsit"],
                            name = (string) dataReader["Localitate_sfarsit"],
                            raion = new Raion()
                            {
                                Id = (int) dataReader["id_raion_sfarsit"],
                                Nume = (string) dataReader["nume_raion_sfarsit"]
                            }
                        }
                    });
                }
            }

            return trasee;
        }

        #endregion


        #region Cursa

        public Cursa CreateCursa(Cursa cursa)
        {
            using (SqlConnection connection = getConnection())
            {
                String queryInsert =
                    $"INSERT INTO Cursa(id_traseu, id_automobil, ora) VALUES ({cursa.traseu.id_traseu}, {cursa.Automobile.tipAutomobil.id}, '{cursa.ora}')";

                connection.Open();

                SqlCommand commandInsert = new SqlCommand(queryInsert, connection);

                try
                {
                    commandInsert.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    throw;
                }
            }

            return ReadCursa(cursa);
        }

        public Cursa ReadCursa(Cursa cursa)
        {
            using (SqlConnection connection = getConnection())
            {
                String queryReturn =
                    "SELECT id_cursa, id_automobil, CONVERT(nvarchar(5), ora) AS ora, id_auto, nr_inmatriculare, id_tip_auto, denumire_tip_auto, nr_locuri, id_traseu, id_localitate_inceput, id_localitate_sfarsit, distanta, Localitate_inceput, Localitate_sfarsit, id_raion_inceput, nume_raion_inceput, id_raion_sfarsit, nume_raion_sfarsit FROM Cursa_Full " +
                    $" WHERE id_automobil LIKE '{cursa.traseu.id_traseu}' AND CONVERT(nvarchar(8), ora) LIKE '{cursa.ora}'";
                connection.Open();

                SqlCommand commandSelect = new SqlCommand(queryReturn, connection);

                SqlDataReader dataReader = commandSelect.ExecuteReader();

                if (dataReader.Read())
                {
                    return new Cursa()
                    {
                        id_cursa = (int) dataReader["id_cursa"],
                        ora = (string) dataReader["ora"],
                        Automobile = new Automobile()
                        {
                            id = (int) dataReader["id_automobil"],
                            nrInmatriculare = (string) dataReader["nr_inmatriculare"],
                            tipAutomobil = new TipAutomobil()
                            {
                                denumire = (string) dataReader["denumire_tip_auto"],
                                id = (int) dataReader["id_tip_auto"],
                                nrLocuri = (int) dataReader["nr_locuri"]
                            }
                        },
                        traseu = new Traseu()
                        {
                            id_traseu = (int) dataReader["id_traseu"],
                            distanta = (int) dataReader["distanta"],
                            localitate_inceput = new Localitate()
                            {
                                id = (int) dataReader["id_localitate_inceput"],
                                name = (string) dataReader["Localitate_inceput"],
                                raion = new Raion()
                                {
                                    Id = (int) dataReader["id_raion_inceput"],
                                    Nume = (string) dataReader["nume_raion_inceput"]
                                }
                            },
                            localitate_sfarsit = new Localitate()
                            {
                                id = (int) dataReader["id_localitate_sfarsit"],
                                name = (string) dataReader["Localitate_sfarsit"],
                                raion = new Raion()
                                {
                                    Id = (int) dataReader["id_raion_sfarsit"],
                                    Nume = (string) dataReader["nume_raion_sfarsit"]
                                }
                            }
                        }
                    };
                }
            }

            return null;
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
            List<Cursa> curse = new List<Cursa>();

            using (SqlConnection connection = getConnection())
            {
                String querySelect =
                    "SELECT id_cursa, id_automobil, CONVERT(nvarchar(5), ora) AS ora, id_auto, nr_inmatriculare, id_tip_auto, denumire_tip_auto, nr_locuri, id_traseu, id_localitate_inceput, id_localitate_sfarsit, distanta, Localitate_inceput, Localitate_sfarsit, id_raion_inceput, nume_raion_inceput, id_raion_sfarsit, nume_raion_sfarsit FROM Cursa_Full ";

                connection.Open();

                SqlCommand commandSelect = new SqlCommand(querySelect, connection);

                SqlDataReader dataReader = commandSelect.ExecuteReader();
                while (dataReader.Read())
                {
                    curse.Add(new Cursa()
                    {
                        id_cursa = (int) dataReader["id_cursa"],
                        ora = (string) dataReader["ora"],
                        Automobile = new Automobile()
                        {
                            id = (int) dataReader["id_automobil"],
                            nrInmatriculare = (string) dataReader["nr_inmatriculare"],
                            tipAutomobil = new TipAutomobil()
                            {
                                denumire = (string) dataReader["denumire_tip_auto"],
                                id = (int) dataReader["id_tip_auto"],
                                nrLocuri = (int) dataReader["nr_locuri"]
                            }
                        },
                        traseu = new Traseu()
                        {
                            id_traseu = (int) dataReader["id_traseu"],
                            distanta = (int) dataReader["distanta"],
                            localitate_inceput = new Localitate()
                            {
                                id = (int) dataReader["id_localitate_inceput"],
                                name = (string) dataReader["Localitate_inceput"],
                                raion = new Raion()
                                {
                                    Id = (int) dataReader["id_raion_inceput"],
                                    Nume = (string) dataReader["nume_raion_inceput"]
                                }
                            },
                            localitate_sfarsit = new Localitate()
                            {
                                id = (int) dataReader["id_localitate_sfarsit"],
                                name = (string) dataReader["Localitate_sfarsit"],
                                raion = new Raion()
                                {
                                    Id = (int) dataReader["id_raion_sfarsit"],
                                    Nume = (string) dataReader["nume_raion_sfarsit"]
                                }
                            }
                        }
                    });
                }
            }

            return curse;
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