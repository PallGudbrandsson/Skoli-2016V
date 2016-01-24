CREATE TABLE IF NOT EXISTS school(
	id int(4),
	name varchar(255),
	CONSTRAINT school_PK PRIMARY KEY (id)
);
CREATE TABLE IF NOT EXISTS student(
	id int(6),
	firstn varchar(255),
	lasntn varchar(255),
	birthday date,
	start_date date,
	end_date date,
	ssid int(10),/*kennitala*/
	CONSTRAINT student_PK PRIMARY KEY(id)
);
CREATE TABLE IF NOT EXISTS time(
	id int(6),
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
	id int(6),
	firstn varchar(255),
	lasntn varchar(255),
	short char(3),
	email varchar(255),
	school_id int(4),
	CONSTRAINT teacher_PK PRIMARY KEY (id),
	CONSTRAINT teacher_ref_school FOREIGN KEY (school_id) REFERENCES school(id)
);
CREATE TABLE IF NOT EXISTS teacher_degree(
	id int(3),
	teacher_id int(6),
	degree_name varchar(255),
	CONSTRAINT teacher_degree_pk PRIMARY KEY(id),
	CONSTRAINT degree_ref_teacher FOREIGN KEY (teacher_id) REFERENCES teacher(id)
);
CREATE TABLE IF NOT EXISTS cource(
	id int(5),
	name varchar(255),
	CONSTRAINT cource_PK PRIMARY KEY(id)
);
CREATE TABLE IF NOT EXISTS cources(
	id int(5),
	name varchar(255),
	level int(2),
	cource_id int(5),
	CONSTRAINT cources_PK PRIMARY KEY (id),
	CONSTRAINT cources_ref_cource FOREIGN KEY (cource_id) REFERENCES cource(id)
);
CREATE TABLE IF NOT EXISTS class(
	id int(5),
	name varchar(75),
	cource_id int(5),
	school_id int(4),
	semester char(5),
	CONSTRAINT class_PK PRIMARY KEY (id),
	CONSTRAINT class_ref_school FOREIGN KEY (school_id) REFERENCES school(id),
	CONSTRAINT class_ref_cource FOREIGN KEY (cource_id) REFERENCES cources(id)
);
CREATE TABLE IF NOT EXISTS class_time_log(
	id int(5),
	class_id int(5),
	time_id int(6),
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
	id int(11),
	class_id int(6),
	due datetime,
	teacher_id int(5),
	CONSTRAINT assignment_PK PRIMARY KEY (id),
	CONSTRAINT assignment_ref_class FOREIGN KEY (class_id) REFERENCES class(id),
	CONSTRAINT assignment_ref_teacher FOREIGN KEY (teacher_id) REFERENCES teacher(id)
);
CREATE TABLE IF NOT EXISTS assignment_submit(
	id int(15),
	assignment_id int(15),
	student_id int(5),
	description longtext,
	file varchar(255),
	CONSTRAINT assignment_submit_PK PRIMARY KEY (id),
	CONSTRAINT assignment_submit_ref_student FOREIGN KEY (student_id) REFERENCES student(id),
	CONSTRAINT assignment_submit_ref_assignment FOREIGN KEY (assignment_id) REFERENCES assignment(id)
);
CREATE TABLE IF NOT EXISTS student_in_class(
	id int (8),
	student_id int(6),
	class_id int(5),
	semester char(5),
	log_time datetime,
	log_staff int(6),
	final_grade int(3),
	passed bool,
	CONSTRAINT student_in_class_PK PRIMARY KEY (id),
	CONSTRAINT student_in_class_ref_student FOREIGN KEY (student_id) REFERENCES student(id),
	CONSTRAINT student_in_class_ref_class FOREIGN KEY (class_id) REFERENCES class(id)
);