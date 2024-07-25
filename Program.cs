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
                            List<Grade> pupil1 = new List<Grade>();
                            SchoolService.AddPupil(new Pupil(pupilName, pupilSurname, age, clas, pupil1));
                            break;

                        case "2":
                            Console.WriteLine("Enter teacher's name: ");
                            string teacherName = Console.ReadLine();

                            Console.WriteLine("Enter teacher's surname: ");
                            string teacherSurname = Console.ReadLine();

                            Console.WriteLine("Enter teacher's subject: ");
                            string teacherSubject = Console.ReadLine();

                            SchoolService.AddTeacher(new Teacher(

                            break;
                    }




                }

    }


        } 
