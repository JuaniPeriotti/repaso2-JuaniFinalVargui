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
    }
}
