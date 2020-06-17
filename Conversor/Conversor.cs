using Conversor.CustomControlItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Conversor
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
        }

       
        private void frmConversor_Load(object sender, EventArgs e)
        {

            LoadComboBox();

        }

        private void LoadComboBox()    /// Cargar los combo Box
        {
            ComboBoxItem OpcionDefecto = new ComboBoxItem
            {
                Text = "Seleccione",
                value = null

            };

            ComboBoxItem PesosOpcion = new ComboBoxItem
            {
                Text = "Pesos",
                value = 1
            };
            ComboBoxItem DolarOpcion = new ComboBoxItem
            {
                Text = "Dolar",
                value = 2
            };
            ComboBoxItem EuroOpcion = new ComboBoxItem
            {
                Text = "Euro",
                value = 3
            };

            ////Agregamos las opciones a los Combo Box
            cbxMonedaOrigen.Items.Add(OpcionDefecto);
            cbxMonedaOrigen.Items.Add(PesosOpcion); 
            cbxMonedaOrigen.Items.Add(DolarOpcion);
            cbxMonedaOrigen.Items.Add(EuroOpcion);
            cbxMonedaOrigen.SelectedItem = OpcionDefecto;

            cbxMonedaDestino.Items.Add(OpcionDefecto);
            cbxMonedaDestino.Items.Add(PesosOpcion);
            cbxMonedaDestino.Items.Add(DolarOpcion);
            cbxMonedaDestino.Items.Add(EuroOpcion);
            cbxMonedaDestino.SelectedItem = OpcionDefecto;

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {

            try
            {
                ComboBoxItem seleccionadoOrigen = cbxMonedaOrigen.SelectedItem as ComboBoxItem;
                ComboBoxItem seleccionadoDestino = cbxMonedaDestino.SelectedItem as ComboBoxItem;

                if (seleccionadoOrigen.value == null)
                {
                    MessageBox.Show("Seleccione denominacion de origen");
                }
                if (seleccionadoDestino.value == null)
                {
                    MessageBox.Show("Seleccione denominacion destino");
                }
                if (string.IsNullOrEmpty(txtTotal.Text.Trim()))
                {
                    MessageBox.Show("Inserte cantidad a convertir");
                }
            }
            catch(Exception exception)
            {

                MessageBox.Show("Debe colocar una cantidad Numerica");
                    
                    throw;
            }
          
                
        }
    }
}
