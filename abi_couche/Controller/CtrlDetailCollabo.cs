using abi_couche.Controller;
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
            initListener();
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
            fd.buttonAnnuler.Enabled = false;

        }

        private void initListener()
        {
            fd.buttonOk.Click += new EventHandler(ClickOk);
            fd.buttonAppliquerModifier.Click += new EventHandler(ClickModifier);
            fd.buttonAddContrat.Click += new EventHandler(ClickAddContrat);


        }

        private void ClickOk(object sender, EventArgs e)
        {
            fd.Close();
        }

        private void ClickModifier(object sender, EventArgs e)
        {

            CtrlUpdateCollabo cuc = new CtrlUpdateCollabo(this.collaborateur);
        }

        private void ClickAddContrat(object sender, EventArgs e)
        {
             CtrlAddContrat cac = new CtrlAddContrat(collaborateur);
        }
    }
}
