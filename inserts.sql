-- Создание таблицы Airports для хранения информации об аэропортах
CREATE TABLE Airports (
                          Id INTEGER PRIMARY KEY AUTOINCREMENT,
                          City TEXT NOT NULL,
                          Name TEXT NOT NULL,
                          Code TEXT NOT NULL
);

-- Создание таблицы "Planes" для хранения информации о самолетах
CREATE TABLE Planes (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Model TEXT NOT NULL,
                        Capacity INTEGER NOT NULL
);
-- Создание таблицы "Passengers" для хранения информации о пассажирах
CREATE TABLE Passengers (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            FirstName TEXT NOT NULL,
                            LastName TEXT NOT NULL,
                            MiddleName TEXT NOT NULL,
                            DateOfBirth DATE NOT NULL,
                            PassportNumber INTEGER NOT NULL
);

-- Создание таблицы "Tickets" для хранения информации о билетах
CREATE TABLE Tickets (
                         Id INTEGER PRIMARY KEY AUTOINCREMENT,
                         FlightID INTEGER,
                         PassengerID INTEGER,
                         RowNumber INTEGER NOT NULL,
                         SeatID INTEGER NOT NULL,                         
                         FOREIGN KEY (FlightID) REFERENCES Flights(Id),
                         FOREIGN KEY (PassengerID) REFERENCES Passengers(Id),
                         FOREIGN KEY (SeatID) REFERENCES SeatsCategories(Id)
);

CREATE TABLE SeatsCategories (
                                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                 NameSeat TEXT NOT NULL ,
                                 Price REAL NOT NULL
);

-- Создание таблицы "Flights" для хранения информации о рейсах
CREATE TABLE Flights (
                         Id INTEGER PRIMARY KEY AUTOINCREMENT,
                         PlaneID INTEGER,
                         DepartureAirportID INTEGER,
                         ArrivalAirportID INTEGER,
                         DepartureTime DATETIME NOT NULL,
                         ArrivalTime DATETIME NOT NULL,
                         Price REAL,
                         FOREIGN KEY (DepartureAirportID) REFERENCES Airports(Id),
                         FOREIGN KEY (ArrivalAirportID) REFERENCES Airports(Id),
                         FOREIGN KEY (PlaneID) REFERENCES Planes(Id)
);

INSERT INTO Airports (City, Name, Code)
VALUES
    ('Казань', 'Казань', 'KZN'),
    ('Москва', 'Домодедово', 'DME'),
    ('Москва', 'Шереметьево', 'SVX'),
    ('Москва', 'Внуково', 'VKO'),
    ('Санкт-Петербург', 'Пулково', 'LED'),
    ('Екатеринбург', 'Кольцово', 'SVX'),
    ('Новосибирск', 'Толмачево', 'OVB'),
    ('Сочи', 'Адлер', 'AER'),
    ('Анапа', 'Витязево', 'AAQ'),
    ('Геленджик', 'Геленджик', 'GDZ'),
    ('Уфа', 'Уфа', 'UFA'),
    ('Самара', 'Курумоч', 'KUF'),
    ('Ростов-на-Дону', 'Платов', 'ROV'),
    ('Калининград', 'Храброво', 'KGD');

INSERT INTO Planes (Model, Capacity)
VALUES
    ('Airbus A320', 150),
    ('Boeing 737-800', 160),
    ('Boeing 777-300', 400),
    ('Sukhoi Superjet 100', 98),
    ('Airbus A321', 220),
    ('Airbus A330', 260),
    ('Boeing 787 Dreamliner', 330),
    ('Boeing 747-8', 500),
    ('Antonov An-148', 85),
    ('Ilyushin Il-96', 375);

