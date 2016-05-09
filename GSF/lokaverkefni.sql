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
DELETE 
end $$


DROP FUNCTION IF EXISTS numberOfStudents $$
CREATE FUNCTION numberOfStudents()
returns int
begin

end $$


DROP FUNCTION IF EXISTS totalNumberOfStudentCredits $$
CREATE FUNCTION totalNumberOfStudentCredits()
returns int
begin

end $$


DROP FUNCTION IF EXISTS totalNumberOfStudentTakingSpecificCourse
CREATE FUNCTION totalNumberOfStudentTakingSpecificCourse()
returns int
begin

end $$


--view afangar sem siggi er ekki ad kenna
--view allir forritunar afangar