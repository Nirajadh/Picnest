use imgdatabase

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    Username NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL

);

INSERT INTO Users (Name, Username, Password) VALUES ('John Doe', 'john_doe', 'password123');
INSERT INTO Users (Name, Username, Password) VALUES ('Jane Smith', 'jane_smith', 'pass123');
INSERT INTO Users (Name, Username, Password) VALUES ('Alice Johnson', 'alice_johnson', 'qwerty');
select * from users




CREATE TABLE UserUploads (
    UploadID INT PRIMARY KEY IDENTITY,
    UserID INT NOT NULL,
    ImageData VARBINARY(MAX),
    Caption NVARCHAR(255) null,
    UploadDate DATETIME,
    CONSTRAINT FK_UserUploads_Users FOREIGN KEY (UserID) REFERENCES Users(UserID) on delete cascade;

);
select *from useruploads
truncate table users 
alter table UserUploads add constraint PFK_UserUploads_Users FOREIGN KEY (UserID) REFERENCES Users(UserID) on delete cascade;
alter table UserUploads drop constraint PFK_UserUploads_Users ;
ALTER TABLE UserUploads ADD Likes INT DEFAULT 0 not null;
alter table useruploads
drop  column likes ;

CREATE TABLE Liked (

UserID INT NOT NULL,
 UploadID INT not null,

  PRIMARY KEY (UserID, UploadID)
);
drop table liked

CREATE TABLE Comments (
    CommentID INT PRIMARY KEY IDENTITY,
    UploadID INT FOREIGN KEY REFERENCES UserUploads(UploadID),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    CommentText NVARCHAR(MAX),
    CommentDate DATETIME DEFAULT GETDATE() 
);


	DELETE FROM Liked WHERE UserID=3 AND UploadID=5

	DELETE FROM Liked WHERE UploadID= 5
	select * from Liked


	SELECT UploadID, ImageData, Caption, UploadDate, (SELECT Username FROM Users WHERE UserID = UserUploads.UserID)  AS Username FROM UserUploads where Username <> 'Nirajadh'  ORDER BY UploadID DESC