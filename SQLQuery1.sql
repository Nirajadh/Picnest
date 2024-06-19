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
    CONSTRAINT FK_UserUploads_Users FOREIGN KEY (UserID) REFERENCES Users(UserID) on delete cascade

);
select *from useruploads
truncate table users
alter table UserUploads add constraint PFK_UserUploads_Users FOREIGN KEY (UserID) REFERENCES Users(UserID) on delete cascade;
alter table UserUploads drop constraint FK_UserUploads_Users ;
ALTER TABLE UserUploads ADD Likes INT DEFAULT 0;
