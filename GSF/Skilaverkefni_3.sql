delimiter $$

drop procedure if exists BookingInfo $$

create procedure BookingInfo(booking_number int)
begin
    SELECT flightschedule.flightNumber, booking.bookingNumber, flights.flightDate, booking.cardholdersName
    FROM booking
    JOIN Flights ON booking.flightCode = flights.flightCode
    JOIN flightschedule ON flights.flightNumber = flightschedule.flightNumber
    WHERE booking.bookingNumber = booking_number;
end $$



drop procedure if exists NewAircraft $$

create procedure NewAircraft(id int, classConfig varchar(25), startOfService date)
begin
    INSERT INTO aircrafts (aircraftID, classConfiguration, serviceEntry,aircraftType)
    VALUES (id, lol, lool, 1);
end $$

-- 3
drop procedure if exists AircraftSeats $$

create procedure AircraftSeats(idid varchar(6))
begin
SELECT * FROM seats WHERE aircraftID = idid;
end $$

-- 4
drop procedure if exists FlightBookingNumbers $$

create procedure FlightBookingNumbers(code int)
begin
	SELECT bookingNumber FROM booking WHERE flightCode = code;
end $$

-- 5
drop procedure if exists FlightPlans $$

create procedure FlightPlans(flight_number int)
begin
	SELECT flightschedule.flightNumber, flightschedule.weekday, O.orgin, D.destination FROM flightschedule
	INNER JOIN places O ON flightschedule.orgin = places.placeID
	INNER JOIN places D ON flightschedule.destination = places.placeID
	WHERE flightNumber = flight_number;
end $$

-- 6
drop function if exists getFlightCode $$
create function getFlightCode(flight_number char(5),flight_date date)
returns char(6)
begin
RETURN(SELECT flightCode FROM flights 
WHERE flightNumber = flightNumber AND flightDate = flight_date);
end $$

-- 7
drop function if exists getAircraftID $$

create function getAircraftID(flight_number char(5),flight_date date)
returns char(6)
begin
RETURN(SELECT aircraftID FROM flights 
WHERE flightNumber = flight_number AND flightDate = flight_date);
end $$

-- 8
drop procedure if exists PassengerInfo $$

create procedure PassengerInfo(flight_number char(5), flight_date date)
begin
	SELECT Passengers.PassengerName, concat(seats.rowNumber, ':', seats.seatNumber) FROM flights
	JOIN aircrafts ON flights.aircraftID = aircrafts.aircraftID
	JOIN seats ON Aircrafts.aircraftID = Seats.aircraftID
	JOIN Passengers ON Seats.seatID = Passengers.seatingID
	WHERE Flights.flightNumber = flight_number AND flights.flightDate = flight_date;
end $$

-- 9
drop function if exists iceDate $$

create function iceDate(flight_date date)
returns varchar(12)
begin
return (SELECT DATE_FORMAT(dateconvert,'%m-%d-%Y'));
end $$


-- 10
drop procedure if exists seatInfo $$

create procedure seatInfo(seat_id int)
begin
SELECT 	CONCAT(aircraftID,' ', rowNumber, seatNumber,' ', seatID) AS info FROM seats
WHERE seatID = seat_id;
end