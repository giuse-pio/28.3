using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28._3
{
    public class Agenzia
    {
        public string Nome { get; set; }


        public List<Immobile> Immobili { get; set; }

        public Immobile Immobile { get; set; }


        public List<Immobile> Ricerca(string id)
        {
            List<Immobile> risultati = new List<Immobile>();
            foreach (var immobile in this.Immobili)
            {
                if (immobile.ID == id)
                {
                    risultati.Add(immobile);
                }
            }
            return risultati;

            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("ID non può essere null o vuoto");
            }
        }

        public void Aggiungi(Immobile immobile)
        {
            if (immobile == null)
            {
                throw new ArgumentNullException(nameof(immobile));
            }

            Immobili.Add(immobile);
        }
    }
}