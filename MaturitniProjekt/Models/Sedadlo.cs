using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniProjekt.Models
{
    public class Sedadlo
    {
        public int Rada
        {
            get; set;
        }

        public int Id { 
            get; set;
        }

        public int Cislo
        {
            get; set;
        }

        public TypSedadla Typ
        {
            get; set;
        }

        public Sedadlo()
        {

        }

        public Sedadlo(int rada, int id, int cislo, TypSedadla typ)
        {
            Rada = rada;
            Id = id;
            Cislo = cislo;
            Typ = typ;
        }

        public override string ToString()
        {
            return "Řada" + Rada + ", místo " + Cislo;
        }
    }
}
