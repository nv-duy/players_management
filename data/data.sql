create database players_management

use players_management

CREATE TABLE Clubs
(
    ClubID INT PRIMARY KEY IDENTITY,
    ClubName NVARCHAR(100),
    Budget FLOAT
)

CREATE TABLE Players
(
    PlayerID INT PRIMARY KEY IDENTITY,
    PlayerName NVARCHAR(100),
    Nationality NVARCHAR(50),
    Position NVARCHAR(30),
    Price FLOAT,

    ClubID INT,

    FOREIGN KEY (ClubID)
    REFERENCES Clubs(ClubID)
)

CREATE TABLE Coaches
(
    CoachID INT PRIMARY KEY IDENTITY,
    CoachName NVARCHAR(100),
    Nationality NVARCHAR(50),

    ClubID INT,

    FOREIGN KEY (ClubID)
    REFERENCES Clubs(ClubID)
)

CREATE TABLE Contracts
(
    ContractID INT PRIMARY KEY IDENTITY,

    PlayerID INT,
    CoachID INT,
    ClubID INT,

    Salary FLOAT,
    StartDate DATE,
    EndDate DATE,

    FOREIGN KEY (PlayerID)
    REFERENCES Players(PlayerID),

    FOREIGN KEY (CoachID)
    REFERENCES Coaches(CoachID),

    FOREIGN KEY (ClubID)
    REFERENCES Clubs(ClubID)
)

INSERT INTO Clubs(ClubName, Budget)
VALUES
('Barcelona', 1000000),
('Real Madrid', 2000000)

INSERT INTO Players
(PlayerName, Nationality, Position, Price, ClubID)
VALUES
('Messi', 'Argentina', 'RW', 1000, 1),
('Ronaldo', 'Portugal', 'ST', 900, 2)

INSERT INTO Coaches
(CoachName, Nationality, ClubID)
VALUES
('Xavi', 'Spain', 1),
('Ancelotti', 'Italy', 2)
