using abi_couche.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    class CtrlAddCollabo
    {

        private FrmList windowParent;
        private FrmDetailCollabo window;
        private Collaborateur collaborateur;
       
        
        public CtrlAddCollabo(FrmList windowParent)
        {
            this.collaborateur = new Collaborateur();
            this.windowParent = windowParent;
            this.window = new FrmDetailCollabo();
            initWindow();
            initListener();
            this.window.ShowDialog();
        }

        private void initWindow()
        {
            this.window.Text = "Ajouter un collaborateur";
            this.window.groupBox1.Text = "Ajouter collaborateur n°"+Collaborateur.CurrentMatricule;

            this.window.buttonOk.Text = "Valider";
            this.window.buttonAnnuler.Text = "Annuler";
            this.window.buttonAddContrat.Text = "Ajouter Contrat";
            this.window.buttonAppliquerModifier.Visible = false;
            

           
        }

        private void initListener()
        {
            this.window.buttonOk.Click += new EventHandler(ClickValider);
            this.window.buttonAnnuler.Click += new EventHandler(ClickAnnuler);
            this.window.buttonAddContrat.Click += new EventHandler(ClickAddContrat);
        }
        private void ClickValider(object sender, EventArgs e)
        {
            string nom = this.window.tbNom.Text;
            string prenom = this.window.tbPrenom.Text;
            string qualification = this.window.tbQualification.Text;
            int anciennete = Convert.ToInt32(this.window.tbAncienneté.Text);
            float salaireInitial = Convert.ToInt32(this.window.tbSalaire.Text);

            collaborateur.NomCollabo = nom;
            collaborateur.PrenomCollabo =prenom;
            collaborateur.QualificationPrincipaleCourante =qualification;
            collaborateur.SalaireBrut =salaireInitial;
            collaborateur.Anciennete =anciennete;
            
            Collaborateurs.getCollaborateurs().AddCollaborateur(collaborateur);
            this.windowParent.dgv.Refresh();
            this.window.Close();
            

        }

        private void ClickAnnuler(object sender, EventArgs e)
        {

        }

        private void ClickAddContrat(object sender, EventArgs e)
        {
            CtrlAddContrat cac = new CtrlAddContrat(this.collaborateur);
        }

    }
}
