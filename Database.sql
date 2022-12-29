--Hospital 

CREATE TABLE Country
(
	countryId INTEGER CONSTRAINT cn_cid_pk PRIMARY KEY,
	countryName NVARCHAR(100) NOT NULL,
	riskOfForeignDisease BIT NOT NULL
);
GO

CREATE TABLE City
(
	cityId INTEGER CONSTRAINT ct_ctid_pk PRIMARY KEY,
	cityName NVARCHAR(100) NOT NULL
);
GO

--To show the current occupation of a patient
CREATE TABLE Occupation
(
	occupationId INTEGER CONSTRAINT occ_ocid_pk PRIMARY KEY,
	occupationName NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Patnt
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
	sex BIT,	--1 male , 0 female
	occupationId INTEGER NOT NULL CONSTRAINT pt_occid_fk REFERENCES Occupation(occupationId),
	countryId INTEGER NOT NULL CONSTRAINT cn_cid_fk REFERENCES Country(countryId),
	cityId INTEGER NOT NULL CONSTRAINT ct_ctid_fk REFERENCES City(cityId)
);
GO

CREATE TABLE Department
(
	departmentId INTEGER CONSTRAINT dp_dpid_pk PRIMARY KEY,
	departmentName NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Hospital_Employee
(
	employeeId INTEGER CONSTRAINT emp_empid_pk PRIMARY KEY,
	firstName NVARCHAR(100) NOT NULL,
	lastName NVARCHAR(100) NOT NULL,
	[address] NVARCHAR(250) NOT NULL,
	martialStatus NVARCHAR(20) NOT NULL,
	age INTEGER NOT NULL,
	phone INTEGER NOT NULL,
	hireDate DATETIME NOT NULL,
	attritionDate DATETIME,
	sex BIT,
	countryId INTEGER NOT NULL CONSTRAINT cnHE_cid_fk REFERENCES Country(countryId),
	cityId INTEGER NOT NULL CONSTRAINT ctHE_ctid_fk REFERENCES City(cityId),
	departmentId INTEGER NOT NULL CONSTRAINT dp_dpid_fk REFERENCES department(departmentId)
);
GO

CREATE TABLE Medication
(
	medicationId INTEGER CONSTRAINT md_mdid_pk PRIMARY KEY,
	medicationName NVARCHAR(100) NOT NULL,
	symptoms TEXT NOT NULL,
	diseaseTreatment TEXT NOT NULL,			--The diseases the product treats
	expiryDate DATETIME NOT NULL,
	medicationQTY INTEGER,
);
GO

CREATE TABLE MedicationOrder
(
	medicationOrderId INTEGER CONSTRAINT mdod_mdodid_pk PRIMARY KEY,
	orderQTY INTEGER NOT NULL,
	boughtDate DATETIME NOT NULL,	--The date the medicine was bought
	dueDate DATETIME NOT NULL,		--The date the medicine is estimated to arrive
	orderCost INTEGER NOT NULL,
	medicationId INTEGER NOT NULL CONSTRAINT md_mdid_fk REFERENCES Medication(medicationId)
);
GO

CREATE TABLE healthStatus
(
	pId INTEGER NOT NULL CONSTRAINT htst_ptid_fk REFERENCES patnt(pId),
	currentHealth NVARCHAR(100) NOT NULL,
	disability NVARCHAR(100),
	mentalHealth NVARCHAR(100),
	medication NVARCHAR(100),
	medicalHistory NVARCHAR(100),
	geneticInformation NVARCHAR(100),
	--Can always add more health related information
);
GO