INSERT INTO Passengers (FirstName, LastName, MiddleName, DateOfBirth, PassportNumber)
VALUES
    ('Иван', 'Иванов', 'Иванович', '1980-01-01', 8017123456),
    ('Петр', 'Петров', 'Петрович', '1985-03-15', 8017234567),
    ('Семен', 'Семенов', 'Семенович', '1990-05-20', 9223345678),
    ('Анна', 'Иванова', 'Петровна', '1995-07-25', 9223456789),
    ('Ольга', 'Сидорова', 'Андреевна', '1992-09-12', 9220567890),
    ('Наталья', 'Попова', 'Сергеевна', '1988-11-03', 9223678901),
    ('Мария', 'Соколова', 'Алексеевна', '1993-02-14', 9223789012),
    ('Татьяна', 'Лебедева', 'Викторовна', '1997-06-22', 9223890123),
    ('Полина', 'Кузнецова', 'Петровна', '1999-08-14', 9223901834),
    ('Надежда', 'Кузнецова', 'Арсеньевна', '1999-04-17', 9223904434),
    ('Алла', 'Кузнецова', 'Платонова', '1999-08-13', 9223901232),
    ('Полина', 'Кузнецова', 'Павловна', '1999-08-16', 9223901877),
    ('Надежда', 'Сидорова', 'Арсеньевна', '1999-05-18', 9223966434),
    ('Кристина', 'Сидорова', 'Арсеньевна', '1999-07-19', 9223901266),
    ('Алия', 'Кузнецова', 'Маратовна', '1999-05-17', 9223901231),
    ('Налалья', 'Кузнецова', 'Игоревна', '1999-11-11', 9223901230),
    ('Виктория', 'Новикова', 'Павловна', '2001-12-29', 9223123456),
    ('Алина', 'Новикова', 'Андреевна', '1999-07-17', 9223881234),
    ('Мария', 'Горбачева', 'Павловна', '1988-02-28', 8017000321),
    ('Алексей', 'Федоров', 'Николаевич', '1993-04-05', 8017005432),
    ('Елена', 'Смирнова', 'Владимировна', '1991-11-14', 8017005343),
    ('Никита', 'Кузнецов', 'Алексеевич', '1997-09-23', 8017006543),
    ('Анастасия', 'Попова', 'Сергеевна', '1996-06-30', 8017019283),
    ('Игорь', 'Кожин', 'Евгеньевич', '1987-12-24', 8017043921),
    ('Татьяна', 'Сидорова', 'Ивановна', '1989-03-02', 8017067439),
    ('Роман', 'Орлов', 'Викторович', '1994-10-19', 8017095432),
    ('Олег', 'Соколов', 'Михайлович', '1998-01-12', 8017106577),
    ('Виктория', 'Лазарева', 'Александровна', '1990-08-04', 8017126532),
    ('Татьяна', 'Новикова', 'Андреевна', '2000-12-29', 9223093456),
    ('Дмитрий', 'Волков', 'Сергеевич', '1985-07-08', 8017132123),
    ('Кирилл', 'Новиков', 'Петрович', '1983-12-03', 8017165432),
    ('Ярослав', 'Морозов', 'Иванович', '1992-02-14', 8017176543),
    ('Юлия', 'Ершова', 'Викторовна', '1988-10-21', 8017199283),
    ('Артем', 'Степанов', 'Алексеевич', '1987-06-17', 8017213921),
    ('Светлана', 'Литвинова', 'Семеновна', '1994-01-05', 8017227437),
    ('Владимир', 'Соловьев', 'Егорович', '1996-12-24', 8017234432),
    ('Надежда', 'Филиппова', 'Васильевна', '1997-03-15', 8017247577),
    ('Людмила', 'Куликова', 'Денисовна', '1991-09-04', 8017251432),
    ('Андрей', 'Комаров', 'Максимович', '1989-11-12', 8017266543);

INSERT INTO Flights (PlaneID, DepartureAirportID, ArrivalAirportID, DepartureTime, ArrivalTime, Price)
VALUES
    (1, 1, 2, '2023-06-01 12:00:00', '2023-06-01 15:00:00', 1000),
    (2, 1, 10, '2023-06-05 18:00:00', '2023-06-05 21:00:00', 1000),
    (3, 1, 5, '2023-07-20 09:00:00', '2023-07-20 12:30:00', 1000),
    (5, 1, 7, '2023-08-14 16:45:00', '2023-08-14 19:15:00', 1000),
    (9, 1, 6, '2023-09-23 11:15:00', '2023-09-23 13:45:00', 1000),
    (7, 1, 9, '2023-10-31 09:30:00', '2023-10-31 13:15:00', 1000),
    (4, 1, 2, '2023-12-10 21:00:00', '2023-12-11 00:25:00', 1000),
    (10, 1, 3, '2024-01-15 14:50:00', '2024-01-15 17:35:00', 1000),
    (6, 1, 4, '2024-02-28 12:35:00', '2024-02-28 16:10:00', 1000),
    (8, 1, 10, '2024-03-29 06:20:00', '2024-03-29 10:55:00', 1000);

INSERT INTO SeatsCategories (NameSeat, Price) VALUES ('A', 400),
                                                     ('B', 250),
                                                     ('C', 300),
                                                     ('D', 300),
                                                     ('E', 250),
                                                     ('F', 400);

