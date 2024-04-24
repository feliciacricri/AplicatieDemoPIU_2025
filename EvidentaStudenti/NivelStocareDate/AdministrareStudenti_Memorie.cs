using LibrarieModele;
using System.Collections.Generic;

namespace NivelStocareDate
{
    public class AdministrareStudenti_Memorie
    {
        private List<Student> studenti;

        public AdministrareStudenti_Memorie()
        {
            studenti = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            studenti.Add(student);
        }

        public List<Student> GetStudenti()
        {
            return studenti;
        }
    }
}