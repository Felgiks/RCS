Create Table employees ( #uztaisiit tabulu
EmployeeID INT PRIMARY KEY auto_increment,
firstName VARCHAR(20) NOT NULL, #komentaaram jabut aiz komata
LastName VARCHAR(20) NOT NULL
);

INSERT INTO Employees (EmployeeID, firstName, LastName) #ievietojam
VALUES (1, "Martins", "Darbinieks");

INSERT INTO Employees (firstName, LastName)
VALUES 
("Janis", "Darbinieks"),
("Anna", "Zalite"),
("Kristine", "Putnina");

select firstName FROM employees; # zvaigniites vietaa items ko tu veelies

select * from employees;

select firstName, LastName from employees;

select firstName, LastName 
from employees
where EmployeeID = 2;

select firstName, LastName 
from employees
where EmployeeID >= 2;

drop table employees;