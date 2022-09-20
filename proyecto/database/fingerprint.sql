drop database if exists Honorarios_Check_DGTIT;

create database Honorarios_Check_DGTIT CHARACTER SET utf8 COLLATE utf8_general_ci;

use Honorarios_Check_DGTIT;

create table daysIn (
    daysInID smallint not null identity(1,1) primary key,
    monday bit default 0,
    tuesday bit default 0,
    wednesday bit default 0,
    thursday bit default 0,
    friday bit default 0,
    saturday bit default 0
);

create table schedule (
    scheduleID smallint not null identity(1,1) primary key,
    daysInID smallint not null foreign key REFERENCES daysIn(daysInID),
    timeIn  time default '08:30:00',
    timeOut time default '16:00:00',
         
);

create table fingerprint (
    fingerprintID smallint not null identity(1,1) primary key,
    huella varbinary(max) not null
);

create table users (
    userID smallint not null identity(1,1) primary key,
    scheduleID smallint not null,
    fingerprintID smallint not null,
    birthday date not null,
    name varchar (50) not null,
    lastname varchar (40) not null,
    lastname2 varchar (40) not null,
    fullname varchar (100) not null,
    jobPosition varchar (50) not null,
    email varchar (50) not null,
	constraint fkscheduleID foreign key (scheduleID) REFERENCES schedule(scheduleID),
    constraint fkfingerprint foreign key (fingerprintID) REFERENCES fingerprint(fingerprintID)
);

create table verifyCheck(
    verifyCheckID smallint not null identity(1,1) primary key,
    fingerprintID smallint not null, 
    checkDate date not null,
    checkTime time not null, 
    constraint fkfingerprint2 foreign key (fingerprintID) REFERENCES fingerprint(fingerprintID)
);

create table inAndOutHistory(
    inAndOutHistoryID smallint not null identity(1,1) primary key,
    userID smallint not null,
    verifyCheckID smallint not null,
    arrivingTime time not null,
    leavingTime time not null, 
    workDate date not null,
    constraint fkusers foreign key (userID) REFERENCES users(userID),
    constraint fkverifyCheck foreign key (verifyCheckID) REFERENCES verifyCheck(verifyCheckID)
);

create table administrator (
    administratorID smallint not null identity(1,1) primary key,
    admPassword varchar (100) not null,
    name varchar (50) not null,
    lastname varchar (50),
    lastname2 varchar (50),
    fullname varchar (100),
    email varchar (50) not null
);

