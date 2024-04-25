using LibrarieModele;
using System.Collections.Generic;

namespace NivelStocareDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddStudent(Student s);
        List<Student> GetStudenti();
        Student GetStudent(string nume, string prenume);
        Student GetStudent(int idStudent);
        bool UpdateStudent(Student s);
    }
}
