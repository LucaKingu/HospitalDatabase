--Hospital 

CREATE TABLE Country
(
	countryId INTEGER PRIMARY KEY,
	countryName NVARCHAR(100) NOT NULL,
	riskOfForeignDisease BIT NOT NULL
);
GO