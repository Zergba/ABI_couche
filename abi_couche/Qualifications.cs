using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    class Qualifications
    {
        private List<Qualification> listQualification;


        public void AddQualification(Qualification qualification)
        {
            if (!this.listQualification.Contains(qualification))
            {
                this.listQualification.Add(qualification);
            }
        }

        public void RemoveQualification(Qualification qualification)
        {
            if (this.listQualification.Contains(qualification))
            {
                this.listQualification.Remove(qualification);
            }
        }

        public List<Qualification> getAllQualification()
        {
            return new List<Qualification>(this.listQualification);
        }

        public Qualification getQualificationById(int id)
        {
            Qualification result = null;
            foreach (Qualification qualification in this.listQualification)
            {
                if (qualification.Id == id) result = qualification;
            }
            return result;
        }

        public Qualification getQualificationByLibelle(string libelle)
        {
            Qualification result = null;
            foreach (Qualification qualification in this.listQualification)
            {
                if (qualification.Libelle == libelle) result = qualification;
            }
            return result;
        }

        public Qualifications()
        {
            this.listQualification = new List<Qualification>();
        }
        public Qualifications(List<Qualification>listQualification)
        {
            this.listQualification = listQualification;
        }


    }
}
