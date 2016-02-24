CREATE TABLE IF NOT EXISTS users(
	id int(11),
	username varchar(255),
	password varchar(255)
);
CREATE TABLE IF NOT EXISTS currency(
	id int(11),
	name varchar(255),
	converionToBase decimal(11),
	convertionFromBase decimal(11)
);
CREATE TABLE IF NOT EXISTS types(
	id int(11),
	name varchar(255),
	more varchar(512)
);
CREATE TABLE IF NOT EXISTS spending(
	id int(11),
	user_id int(11),
	amount decimal(11),
	currency int(11),
	day date,
	type int(11),
	more varchar(512),
	normalCurrency int(11),
	CONSTRAINT currency_ref FOREIGN KEY currency REFERENCES currency(id),
	CONSTRAINT user_ref FOREIGN KEY user_id REFERENCES users(id),
	CONSTRAINT type_ref FOREIGN KEY type REFERENCES types(id)
);
CREATE TABLE IF NOT EXISTS spending
(
	id int(11),
	user_id int(11) REFERENCES users(id),
	amount decimal(11),
	currency int(11) REFERENCES currency(id),
	day date,
	type int(11) REFERENCES types(id),
	more varchar(512),
	normalCurrency int(11)
);