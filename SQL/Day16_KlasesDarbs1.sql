Create Table students ( #uztaisiit tabulu
studentID INT PRIMARY KEY auto_increment,
studentaVards VARCHAR(20) NOT NULL, #komentaaram jabut aiz komata
studentaUzvards VARCHAR(20) NOT NULL,
studentaKurss INT NOT NULL
);

Alter table students
add hobbies varchar(30);

alter table students
drop column hobbies;

alter table students
modify column hobbies varchar(40);

INSERT INTO students (studentaVards, studentaUzvards, studentaKurss)
VALUES  #studentu saraksts
("Janis", "Darbinieks", 1),
("Anna", "Zalite", 1),
("Kristine", "Putnina", 2),
("Janis", "Darbinieks", 2),
("Anna", "Zalite", 3),
("Kristine", "Putnina", 3);

select * from students;

drop table students; #dzest studentu tabulu

select studentaVards, studentaUzvards from students;

select studentaVards, studentaUzvards, studentaKurss
from students
where studentaKurss = 2;

select studentaVards, studentaUzvards, studentaKurss
FROM students
WHERE studentaKurss = 1 OR studentaKurss = 3; 

select studentaVards, studentaUzvards, studentaKurss
FROM students
WHERE studentaVards = "Anna";
