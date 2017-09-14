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
       
        
        public CtrlAddCollabo(FrmList windowParent)
        {
            this.windowParent = windowParent;
            this.window = new FrmDetailCollabo();
            initWindow();
            this.window.ShowDialog();
        }

        public void initWindow()
        {
            this.window.Text = "Ajouter un collaborateur";
            this.window.groupBox1.Text = "Ajouter collaborateur";

            this.window.buttonOk.Text = "Valider";
            this.window.buttonAnnuler.Text = "Annuler";
            this.window.buttonAddContrat.Text = "Ajouter Contrat";
            this.window.buttonAppliquerModifier.Visible = false;
            

            this.window.buttonOk.Click += new EventHandler(valider);
        }

        public void valider(object sender, EventArgs e)
        {
            string nom = this.window.tbNom.Text;
            string prenom = this.window.tbPrenom.Text;
            string qualification = this.window.tbQualification.Text;
            int anciennete = Convert.ToInt32(this.window.tbAncienneté.Text);
            float salaireInitial = Convert.ToInt32(this.window.tbSalaire.Text);


            Collaborateur c = new Collaborateur(nom, prenom, qualification, anciennete, salaireInitial, null);
            Collaborateurs.getCollaborateurs().AddCollaborateur(c);
            this.windowParent.dgv.Refresh();
            this.window.Close();
            

        }

        public void annuler(object sender, EventArgs e)
        {

        }

        public void AddContrat(object sender, EventArgs e)
        {

        }

        public void AddImage(object sender, EventArgs e)
        {

        }

    }
}
