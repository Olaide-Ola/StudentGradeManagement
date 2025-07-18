using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagement.Core.Interface
{
    internal interface IStudentService
    {
        void AddStudent();
        void ReadAllStudent();
        void UpdateStudent();
        void DeleteStudent();
        void CalculateGrade();
    }
}
