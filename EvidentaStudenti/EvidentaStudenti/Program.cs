using System;
using System.Configuration;
using System.IO;
using LibrarieModele;
using LibrarieModele.Enumerari;
using NivelStocareDate;

namespace EvidentaStudenti
{
    class Program
    {
        static void Main()
        {
            //AdministrareStudenti_Memorie adminStudenti = new AdministrareStudenti_Memorie();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            AdministrareStudenti_FisierText adminStudenti = new AdministrareStudenti_FisierText(caleCompletaFisier);
            Student studentNou = new Student();
            int nrStudenti = 0;

            // acest apel ajuta la obtinerea numarului de studenti inca de la inceputul executiei
            // astfel incat o eventuala adaugare sa atribuie un IdStudent corect noului student
            adminStudenti.GetStudenti(out nrStudenti);

            string optiune;
            do
            {
                Console.WriteLine("C. Citire informatii student de la tastatura");
                Console.WriteLine("I. Afisarea informatiilor despre ultimului student introdus");
                Console.WriteLine("A. Afisare studenti din fisier");
                Console.WriteLine("S. Salvare student in fisier");
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
                        AfisareStudenti(studenti);

                        break;
                    case "S":
                        int idStudent = ++nrStudenti;
                        studentNou.IdStudent = idStudent;
                        //adaugare student in fisier
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

            Console.WriteLine("Introduceti notele");
            string note = Console.ReadLine();
            student.SetNote(note);

            Console.WriteLine("Alegeti un program de studiu: ");
            Console.WriteLine("1 - Calculatoare \n" +
            "2 - Automatica \n" +
            "3 - Electronica \n" +
            "4 - Electrotehnica \n" +
            "5 - Energetica \n" +
            "6 - InginerieEconomica \n");
            int optiune = Convert.ToInt32(Console.ReadLine());
            student.Specializare = (ProgramStudiu)optiune;

            return student;
        }

        public static void AfisareStudent(Student student)
        {
            string infoStudent = string.Format("Studentul cu id-ul #{0} are numele: {1} {2} si notele: {3}. Este inscris la programul de studiu: {4}",
                    student.IdStudent,
                    student.Nume ?? " NECUNOSCUT ",
                    student.Prenume ?? " NECUNOSCUT ",
                    string.Join(",", student.GetNote()),
                    student.Specializare);

            Console.WriteLine(infoStudent);
        }

        public static void AfisareStudenti(Student[] studenti)
        {
            Console.WriteLine("Studentii sunt:");
            foreach (Student student in studenti)
            {
                string infoStudent = student.Info();
                Console.WriteLine(infoStudent);
            }
        }
    }
}
