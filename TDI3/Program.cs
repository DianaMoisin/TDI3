using System;
using System.Collections.Generic;

namespace TDI3
{
    class Program
    {
        static void Main(string[] args)
        {   
            // ex1
            Note nota = new Note();

            List<Note> noteElev1 = new List<Note>();
            nota.Nota = 10;
            noteElev1.Add(nota);
            nota.Nota = 9;
            noteElev1.Add(nota);
            nota.Nota = 8;
            noteElev1.Add(nota);

            List<Note> noteElev2 = new List<Note>();
            nota.Nota = 7;
            noteElev2.Add(nota);
            nota.Nota = 5;
            noteElev2.Add(nota);
            nota.Nota = 8;
            noteElev2.Add(nota);

            List<Note> noteElev3 = new List<Note>();
            nota.Nota = 10;
            noteElev3.Add(nota);
            nota.Nota = 6;
            noteElev3.Add(nota);
            nota.Nota = 8;
            noteElev3.Add(nota);

            Elev elev1 = new Elev("Popa", "Ion", noteElev1);
            Elev elev2 = new Elev("Ionescu", "Vasile", noteElev2);
            Elev elev3 = new Elev("Georgescu", "Maria", noteElev3);

            List<Elev> elevi = new List<Elev>();
            elevi.Add(elev1);
            elevi.Add(elev2);
            elevi.Add(elev3);

            Catalog catalog = new Catalog()
            {
                NumeClasa = "ClasaZero",
                Elevi = elevi
            };

            string premiant = catalog.GetPremiantul(catalog);

            Console.WriteLine(catalog.GetClasaElev(catalog));
      
        }
    }
}
