using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excursion.Modelo;

namespace Excursion
{
    public partial class Elementoss : Form
    {

        public Elementoss()
        {
            InitializeComponent();
        }
        
        
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }
        private void GuardarDatos()
        {
            using (CnxEF db = new CnxEF())
            {
                Elementos e = new Elementos();
                e.Nombre = txtElemento.Text;
                e.Calorias = int.Parse(txtCalorias.Text);
                e.Peso = int.Parse(txtPeso.Text);
                
                db.SaveChanges(e);
            }
               
           
        }
    }
}
