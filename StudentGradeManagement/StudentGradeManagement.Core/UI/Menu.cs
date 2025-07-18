using StudentGradeManagement.Core.Model;
using StudentGradeManagement.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagement.Core.UI
{
    public static class Menu
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("Student Grade Management");
            do
            {
                Console.WriteLine("1 - Add Student\n" +
            "2 - View all Students\n" +
            "3 - Update Student\n" +
            "4 - Delete Student\n" +
            "5 - Calculate Grades\n" +
            "6 - Exit");
            Console.Write("\nChoose an option: ");

                string? userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        StudentService.AddStudent();
                        break;
                    case "2":
                        StudentService.ReadAllStudent();
                        break;
                    case "3":
                        StudentService.UpdateStudent();
                        break;
                    case "4":
                        StudentService.DeleteStudent();
                        break;
                    case "5":
                        StudentService.CalculateGrade();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            } while (true);

        }

    }
}
