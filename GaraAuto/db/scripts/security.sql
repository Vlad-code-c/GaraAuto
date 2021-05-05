CREATE LOGIN defaultUser WITH PASSWORD = 'defaultPassword';

CREATE USER defaultUser FOR LOGIN defaultUser;

GRANT SELECT, UPDATE, DELETE TO defaultUser;

CREATE LOGIN admin WITH PASSWORD = '*********';

CREATE USER admin FOR LOGIN admin;

GRANT ALL TO admin;
