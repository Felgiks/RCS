create table jobs(
jobID int primary key auto_increment,
jobDescription varchar(50) not null
);

alter table jobs
add jobName varchar(20) not null;

insert into jobs (jobName , jobDescription)
values("Programmetajs", "raksta kodu"),
("HR's", "palidz cilvekiem"),
("Gramatvede", "Naudas vizards");

update jobs
set jobName = "Gramatvede"
where jobID = 3;

delete from jobs
where jobID > 3;

select * from jobs;

Create Table darbinieki ( #uztaisiit tabulu
darbiniekaID INT PRIMARY KEY auto_increment,
darbiniekaVards VARCHAR(20) NOT NULL, #komentaaram jabut aiz komata
darbiniekaUzvards VARCHAR(20) NOT NULL,
jobID int,
foreign key (jobID) references jobs(jobID)
);

drop table darbinieki;
drop table jobs;

insert into darbinieki(darbiniekaVards, darbiniekaUzvards)
values
("Janis", "Darbinieks"),
("Anna", "Zalite"),
("Kristine", "Putnina");
;

select * from darbinieki;

update darbinieki
set darbiniekaVards = "Gatis", darbiniekaUzvards = "Kandis"
where darbiniekaID = 1;

update darbinieki
set darbiniekaVards = "Maiks", darbiniekaUzvards = "Tainais"
where darbiniekaID = 3;

update darbinieki
set darbiniekaVards = "Rayesh", darbiniekaUzvards = "Uzvards"
where darbiniekaID = 2;

alter table darbinieki
add column jobID int;

alter table darbinieki
add constraint FK_job_id
foreign key (jobID) references jobs(jobID);

select * from darbinieki;

alter table darbinieki
drop foreign key savienojums_job_id;

update darbinieki
set jobID = 1
where darbiniekaID = 2;

update darbinieki
set jobID = 3
where darbiniekaID = 3;

update darbinieki
set jobID = 2
where darbiniekaID = 1;

select darbinieki.darbiniekaVards , darbinieki.darbiniekaUzvards, jobs.jobName 
from darbinieki, jobs
where darbinieki.jobID = jobs.jobID;

#------------------------

create table Team
(teamID int primary key auto_increment,
teamName varchar(10) not null);

insert into Team (teamName)
values ("Alpha"),
("Beta");

alter table darbinieki
add column teamID int;

alter table darbinieki
add constraint fk_team_id
foreign key (teamID) references Team(teamID);

update darbinieki
set teamID = 1
where darbiniekaID < 2;

update darbinieki
set teamID = 2
where darbiniekaID = 3;

select * from darbinieki;

select darbinieki.darbiniekaVards, darbinieki.darbiniekaUzvards, team.teamName
from darbinieki, team
where Team.teamID = darbinieki.teamID;