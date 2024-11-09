using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer
{
    internal class Student
    {
        string StudentName, StudentSurname, StudentDOB, PhoneNum, HomeAddress, StudentNum, ModuleCode;
        int GenderID;

        public Student(string studentName, string studentSurname, string studentDOB, string phoneNum, string homeAddress, string studentNum,  int genderID)
        {
            StudentName1 = studentName;
            StudentSurname1 = studentSurname;
            StudentDOB1 = studentDOB;
            PhoneNum1 = phoneNum;
            HomeAddress1 = homeAddress;
            StudentNum1 = studentNum;
            GenderID1 = genderID;
        }

        public string StudentName1 { get => StudentName; set => StudentName = value; }
        public string StudentSurname1 { get => StudentSurname; set => StudentSurname = value; }
        public string StudentDOB1 { get => StudentDOB; set => StudentDOB = value; }
        public string PhoneNum1 { get => PhoneNum; set => PhoneNum = value; }
        public string HomeAddress1 { get => HomeAddress; set => HomeAddress = value; }
        public string StudentNum1 { get => StudentNum; set => StudentNum = value; }
        public int GenderID1 { get => GenderID; set => GenderID = value; }
    }
}
