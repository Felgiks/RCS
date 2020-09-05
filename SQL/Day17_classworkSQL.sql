Create Table zoodarbinieki ( #uztaisiit tabulu
darbiniekaID INT PRIMARY KEY auto_increment,
vards VARCHAR(20) NOT NULL, #komentaaram jabut aiz komata
uzvards VARCHAR(20) NOT NULL,
amats VARCHAR(20) NOT NULL
);

select * from zoodarbinieki;

Create Table veikaladzivnieki ( 
dzivniekaID INT PRIMARY KEY auto_increment,
vards VARCHAR(20) NOT NULL,
suga VARCHAR(20) NOT NULL,
modelis VARCHAR(20) NOT NULL,
darbiniekaID int not null references zoodarbinieki(darbiniekaID)
);

select * from veikaladzivnieki;

ALTER TABLE veikaladzivnieki CHANGE pardevejs darbiniekaID char(20);

ALTER TABLE veikaladzivnieki CHANGE saimnieks klientaID char(20);

alter table veikaladzivnieki
add constraint FK_saimnieks
foreign key (klientaID) references klienti(k);

alter table veikaladzivnieki
add constraint FK_pardevejs
foreign key (darbiniekaID) references zoodarbinieki(darbiniekaID);

Create Table klienti ( #uztaisiit tabulu
klientaID INT PRIMARY KEY auto_increment,
vards VARCHAR(20) NOT NULL, #komentaaram jabut aiz komata
uzvards VARCHAR(20) NOT NULL,
modelis VARCHAR(20) NOT NULL
);

select * from klienti;

alter table klienti
modify column modelis varchar(40);

insert into zoodarbinieki (vards, uzvards, amats)
values 
("janis", "kartotajs", "Precu menegeris"),
("Buks", "Rajesh", "Mazgatajs"),
("Stalts", "Stirnis", "PArdevejs");

insert into klienti (vards, uzvards, modelis)
values 
("Sprukts", "kartotajs", "Kaķu tante"),
("Valdis", "Pīzelis", "Žurkuvīrs"),
("Rajesh", "Kurts", "Rukša saimnieks");

delete from klienti
where klientaID > 3;

insert into veikaladzivnieki (vards, suga, modelis)
values 
("Brenda", "kaķis", "LV īsspalvainais"),
("Dollars", "kaķis", "Lauku sēdinātais"),
("Rika", "suns", "Uzticibas miesojums");

