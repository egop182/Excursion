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
    public partial class Riscoss : Form
    {
        public Riscoss()
        {
            InitializeComponent();
        }
        Riscos r = new Riscos();

        private void btnSeleccionarElementos_Click(object sender, EventArgs e)
        {
            GuardarRiscos();
            llenarLista();
        }

        private void GuardarRiscos()
        {                       
            r.Nombre = txtNombreRisco.Text;
            r.Calorias= int.Parse(txtCalorias.Text);
            r.Peso = int.Parse(txtPeso.Text);

            using (CnxEF db = new CnxEF())
            {               
                db.Riscos.Add(r);
                db.SaveChanges();
                MessageBox.Show("Información del Risco Guardad Correctamente!!!");
            }           
        }

        //Traer de la BD los elementos existentes con todos sus datos.
        public List<Elementos> listaElementos()
        {
            using (CnxEF db = new CnxEF())
                return db.Database.SqlQuery<Elementos>("Select * from Elementos").ToList();               
        }


        public void llenarLista()
        {
            var c = int.Parse(txtCalorias.Text);
            var p = int.Parse(txtPeso.Text);
            var sumaCalorias = 0;
            var sumaPesos = 0;

            //Siclo para encontrar los elementos contenidos en la lista que se pueden incluir dentro de la selección
            List<Elementos> seleccion = new List<Elementos>();
            foreach (Elementos lista in listaElementos())
            {
                var calorias = lista.Calorias;
                var peso = lista.Peso;

                if (peso < p && calorias < c)
                {
                    sumaCalorias += lista.Calorias.Value;
                    sumaPesos += lista.Peso.Value;
                    
                    if (sumaPesos < p && sumaCalorias < c)
                    {
                        seleccion.Add(lista);                      
                        dgvElementosSeleccionados.DataSource = seleccion.ToList();
                    }
                }
            }
        }

    }
}
