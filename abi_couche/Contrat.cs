﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    public abstract class Contrat
    {
        private int id;
        private List<Avenant> avenants;
        private DateTime dateDebut;
        private DateTime dateFin;
        private string motif;

    }
}
