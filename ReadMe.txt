What this WCF Service does: 
	This service is a demonstration of how WCF Services could be used by a University Registrar. It can look up courses and students, 
	add/remove students to courses, calculate the high, low, and average GPAs of a course's participants, as well as create entirely 
	new courses and enrolling new students. Although it uses default (hard-coded) initial data, it simulates a real-world application
	by accounting for duplicate entries for courses/students, based on their properties which would be primary keys in their respective databases.

How to use the Client:
	The Client for this WCF Service is very straightforward. When it is launched, a list of courses and their information is displayed. 
	When a row is selected, mopre detailed information is shown, and a list containing its participants is displayed underneath. 
	To see a list of all students, click the "Show All Students" button. With a course and student are selected, you can add the selected
	student to the selected course. When a course is selected and showing its participants, you can remove them. You can also create new Courses
	or Students at any time by clicking their respective buttons and filling in the required information.

Notes:
	This is a self-hosted WCF Service Library that uses four endpoints to connect to the client: nettcp, basichttp, wshttp, and a named pipe.