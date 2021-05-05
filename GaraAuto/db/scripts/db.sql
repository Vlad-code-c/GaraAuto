CREATE TABLE TipAutomobil
(
    id        int primary key identity,
    denumire  nvarchar(50) not null unique,
    nr_locuri int
);


CREATE TABLE Automobile
(
    id               int primary key identity,
    nr_inmatriculare nvarchar(10) UNIQUE,
    tip_automobil    int,

    constraint tip_automobil_fk foreign key (tip_automobil) references TipAutomobil (id)
);
-- ALTER TABLE Automobile ADD UNIQUE (nr_inmatriculare)

CREATE TABLE Raion
(
    id   int primary key identity,
    nume nvarchar(50) unique
);


CREATE TABLE Localitate
(
    id       int primary key identity,
    nume     nvarchar(50) unique,
    id_raion int,

    constraint id_raion_fk foreign key (id_raion) references Raion (id)
);

CREATE TABLE Traseu
(
    id_traseu             int primary key identity,
--     denumire              nvarchar(50) NULL,
    id_localitate_inceput int,
    id_localitate_sfarsit int,

    constraint id_localitate_inceput_fk foreign key (id_localitate_inceput) references Localitate (id),
    constraint id_localitate_sfarsit_fk foreign key (id_localitate_sfarsit) references Localitate (id),
    constraint uq_id_localit unique (id_localitate_inceput, id_localitate_sfarsit)
);

-- CREATE VIEW Traseu_Full AS
-- SELECT T.id_traseu,
--        T.id_localitate_inceput,
--        T.id_localitate_sfarsit,
--        L.id_raion,
--        R.nume                                                                 AS 'Raion',
--        (SELECT TOP 1 nume FROM Localitate WHERE id = T.id_localitate_inceput) AS 'Localitate_inceput',
--        (SELECT TOP 1 nume FROM Localitate WHERE id = T.id_localitate_sfarsit) AS 'Localitate_sfarsit'
-- FROM Traseu AS T
--          LEFT JOIN Localitate L on T.id_localitate_inceput = L.id
--          LEFT JOIN Raion R on L.id_raion = R.id

CREATE OR ALTER VIEW Traseu_Full AS
SELECT T.id_traseu,
       T.id_localitate_inceput,
       T.id_localitate_sfarsit,

       (SELECT TOP 1 nume FROM Localitate WHERE id = T.id_localitate_inceput) AS 'Localitate_inceput',
       (SELECT TOP 1 nume FROM Localitate WHERE id = T.id_localitate_sfarsit) AS 'Localitate_sfarsit',
       (SELECT TOP 1 id
        FROM Raion
        WHERE (SELECT TOP 1 id_raion FROM Localitate WHERE T.id_localitate_inceput = Localitate.id) =
              Raion.id)                                                       AS 'id_raion_inceput',
       (SELECT TOP 1 nume
        FROM Raion
        WHERE (SELECT TOP 1 id_raion FROM Localitate WHERE T.id_localitate_inceput = Localitate.id) =
              Raion.id)                                                       AS 'nume_raion_inceput',
       (SELECT TOP 1 id
        FROM Raion
        WHERE (SELECT TOP 1 id_raion FROM Localitate WHERE T.id_localitate_sfarsit = Localitate.id) =
              Raion.id)                                                       AS 'id_raion_sfarsit',
       (SELECT TOP 1 nume
        FROM Raion
        WHERE (SELECT TOP 1 id_raion FROM Localitate WHERE T.id_localitate_sfarsit = Localitate.id) =
              Raion.id)                                                       AS 'nume_raion_sfarsit'
FROM Traseu AS T


-- create trigger set_denumire_traseu
--     on Traseu
--     after insert
--     as
-- begin
--     UPDATE Traseu
--     SET denumire = (SELECT TOP 1 nume FROM Localitate WHERE id = inserted.id_localitate_inceput) + ' - ' +
--                    (SELECT TOP 1 nume FROM Localitate WHERE id = inserted.id_localitate_sfarsit)
--     FROM inserted
--     WHERE Traseu.id_localitate_inceput = inserted.id_localitate_inceput
--       AND Traseu.id_localitate_sfarsit = inserted.id_localitate_sfarsit
-- end;
GO;

CREATE TABLE Cursa
(
    id_cursa     int identity primary key,
    id_traseu    int,
    id_automobil int,

    constraint id_traseu_fk foreign key (id_traseu) references Traseu (id_traseu),
    constraint id_automobile_fk foreign key (id_automobil) references Automobile (id)
);

CREATE TABLE Pasager
(
    idnp         bigint primary key,
    nume_prenume nvarchar(100),
    birth_year   int
);

CREATE TABLE LocuriOcupate
(
    id_cursa   int,
    id_pasager bigint,

    constraint pk_locuri_ocupate primary key (id_cursa, id_pasager),
    constraint id_cursa_fk foreign key (id_cursa) references Cursa (id_cursa),
    constraint id_pasager_fk foreign key (id_pasager) references Pasager (idnp)
);