using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    class CtrlDetailCollabo
    {


        private Collaborateur collaborateur;
        private FrmDetailCollabo fd;

        public CtrlDetailCollabo(Collaborateur collaborateur)
        {
            this.collaborateur = collaborateur;

            initForm();
            loadCollaborateur();

            fd.Show();
        }

        private void loadCollaborateur()
        {
            fd.Text = collaborateur.Matricule.ToString() + " - " + collaborateur.PrenomCollabo + " " + collaborateur.NomCollabo;
            fd.groupBox1.Text = "Détail du Matricule n°" + collaborateur.Matricule.ToString();

            fd.tbAncienneté.Text = collaborateur.Anciennete.ToString();
            fd.tbNom.Text = collaborateur.NomCollabo;
            fd.tbPrenom.Text = collaborateur.PrenomCollabo;
            fd.tbQualification.Text = collaborateur.QualificationPrincipaleCourante;
            fd.tbSalaire.Text = collaborateur.SalaireBrut.ToString();

            fd.Text = "Détail du Client n°" + collaborateur.Matricule.ToString();




        }

        private void initForm()
        {
            this.fd = new FrmDetailCollabo();
            
            fd.tbAncienneté.ReadOnly = true;
            fd.tbNom.ReadOnly = true;
            fd.tbPrenom.ReadOnly = true;
            fd.tbQualification.ReadOnly = true;
            fd.tbSalaire.ReadOnly = true;

            



        }
    }
}
