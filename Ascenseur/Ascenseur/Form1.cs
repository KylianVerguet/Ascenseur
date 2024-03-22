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

        

        public void monter_Click(object sender, EventArgs e)
        {
            
            ascenseur.monter();
            etage.Text = ascenseur.getEtage().ToString();
        }

        public void descendre_Click(object sender, EventArgs e)
        {
            ascenseur.descendre();
            etage.Text = ascenseur.getEtage().ToString();

        }

        public void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
