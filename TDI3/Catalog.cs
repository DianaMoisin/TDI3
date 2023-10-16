using System;
using System.Collections.Generic;
using System.Text;

namespace TDI3
{
    public class Catalog
    {
        public string NumeClasa { get; set; }

        public List<Elev> Elevi { get; set; }

        public Catalog(string NumeClasa, List<Elev> elevi)
        {
            this.NumeClasa = NumeClasa;
            this.Elevi = elevi;
        }

        public Catalog()
        {
        }

        public string GetClasaElev(Catalog catalog)
        {
            string numeElev = "";
            string clasa = catalog.NumeClasa + ": ";

            foreach (var item in catalog.Elevi)
            {
                numeElev = item.Nume + " " + item.Prenume;
                clasa += numeElev;
            }

            return clasa;
        }

        public string GetPremiantul(Catalog catalog)
        {
            string elev = "";
            int nota = 0;

            foreach (var item in catalog.Elevi)
            {
                foreach (var element in item.Note)
                {
                    if (item.GetMedieElev(item.Note) > nota)
                    {
                        nota = element.Nota;
                        elev = item.Nume + " " + item.Prenume;
                    }
                }
            }
            return elev;
        }
    }
}
