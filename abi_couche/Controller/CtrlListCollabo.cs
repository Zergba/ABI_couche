using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace abi_couche
{
    class CtrlListCollabo
    {


        private MDIParent parent;
        private FrmList window;
        
        private BindingSource source;

        public CtrlListCollabo(MDIParent parent)
        {

            this.parent = parent;
            
            this.source = new BindingSource();

            this.initWindow();
        }

       
        private void initGrid(BindingSource source)
        {
            this.window.dgv.DataSource = source;
            this.window.dgv.Refresh();
        }
        private void initGrid()
        {
            this.window.dgv.DataSource = new BindingList<Collaborateur>();
            this.window.dgv.Refresh();
        }

        private void initWindow()
        {
            
           
            this.window = new FrmList();
            this.window.MdiParent = this.parent;
            this.window.Text = "Liste des Collaborateurs";
            this.source.DataSource = Collaborateurs.getCollaborateurs().ListCollaborateur;
            this.initGrid(this.source);
            this.window.dgv.SelectionChanged += new EventHandler(selectionChanged);
            this.window.dgv.CellDoubleClick += new DataGridViewCellEventHandler(showDetail);
            this.window.buttonRight.Click += new EventHandler(showDetail);
            this.window.buttonCenter.Click += new EventHandler(showUpdate);
            this.window.buttonLeft.Click += new EventHandler(showAdd);


            this.window.buttonRight.Text = "Détail";
            this.window.buttonCenter.Text = "Modifier";
            this.window.buttonLeft.Text = "Ajouter";


            this.window.Show();
        }


        private void showAdd(object senders, EventArgs e)
        {
            CtrlAddCollabo cac = new CtrlAddCollabo(this.window);
        }

        private void showDetail(object senders, EventArgs e)
        {
            foreach(DataGridViewRow  row in this.window.dgv.SelectedRows)
            {
                Collaborateur collaborateur = row.DataBoundItem as Collaborateur;
                CtrlDetailCollabo cdc = new CtrlDetailCollabo(collaborateur);
            }
            
        }

        private void showUpdate(object senders, EventArgs e)
        {
            foreach (DataGridViewRow row in this.window.dgv.SelectedRows)
            {
                Collaborateur collaborateur = row.DataBoundItem as Collaborateur;
                CtrlUpdateCollabo cuc = new CtrlUpdateCollabo(collaborateur);
            }
            
        }

        private void selectionChanged(object senders, EventArgs e)
        {
            if (this.window.dgv.SelectedRows.Count <= 0)
            {
                this.window.buttonRight.Enabled = false;
                this.window.buttonLeft.Enabled = false;
            }
            else
            {
                this.window.buttonRight.Enabled = true;
                this.window.buttonLeft.Enabled = true;
            }
        }













    }
}
