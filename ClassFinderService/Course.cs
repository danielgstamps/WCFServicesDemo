using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Author: Daniel Stamps
// Version: 4/16/2015
namespace ClassFinderService
{
    [DataContract]
    public class Course
    {
        private int _crn;
        private string _title;
        private string _instructor;
        private readonly List<Student> _enrolledStudents;

        [DataMember]
        public int Crn
        {
            get { return this._crn; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("CRN must be a positive number.");
                }
                this._crn = value;
            }
        }

        [DataMember]
        public string Title
        {
            get { return this._title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Title cannot be empty.");
                }
                this._title = value;
            }
        }

        [DataMember]
        public string Instructor
        {
            get { return this._instructor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Instructor cannot be empty.");
                }
                this._instructor = value;
            }
        }

        public List<Student> EnrolledStudents
        {
            get { return this._enrolledStudents; }
        } 

        public Course(int crn, string title, string instructor)
        {
            this.Crn = crn;
            this.Title = title;
            this.Instructor = instructor;
            this._enrolledStudents = new List<Student>();
        }

        public bool AddStudent(Student studentToAdd)
        {
            if (this._enrolledStudents.Contains(studentToAdd))
            {
                return false;
            }

            studentToAdd.NumberOfCourses += 1;
            this._enrolledStudents.Add(studentToAdd);
            return true;
        }

        public void RemoveStudent(Student student)
        {
            student.NumberOfCourses -= 1;
            this._enrolledStudents.Remove(student);
        }

        public double GetAverageGpa()
        {
            if (this._enrolledStudents.Count == 0)
            {
                return 0;
            }
            return this._enrolledStudents.Average(x => x.Gpa);
        }

        public double GetHighestGpa()
        {
            if (this._enrolledStudents.Count == 0)
            {
                return 0;
            }
            return this._enrolledStudents.Max(x => x.Gpa);
        }

        public double GetLowestGpa()
        {
            if (this._enrolledStudents.Count == 0)
            {
                return 0;
            }
            return this._enrolledStudents.Min(x => x.Gpa);
        }
    }
}