using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abi_couche
{
    class CtrlMDI
    {

        private MDIParent window;

        public MDIParent Window{
            get{
                return window;
            }
        }
        public CtrlMDI()
        {
            this.window = new MDIParent();
            init();
        }

        private void init()
        {
            window.listeCollaboToolStripMenuItem.Click += new EventHandler(openListCollabo);
        }




        private void openListCollabo(object senders, EventArgs e)
        {
            CtrlListCollabo clc = new CtrlListCollabo(this.window);
        }



    }
}
