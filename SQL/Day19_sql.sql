#Klienti
CREATE TABLE Clients(
	clientId int PRIMARY KEY AUTO_INCREMENT,
    firstName varchar(20) NOT NULL,
    lastName varchar(20) NOT NULL,
    phoneNr varchar (20) NOT NULL
);

INSERT INTO Clients (firstName, lastName, phoneNr)
VALUES 
("Janis", "Darbinieks", "11111111"),
("Anna", "Darbiniece", "22222222"),
("Juris", "Caklais", "33333333");	


#Darbinieki
CREATE TABLE Employees(
    employeeId int PRIMARY KEY AUTO_INCREMENT,
    firstName varchar(20) NOT NULL,
    lastName varchar(20) NOT NULL,
    phoneNr varchar (20) NOT NULL
);

INSERT INTO Employees (firstName, lastName, phoneNr)
VALUES 
("Kristine", "Test", "4444444"),
("Aleksandrs", "Test2", "55555555"),
("Juris", "Test3", "666666666");	


#DzivniekaTips

CREATE TABLE AnimalType(
	 typeId int PRIMARY KEY AUTO_INCREMENT,
     typeName varchar(30) NOT NULL,
     typeDescription varchar(100) NOT NULL
);

INSERT INTO AnimalType (typeName, typeDescription)
VALUES 
("Suns", "Cilveka labakais draugs"),
("Kakis", "Kakis rada majigumu"),
("Papagailis", "Man nepatik kaki");	


#Dzivnieki

CREATE TABLE Animal(
	 animalId int PRIMARY KEY AUTO_INCREMENT,
     animalName varchar(30) NOT NULL,
     typeId int NOT NULL,
     employeeId int,
     clientId int,
     FOREIGN KEY (typeId) REFERENCES AnimalType(typeId),
     FOREIGN KEY (employeeId) REFERENCES Employees(employeeId),
     FOREIGN KEY (clientId) REFERENCES Clients(clientId)
);

INSERT INTO Animal (animalName, typeId)
VALUES 
("Reksis", 1),
("Muris", 2),
("Pollijs", 3);

INSERT INTO Animal (animalName, typeId)
VALUES 
("Kuzja", 2);	

#nopirkt dzivnieku
UPDATE Animal
SET employeeId = 3, clientId = 1
WHERE animalId = 1;

UPDATE Animal
SET employeeId = 2, clientId = 1
WHERE animalId = 2;

UPDATE Animal
SET employeeId = 1, clientId = 2
WHERE animalId = 4;

#select
SELECT Animal.animalName, animaltype.typeName, animaltype.typeDescription, 
concat(clients.firstName, ' ' ,clients.lastName) AS 'Saimnieks', employees.lastName AS 'Pardevejs'
FROM animal
INNER JOIN animaltype
ON animal.typeId = animalType.typeId
INNER JOIN clients
ON clients.clientId = animal.clientId
INNER JOIN employees
ON employees.employeeId = animal.employeeId;


SELECT Animal.animalName, animaltype.typeName, animaltype.typeDescription
FROM animal, animaltype
WHERE animal.typeId = animaltype.typeId AND animal.clientId IS null;
