using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascenseur
{
    internal class Ascenseur
    {
        private int etage;
        private int etageMax;
        private int etageMin;
        private bool etatPorte;

        public Ascenseur(int etageMax, int etageMin)
        {
            this.etageMax = etageMax;
            this.etageMin = etageMin;
            etage = 0;
            etatPorte = false;
        }

        

        public void monter()
        {
            if (etage < etageMax)
            {
                etage++;
            }
        }

        public void descendre()
        {
            if (etage > etageMin)
            {
                etage--;
            }
        }

        public int getEtage()
        {
            return etage;
        }

        public void setEtage(int etage)
        {
            this.etage = etage;
        }


       
    }
}
