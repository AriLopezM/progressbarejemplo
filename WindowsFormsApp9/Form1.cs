using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        private int conteo;
        public Form1()
        {
            InitializeComponent(); conteo = 0;
        }

        private void tmrPrueba_Tick_1(object sender, EventArgs e)
        {
            conteo++;
            lblValor.Text = conteo.ToString();

            if(pbrTrabajo.Value<100)
                pbrTrabajo.Value++;
            if(pbrTrabajo.Value==100)
                tmrPrueba.Enabled = false;
        }
        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = true;
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrPrueba.Enabled = false;   
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = false;
        }

    }
}



