CREATE TABLE 'school'(
	id int(4),
	name varchar(255)
);
CREATE TABLE 'student'(
	id int(6),
	firstn varchar(255),
	lasntn varchar(255),
	birthday date,
	start_date date,
	end_date date,
	ssid int(10)/*kennitala*/
);
CREATE TABLE 'time'(
	id int(6),
	day varchar(3),
	time_start time,
	time_end time
);
CREATE TABLE 'roles'(
	id int(1),
	name varchar(255)
)
CREATE TABLE 'teacher_degree'(
	teacher_id int(6),
	degree_name varchar(255),

);
CREATE TABLE 'cource'(
	id int(5),
	name varchar(255)
);
CREATE TABLE 'cources'(
	id int(5)
	name varchar(255)
	level int(2)
	cource_id int(5)
	CONSTRAINT 'cources_PK' PRIMARY KEY (id)
	CONSTRAINT 'cources_ref_cource' FOREIGN KEY REFERENCES cource(id)
);
CREATE TABLE 'teacher'(
	id int(6),
	
)