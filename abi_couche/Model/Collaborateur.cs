using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
   public class Collaborateur
    {

        private static int currentMatricule = 1;

        private int matricule;
        private string nomCollabo;
        private string prenomCollabo;
        private string qualificationPrincipaleCourante;
        private int anciennete;
        private float salaireBrut;
        private List<Contrat> contrats;
        
               
        public Collaborateur()
        {
            this.contrats = new List<Contrat>();
        }
        public Collaborateur(int matricule, string nomCollabo, string prenomCollabo, string qualificationPrincipaleCourante, int anciennete, float salaireBrut, List<Contrat> contrats)
        {
            this.matricule = matricule;
            this.nomCollabo = nomCollabo;
            this.prenomCollabo = prenomCollabo;
            this.qualificationPrincipaleCourante = qualificationPrincipaleCourante;
            this.anciennete = anciennete;
            this.salaireBrut = salaireBrut;
            this.contrats = contrats;
       
            
        }
        public Collaborateur(string nomCollabo, string prenomCollabo, string qualificationPrincipaleCourante, int anciennete, float salaireBrut, List<Contrat> contrats)
        {
            this.matricule = currentMatricule++;
            this.nomCollabo = nomCollabo;
            this.prenomCollabo = prenomCollabo;
            this.qualificationPrincipaleCourante = qualificationPrincipaleCourante;
            this.anciennete = anciennete;
            this.salaireBrut = salaireBrut;
            this.contrats = contrats;


        }
        public Collaborateur(string nomCollabo, string prenomCollabo, string qualificationPrincipaleCourante, int anciennete, float salaireBrut)
        {
            this.matricule = currentMatricule++;
            this.nomCollabo = nomCollabo;
            this.prenomCollabo = prenomCollabo;
            this.qualificationPrincipaleCourante = qualificationPrincipaleCourante;
            this.anciennete = anciennete;
            this.salaireBrut = salaireBrut;
            this.contrats = new List<Contrat>();


        }

        public static int CurrentMatricule
        {
            get
            {
               return currentMatricule;
            }
        }

        public int Matricule
        {
            get
            {
                return matricule;
            }

            set
            {
                if (value < 0) throw new Exception("Matricule can't be negative");
                matricule = value;
            }
        }

        public string NomCollabo
        {
            get
            {
                return nomCollabo;
            }

            set
            {
                if(value==null) throw new Exception("name can't be Null");
                nomCollabo = value;
            }
        }

        public float SalaireBrut
        {
            get
            {
                return salaireBrut;
            }

            set
            {
                if (value < 0) throw new Exception("salary can't be negative");
                salaireBrut = value;
            }
        }

        public string PrenomCollabo
        {
            get
            {
                return prenomCollabo;
            }

            set
            {
                prenomCollabo = value;
            }
        }

        public string QualificationPrincipaleCourante
        {
            get
            {
                return qualificationPrincipaleCourante;
            }

            set
            {
                qualificationPrincipaleCourante = value;
            }
        }

        public int Anciennete
        {
            get
            {
                return anciennete;
            }

            set
            {
                anciennete = value;
            }
        }

        public List<Contrat> Contrats
        {
            get
            {
                return contrats;
            }

            set
            {
                contrats = value;
            }
        }

      

       

        public override string ToString()
        {

            string result = "";
            
            result += "Matricule: ";
            result += this.Matricule;
            result += " - ";
            result += "Prénom: ";
            result += this.prenomCollabo;
            result += " - ";
            result += "Nom: ";
            result += this.NomCollabo;
            result += " - ";
            result += "Salaire Brut: ";
            result += this.SalaireBrut;
            result += " - ";
            result += "Qualification: ";
            result += this.QualificationPrincipaleCourante;
            result += " - ";
            result += "Ancienneté: ";
            result += this.Anciennete;
            result += " | ";
           


            return result;
        }
    }
}
