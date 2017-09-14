using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche.Controller
{
    class CtrlAddContrat
    {

        FrmDetailContrat window;
        Collaborateur collaborateur;


        public CtrlAddContrat(Collaborateur collaborateur) {
            this.collaborateur = collaborateur;
            this.window = new FrmDetailContrat();
            initWindow();
            initListener();
            window.Show();
        }

        private void initWindow()
        {
            window.Text = "Ajouter un contrat";
            window.gbContrat.Text = "Contrat n°"+Contrat.CurrentID;

        }

        private void initListener()
        {
            this.window.buttonAnnuler.Click += new EventHandler(clickAnnuler);
            this.window.buttonAnnuler.Click += new EventHandler(clickValider);
        }

        private void clickValider(Object sender, EventArgs e)
        {

        }

        private void clickAnnuler(Object sender, EventArgs e)
        {
            window.Close();
        }

    }
}
