INSERT INTO TipAutomobil (denumire, nr_locuri)
VALUES ('Mercedes-Benz Sprinter', 28);

INSERT INTO Automobile (nr_inmatriculare, tip_automobil)
VALUES ('MH BH 394', 1)

INSERT INTO Raion(nume)
VALUES ('Balti'),
       ('Edinet'),
       ('Soroca'),
       ('Orhei'),
       ('Tiraspol'),
       ('Ungheni'),
       ('Chisinau'),
       ('Hincesti')

INSERT INTO Localitate (nume, id_raion)
VALUES ('Balti', 1),
       ('Rascani', 1),
       ('Glodeni', 1),
       ('Singerei', 1),
       ('Falesti', 1),
       ('Edinet', 2),
       ('Briceni', 2),
       ('Ocnita', 2),
       ('Donduseni', 2),
       ('Soroca', 3),
       ('Drochia', 3),
       ('Floresti', 3),
       ('Orhei', 4),
       ('Telenesti', 4),
       ('Rezina', 4),
       ('Soldanesti', 4),
       ('Dubasari', 5),
       ('Ungheni', 6),
       ('Calarasi', 6),
       ('Nisporeni', 6),
       ('Anenii-Noi', 7),
       ('Ialoveni', 7),
       ('Straseni', 7),
       ('Criuleni', 7),
       ('Lapusna', 8),
       ('Leova', 8),
       ('Cimislia', 8)

INSERT INTO Traseu (id_localitate_inceput, id_localitate_sfarsit)
VALUES (1, 15),
       (2, 6),
       (6, 2);

INSERT INTO Cursa (id_traseu, id_automobil)
VALUES (4, 1);

INSERT INTO Pasager (idnp, nume_prenume, birth_year)
VALUES (2002200220020, 'Stici Vlad', 2002),
       (2002200220021, 'Gherasim Elena', 2002),
       (2002200220022, 'Crozu Stas', 2002),
       (2002200220023, 'Chitic Daniel', 2001);

INSERT INTO LocuriOcupate (id_cursa, id_pasager)
VALUES (3, 2002200220020);