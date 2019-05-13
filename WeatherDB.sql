USE master
DROP DATABASE WeatherDB
CREATE DATABASE WeatherDB
GO
USE WeatherDB
--users layer--
CREATE TABLE DbUser(
Userid INT PRIMARY KEY IDENTITY(1,1),
TypeOfUser INT,
UserPassword NVARCHAR(20),
UserLogin NVARCHAR(20)
)
CREATE TABLE DbUserType(
Typeid INT PRIMARY KEY IDENTITY(1,1),
TypeName NVARCHAR(20)
)
--FOREIGN KEYS--
ALTER TABLE DbUser ADD CONSTRAINT FkDbUserType FOREIGN KEY (TypeOfUser) REFERENCES DbUserType(Typeid); 
--check weather layer--
CREATE TABLE City(
Cityid INT PRIMARY KEY IDENTITY(1,1),
CityName NVARCHAR(50)
)
CREATE TABLE WeatherHistory(
Historyid INT PRIMARY KEY IDENTITY(1,1),
city INT,
Temperature FLOAT,
Pressure FLOAT,
Humidity FLOAT,
WindSpeed FLOAT,
WeatherDate DATETIME
)
--FOREIGN KEYS--
ALTER TABLE WeatherHistory ADD CONSTRAINT FkCity FOREIGN KEY (city) REFERENCES City(Cityid);
--VIEWS--
GO
CREATE VIEW vWeatherHistory
AS
SELECT WeatherHistory.Historyid, City.CityName, WeatherHistory.Temperature, WeatherHistory.Pressure,
		WeatherHistory.Humidity, WeatherHistory.WindSpeed,	WeatherHistory.WeatherDate
FROM WeatherHistory
JOIN City
ON WeatherHistory.city=City.Cityid
GO
CREATE VIEW vUsers
AS
SELECT DbUser.Userid, DbUserType.TypeName, DbUser.UserLogin, DbUser.UserPassword
FROM DbUser
JOIN DbUserType 
ON DbUser.TypeOfUser = DbUserType.Typeid
GO
