using System;

namespace Week6.SupermercatoEF.Models
{
    public class Vendita
    {
        public int NumeroVendita { get; set; }
        public int Quantita { get; set; }
        public DateTime DataVendita { get; set; }
        
        public String CodiceProdotto { get; set; }
        public Prodotto Prodotto { get; set; }
    }
}