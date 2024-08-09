using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace repaso2_JuaniFinalVargui
{
    public partial class Form1 : Form
    {
        List<Dictionary<string, string>> listaDeSabores;
        private conexionBD miConexion;

        public Form1()
        {
           InitializeComponent();
           miConexion = new conexionBD(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./HELADITO.mdb;");
           miConexion.abrirConexion();
           List<Dictionary<string, string>> listaDeSabores = miConexion.obtenerSaboresYTipos();
           foreach(var diccionario in listaDeSabores)
           {
                string saborTipo = diccionario["nombre"] + " - " + diccionario["tipo"];
                cbGustos.Items.Add(saborTipo);
           }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> listaTipos = miConexion.obtenerSaboresYTipos();
            cbTipos.Items.Clear();
            cbTipos.Items.AddRange(listaTipos.ToArray());

        }
        private void comboBoxTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el tipo seleccionado
            string tipoSeleccionado = cbTipos.SelectedItem.ToString();

            // Llamar al método que carga los sabores filtrados
            CargarComboBoxSegunTipo(tipoSeleccionado);
        }
        private void CargarComboBoxSegunTipo(string tipo)
        {
            cbTipos.Items.Clear();

            if (listaDeSabores != null && listaDeSabores.Any())
            {
                var saboresFiltrados = listaDeSabores
                    .Where(diccionario => diccionario.ContainsKey("tipo") && diccionario["tipo"].Equals(tipo, StringComparison.OrdinalIgnoreCase))
                    .Select(diccionario => diccionario["nombre"])
                    .ToList();

                if (saboresFiltrados.Count > 0)
                {
                    cbGustos.Items.AddRange(saboresFiltrados.ToArray());
                }
                else
                {
                    MessageBox.Show("No se encontraron sabores para el tipo seleccionado.");
                }
            }
            else
            {
                MessageBox.Show("No se encontraron sabores para el tipo seleccionado.");
            }

        }

    }
}
