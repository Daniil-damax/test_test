﻿CREATE TABLE House(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL
);
CREATE TABLE Complex(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Id_house INT REFERENCES House(Id)
);
