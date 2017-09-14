using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abi_couche
{
    class CtrlUpdateCollabo
    {

        FrmDetailCollabo fd;
        Collaborateur collaborateur;

        public CtrlUpdateCollabo(Collaborateur collaborateur)
        {
            initForm();
            this.collaborateur = collaborateur;
            this.loadCollaborateur();
            fd.ShowDialog();

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
            fd = new FrmDetailCollabo();
            fd.buttonAppliquerModifier.Text = "Appliquer";
        }


    }
}
