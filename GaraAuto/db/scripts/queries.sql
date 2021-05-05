--public void CreateLocalitate(Localitate localitate)
CREATE OR ALTER PROCEDURE createLocalitate @numeLocalitate nvarchar(50), @numeRaion nvarchar(50)
    AS
    BEGIN
        insert into Localitate(nume, id_raion) 
            VALUES (@numeLocalitate, 
                    (select TOP 1 Raion.id FROM Raion WHERE LOWER(Raion.nume) Like LOWER(@numeRaion)))
    END

EXEC createLocalitate @numeLocalitate = 'LocalitateTest', @numeRaion = 'RaionTest';

SELECT Raion.id, Localitate.id FROM Localitate, Raion
    WHERE Raion.id = Localitate.id_raion AND LOWER(Localitate.nume) LIKE LOWER('Orhei');

--public int CreateRaion(Raion raion)
CREATE PROCEDURE createRaion @numeRaion nvarchar(50)
    AS 
    BEGIN
        DECLARE @id_raion int = (select 1 FROM Raion WHERE nume LIKE @numeRaion)

        if @id_raion is null
            insert into Raion(nume) VALUES (@numeRaion)       
    END;

--public int CreateRaion(Raion raion)
create or alter trigger trigger_create_raion
    on Raion
    instead of insert
    as  
    begin 
        set nocount on;
        declare @nume_raion nvarchar(50)
        
        declare n_cursor CURSOR for select nume from inserted
        
        open n_cursor
        FETCH NEXT FROM n_cursor INTO @nume_raion
        
        WHILE @@FETCH_STATUS = 0
        Begin
            
            if not exists((select 1 FROM inserted, Raion WHERE Raion.nume LIKE @nume_raion))
                insert into Raion(nume) VALUES (@nume_raion)
            
            FETCH NEXT FROM n_cursor INTO @nume_raion
        end
        Close n_cursor
        DEALLOCATE n_cursor
    end;
GO

SELECT auto.id, auto.nr_inmatriculare, auto.tip_automobil, tip.denumire, tip.nr_locuri 
    FROM Automobile AS auto, TipAutomobil AS tip
        WHERE auto.tip_automobil = tip.id


SELECT * FROM Raion

SELECT * FROM Automobile

INSERT INTO Automobile(nr_inmatriculare, tip_automobil) VALUES ('GH Fh 485', 1)
SELECT id FROM Automobile WHERE LOWER(nr_inmatriculare) LIKE LOWER('GH FH 485')

SELECT * FROM TipAutomobil WHERE Lower(denumire) LIKE LOWER('a') 

SELECT * FROM Pasager
INSERT INTO Pasager(idnp, nume_prenume, birth_year) VALUES (47759895468, 'Test dM', 2000)

SELECT * FROM Traseu
INSERT INTO Traseu(id_localitate_inceput, id_localitate_sfarsit) VALUES (2, 1)

SELECT * FROM Traseu_Full WHERE id_localitate_inceput = 1 AND id_localitate_sfarsit = 2
SELECT * FROM Traseu_Full

SELECT id_traseu, id_localitate_inceput, id_localitate_sfarsit, Localitate_inceput, Localitate_sfarsit, id_raion_inceput, nume_raion_inceput, id_raion_sfarsit, nume_raion_sfarsit FROM Traseu_Full


SELECT * FROM Localitate

SELECT L.id AS 'id_loc', L.nume AS 'nume_loc', R.id AS 'id_raion', R.nume AS 'nume_raion' FROM Raion AS R, Localitate AS L 
    WHERE R.Id = L.id_raion
      --AND LOWER(L.nume) LIKE LOWER('Orhei')
      
      
SELECT * FROM Cursa


-- SELECT id_traseu, id_localitate_inceput, id_localitate_sfarsit, id_raion, Raion, Localitate_inceput, Localitate_sfarsit FROM Traseu_Full
