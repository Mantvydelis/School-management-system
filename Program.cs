using Mokyklos_valdymo_sistema.Models;
using Mokyklos_valdymo_sistema.Service;
using System;
using System.Xml.Serialization;

namespace ManoPrograma
{
    public class PagrindineKlase
    {
        public static void Main(string[] args)
        {

            List<Teacher> teachers = new List<Teacher>();
            TeacherControl teacherControl = new TeacherControl(teachers);
            List<Pupil> pupils = new List<Pupil>();
            PupilControl pupilControl = new PupilControl(pupils);
            SchoolService schoolService = new SchoolService(pupilControl, teacherControl);


            while (true)
            {
                Console.WriteLine("1. Add pupil");
                Console.WriteLine("2. Add teacher");
                Console.WriteLine("3. Add grade");
                Console.WriteLine("4. Review all students");
                Console.WriteLine("5. Review all teachers");
                Console.WriteLine("6. Review all grades");
                Console.WriteLine("0. Leave");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();


                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter students's name: ");
                            string pupilName = Console.ReadLine();
                            Console.Write("Enter students's surname: ");
                            string pupilSurname = Console.ReadLine();
                            Console.Write("Enter students's age: ");
                            int age = int.Parse(Console.ReadLine());
                            Console.Write("Enter students's class: ");
                            string clas = Console.ReadLine();

                            bool IsThere = false;

                            foreach (var p in pupils)
                            {

                                if (pupilName == p.Name && pupilSurname == p.Surname)
                                {
                                    Console.WriteLine("This student already exists.");
                                    IsThere = true;
                                    break;
                                }

                            }
                            if (IsThere == false)
                            {
                                schoolService.AddPupil(new Pupil(pupilName, pupilSurname, age, clas));
                            }
                            
                            schoolService.AddPupil(new Pupil(pupilName, pupilSurname, age, clas));


                            break;

                        case "2":
                            Console.WriteLine("Enter teacher's name: ");
                            string teacherName = Console.ReadLine();

                            Console.WriteLine("Enter teacher's surname: ");
                            string teacherSurname = Console.ReadLine();

                            Console.WriteLine("Enter teacher's subject: ");
                            string teacherSubject = Console.ReadLine();

                            bool IsThere2 = false;

                            foreach (var p in teachers)
                            {

                                if (teacherName == p.Name && teacherSurname == p.Surname)
                                {
                                    Console.WriteLine("This teacher already exists.");
                                    IsThere2 = true;
                                    break;
                                }

                            }
                            if (IsThere2 == false)
                            {
                                schoolService.AddTeacher(new Teacher(teacherName, teacherSurname, teacherSubject));
                            }


                            break;

                        case "3":
                            Console.WriteLine("Enter pupil's name: ");
                            pupilName = Console.ReadLine();

                            Console.WriteLine("Enter pupil's surname: ");
                            pupilSurname = Console.ReadLine();

                            Console.WriteLine("Enter teacher's name: ");
                            teacherName = Console.ReadLine();

                            Console.WriteLine("Enter teacher's surname: ");
                            teacherSurname = Console.ReadLine();

                            Console.WriteLine("Enter teacher's subject: ");
                            teacherSubject = Console.ReadLine();

                            Console.WriteLine("Enter pupil's grade: ");
                            int pupilGrade = int.Parse(Console.ReadLine());

                            if (pupilGrade >= 1 && pupilGrade <= 10)
                            {
                                Grade grade = new Grade(teacherSubject, DateTime.Now.ToString(), pupilGrade);

                                schoolService.AddGrade(pupilName, pupilSurname, teacherName, teacherSurname, grade);
                            }
                            else
                            {
                                Console.WriteLine("There is no such grade");
                            }


                            break;

                        case "4":
                            var allPupils = schoolService.GetAllPupils();
                            foreach (var pupil in pupils)
                            {
                                Console.WriteLine(pupil.GetInfo());
                            }

                            break;

                        case "5":
                            var allTeachers = schoolService.GetAllTeachers();
                            foreach (var teacher in teachers)
                            {
                                Console.WriteLine(teacher.GetInfo());
                            }

                            break;

                        case "6":

                            Console.Write("Enter pupil's name: ");
                            pupilName = Console.ReadLine();
                            Console.Write("Enter pupil's surname: ");
                            pupilSurname = Console.ReadLine();
                            var grades = schoolService.GetPupilsGrades(pupilName, pupilSurname);

                            foreach (var p in grades)
                            {
                                Console.WriteLine($"{p.Topic}, {p.CompletionDate}, {p.ActualGrade}");
                            }
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("Wrong choice.");
                            break;




                    }




                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error:  {ex.Message}");
                }

                Console.WriteLine();
            }


        }
    }
}
