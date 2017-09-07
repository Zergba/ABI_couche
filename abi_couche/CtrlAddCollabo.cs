using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    class CtrlAddCollabo
    {

        FrmDetail window;
       
        
        public CtrlAddCollabo()
        {
            this.window = new FrmDetail();
            initWindow();
            this.window.ShowDialog();
        }

        public void initWindow()
        {
            this.window.Text = "Ajouter un collaborateur";
            this.window.groupBox1.Text = "Ajouter collaborateur n°" + "X";

            this.window.buttonContracts.Text = "Valider";
            this.window.buttonCurrentContract.Text = "Annuler";
            this.window.buttonModifier.Text = "Ajouter Contrat";
            this.window.buttonAugmenter.Visible = false;
            this.window.buttonPicture.Text = "Ajouter Image";

            this.window.buttonContracts.Click += new EventHandler(valider);




        }

        public void valider(object sender, EventArgs e)
        {
            string nom = this.window.tbNom.Text;
            string prenom = this.window.tbPrenom.Text;
            string qualification = this.window.tbQualification.Text;
            int anciennete = Convert.ToInt32(this.window.tbAncienneté.Text);
            float salaireInitial = Convert.ToInt32(this.window.tbSalaireInitial.Text);
            bool actif = this.window.checkBox1.Checked;
            string photographie = "";

            Collaborateur c = new Collaborateur(0, nom, prenom, qualification, anciennete, salaireInitial, actif);


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
