using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneCD
{
    internal class Brano
    {
        // Attributi privati
        private string titolo;
        private string autore;
        private double durata;

        // Costruttore
        public Brano(string titolo, string autore, double durata)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.durata = durata;
        }

        // Metodi getter
        public string GetTitolo()
        {
            return titolo;
        }

        public string GetAutore()
        {
            return autore;
        }

        public double GetDurata()
        {
            return durata;
        }

        // Metodi setter
        public void SetTitolo(string titolo)
        {
            this.titolo = titolo;
        }

        public void SetAutore(string autore)
        {
            this.autore = autore;
        }

        public void SetDurata(double durata)
        {
            this.durata = durata;
        }

        // Metodo ToString che restituisce una stringa con tutti i dati dell'oggetto
        public override string ToString()
        {
            return $"Titolo: {titolo}, Autore: {autore}, Durata: {durata} minuti";
        }

        // Metodo shortSong che verifica se il brano ha una durata inferiore al limite passato
        public bool ShortSong(double durataLimite)
        {
            return durata < durataLimite;
        }
    }
}
