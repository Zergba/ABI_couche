using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    class Stage : Contrat
    {
        public Stage(DateTime dateDebut, DateTime dateFin, string motif, float remuneration) : base(dateDebut, dateFin, motif, remuneration)
        {
        }
    }
}
