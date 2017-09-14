using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    class Interim : Contrat
    {
        public Interim(DateTime dateDebut, DateTime dateFin, string motif, float remuneration) : base(dateDebut, dateFin, motif, remuneration)
        {
        }
    }
}
