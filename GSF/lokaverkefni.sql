delimiter $$


drop procedure IF EXISTS newStudent $$
create procedure newStudent(fn varchar(255), ln varchar(255), bir date, parent varchar(255), fyear year, gyear year)
begin
INSERT INTO students(firstName, lastName, dob, legalGuardian, freshmanYear, graduationYear) 
VALUES("fn", "ln", "bir", "parent", fyear, gyear);
end $$


DROP PROCEDURE IF EXISTS addStudentCourse $$
CREATE PROCEDURE addStudentCourse(regdate date, gid int(11), sid int(11))
begin
INSERT INTO studentregistration(registrationDate, groupID, studentID)
VALUES("regdate", gid, sid);
end $$

/*
DROP PROCEDURE IF EXISTS studentCourse $$
CREATE PROCEDURE studentCourse(sid int(11), coursen char(10))
begin
DECLARE hopar = (SELECT groupID FROM studentregistration WHERE studentID = sid);
SELECT * FROM groups WHERE groudID IN hopar AND courseNumber = coursen;

end $$
need another way

DROP PROCEDURE IF EXISTS studentCourses $$
CREATE PROCEDURE studentCourses(sid int(11))
begin
SELECT * FROM groups WHERE groupID IN (SELECT groupID FROM studentregistration WHERE studentID = sid);
end $$
lika her
*/

DROP PROCEDURE IF EXISTS updateStudentCource $$
CREATE PROCEDURE updateStudentCource(sid, int(11), olid int(11), nid int(11))
begin
UPDATE studentregistration SET groupID = nid WHERE studentID = sid AND groupID = olid;

end $$


DROP PROCEDURE IF EXISTS deleteStudentCource $$
CREATE PROCEDURE deleteStudentCource(sid int(11), gid int(11))
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
CREATE FUNCTION totalNumberOfStudentCredits(sid int(11))
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
CREATE FUNCTION totalNumberOfStudentTakingSpecificCourse(cnum char(10))
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
>>>>>>> origin/master
DROP VIEW IF EXISTS allProgrammingCourses $$
CREATE VIEW allProgrammingCourses
SELECT * FROM courses WHERE courseNumber LIKE "FOR%"