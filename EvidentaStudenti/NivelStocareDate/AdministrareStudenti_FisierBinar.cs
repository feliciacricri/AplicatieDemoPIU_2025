using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NivelStocareDate
{
    //clasa AdministrareStudenti_FisierBinar implementeaza interfata IStocareData
    public class AdministrareStudenti_FisierBinar : IStocareData
    {
        private const int ID_PRIMUL_STUDENT = 1;
        private const int INCREMENT = 1;

        string NumeFisier { get; set; }
        public AdministrareStudenti_FisierBinar(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sBinFile = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sBinFile.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sBinFile.Close();
            //using (Stream sBinFile = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }

        public void AddStudent(Student s)
        {
            s.IdStudent = GetId();

            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Append, FileAccess.Write))
                {
                    //serializarea unui obiect
                    b.Serialize(sBinFile, s);
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public List<Student> GetStudenti()
        {
            List<Student> studenti = new List<Student>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {

                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        studenti.Add((Student)b.Deserialize(sBinFile));
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return studenti;
        }
        public Student GetStudent(int idStudent)
        {
            throw new Exception("Optiunea GetStudent by Id nu este implementata");
        }

        public Student GetStudent(string nume, string prenume)
        {
            BinaryFormatter b = new BinaryFormatter();

            //instructiunea 'using' va apela sBinFile.Close();
            using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
            {

                while (sBinFile.Position < sBinFile.Length)
                {
                    //Observati conversia!!!
                    Student student = (Student)b.Deserialize(sBinFile);
                    if (student.Nume.Equals(nume) && student.Prenume.Equals(prenume))
                        return student;
                }
            }

            return null;
        }

        public bool UpdateStudent(Student s)
        {
            throw new Exception("Optiunea UpdateStudent nu este implementata");
        }

        private int GetId()
        {
            int IdStudent = ID_PRIMUL_STUDENT;
            try
            {
                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        Student s = (Student)b.Deserialize(sBinFile);
                        IdStudent = s.IdStudent + INCREMENT;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return IdStudent;
        }
    }
}
