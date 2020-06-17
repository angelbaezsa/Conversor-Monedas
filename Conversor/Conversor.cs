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
            cbxMonedaOrigen.Items.Add(PesosOpcion); 
            cbxMonedaOrigen.Items.Add(DolarOpcion);
            cbxMonedaOrigen.Items.Add(EuroOpcion);

            cbxMonedaDestino.Items.Add(PesosOpcion);
            cbxMonedaDestino.Items.Add(DolarOpcion);
            cbxMonedaDestino.Items.Add(EuroOpcion);

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {

            ComboBoxItem seleccionado = cbxMonedaDestino.SelectedItem as ComboBoxItem;
            MessageBox.Show(seleccionado.Text, "Valor seleccionado");
        }
    }
}
