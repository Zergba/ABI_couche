using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    public class Cdi : Contrat
    {
        public Cdi(DateTime dateDebut, DateTime dateFin, string motif, float remuneration) : base(dateDebut, dateFin, motif, remuneration)
        {
        }
    }
}
