--public void CreateLocalitate(Localitate localitate)
CREATE OR
ALTER PROCEDURE createLocalitate @numeLocalitate nvarchar(50), @numeRaion nvarchar(50)
AS
BEGIN
    insert into Localitate(nume, id_raion)
    VALUES (@numeLocalitate,
            (select TOP 1 Raion.id FROM Raion WHERE LOWER(Raion.nume) Like LOWER(@numeRaion)))
END
GO

EXEC createLocalitate @numeLocalitate = 'LocalitateTest', @numeRaion = 'RaionTest';

SELECT Raion.id, Localitate.id
FROM Localitate,
     Raion
WHERE Raion.id = Localitate.id_raion
  AND LOWER(Localitate.nume) LIKE LOWER('Orhei');

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

                if not exists((select 1
                               FROM inserted,
                                    Raion
                               WHERE Raion.nume LIKE @nume_raion))
                    insert into Raion(nume) VALUES (@nume_raion)

                FETCH NEXT FROM n_cursor INTO @nume_raion
            end
        Close n_cursor
        DEALLOCATE n_cursor
    end;
GO

SELECT auto.id, auto.nr_inmatriculare, auto.tip_automobil, tip.denumire, tip.nr_locuri
FROM Automobile AS auto,
     TipAutomobil AS tip
WHERE auto.tip_automobil = tip.id


SELECT *
FROM Raion

SELECT *
FROM Automobile

INSERT INTO Automobile(nr_inmatriculare, tip_automobil)
VALUES ('GH Fh 485', 1)
SELECT id
FROM Automobile
WHERE LOWER(nr_inmatriculare) LIKE LOWER('GH FH 485')

SELECT *
FROM TipAutomobil
WHERE Lower(denumire) LIKE LOWER('a')

SELECT *
FROM Pasager
INSERT INTO Pasager(idnp, nume_prenume, birth_year)
VALUES (47759895468, 'Test dM', 2000)

SELECT *
FROM Traseu
INSERT INTO Traseu(id_localitate_inceput, id_localitate_sfarsit)
VALUES (2, 1)

SELECT *
FROM Traseu_Full
WHERE id_localitate_inceput = 1
  AND id_localitate_sfarsit = 2
SELECT *
FROM Traseu_Full

SELECT id_traseu,
       id_localitate_inceput,
       id_localitate_sfarsit,
       Localitate_inceput,
       Localitate_sfarsit,
       id_raion_inceput,
       nume_raion_inceput,
       id_raion_sfarsit,
       nume_raion_sfarsit
FROM Traseu_Full


SELECT *
FROM Localitate

SELECT L.id AS 'id_loc', L.nume AS 'nume_loc', R.id AS 'id_raion', R.nume AS 'nume_raion'
FROM Raion AS R,
     Localitate AS L
WHERE R.Id = L.id_raion
--AND LOWER(L.nume) LIKE LOWER('Orhei')


SELECT *
FROM Cursa
INSERT INTO Cursa(id_traseu, id_automobil)
VALUES (1, 2)

-- SELECT id_traseu, id_localitate_inceput, id_localitate_sfarsit, id_raion, Raion, Localitate_inceput, Localitate_sfarsit FROM Traseu_Full


SELECT id, nr_inmatriculare, tip_automobil
FROM Automobile


SELECT L.id AS 'id_loc', L.nume AS 'nume_loc', R.id AS 'id_raion', R.nume AS 'nume_raion'
FROM Raion AS R,
     Localitate AS L
WHERE R.Id = L.id_raion
  AND LOWER(L.nume) LIKE LOWER('Balti')


SELECT *
FROM Cursa
WHERE DATEPART(hh, ora) LIKE 15
  AND DATEPART(minute, ora) LIKE 0
SELECT *
FROM Cursa
WHERE id_traseu LIKE '%'
  AND id_automobil LIKE '%'
  AND CONVERT(nvarchar(8), ora) LIKE '%'

