
using System;

namespace LibrarieModele
{
    public class Student
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;

        // data membra privata
        int[] note;

        //proprietati auto-implemented
        public int IdStudent { get; set; } //identificator unic student
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public void SetNote(int[] _note)
        {
            note = new int[_note.Length];
            _note.CopyTo(note, 0);
        }

        public int[] GetNote()
        {
            // returneaza o copie a vectorului, astfel încât utilizatorii acestei 
            // clase să nu poata modifica în mod direct conținutul vectorului 
            return (int[])note.Clone();
        }

        //contructor implicit
        public Student()
        {
            Nume = Prenume = string.Empty;
        }

        //constructor cu parametri
        public Student(int idStudent, string nume, string prenume)
        {
            this.IdStudent = idStudent;
            this.Nume = nume;
            this.Prenume = prenume;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Student(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            this.IdStudent = Convert.ToInt32(dateFisier[ID]);
            this.Nume = dateFisier[NUME];
            this.Prenume = dateFisier[PRENUME];
        }

        public string Info()
        {
            string info = $"Id:{IdStudent} Nume:{Nume ?? " NECUNOSCUT "} Prenume: {Prenume ?? " NECUNOSCUT "}";

            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectStudentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdStudent.ToString(),
                (Nume ?? " NECUNOSCUT "),
                (Prenume ?? " NECUNOSCUT "));

            return obiectStudentPentruFisier;
        }
    }
}
