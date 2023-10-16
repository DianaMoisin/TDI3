using System;
using System.Collections.Generic;
using System.Text;

namespace TDI3
{
    public class Elev
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public List<Note> Note { get; set; }

        public Elev(string Nume, string Prenume, List<Note> Note)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.Note = Note;
        }

        public int GetMedieElev(List<Note> note)
        {
            int medie = 0;

            foreach (var item in note)
            {
                medie += item.Nota;
            }

            medie /= note.Count;

            return medie;
        }

        public string GetNoteElev(Elev elevul)
        {
            string elev = elevul.Nume + " " + elevul.Prenume + ": " ;


            foreach (var item in elevul.Note)
            {
                elev += item;
            }

            return elev;
        }
    }
}
