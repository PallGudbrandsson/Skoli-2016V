CREATE TABLE 'school'(
	id int(4),
	name varchar(255),
	CONSTRAINT 'school_PK' PRIMARY KEY (id)
);
CREATE TABLE 'student'(
	id int(6),
	firstn varchar(255),
	lasntn varchar(255),
	birthday date,
	start_date date,
	end_date date,
	ssid int(10),/*kennitala*/
	CONSTRAINT 'student_PK' PRIMARY KEY(id)
);
CREATE TABLE 'time'(
	id int(6),
	day varchar(3),
	time_start time,
	time_end time,
	CONSTRAINT 'time_PK' PRIMARY KEY(id)
);
CREATE TABLE 'roles'(
	id int(1),
	name varchar(255),
	CONSTRAINT 'roles_pk' PRIMARY KEY(id)
)
CREATE TABLE 'teacher_degree'(
	teacher_id int(6),
	degree_name varchar(255),
	CONSTRAINT 'teacher_degree_pk' PRIMARY KEY(id)
);
CREATE TABLE 'cource'(
	id int(5),
	name varchar(255),
	CONSTRAINT 'cource_PK' PRIMARY KEY(id)
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
	firstn varchar(255),
	lasntn varchar(255),
	short char(3),
	email varchar(255),
	school_id int(4),
	CONSTRAINT 'teacher_PK' PRIMARY KEY (id),
	CONSTRAINT 'teacher_ref_school' FOREIGN KEY REFERENCES school(id)
);
CREATE TABLE 'group_time_log'(
	group_id int(5),
	time_id int(3),
	CONSTRAINT 'time_log_PK' PRIMARY KEY (group_id),
	CONSTRAINT 'time_log_ref_time' FOREIGN KEY (time_id) REFERENCES time(id)
);
CREATE TABLE 'group'(
	id int(5),
	name varchar(75),
	cource_id int(5),
	school_id int(4),
	semester char(5),
	CONSTRAINT 'group_PK' PRIMARY KEY (id),
	CONSTRAINT 'group_ref_school' FOREIGN KEY (school_id) REFERENCES school(id),
	CONSTRAINT 'group_ref_cource' FOREIGN KEY (cource_id) REFERENCES cources(id)
);
CREATE TABLE 'teaching'(
	teacher_id int(6),
	group_id int(5),
	role int(1),
	CONSTRAINT 'teaching_PK' PRIMARY KEY (teacher_id)
	CONSTRAINT 'teaching_ref_teacher' FOREIGN KEY teacher_id REFERENCES teacher(id),
	CONSTRAINT 'teaching_ref_group' FOREIGN KEY group_id REFERENCES group(id)
);
CREATE TABLE 'assignment_submit'(
	id int(15),
	student_id int(5),
	description longtext,
	file varchar(255),
	CONSTRAINT 'assignment_submit_PK' PRIMARY KEY (id)
);
CREATE TABLE 'assignment'(
	id int(11),
	group_id int(6),
	due datetime,
	teacher_id int(5),
	CONSTRAINT 'assignment_PK' PRIMARY KEY (id),
	CONSTRAINT 'assignment_ref_group' FOREIGN KEY (group_id) REFERENCES group(id),
	CONSTRAINT 'assignment_ref_teacher' FOREIGN KEY (teacher_id) REFERENCES teacher(id)
);
CREATE TABLE 'student_in_group'(
	id int (8),
	student_id int(6),
	group_id int(5),
	semester char(5),
	log_time datetime,
	log_staff int(6),
	final_grade int(3),
	passed bool,
	CONSTRAINT 'student_in_group_PK' PRIMARY KEY (id),
	CONSTRAINT 'student_in_group_ref_student' FOREIGN KEY student_id REFERENCES student(id),
	CONSTRAINT 'student_in_group_ref_group' FOREIGN KEY group_id REFERENCES group(id)
);