using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace _28._3
{
    public class Immobile
    {
        public string ID { get; set; }
        public int CAP { get; set; }
        public string Indirizzo { get; set; }
        public string Citta { get; set; }
        public float Mq2 { get; set; }

        


        public override string ToString()
        {
            return $"immobile {ID} {Indirizzo} {CAP} {Citta} {Mq2}";
        }
    }
}