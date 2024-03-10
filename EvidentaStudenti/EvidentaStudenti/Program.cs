using System;
using LibrarieModele;
using NivelStocareDate;

namespace EvidentaStudenti
{
    class Program
    {
        static void Main()
        {
            AdministrareStudenti_Memorie adminStudenti = new AdministrareStudenti_Memorie();
            Student studentNou = new Student();
            int nrStudenti = 0;

            string optiune;
            do
            {
                Console.WriteLine("C. Citire informatii student de la tastatura");
                Console.WriteLine("I. Afisarea informatiilor despre ultimului student introdus");
                Console.WriteLine("A. Afisare studenti din fisier");
                Console.WriteLine("S. Salvare student in vector de obiecte");
                Console.WriteLine("X. Inchidere program");

                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        studentNou = CitireStudentTastatura();

                        break;
                    case "I":
                        AfisareStudent(studentNou);

                        break;
                    case "A":
                        Student[] studenti = adminStudenti.GetStudenti(out nrStudenti);
                        AfisareStudenti(studenti, nrStudenti);

                        break;
                    case "S":
                        int idStudent = ++nrStudenti;
                        studentNou.IdStudent = idStudent;
                        //adaugare student in vectorul de obiecte
                        adminStudenti.AddStudent(studentNou);

                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        public static Student CitireStudentTastatura()
        {
            Console.WriteLine("Introduceti numele");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti prenumele");
            string prenume = Console.ReadLine();

            Student student = new Student(0, nume, prenume);

            return student;
        }

        public static void AfisareStudent(Student student)
        {
            string infoStudent = string.Format("Studentul cu id-ul #{0} are numele: {1} {2}",
                    student.IdStudent,
                    student.Nume ?? " NECUNOSCUT ",
                    student.Prenume ?? " NECUNOSCUT ");

            Console.WriteLine(infoStudent);
        }

        public static void AfisareStudenti(Student[] studenti, int nrStudenti)
        {
            Console.WriteLine("Studentii sunt:");
            for (int contor = 0; contor < nrStudenti; contor++)
            {
                string infoStudent = studenti[contor].Info();
                Console.WriteLine(infoStudent);
            }
        }
    }
}
