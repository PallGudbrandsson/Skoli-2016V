delimiter $$
-- 1
-- Skrifið Stored Procedure sem skilar upplýsingum um ákveðna bókun.
-- Sýna þarf eftirfarandi: flightNumber,bookingNumber,flightDate,cardholdersName
-- Notandinn sendir bókunarnúmerið(bookingNumber) sem færibreytu.
drop procedure if exists BookingInfo $$

create procedure BookingInfo(booking_number int)
begin
    SELECT flightschedule.flightNumber, booking.bookingNumber, flights.flightDate, booking.cardholdersName
    FROM booking
    JOIN Flights ON booking.flightCode = flights.flightCode
    JOIN flightschedule ON flights.flightNumber = flightschedule.flightNumber
    WHERE booking.bookingNumber = booking_number
end $$

-- 2
-- Skrifið Stored Procedure sem nýskráir flugvél í FreshAir gagnagrunninn.
-- Hafið í huga að upplýsingar um flugvélar eru í tveim töflum: Aircrafts og Aircrafttypes.
-- Upplýsingar um sæti í hverri flugvél eru svo geymdar í töflunni Seats en ekki þarf að skrá þau hér.
-- Skráið Embraer ERJ 145 flugvél í grunninn.  Info:  https://en.wikipedia.org/wiki/Embraer_ERJ_145_family
drop procedure if exists NewAircraft $$

create procedure newAircraft(int id, varchar classConfig, date startOfService)
begin
    INSERT INTO aircrafts (aircraftID, classConfiguration, serviceEntry,aircraftType)
    VALUES (id, classConfig, startOfService, 1);
end $$

-- 3
-- Skrifið Stored Procedure sem birtir upplýsingar um öll sæti á ákveðinni flugvél
-- einkennisnnúmer(aircraftID) er sent sem færibreyta
drop procedure if exists AircraftSeats $$

create procedure AircraftSeats( varchar id )
begin
    SELECT * FROM seats WHERE aircraftID = id
end $$

-- 4
-- Skrifið Stored Procedure sem sækir öll bókunarnúmer úr ákveðnu flugi.
-- gefa skal upp flugnúmer(flight number) og flugdag(flightDate)
drop procedure if exists FlightBookingNumbers $$

create procedure FlightBookingNumbers(int code)
begin
	SELECT bookingNumber FROM booking WHERE flightCode = code 
end $$

-- 5
-- Skrifið Stored Procedure sem birtir flugáætlanir.
-- Birtið flugnúmer,vikudag,brottfararstað(origin),áfangastað(destination)
drop procedure if exists FlightPlans $$

create procedure FlightPlans(int flight_number)
begin
	SELECT flightschedule.flightNumber, flightschedule.weekday, O.orgin, D.destination FROM flightschedule
	INNER JOIN places O ON flightschedule.orgin = places.placeID
	INNER JOIN places D ON flightschedule.destination = places.placeID
	WHERE flightNumber = flight_number
end $$

-- 6
-- Skrifið function sem sækir flugkóðann(flightCode) fyrir ákveðið flug á ákveðnum degi.
-- Sendið flugnúmerið og flugdaginn inn sem færibreytur
-- ATH:Flugkóði er ekki það sama og flugNúmer heldur er um að ræða (frum)lykil að gögnum um flugið sjálft.
drop function if exists getFlightCode $$
create function getFlightCode(flight_number char(5),flight_date date)
returns char(6)
begin
SELECT flightCode FROM flights 
WHERE flightNumber = flightNumber AND flightDate = flight_date
end $$

-- 7
-- Skrifið function sem sækir einkennisstafi þeirrar flugvélar sem flýgur ákveðið flug(leið).
-- Sendið flugnúmerið og flugdaginn inn sem færibreytur
drop function if exists getAircraftID $$

create function getAircraftID(flight_number char(5),flight_date date)
returns char(6)
begin
SELECT aircraftID FROM flights 
WHERE flightNumber = flight_number AND flightDate = flight_date
end $$

-- 8
-- Skrifið Stored Procedure sem sækir nöfn og sæti allra farþega í ákveðnu flugi.
-- Sendið flugnúmerið og flugdaginn inn sem færibreytur
-- Notið concat() fallið til að birta sætin á forminu NúmerBókstafur ( t.d: 3A)
-- ATH: Hér þarf líklega að nota fjórar töflur, Flights,Booking,Passengers,Seats
drop procedure if exists PassengerInfo $$
create procedure PassengerInfo(flight_number char(5), flight_date date)
begin
	SELECT Passengers.PassengerName, concat(seats.rowNumber, ':', seats.seatNumber) FROM flights
	JOIN aircrafts ON flights.aircraftID = aircrafts.aircraftID
	JOIN seats ON Aircrafts.aircraftID = Seats.aircraftID
	JOIN Passengers ON Seats.seatID = Passengers.seatingID
	WHERE Flights.flightNumber = flight_number AND flights.flightDate = cflight_date
end

-- 9
-- Skrifið function,iceDate sem tekur inn dagsetningu(date) á SQL forminu 'ÁÁÁÁ-MM-DD'
-- og skilar streng með íslenskri dagsetningu 'DD-MM-ÁÁÁÁ'.
-- Hérna skuluð þið nota innbyggða fallið date_format til aðstoðar


-- 10
-- eftirfarandi SQL kóði telur hversu oft hefur verið setið í ákveðnum sætum fyrir
-- allar flugferðir:
--     select seatID,count(seatingID)
--     from Seating
--     group by seatID;
--
-- Skrifið Stored Procedure sem hjúpar þessa virkni en bætið við, þannig að sætið
-- sé á forminu NúmerBókstafur t.d: 1A og að auðkenni flugvélarinnar komi líka pr. sæti.
-- Dæmi:  TF-HAL 1A 29 delimiter $$