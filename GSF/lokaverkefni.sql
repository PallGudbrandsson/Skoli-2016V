delimiter $$


DROP PROCEDURE IF EXISTS newStudent $$
CREATE PROCEDURE newStudent(fn varchar, ln varchar, bir date, parent varchar, fyear year, gyear year)
begin
INSERT INTO students("fn", "ln", "bir", "parent", fyear, gyear);
end $$


DROP PROCEDURE IF EXISTS addStudentCourse $$
CREATE PROCEDURE addStudentCourse(regdate date, gid int, sid int)
begin
INSERT INTO studentregistration("regdate", gid, sid);
end $$


DROP PROCEDURE IF EXISTS studentCourse $$
CREATE PROCEDURE studentCourse(sid int, coursen char)
begin--ekki viss um ad thetta ma
--finna groupid thar sem nemandi er skradur og svo velja thad sem jafngildir coursen
SELECT * FROM groups WHERE groupID IN (SELECT groupID FROM studentregistration WHERE studentID = sid) AND courseNumber = coursen;
end $$

DROP PROCEDURE IF EXISTS studentCourses $$
CREATE PROCEDURE studentCourses(sid int)
begin
SELECT * FROM groups WHERE groupID IN (SELECT groupID FROM studentregistration WHERE studentID = sid);
end $$


DROP PROCEDURE IF EXISTS updateStudentCource $$
CREATE PROCEDURE updateStudentCource(sid, int, olid int, nid int)
begin
--er ekki viss um hvad thessi a ad updatea en held ad thad se reg
UPDATE studentregistration SET groupID = nid WHERE studentID = sid, groupID = olid;
end $$


DROP PROCEDURE IF EXISTS deleteStudentCource $$
CREATE PROCEDURE deleteStudentCource(sid int, gid int)
begin
DELETE FROM studentregistration WHERE studentID = sid, groupID = gid
end $$


DROP FUNCTION IF EXISTS numberOfStudents $$
CREATE FUNCTION numberOfStudents()
returns int
begin
--geyma. Þarf að finna leið til að ná í árið sem er
RETURN(SELECT COUNT(studentID)) FROM students WHERE graduationYear > NOW());
end $$


DROP FUNCTION IF EXISTS totalNumberOfStudentCredits $$
CREATE FUNCTION totalNumberOfStudentCredits(sid int)
returns int
begin
RETURN(
	SELECT COUNT(courses.courseCredits) AS Student Credits FROM courses
	JOIN groups ON courses.courseNumber = groups.courseNumber
	JOIN studentregistration ON groups.groupID = studentregistration.groupID
	WHERE studentregistration.studentID = sid
	);
end $$


DROP FUNCTION IF EXISTS totalNumberOfStudentTakingSpecificCourse
CREATE FUNCTION totalNumberOfStudentTakingSpecificCourse(cnum char)
returns int
begin
RETURN(
	SELECT COUNT(studentregistration.registrationNumber) AS GroupCount FROM studentregistration
	JOIN groups ON studentregistration.groupID = groups.groupID
	JOIN courses ON groups.courseNumber = courses.courseNumber
	WHERE courses.courseNumber = cnum
);
end $$

DROP VIEW IF EXISTS avoidSiggi $$
CREATE VIEW avoidSiggi
SELECT * FROM courses
WHERE courseNumber != 'GSF2A3U' 
OR courseNumber != 'GSF2B3U' 
OR courseNumber != 'GSF3A3U' 
OR courseNumber != 'FOR2G3U' 
OR courseNumber != 'FOR4A3U'--view afangar sem siggi er ekki ad kenna
--view allir forritunar afangar
DROP VIEW IF EXISTS allProgrammingCourses $$
CREATE VIEW allProgrammingCourses
SELECT * FROM courses WHERE courseNumber LIKE "FOR%"