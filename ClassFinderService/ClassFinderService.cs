using System.Collections.Generic;
using System.ServiceModel;

// Author: Daniel Stamps
// Version: 4/16/2015
namespace ClassFinderService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        ConcurrencyMode=ConcurrencyMode.Single,
        IncludeExceptionDetailInFaults = true)]
    public class ClassFinderService : IClassFinderService
    {
        private readonly List<Course> _allCourses = new List<Course>()
        {
            new Course(1300, "Intro to Computer Science", "Anja Remshagen"),
            new Course(1301, "Computer Science I", "Will Lloyd"),
            new Course(1302, "Computer Science II", "Michael Orsega"),
            new Course(3201, "Program Construction I", "Duane Yoder"),
            new Course(3202, "Program Construction II", "Duane Yoder"),
            new Course(3211, "Software Engineering I", "Will Lloyd"),
            new Course(3212, "Software Engineering II", "Will Lloyd"),
            new Course(3151, "Data Structures and Discrete Math I", "Anja Remshagen"),
            new Course(3152, "Data Structures and Discrete Math II", "Anja Remshagen"),
            new Course(3230, "Information Management", "Li Yang"),
            new Course(4225, "Parallel and Distributed Systems", "Li Yang"),
            new Course(3110, "System Architecture", "Lewis Baumstark"),
            new Course(3280, "System and Network Administration", "Lewis Baumstark")       
        };

        private readonly List<Student> _allStudents = new List<Student>()
        {
            new Student(917375553, "Daniel Stamps", 3.1),
            new Student(917613613, "Ayaan Kazerouni", 3.8),
            new Student(917296032, "Benjamin Fausett", 3.3),
            new Student(917332546, "Christopher Kittredge", 3.4),
            new Student(917530496, "James Thompson", 3.0),
            new Student(917556323, "Thomas Hemphill", 4.0),
            new Student(917886754, "Timothy Oglesby", 3.0),
            new Student(917895343, "William Cahill", 3.5),
            new Student(917123123, "Kristi Chastain", 3.6),
            new Student(917643313, "Lewis Christmas", 3.0),
            new Student(917545096, "Jeffrey Simmons", 3.2),
            new Student(917444212, "John Moore", 3.0),
            new Student(917567890, "Kenneth Weathington", 3.8),
            new Student(917432432, "Michael Carr", 3.5),
            new Student(917257433, "Shane Pratt", 3.9)
        };

        public List<Course> GetAllCourses()
        {
            return this._allCourses;
        }

        public List<Student> GetAllStudents()
        {
            return this._allStudents;
        }

        public List<Student> GetStudentsInCourse(int crn)
        {
            return this._allCourses.Find(x => x.Crn == crn).EnrolledStudents;
        }

        public bool AddStudentToCourse(int id, int crn)
        {
            return this._allCourses.Find(x => x.Crn == crn).AddStudent(
                this._allStudents.Find(x => x.Id == id));
        }

        public void RemoveStudentFromCourse(int id, int crn)
        {
            this._allCourses.Find(x => x.Crn == crn).RemoveStudent(
                this._allStudents.Find(x => x.Id == id));
        }

        public double GetMaxGpaForCourse(int crn)
        {
            return this._allCourses.Find(x => x.Crn == crn).GetHighestGpa();
        }

        public double GetAverageGpaForCourse(int crn)
        {
            return this._allCourses.Find(x => x.Crn == crn).GetAverageGpa();
        }

        public double GetMinGpaForCourse(int crn)
        {
            return this._allCourses.Find(x => x.Crn == crn).GetLowestGpa();
        }

        public bool CreateNewStudent(int id, string name, double gpa)
        {
            if (this._allStudents.Contains(this._allStudents.Find(x => x.Id == id)))
            {
                return false;
            }
            this._allStudents.Add(new Student(id, name, gpa));
            return true;
        }

        public bool CreateNewCourse(int crn, string title, string instructor)
        {
            if (this._allCourses.Contains(this._allCourses.Find(x => x.Crn == crn)))
            {
                return false;
            }
            this._allCourses.Add(new Course(crn, title, instructor));
            return true;
        }
    }
}