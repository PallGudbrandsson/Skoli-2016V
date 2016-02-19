DROP DATABASE IF EXISTS 2410982069_gsf_verk_1;
CREATE DATABASE 2410982069_gsf_verk_1;
USE 2410982069_gsf_verk_1;


CREATE TABLE IF NOT EXISTS school(
	id int(4) AUTO_INCREMENT,
	name varchar(255),
	CONSTRAINT school_PK PRIMARY KEY (id)
);
CREATE TABLE IF NOT EXISTS student(
	id int(6) AUTO_INCREMENT,
	firstn varchar(255),
	lastn varchar(255),
	birthday date,
	start_date date,
	end_date date,
	ssid int(10),/*kennitala*/
	CONSTRAINT student_PK PRIMARY KEY(id)
);
CREATE TABLE IF NOT EXISTS time(
	id int(6) AUTO_INCREMENT,
	day varchar(3),
	time_start time,
	time_end time,
	CONSTRAINT time_PK PRIMARY KEY(id)
);
CREATE TABLE IF NOT EXISTS roles(
	id int(1),
	name varchar(255),
	CONSTRAINT roles_pk PRIMARY KEY(id)
);
CREATE TABLE IF NOT EXISTS teacher(
	id int(6) AUTO_INCREMENT,
	firstn varchar(255),
	lastn varchar(255),
	short char(3),
	email varchar(255),
	school_id int(4),
	CONSTRAINT teacher_PK PRIMARY KEY (id),
	CONSTRAINT teacher_ref_school FOREIGN KEY (school_id) REFERENCES school(id)
);
CREATE TABLE IF NOT EXISTS teacher_degree(
	id int(3) AUTO_INCREMENT,
	teacher_id int(6),
	degree_name varchar(255),
	CONSTRAINT teacher_degree_pk PRIMARY KEY(id),
	CONSTRAINT degree_ref_teacher FOREIGN KEY (teacher_id) REFERENCES teacher(id)
);
CREATE TABLE IF NOT EXISTS cource(
	id int(11) AUTO_INCREMENT,
	nr varchar(255),
	school_id int(4),
	units int(11),
	CONSTRAINT cource_PK PRIMARY KEY(id),
	CONSTRAINT cource_ref_school FOREIGN KEY (school_id) REFERENCES school(id)
);
CREATE TABLE IF NOT EXISTS class(
	id int(5) AUTO_INCREMENT,
	name varchar(75),
	cource_id varchar(255),
	semester char(5),
	CONSTRAINT class_PK PRIMARY KEY (id)
);
CREATE TABLE IF NOT EXISTS class_time_log(
	id int(5) AUTO_INCREMENT,
	class_id int(5),
	time_id int(6),	
	day varchar(3),
	CONSTRAINT time_log_PK PRIMARY KEY (id),
	CONSTRAINT time_log_ref_time FOREIGN KEY (time_id) REFERENCES time(id),
	CONSTRAINT time_log_ref_cource FOREIGN KEY (class_id) REFERENCES class(id)
);
CREATE TABLE IF NOT EXISTS teaching(
	teacher_id int(6),
	class_id int(5),
	role int(1),
	CONSTRAINT teaching_PK PRIMARY KEY (teacher_id),
	CONSTRAINT teaching_ref_teacher FOREIGN KEY (teacher_id) REFERENCES teacher(id),
	CONSTRAINT teaching_ref_class FOREIGN KEY (class_id) REFERENCES class(id),
	CONSTRAINT teaching_ref_role FOREIGN KEY (role) REFERENCES roles(id)
);
CREATE TABLE IF NOT EXISTS assignment(
	id int(11) AUTO_INCREMENT,
	class_id int(6),
	due datetime,
	teacher_id int(5),
	CONSTRAINT assignment_PK PRIMARY KEY (id),
	CONSTRAINT assignment_ref_class FOREIGN KEY (class_id) REFERENCES class(id),
	CONSTRAINT assignment_ref_teacher FOREIGN KEY (teacher_id) REFERENCES teacher(id)
);
CREATE TABLE IF NOT EXISTS assignment_submit(
	id int(15) AUTO_INCREMENT,
	assignment_id int(15),
	student_id int(5),
	description longtext,
	file varchar(255),
	CONSTRAINT assignment_submit_PK PRIMARY KEY (id),
	CONSTRAINT assignment_submit_ref_student FOREIGN KEY (student_id) REFERENCES student(id),
	CONSTRAINT assignment_submit_ref_assignment FOREIGN KEY (assignment_id) REFERENCES assignment(id)
);
CREATE TABLE IF NOT EXISTS student_in_class(
	id int (8) AUTO_INCREMENT,
	student_id int(6),
	class_id int(5),
	log_time datetime,
	log_staff int(6),
	final_grade int(3),
	passed bool,
	CONSTRAINT student_in_class_PK PRIMARY KEY (id),
	CONSTRAINT student_in_class_ref_student FOREIGN KEY (student_id) REFERENCES student(id),
	CONSTRAINT student_in_class_ref_class FOREIGN KEY (class_id) REFERENCES class(id)
);






INSERT INTO school (name) VALUES ("Upplýsingatækniskólinn");

INSERT INTO teacher(firstn, lastn, short, email, school_id) VALUES ("Dóra", "Gunnarsdóttir", "DG", "dora@tskoli.is", 1);
INSERT INTO teacher(firstn, lastn, short, email, school_id) VALUES ("Heiða", "Einarsdóttir", "HE", "heida@tskoli.is", 1);

INSERT INTO teacher_degree(teacher_id, degree_name) VALUES (1, "Master of Science");
INSERT INTO teacher_degree(teacher_id, degree_name) VALUES (2, "Batchelor of Arts");

INSERT INTO cource(nr, school_id, units) VALUES ("CNA3C3U", 1, 3);
INSERT INTO cource(nr, school_id, units) VALUES ("FOR3S3U", 1, 3);

INSERT INTO student(firstn, lastn, birthday, start_date, end_date, ssid) VALUES ("Steinn", "Elísson", "1996-10-16", "2016-02-18", "2019-02-18", 1610961234);
INSERT INTO student(firstn, lastn, birthday, start_date, end_date, ssid) VALUES("Axel", "Jóhannsson", "1992-04-12", "2016-02-18", "2159-02-19", 1204921234);

INSERT INTO class (name, cource_id, semester) VALUES("Inngangur að WAN", 1, "2016H");
INSERT INTO class (name, cource_id, semester) VALUES("Forritun smátækja", 2, "2016H");

INSERT INTO student_in_class (student_id, class_id, log_time, log_staff, final_grade, passed)
VALUES (1, 1, CURDATE(), 1, 6, 1);

INSERT INTO student_in_class (student_id, class_id, log_time, log_staff, final_grade, passed)
VALUES (2, 1, CURDATE(), 1, 6, 1);
INSERT INTO student_in_class (student_id, class_id, log_time, log_staff, final_grade, passed)
VALUES (2, 2, CURDATE(), 1, 6, 1);


/*Nöfn allra nemenda sem eru ekki skráðir í áfanga*/
SELECT id FROM student
WHERE id NOT IN (SELECT student_id FROM student_in_class)
/*Velja nafn allra sem eru skráðir í CNA*/
SELECT student_id FROM student_in_class
WHERE class_id = 1
/*Heildar fjöldi áfanga sem nemandi er skráður í*/
SELECT COUNT(id) AS FjoldiAfanga FROM student_in_class
WHERE student_id = 2
/*Allir áfangar sem eru kenndir á haustönn 2016*/
SELECT name FROM class
WHERE semester = "2016H"