create database record;
Create table recordadd(ID  varchar(50) Null, Name varchar(50) Null,F_Name varchar(50) Null,Age varchar(50),Sex varchar(50) Null, DOB varchar(50) Null,MobileNo varchar(50) Null,CNICNo varchar(50) Null,City varchar(50) Null ,Address varchar(50) Null);

ALTER TABLE recordadd ADD Height varchar(50)

ALTER TABLE recordadd ALTER COLUMN Height varchar(50);

 ALTER TABLE recordadd ADD EyeColor varchar(50)
 ALTER TABLE recordadd ADD Any_Disease varchar(50)
 ALTER TABLE recordadd ADD Donated_Before varchar(50)
 ALTER TABLE recordadd ADD Blood_Group varchar(50)
 ALTER TABLE recordadd ADD Date_Donation varchar(50)
 
 
 ALTER TABLE recordadd DROP COLUMN Height;
  ALTER TABLE recordadd DROP COLUMN EyeColor;
   ALTER TABLE recordadd DROP COLUMN Any_Disease;
    ALTER TABLE recordadd DROP COLUMN Donated_Before;
     ALTER TABLE recordadd DROP COLUMN Blood_Group;
      ALTER TABLE recordadd DROP COLUMN Date_Donation;
/*
ab doobara add krhi hun columns

*/
ALTER TABLE recordadd ADD Height varchar(50)Null;
ALTER TABLE recordadd ADD EyeColor varchar(50)Null;
 ALTER TABLE recordadd ADD Any_Disease varchar(50)Null;
 ALTER TABLE recordadd ADD Donated_Before varchar(50)Null;
 ALTER TABLE recordadd ADD Blood_Group varchar(50)Null;
 ALTER TABLE recordadd ADD Date_Donation varchar(50)Null;


 
       
Create table eye(EyeColor varchar(50) Null);
insert into eye(EyeColor)values ('Amber');
insert into eye(EyeColor)values ('Hazel');
insert into eye(EyeColor)values ('Brown');
insert into eye(EyeColor)values ('Gray');
insert into eye(EyeColor)values ('Red');
insert into eye(EyeColor)values ('Green');

Create table bloodgroup(bloodname varchar(50) Null);
insert into bloodgroup(bloodname)values ('O+');
insert into bloodgroup(bloodname)values ('O-');
insert into bloodgroup(bloodname)values ('AB+');
insert into bloodgroup(bloodname)values ('B+');
insert into bloodgroup(bloodname)values ('A+');



Create table donation(Name  varchar(50) Null, Blood_Group varchar(50) Null,Amount varchar(50) Null,Date_of_Donation varchar(50)Null);




Create table bloodbagentry(id  varchar(50) Null, Brand varchar(50) Null,cost varchar(50)Null,Date varchar(50) Null);