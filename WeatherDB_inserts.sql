USE WeatherDB
INSERT INTO DbUserType (TypeName) VALUES
	('standardUser'),
	('admin');
INSERT INTO DbUser (TypeOfUser, UserPassword, UserLogin) VALUES
	(1, 'user', 'user'),
	(2, 'admin', 'admin');
INSERT INTO City(CityName) VALUES
	('Warsaw'),
	('London');
INSERT INTO WeatherHistory(City, Temperature, Pressure, Humidity, WindSpeed, WeatherDate) VALUES
	(1,14.3, 1000, 4, 12.2, '2019-05-11 08:00:00'),
	(1,14.8, 1001, 5, 1.2, '2019-05-12 08:00:00'),
	(2,16.7, 1002, 4, 3.3, '2019-05-11 08:00:00'),
	(2,17.1, 1001, 3, 5.2, '2019-05-12 08:00:00');