CREATE TABLE clients(
	clientID int PRIMARY KEY auto_increment,
    firstName VARCHAR(20) NOT NULL,
    lastName VARCHAR(20) NOT NULL,
    phoneNR varchar(20) NOT NULL
);

insert into clients (firstName, lastName, phoneNR)
VALUES
("Janis", "berzins","29876543"),
("egils", "Kautrigais","22222222"),
("Vanda", "Mazaaa","33333333");

CREATE TABLE employees(
	employeeID int PRIMARY KEY auto_increment,
    firstName VARCHAR(20) NOT NULL,
    lastName VARCHAR(20) NOT NULL,
    phoneNR varchar(20) NOT NULL
);

insert into employees (firstName, lastName, phoneNR)
VALUES
("Maija", "Maigā","29876543"),
("Vanda", "Skaista","22222222"),
("Evija", "Burvīgā","33333333");

CREATE TABLE animaltype(
	typeID int PRIMARY KEY auto_increment,
    typeName VARCHAR(20) NOT NULL,
    typeDescription VARCHAR(20) NOT NULL
);

insert into animaltype (typeName, typeDescription)
VALUES
("Suns", "4 kajas"),
("Kakis", "Spalvukamols"),
("Papagailis", "Nevmieracelaajs");

CREATE TABLE animal(
	animalID int PRIMARY KEY auto_increment,
    animalName VARCHAR(20) NOT NULL,
    typeID int NOT NULL,
    employeeID int,
    clientID int,
    foreign key (typeID) references animaltype(typeID),
    foreign key (employeeID) references employees(employeeID),
    foreign key (clientID) references clients(clientID)
);
insert into animal (animalName, typeID)
VALUES
("Reksis", 1),
("Brenda", 2),
("Rota", 1),
("Goša", 2),
("Mia", 2);

insert into animal (animalName, typeID)
VALUES
("Kuzja", 2);

update animal
set employeeID = 3, clientID = 1
where animalID = 1;

update animal
set employeeID = 2, clientID = 2
where animalID = 2;

update animal
set employeeID = 1, clientID = 1
where animalID = 4;

select * from animal;

select animalName from animal;

SELECT animal.animalName, animaltype.typeName, animaltype.typeDescription, 
concat(clients.firstName, " ", clients.lastName) AS "Saimnieks", #savienot divus laukus vienā
employees.firstName AS "Pardevejs"
from animal
inner join animaltype
on animal.typeID = animaltype.typeID
inner join clients
on clients.clientID = animal.clientID
inner join employees
on employees.employeeID = animal.employeeID;

SELECT animal.animalName, animaltype.typeName, animaltype.typeDescription 
from animal, animaltype
where animal.typeID = animaltype.typeID AND animal.clientID is null;