INSERT INTO Tickets (FlightID, PassengerID, RowNumber, SeatID)
VALUES
    (1, 1, 1, 1),
    (1, 11, 1, 2),
    (1, 12, 1, 4),
    (1, 13, 2, 5),
    (1, 14, 2, 6),
    (1, 15, 2, 2),
    (1, 16, 2, 1),
    (1, 17, 2, 3),
    (1, 18, 3, 2),
    (1, 19, 3, 5),
    (1, 20, 3, 6),
    (1, 21, 3, 4),
    (2, 2, 1, 1),
    (2, 22, 1, 2),
    (2, 23, 1, 3),
    (2, 24, 2, 1),
    (3, 3, 2, 2),
    (4, 4, 18, 4),
    (5, 5, 12, 2),
    (6, 6, 12, 1),
    (7, 7, 1, 3),
    (8, 8, 4, 3),
    (9, 9, 4, 6),
    (10, 10, 2, 6);


SELECT Flights.Id, A1.City || ' (' || A1.Code || ')' AS DepartureAirport,
       A2.City || ' (' || A2.Code || ')' AS ArrivalAirport, DepartureTime, ArrivalTime, Capacity
       FROM Flights
JOIN Airports A2 on A2.Id = Flights.ArrivalAirportID
JOIN Airports A1 on A1.Id = Flights.DepartureAirportID
JOIN Planes P on P.Id = Flights.PlaneID
;


SELECT id, City || ' - ' || Name || ' (' || Code || ')' AS airport FROM Airports;

SELECT Tickets.Id, FlightID, A1.City || ' (' || A1.Code || ')' AS DepartureAirport, 
       A2.City || ' (' || A2.Code || ')' AS ArrivalAirport, F.DepartureTime, F.ArrivalTime,
       RowNumber || SC.NameSeat AS seat, (F.Price + SC.Price) AS TotalPrice, p2.Model, PassengerID, SeatID FROM Tickets
JOIN Passengers P on P.Id = Tickets.PassengerID
JOIN Flights F on F.Id = Tickets.FlightID
JOIN Airports A1 on A1.Id = F.DepartureAirportID
JOIN Airports A2 on A2.Id = F.ArrivalAirportID
JOIN Planes P2 on P2.Id = F.PlaneID
JOIN SeatsCategories SC on SC.Id = Tickets.SeatID;

SELECT * FROM Tickets
JOIN SeatsCategories SC on SC.Id = Tickets.SeatID;

SELECT SeatsCategories.Id, NameSeat FROM SeatsCategories
JOIN Tickets T on SeatsCategories.Id = T.SeatID
WHERE RowNumber = 1 AND FlightID = 1;

SELECT SC.Id, SC.NameSeat FROM SeatsCategories SC
LEFT JOIN Tickets T ON SC.Id = T.SeatID
WHERE T.Id IS NULL OR (T.RowNumber = @RowNumber AND T.FlightID = @FlightID);

SELECT SC.Id, SC.NameSeat FROM SeatsCategories SC
LEFT JOIN Tickets T ON SC.Id = T.SeatID AND T.RowNumber = @RowNumber AND T.FlightID = @FlightID
WHERE T.Id IS NULL;

SELECT Flights.Id, A1.City || ' (' || A1.Code || ')' AS DepartureAirport,
       A2.City || ' (' || A2.Code || ')' AS ArrivalAirport, DepartureTime, ArrivalTime, Capacity
FROM Flights
         JOIN Airports A2 ON A2.Id = Flights.ArrivalAirportID
         JOIN Airports A1 ON A1.Id = Flights.DepartureAirportID
         JOIN Planes P ON P.Id = Flights.PlaneID
WHERE NOT EXISTS (
    SELECT 1
    FROM Tickets T
    WHERE T.FlightID = Flights.Id AND T.PassengerID = @PassengerID
);

SELECT
        P.FirstName || ' ' || P.LastName || ' ' || P.MiddleName AS PassengerName,
        P.PassportNumber,
        A1.Code AS DepartureAirportCode,
        A1.City AS DepartureCity,
        A2.Code AS ArrivalAirportCode,
        A2.City AS ArrivalCity,
        F.DepartureTime,
        strftime('%Y-%m-%d %H:%M:%S', datetime(F.DepartureTime, '-20 minutes')) AS AdjustedDepartureTime,
        RowNumber || SC.NameSeat AS SeatName,
        P2.Model AS PlaneModel,
        F.Id AS FlightID,
        T.Id AS TicketID
FROM Tickets T
         JOIN Passengers P ON P.Id = T.PassengerID
         JOIN Flights F ON F.Id = T.FlightID
         JOIN Airports A1 ON A1.Id = F.DepartureAirportID
         JOIN Airports A2 ON A2.Id = F.ArrivalAirportID
         JOIN Planes P2 ON P2.Id = F.PlaneID
         JOIN SeatsCategories SC ON SC.Id = T.SeatID;

