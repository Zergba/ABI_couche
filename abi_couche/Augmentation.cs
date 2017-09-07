using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    public class Augmentation
    {

        private int id;
        private int montant;
        private DateTime date;
        private string motif;

        public int Montant
        {
            get
            {
                return montant;
            }

            set
            {
                if (value <= 0) throw new Exception("Montant can't be inferior to 1");
                montant = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                if (value == null) throw new Exception("Date can't be Null");

                date = value;
            }
        }

        public string Motif
        {
            get
            {
                return motif;
            }

            set
            {
                if (value == null) throw new Exception("Motif can't be Null");
                motif = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public Augmentation(int id, int montant, DateTime date, string motif)
        {
            this.id = id;
            this.Montant = montant;
            this.Date = date;
            this.Motif = motif;
        }

        public override string ToString()
        {
            string result = "";

            result += "ID: ";
            result += this.Id;
            result += " - ";
            result += " Montant: ";
            result += this.Montant;
            result += " - ";
            result += " Date: ";
            result += this.Date;
            result += " - ";
            result += " Motif: ";
            result += this.Motif;
            result += " | ";


            return result;
        }
    }
}
