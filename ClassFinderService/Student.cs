using System;
using System.Runtime.Serialization;

// Author: Daniel Stamps
// Version: 4/16/2015
namespace ClassFinderService
{
    [DataContract]
    public class Student
    {
        private int _id;
        private string _name;
        private double _gpa;
        private int _numberOfCourses;

        [DataMember]
        public int Id
        {
            get { return this._id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Student ID must be a positive integer.");
                }
                this._id = value;
            }
        }

        [DataMember]
        public string Name
        {
            get { return this._name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name must be at least one character.");
                }
                this._name = value;
            }
        }

        [DataMember]
        public double Gpa
        {
            get { return this._gpa; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("GPA cannot be negative.");
                }
                this._gpa = value;
            }
        }

        [DataMember]
        public int NumberOfCourses
        {
            get { return this._numberOfCourses; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of courses cannot be negative.");
                }
                this._numberOfCourses = value;
            }
        }

        public Student(int id, string name, double gpa)
        {
            this.Id = id;
            this.Name = name;
            this.Gpa = gpa;
            this.NumberOfCourses = 0;
        }
    }
}