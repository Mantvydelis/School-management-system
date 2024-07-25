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
                Console.WriteLine("1. Pridėti mokinį");
                Console.WriteLine("2. Pridėti mokytoją");
                Console.WriteLine("3. Pridėti pažymį");
                Console.WriteLine("4. Peržiūrėti visus mokinius");
                Console.WriteLine("5. Peržiūrėti visus mokytojus");
                Console.WriteLine("6. Peržiūrėti mokinio pažymius");
                Console.WriteLine("0. Išeiti");
                Console.Write("Pasirinkite veiksmą: ");
                string choice = Console.ReadLine();


                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Įveskite mokinio vardą: ");
                            string pupilName = Console.ReadLine();
                            Console.Write("Įveskite mokinio pavardę: ");
                            string pupilSurname = Console.ReadLine();
                            Console.Write("Įveskite mokinio amžių: ");
                            int age = int.Parse(Console.ReadLine());
                            Console.Write("Įveskite mokinio klasę: ");
                            string clas = Console.ReadLine();
                            schoolService.AddPupil(new Pupil(pupilName, pupilSurname, age, clas));
                            break;

                        case "2":
                            Console.WriteLine("Enter teacher's name: ");
                            string teacherName = Console.ReadLine();

                            Console.WriteLine("Enter teacher's surname: ");
                            string teacherSurname = Console.ReadLine();

                            Console.WriteLine("Enter teacher's subject: ");
                            string teacherSubject = Console.ReadLine();

                            schoolService.AddTeacher(new Teacher(teacherName, teacherSurname, teacherSubject));

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

                            Grade grade = new Grade(teacherSubject, DateTime.Now.ToString(), pupilGrade);

                            schoolService.AddGrade(pupilName, pupilSurname, teacherName, teacherSurname, grade);
                            break;

                        case "4":
                            var allPupils = schoolService.GetAllPupils();
                            foreach (var pupil in pupils)
                            {
                                Console.WriteLine(pupil.GetInfo());
                            }

                            break;

                    }




                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error:  {ex.Message}");
                }
            }


        }
    }
}
