using System;

namespace Week6.SupermercatoEF.Models
{
    public class Dipendente
    {
        public string Codice { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }

        public int? RepartoNumero { get; set; }
        public Reparto Reparto { get; set; }
    }
}