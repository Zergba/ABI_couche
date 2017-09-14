using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    public class Collaborateurs
    {

        private List<Collaborateur> listCollaborateur;
        private static Collaborateurs collaborateurs;
        
        private Collaborateurs()
        {
            this.listCollaborateur = new List<Collaborateur>();
            this.init();
        }

        public static Collaborateurs getCollaborateurs()
        {
            if (Collaborateurs.collaborateurs == null) Collaborateurs.collaborateurs = new Collaborateurs();
            return Collaborateurs.collaborateurs;
        }


        public void AddCollaborateur(Collaborateur collaborateur)
        {
            if(!this.listCollaborateur.Contains(collaborateur))
            {
                this.listCollaborateur.Add(collaborateur);
            }
        }

        public void RemoveCollaborateur(Collaborateur collaborateur)
        {
            if (this.listCollaborateur.Contains(collaborateur))
            {
                this.listCollaborateur.Remove(collaborateur);
            }
        }

        public List<Collaborateur> getAllCollaborateur()
        {
            return new List<Collaborateur>(this.listCollaborateur);
        }

        public Collaborateur getCollaborateurByMatricule(int matricule)
        {
            Collaborateur result = null;
            foreach(Collaborateur collaborateur in this.listCollaborateur){
                if (collaborateur.Matricule == matricule) result = collaborateur;
            }
            return result;
        }

        public Collaborateur getCollaborateurByNomCollabo(string nomCollabo)
        {
            Collaborateur result = null;
            foreach (Collaborateur collaborateur in this.listCollaborateur)
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
