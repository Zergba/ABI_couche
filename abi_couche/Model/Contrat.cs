using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    public abstract class Contrat
    {

        private static int currentID = 1;

        protected int id;
        protected DateTime dateDebut;
        protected DateTime dateFin;
        protected string motif;
        protected float remuneration;

        public Contrat(DateTime dateDebut, DateTime dateFin, string motif, float remuneration)
        {
            this.id = currentID++;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.motif = motif;
            this.remuneration = remuneration;
        }

        public static int CurrentID
        {
            get
            {
                return currentID;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public DateTime DateDebut
        {
            get
            {
                return dateDebut;
            }
        }

        public DateTime DateFin
        {
            get
            {
                return dateFin;
            }

            set
            {
                dateFin = value;
            }
        }

        public string Motif
        {
            get
            {
                return motif;
            }
        }

        public float Remuneration
        {
            get
            {
                return remuneration;
            }
        }
    }
}
