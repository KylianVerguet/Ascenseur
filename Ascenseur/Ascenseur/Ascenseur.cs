using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascenseur
{
    internal class Ascenseur
    {
        private int[] etage;
        private int etageMax;
        private int etageMin;
        private bool etatPorte;
        private int PosY;
        private int PosX;


        public Ascenseur(int etageMax, int etageMin)
        {
            etage = new int[etageMax - etageMin + 1];
            this.etageMax = etageMax;
            this.etageMin = etageMin;
            this.PosX = 300;
            this.PosY = 200;
            etatPorte = false;
        }

   

        public int getEtage()
        {
            for (int i = etageMin; i <= etageMax; i++)
            {
                if (etage[i] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public void setEtage(int etage)
        {
            for (int i = etageMin; i <= etageMax; i++)
            {
                if (i == etage)
                {
                    this.etage[i] = 1;
                }
                else
                {
                    this.etage[i] = 0;
                }
            }
        }

        public void setPosY(int PosY)
        {
            this.PosY = PosY;
        }

        public int getPosY()
        {
            return PosY;
        }

        public int getPosX()
        {
            return PosX;
        }

        public bool getEtatPorte()
        {
            return etatPorte;
        }

        public void setEtatPorte(bool etatPorte)
        {
            this.etatPorte = etatPorte;
        }
        

        
    }
}
