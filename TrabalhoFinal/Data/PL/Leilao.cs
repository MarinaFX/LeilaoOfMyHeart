using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoFinal.Data.PL
{
    public abstract class Leilao
    {
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }


        public abstract bool FazerLance();
    }
}