using StudentGradeManagement.Core.Model;
using StudentGradeManagement.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagement.Core.Services
{
    internal class StudentService
    {
        private static readonly List<Student> _Students = new List<Student>();
        public static void AddStudent()
        {
            string studentName = InputValidator.EnterName();
            int studentAge = InputValidator.EnterAge();
            string studentEmail = InputValidator.EnterEmail();
            Console.WriteLine("\nEnter scores.");
            Score score = InputValidator.EnterScore();
            Student Student = new Student() { Name = studentName, Age = studentAge, Email = studentEmail, Score = score, StudentID = _Students.Count + 1 };
            _Students.Add(Student);
            Console.WriteLine("Record Saved Successfullly.\n");
        }
        public static void ReadAllStudent()
        {
            if (_Students.Count > 0)
            {
                for (int i = 0; i < _Students.Count; i++)
                {
                    var item = _Students[i];
                    Console.WriteLine($"\nID is: {item.StudentID}");
                    Console.WriteLine($"Full Name: {item.Name}\n" +
                        $"Age: {item.Age}\n" +
                        $"Email adress: {item.Email}");

                    Console.WriteLine("\n--------------------------------Grades----------------------------------------");
                    Console.WriteLine($"English: {item.Score.English}, Mathematics:  {item.Score.Mathematics}, Chemistry: {item.Score.Chemistry}, Physics: {item.Score.Physics}");
                    Console.WriteLine("---------------------------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("No record found.\n");
            }

        }
        public static void UpdateStudent()
        {
            int userID = InputValidator.GetID();
            Student result = _Students[userID - 1];
            if (result != null)
            {
                Console.Write("Enter new full name (leave blank to keep current name): ");
                string? newFullName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newFullName))
                {
                    result.Name = newFullName;
                }

                Console.Write("Enter new age (leave blank to keep current age):");
                string? userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int newAge))
                {
                    if (newAge >= 16)
                    {
                        result.Age = newAge;
                    }
                }

                Console.Write("Enter new email address (leave blank to keep current email: ");
                string? newEmail = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newEmail) && (newEmail.Contains('@') && newEmail.Contains(".com")))
                {
                    result.Email = newEmail;
                }

                Console.WriteLine("Enter new scores (leave blank to keep current scores: ");
                Console.Write("English score: ");
                string? new_Eng_Score = Console.ReadLine();

                Console.Write("Mathematics: ");
                string? new_Math_Score = Console.ReadLine();

                Console.Write("Chemistry: ");
                string? new_Chem_Score = Console.ReadLine();

                Console.Write("Physics: ");
                string? new_Phy_Score = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(new_Eng_Score) && int.TryParse(new_Eng_Score, out int newEnglishScore))
                {
                    result.Score.English = newEnglishScore;
                }
                if (!string.IsNullOrWhiteSpace(new_Math_Score) && int.TryParse(new_Math_Score, out int newMathsScore))
                {
                    result.Score.Mathematics = newMathsScore;
                }
                if (!string.IsNullOrWhiteSpace(new_Chem_Score) && int.TryParse(new_Chem_Score, out int newChemScore))
                {
                    result.Score.Chemistry = newChemScore;
                }
                if (!string.IsNullOrWhiteSpace(new_Phy_Score) && int.TryParse(new_Phy_Score, out int newPhyScore))

                {
                    result.Score.Physics = newPhyScore;
                }
                Console.WriteLine("Record updated successfully.\n");
            }
        }
        public static void DeleteStudent()
        {
            int userID1 = InputValidator.GetID();
            Console.Write("Enter student ID for confirmation: ");
            string? userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int userID2))
            {
                if (userID2 == userID1 && userID1 == userID2)
                {
                    Student studenToDelete = _Students[userID1 - 1];
                    Console.WriteLine($"{studenToDelete.Name} record has been deleted.\n");
                    _Students.RemoveAt(userID2 - 1);
                }
                else
                {
                    Console.WriteLine("Please enter the correct student ID. Try again.\n");
                }
            }
            else
            {
                Console.WriteLine("Incorrect ID format.\n");
            }

        }
        public static void CalculateGrade()
        {
            int Student_ID = InputValidator.ComputeGrade();
            Student? Student = _Students[Student_ID - 1]; //An error is here
            if (Student != null)
            {
                int gradeResult = Student.Score.GradeCalculator();
                Console.WriteLine("{1} grade result is {0}\n", gradeResult, Student.Name);
                //implement a CGPA grade here.
            }
            else Console.WriteLine("Invalid record.");
        }

    }
}