UPDATE Cursa
SET ora = '08:00:00'
WHERE id_cursa <= 15
INSERT INTO Cursa (id_traseu, id_automobil, ora)
VALUES (5, 2, '15:00')

SELECT id_cursa,
       id_automobil,
       ora,
       id_traseu,
       id_localitate_inceput,
       id_localitate_sfarsit,
       distanta,
       Localitate_inceput,
       Localitate_sfarsit,
       id_raion_inceput,
       nume_raion_inceput,
       id_raion_sfarsit,
       nume_raion_sfarsit
FROM Cursa_Full


SELECT C.id_cursa,
       C.id_automobil,
       C.ora,
       A.id            AS 'id_auto',
       A.tip_automobil AS 'id_tip_auto',
       A.nr_inmatriculare,
       Ta.id           AS 'id_tip_auto',
       TA.denumire     AS 'denumire_tip_auto',
       TA.nr_locuri,
       T.id_traseu,
       T.id_localitate_inceput,
       T.id_localitate_sfarsit,
       T.distanta,
       T.Localitate_inceput,
       T.Localitate_sfarsit,
       T.id_raion_inceput,
       T.nume_raion_inceput,
       T.id_raion_sfarsit,
       t.nume_raion_sfarsit
FROM Cursa C,
     Traseu_Full T,
     TipAutomobil TA,
     Automobile A
WHERE C.id_traseu = T.id_traseu
  AND A.tip_automobil = TA.id
  AND C.id_automobil = A.id


SELECT id_cursa,
       id_automobil,
       CONVERT(nvarchar(5), ora),
       ora,
       id_auto,
       nr_inmatriculare,
       id_tip_auto,
       denumire_tip_auto,
       nr_locuri,
       id_traseu,
       id_localitate_inceput,
       id_localitate_sfarsit,
       distanta,
       Localitate_inceput,
       Localitate_sfarsit,
       id_raion_inceput,
       nume_raion_inceput,
       id_raion_sfarsit,
       nume_raion_sfarsit
FROM Cursa_Full


SELECT *
FROM Cursa

SELECT *
FROM Automobile


UPDATE Automobile
SET tip_automobil = 5
WHERE nr_inmatriculare LIKE 'Vvv Vvv'
DELETE
FROM Automobile
WHERE nr_inmatriculare LIKE 'Vvv Vvv'


UPDATE TipAutomobil
SET denumire  = 'a',
    nr_locuri = 2
WHERE id = 2

DELETE
FROM TipAutomobil
WHERE id = 11

SELECT *
FROM TipAutomobil

SELECT *
FROM Raion


SELECT *
FROM Localitate

UPDATE Localitate
SET nume     = 'Some',
    id_raion = 2
WHERE id = 57
DELETE
FROM Localitate
WHERE id = 1


SELECT idnp, nume_prenume, birth_year
FROM Pasager


UPDATE Pasager
SET nume_prenume = '',
    birth_year   = 2000
WHERE idnp = 1
DELETE
FROM Pasager
WHERE idnp = 1

SELECT *
FROM Traseu
SELECT id_traseu,
       id_localitate_inceput,
       id_localitate_sfarsit,
       Localitate_inceput,
       Localitate_sfarsit,
       id_raion_inceput,
       nume_raion_inceput,
       id_raion_sfarsit,
       nume_raion_sfarsit,
       distanta
FROM Traseu_Full


DELETE
FROM Traseu
WHERE id_traseu = 34
UPDATE Traseu
SET id_localitate_inceput = 22,
    id_localitate_sfarsit = 23,
    distanta              = 12
WHERE id_traseu = 40


SELECT *
FROM Cursa_Full
SELECT *
FROM Cursa


UPDATE Cursa
SET id_traseu    = 1,
    id_automobil = 1,
    ora          = ''
WHERE id_cursa = 1
DELETE
FROM Cursa
WHERE id_cursa = 1

UPDATE Cursa
SET id_traseu    = 4,
    id_automobil = 2,
    ora          = '15:00'
