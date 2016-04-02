delimiter $$

-- 1:  Skrifið function NumberOfSeats() sem telur gluggasætin í ákveðinni flugvél.
--     Notandinn skaffar einkennisstafi (aircraftID) flugélarinnar

drop function if exists NumberOfSeats $$
create function NumberOfSeats(aircraft_ID char(6))
returns int(11)
begin
RETURN(SELECT COUNT(seat_ID) FROM seats WHERE aircraftID = aircraft_ID);
end $$

-- 2:  Skrifið function NumberOfPassengers() sem telur fjölda farþega(sæta sem setið var í)
--     í ákveðnu flugi. Notandinn skaffar flugnúmer og flugdag og þessi
--     function kallar í getFlightCode úr skilaverkefni 3
--     Þannig fáið þið flugkóðann sem þarf að nota til að klára verkið.
	
drop function if exists NumberOfPassengers $$
create function NumberOfPassengers(flight_number char(5),flight_date date)
returns int(6)
begin
RETURN(SELECT COUNT(bookingNumber) FROM seats WHERE flightCode = getFlightCode(flightNumber, flightDate));
end $$

-- 3:  Skrifið function SeatUsage() sem reiknar út sætisnýtingu í prósentum.
--     Þetta er gert á eftirfarandi hátt:
--     sætisnotkun = (fjöldi farþega í flugi * 100) / fjöldi sæta í viðkomandi flugi(þeirri flugvél sem flýgur)
--     Notandinn skaffar sem fyrr flugnúmer og flugdag

drop function if exists SeatUsage $$
create function SeatUsage(flight_number char(5),flight_date date)
returns int(6)
begin
RETURN((NumberOfPassengers(flight_number, flight_date)*100)/NumberOfSeats(flight_number, flight_date));
end $$

-- 4:  Skrifið function FlightRevenue() sem reiknar út heildartekjur úr ákveðnu
--     flugi.  Notandinn gefur upp flugnúmer og flugdag.

drop function if exists FlightRevenue $$
create function FlightRevenue(flight_number char(5),flight_date date)
returns char(6)
begin
RETURN(SELECT SUM(price) FROM passengers 
	WHERE flightCode = (
		SELECT flightCode FROM flights 
		WHERE flightNumber = flight_number AND flightDate = flight_date));
end $$

-- 5:  Skrifið Stored Procedure FlightEconomicInfo() sem birtir eftirfarandi upplýsingar:
--     Flugnúmer,fjölda farþega,sætisnýting,tekjur(innkoma úr viðkomandi flugi)
	delimiter $$

	drop procedure if exists FlightEconomicInfo $$

	create procedure FlightEconomicInfo(flight_number char(5),flight_date date)
	begin
	SELECT (NumberOfPassengers(flight_number,flight_date),SeatUsage(flight_number,flight_date),FlightRevenue(flight_number,flight_date))
	end
	
	-- TEST
--select NumberOfWindowSeats('TF-HAL');
--select NumberOfPassengers('FA196','2008-01-07');
--select SeatUsage('FA196','2008-01-07');
--select FlightRevenue('FA196','2008-01-07');

--call FlightEconomicInfo('FA196','2008-01-07');