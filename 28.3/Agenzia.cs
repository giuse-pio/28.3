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

        public Immobile Immobile
        {
            get => default;
            set
            {
            }
        }

        public List<Immobile> Ricerca(string id)
        {
            return this.Immobili.FindAll(Id => Id.ID.Contains(id));
        }

        public void Aggiungi(Immobile immobile)
        {
            this.Immobili.Add(immobile);
        }
    }
}