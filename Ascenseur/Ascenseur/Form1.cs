using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascenseur
{

    
    public partial class Form1 : Form
    {
        Ascenseur ascenseur = new Ascenseur(2, 0);

        public Form1()
        {

            InitializeComponent();

        }



        public void etage2_Click(object sender, EventArgs e)
        {

            ascenseur.setEtage(2);
            etage.Text = ascenseur.getEtage().ToString();
            timer1_Tick(sender, e);
        }

        private void etage1_Click(object sender, EventArgs e)
        {
            ascenseur.setEtage(1);
            etage.Text = ascenseur.getEtage().ToString();
            timer1_Tick(sender, e);
        }

        private void etage0_Click(object sender, EventArgs e)
        {
            ascenseur.setEtage(0);
            etage.Text = ascenseur.getEtage().ToString();
            timer1_Tick(sender, e);

        }
        public void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ascenseur.setEtage(2);
            etage.Text = ascenseur.getEtage().ToString();
            timer1_Tick(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ascenseur.setEtage(1);
            etage.Text = ascenseur.getEtage().ToString();
            timer1_Tick(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ascenseur.setEtage(0);
            etage.Text = ascenseur.getEtage().ToString();
            timer1_Tick(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //verifier si l'ascenseur est a l'etage sinon le faire monter ou descendre en incrementant ou decrementant la position Y avec un switch case
            //si l'ascenseur est a l'etage alors ouvrir la porte
            //si la porte est ouverte alors la fermer
            switch (ascenseur.getEtage())
            {
                case 0:
                    if (ascenseur.getPosY() != 200)
                {
                        ascenseur.setPosY(ascenseur.getPosY() + 10);
                        groupBox1.Location = new Point(ascenseur.getPosX(), ascenseur.getPosY());
                    }
                    else
                    {
                        if (ascenseur.getEtatPorte() == false)
                        {
                            ascenseur.setEtatPorte(true);
                        }
                        else
                        {
                            ascenseur.setEtatPorte(false);
                        }
                    }
                    break;
                case 1:
                    if (ascenseur.getPosY() != 100)
                    {
                        if (ascenseur.getPosY() > 100)
                        {
                            ascenseur.setPosY(ascenseur.getPosY() - 10);
                            groupBox1.Location = new Point(ascenseur.getPosX(), ascenseur.getPosY());
                        }
                        else
                        {
                            ascenseur.setPosY(ascenseur.getPosY() + 10);
                            groupBox1.Location = new Point(ascenseur.getPosX(), ascenseur.getPosY());
                        }
                    }
                    else
                    {
                        if (ascenseur.getEtatPorte() == false)
                        {
                            ascenseur.setEtatPorte(true);
                        }
                        else
                        {
                            ascenseur.setEtatPorte(false);
                        }
                    }
                    break;
                case 2:
                    if (ascenseur.getPosY() != 0)
                    {
                        ascenseur.setPosY(ascenseur.getPosY() - 10);
                        groupBox1.Location = new Point(ascenseur.getPosX(), ascenseur.getPosY());
                    }
                    else
                    {
                        if (ascenseur.getEtatPorte() == false)
                        {
                            ascenseur.setEtatPorte(true);
                        }
                        else
                        {
                            ascenseur.setEtatPorte(false);
                        }
                    }
                    break;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
