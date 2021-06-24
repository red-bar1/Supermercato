﻿using System;
using System.Collections.Generic;

namespace Week6.SupermercatoEF.Models
{
    public class Prodotto
    {
        public String Codice { get; set; }
        public String Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        
        public int RepartoNumero { get; set; }
        public Reparto Reparto { get; set; }

        public ICollection<Vendita> Vendite { get; set; } = new List<Vendita>();
    }
}