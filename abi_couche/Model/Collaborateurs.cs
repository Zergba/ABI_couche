using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    public class Collaborateurs
    {

        


        private BindingList<Collaborateur> listCollaborateur;
        private static Collaborateurs collaborateurs;

        public BindingList<Collaborateur> ListCollaborateur
        {
            get
            {
                return listCollaborateur;
            }
        }

        private Collaborateurs()
        {
            this.listCollaborateur = new BindingList<Collaborateur>();
            this.init();
        }

        public static Collaborateurs getCollaborateurs()
        {
            if (Collaborateurs.collaborateurs == null) Collaborateurs.collaborateurs = new Collaborateurs();
            return Collaborateurs.collaborateurs;
        }

        public void AddCollaborateur(string Nom)
        {

        }
        public void AddCollaborateur(Collaborateur collaborateur)
        {
            if(!this.ListCollaborateur.Contains(collaborateur))
            {
                this.ListCollaborateur.Add(collaborateur);
            }
        }

        public void RemoveCollaborateur(Collaborateur collaborateur)
        {
            if (this.ListCollaborateur.Contains(collaborateur))
            {
                this.ListCollaborateur.Remove(collaborateur);
            }
        }

        public Collaborateur getCollaborateurByMatricule(int matricule)
        {
            Collaborateur result = null;
            foreach(Collaborateur collaborateur in this.ListCollaborateur){
                if (collaborateur.Matricule == matricule) result = collaborateur;
            }
            return result;
        }

        public Collaborateur getCollaborateurByNomCollabo(string nomCollabo)
        {
            Collaborateur result = null;
            foreach (Collaborateur collaborateur in this.ListCollaborateur)
            {
                if (collaborateur.NomCollabo == nomCollabo) result = collaborateur;
            }
            return result;
        }

        private void init()
        {
            this.AddCollaborateur(new Collaborateur(1,"a","a","a",10,10,null));
        }






    }
}
