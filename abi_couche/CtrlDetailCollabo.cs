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
        private FrmDetail fd;

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
            fd.tbSalaireInitial.Text = collaborateur.SalaireBrut.ToString();
            fd.checkBox1.Checked = collaborateur.Actif;




        }

        private void initForm()
        {
            this.fd = new FrmDetail();
            this.fd.buttonPicture.Visible = false;
            this.fd.checkBox1.Text = "Collaborateur Actif";
        }
    }
}
