using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareStudenti_Memorie
    {
        private const int NR_MAX_STUDENTI = 50;

        private Student[] studenti;
        private int nrStudenti;

        public AdministrareStudenti_Memorie()
        {
            studenti = new Student[NR_MAX_STUDENTI];
            nrStudenti = 0;
        }

        public void AddStudent(Student student)
        {
            studenti[nrStudenti] = student;
            nrStudenti++;
        }

        public Student[] GetStudenti(out int nrStudenti)
        {
            nrStudenti = this.nrStudenti;
            return studenti;
        }
    }
}