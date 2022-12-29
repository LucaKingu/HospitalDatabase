--Hospital 

CREATE TABLE Country
(
	countryId INTEGER CONSTRAINT cn_cid_pk PRIMARY KEY,
	countryName NVARCHAR(100) NOT NULL,
	riskOfForeignDisease BIT NOT NULL
);
GO

--To show the current occupation of a patient
CREATE TABLE Occupation
(
	occupationId INTEGER CONSTRAINT occ_ocid_pk PRIMARY KEY,
	occupationName NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Patient
(
	pId INTEGER CONSTRAINT pt_pid_pk PRIMARY KEY,
	idCard NVARCHAR(10) CONSTRAINT pt_idc_un UNIQUE,
	firstName NVARCHAR(100) NOT NULL,
	lastName NVARCHAR(100) NOT NULL,
	[address] NVARCHAR(250) NOT NULL,
	martialStatus NVARCHAR(20) NOT NULL,
	age INTEGER NOT NULL,
	phone INTEGER NOT NULL,
	registrationDate DATETIME NOT NULL,
	sex BIT,
	occupationId INTEGER NOT NULL CONSTRAINT pt_occid_fk REFERENCES Occupation(occupationId)
);
GO

