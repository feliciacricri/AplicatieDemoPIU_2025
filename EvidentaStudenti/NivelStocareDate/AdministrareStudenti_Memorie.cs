using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelStocareDate
{
    public class AdministrareStudenti_Memorie : IStocareData
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

        public Student GetStudent(int idStudent)
        {
            throw new Exception("Optiunea GetStudent by Id nu este implementata");
        }

        public Student GetStudent(string nume, string prenume)
        {
            throw new Exception("Optiunea GetStudent nu este implementata");
        }

        public bool UpdateStudent(Student s)
        {
            throw new Exception("Optiunea UpdateStudent nu este implementata");
        }
    }
}