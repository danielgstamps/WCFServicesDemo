using System.Collections.Generic;
using System.ServiceModel;

// Author: Daniel Stamps
// Version: 4/16/2015
namespace ClassFinderService
{
    [ServiceContract]
    public interface IClassFinderService
    {
        [OperationContract]
        List<Course> GetAllCourses();

        [OperationContract]
        List<Student> GetAllStudents();

        [OperationContract]
        List<Student> GetStudentsInCourse(int crn);

        [OperationContract]
        bool AddStudentToCourse(int id, int crn);

        [OperationContract]
        void RemoveStudentFromCourse(int id, int crn);

        [OperationContract]
        double GetMaxGpaForCourse(int crn);

        [OperationContract]
        double GetAverageGpaForCourse(int crn);

        [OperationContract]
        double GetMinGpaForCourse(int crn);

        [OperationContract]
        bool CreateNewStudent(int id, string name, double gpa);

        [OperationContract]
        bool CreateNewCourse(int crn, string title, string instructor);
    }
}