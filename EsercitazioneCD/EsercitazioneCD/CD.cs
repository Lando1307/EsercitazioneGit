using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneCD
{
    internal class CD
    {
        private string titolo;
        private string autore;
        private List<Brano> brani;

        public CD(string titolo, string autore, List<Brano> brani)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.brani = brani;
        }

        public string getTitolo()
        {
            return titolo;
        }

        public void setTitolo(string titolo)
        {
            this.titolo = titolo;
        }

        public string getAutore()
        {
            return autore;
        }

        public void setAutore(string autore)
        {
            this.autore = autore;
        }

        public string toString()
        {
            string s = "";
            foreach (Brano b in brani)
            {
                s += b.getTitolo() + "\t";
            }
            return s;
        }

        public double getDurata()
        {
            double durata = 0;
            foreach (Brano b in brani)
            {
                durata += b.getDurata();
            }
            return durata;
        }
    }
}
