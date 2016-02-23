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

create procedure newAircraft( /* Færibreytur hér */ )
begin
    -- Kóði hér
end $$

-- 3
-- Skrifið Stored Procedure sem birtir upplýsingar um öll sæti á ákveðinni flugvél
-- einkennisnnúmer(aircraftID) er sent sem færibreyta
drop procedure if exists AircraftSeats $$

create procedure AircraftSeats( /* Færibreytan hér */ )
begin
    -- Kóði hér
end $$

-- 4
-- Skrifið Stored Procedure sem sækir öll bókunarnúmer úr ákveðnu flugi.
-- gefa skal upp flugnúmer(flight number) og flugdag(flightDate)
drop procedure if exists FlightBookingNumbers $$

create procedure FlightBookingNumbers( /* Færibreytur hér */  )
begin
	-- Kóði hér
end $$

-- 5
-- Skrifið Stored Procedure sem birtir flugáætlanir.
-- Birtið flugnúmer,vikudag,brottfararstað(origin),áfangastað(destination)


-- 6
-- Skrifið function sem sækir flugkóðann(flightCode) fyrir ákveðið flug á ákveðnum degi.
-- Sendið flugnúmerið og flugdaginn inn sem færibreytur
-- ATH:Flugkóði er ekki það sama og flugNúmer heldur er um að ræða (frum)lykil að gögnum um flugið sjálft.
drop function if exists getFlightCode $$
create function getFlightCode(flight_number char(5),flight_date date)
returns int
begin

end $$

-- 7
-- Skrifið function sem sækir einkennisstafi þeirrar flugvélar sem flýgur ákveðið flug(leið).
-- Sendið flugnúmerið og flugdaginn inn sem færibreytur
drop function if exists getAircraftID $$

create function getAircraftID(flight_number char(5),flight_date date)
returns char(6)
begin

end $$

-- 8
-- Skrifið Stored Procedure sem sækir nöfn og sæti allra farþega í ákveðnu flugi.
-- Sendið flugnúmerið og flugdaginn inn sem færibreytur
-- Notið concat() fallið til að birta sætin á forminu NúmerBókstafur ( t.d: 3A)
-- ATH: Hér þarf líklega að nota fjórar töflur, Flights,Booking,Passengers,Seats


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