WHERE id_cursa = 4


SELECT id_cursa,
       id_automobil,
       CONVERT(nvarchar(5), ora) AS ora,
       id_auto,
       nr_inmatriculare,
       id_tip_auto,
       denumire_tip_auto,
       nr_locuri,
       id_traseu,
       id_localitate_inceput,
       id_localitate_sfarsit,
       distanta,
       Localitate_inceput,
       Localitate_sfarsit,
       id_raion_inceput,
       nume_raion_inceput,
       id_raion_sfarsit,
       nume_raion_sfarsit
FROM Cursa_Full
WHERE id_automobil LIKE 1
  AND CONVERT(nvarchar(8), ora) LIKE '15:0%'
  AND id_traseu = 4


SELECT *
FROM Automobile
select *
from Localitate

SELECT *
FROM Pasager

SELECT Automobile.id, nr_inmatriculare, tip_automobil, Tip.denumire, Tip.nr_locuri
FROM Automobile,
     TipAutomobil Tip
WHERE nr_inmatriculare = 'MH BH 394'
  AND tip_automobil = 1
  AND Automobile.tip_automobil = Tip.id


SELECT id_cursa,
       id_automobil,
       CONVERT(nvarchar(5), ora) AS ora,
       id_auto,
       nr_inmatriculare,
       id_tip_auto,
       denumire_tip_auto,
       nr_locuri,
       id_traseu,
       id_localitate_inceput,
       id_localitate_sfarsit,
       distanta,
       Localitate_inceput,
       Localitate_sfarsit,
       id_raion_inceput,
       nume_raion_inceput,
       id_raion_sfarsit,
       nume_raion_sfarsit
FROM Cursa_Full
WHERE id_automobil LIKE 35
  AND CONVERT(nvarchar(8), ora) LIKE '8:0%'
  AND id_traseu = 8


SELECT id_cursa,
       id_automobil,
       CONVERT(nvarchar(5), ora) AS ora,
       id_auto,
       nr_inmatriculare,
       id_tip_auto,
       denumire_tip_auto,
       nr_locuri,
       id_traseu,
       id_localitate_inceput,
       id_localitate_sfarsit,
       distanta,
       Localitate_inceput,
       Localitate_sfarsit,
       id_raion_inceput,
       nume_raion_inceput,
       id_raion_sfarsit,
       nume_raion_sfarsit
FROM Cursa_Full
WHERE id_automobil LIKE 1
  AND CONVERT(nvarchar(8), ora) LIKE '%8:0%'
  AND id_traseu = 7


SELECT *
FROM TipAutomobil


SELECT *
FROM Automobile

SELECT *
FROM Raion

SELECT *
FROM Localitate


SELECT *
FROM Pasager


SELECT *
FROM Traseu


SELECT *
FROM Traseu_Full

SELECT *
FROM Cursa_Full

SELECT *
FROM LocuriOcupate

INSERT INTO LocuriOcupate (id_cursa, id_pasager)
VALUES (1, 1)


SELECT id_user, email, password
FROM Users
WHERE email LIKE 'vladz1992b@gmail.com'
  AND password LIKE '12345'

SELECT *
FROM UsersRoles
WHERE id_user = 1

SELECT *
FROM Users

SELECT id_user, UsersRoles.id_role, Roles.role
FROM UsersRoles,
     Roles
WHERE UsersRoles.id_role = Roles.id_role
  AND id_user = 1



SELECT * FROM Users

SELECT * FROM UsersRoles

UPDATE Users Set password = '__' + password + '__' WHERE 1=1



SELECT * FROM Users


SELECT * FROM Cursa_Full

SELECT C.id_cursa AS 'id_cursa',
       P.idnp AS 'idnp',
       nume_prenume,
       birth_year,
       C.*
       
       FROM LocuriOcupate LO, Cursa_Full C, Pasager P WHERE C.id_cursa = LO.id_cursa AND P.idnp = LO.id_pasager



SELECT * FROM LocuriOcupate


