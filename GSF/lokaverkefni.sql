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
DECLARE hopar = (SELECT groupID FROM studentregistration WHERE studentID = sid);
SELECT * FROM groups WHERE groudID IN hopar AND courseNumber = coursen;
end $$

DROP PROCEDURE IF EXISTS studentCourses $$
CREATE PROCEDURE studentCourses(sid int)
begin
DECLARE registered = (SELECT groudID FROM studentregistration WHERE studentID = sid)
SELECT * FROM groups WHERE groupID IN registered;
end $$


DROP PROCEDURE IF EXISTS updateStudentCource $$
CREATE PROCEDURE updateStudentCource(sid, int, olid int, nid int)
begin
--er ekki viss um hvad thessi a ad updatea en held ad thad se reg
UPDATE studentregistration SET groupID = nid WHERE studentID = sid AND groupID = olid;
end $$


DROP PROCEDURE IF EXISTS deleteStudentCource $$
CREATE PROCEDURE deleteStudentCource(sid int, gid int)
begin
DELETE FROM studentregistration WHERE studentID = sid AND groupID = gid
end $$


DROP FUNCTION IF EXISTS numberOfStudents $$
CREATE FUNCTION numberOfStudents()
returns int
begin
RETURN(SELECT COUNT(studentID)) FROM students WHERE graduationYear > NOW());
end $$


DROP FUNCTION IF EXISTS totalNumberOfStudentCredits $$
CREATE FUNCTION totalNumberOfStudentCredits(sid int)
returns int
begin
RETURN(
	SELECT COUNT(courses.courseCredits) FROM courses
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
	SELECT COUNT(studentregistration.regisrationNumber) FROM studentregistration
	JOIN groups ON studentregistration.groupID = groups.groupID
	JOIN courses ON groups.courseNumber = courses.courseNumber
	WHERE courses.courseNumber = cnum
);
end $$

DROP VIEW IF EXISTS avoidSiggi $$
CREATE VIEW avoidSiggi
SELECT * FROM courses
WHERE courseNumber IS NOT "GSF2A3U" AND courseNumber IS NOT "GSF2B3U" AND courseNumber IS NOT "GSF3A3U" AND courseNumber IS NOT "FOR2G3U" AND courseNumber IS NOT "FOR4A3U"
--view afangar sem siggi er ekki ad kenna
--view allir forritunar afangar
DROP VIEW IF EXISTS allProgrammingCourses $$
CREATE VIEW allProgrammingCourses
SELECT * FROM courses WHERE courseNumber LIKE "FOR%"