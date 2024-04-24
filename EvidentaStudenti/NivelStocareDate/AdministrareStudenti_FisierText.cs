using LibrarieModele;
using System;
using System.IO;

namespace NivelStocareDate
{
    public class AdministrareStudenti_FisierText
    {
        private const int ID_PRIMUL_STUDENT = 1;
        private const int INCREMENT = 1;
        private const int NR_MAX_STUDENTI = 50;
        private string numeFisier;

        public AdministrareStudenti_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddStudent(Student student)
        {
            student.IdStudent = GetId();

            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(student.ConversieLaSir_PentruFisier());
            }
        }

        public Student[] GetStudenti(out int nrStudenti)
        {
            Student[] studenti = new Student[NR_MAX_STUDENTI];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrStudenti = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    studenti[nrStudenti++] = new Student(linieFisier);
                }
            }

            Array.Resize(ref studenti, nrStudenti);

            return studenti;
        }

        public Student GetStudent(string nume, string prenume)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Student student = new Student(linieFisier);
                    if (student.Nume.Equals(nume) && student.Prenume.Equals(prenume))
                        return student;
                }
            }

            return null;
        }

        public Student GetStudent(int idStudent)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Student student = new Student(linieFisier);
                    if (student.IdStudent == idStudent)
                        return student;
                }
            }

            return null;
        }

        private int GetId()
        {
            int IdStudent = ID_PRIMUL_STUDENT;

            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Student student = new Student(linieFisier);
                    IdStudent = student.IdStudent + INCREMENT;
                }
            }

            return IdStudent;
        }
    }
}
