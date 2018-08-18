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


        private void btnSeleccionarElementos_Click(object sender, EventArgs e)
        {
            GuardarRiscos();
            llenarLista();

        }

        private void GuardarRiscos()
        {
            Riscos r = new Riscos();
            r.Nombre = txtNombreRisco.Text;
            r.Calorias= int.Parse(txtCalorias.Text);
            r.Peso = int.Parse(txtPeso.Text);

            using (CnxEF db = new CnxEF())
            {               
                //db.Riscos.Add(r);
                db.SaveChanges();
            }
        }

        public void llenarLista()
        {
            var c = int.Parse(txtCalorias.Text);
            var p = int.Parse(txtPeso.Text);
            var sumaCalorias = 0;
            var sumaPesos = 0;

            //Traer de la BD los elementos existentes con todos sus datos.
            List<objElementos> listaElementos = new List<objElementos>();
            //listaElementos = "Select * from Elementos"; //Linea Comentada para que pueda funcionar una parte del programa

            //Siclo para encontrar los elementos contenidos en la lista que se pueden incluir dentro de la selección
            foreach (objElementos lista in listaElementos)
            {
                var calorias = lista.Calorias;
                var peso = lista.Peso;

                if (peso < p && calorias < c)
                {
                    sumaCalorias += calorias;
                    sumaPesos += peso;

                    if (sumaPesos < p && sumaCalorias < c)
                    {
                        List<objElementos> seleccion = new List<objElementos>();
                        dgvElementosSeleccionados.DataSource = seleccion;

                    }
                }
            }
            
        }

    }
}
