using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    class Qualification
    {

        private int id;
        private string libelle;

        public Qualification(int id, string libelle)
        {
            this.id = id;
            this.Libelle = libelle;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Libelle
        {
            get
            {
                return libelle;
            }

            set
            {
                if (value == null) throw new Exception("Libelle can't be Null");
                libelle = value;
            }
        }

        public override string  ToString()
        {
            string result = "";

            result += "ID: ";
            result += this.Id;
            result += " - ";
            result += "Libéllé: ";
            result += this.Libelle;
            result += " | ";

            return result;
        }
    }
}
