using Lab10.entities;
using Lab10.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class FormRuta : Form
    {
        String matricula;
        private RutaService rutaService = new RutaService();
        public FormRuta(string matricula)
        {
            InitializeComponent();
            this.matricula = matricula;
            MostrarRutas(rutaService.ListarTodo(matricula));
        }
        private void MostrarRutas(List<Ruta> rutas)
        {
            dgRutas.DataSource = null;
            if (rutas.Count == 0)
            {
                return;
            }
            else
            {
                dgRutas.DataSource = rutas;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (txbCodigo.Text == "" || txbOrigen.Text == "" || txbDestino.Text == "" || txbKilometros.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Ruta ruta = new Ruta()
            {
                Codigo = txbCodigo.Text,
                Origen = txbOrigen.Text,
                Destino = txbDestino.Text,
                Kilometros = double.Parse(txbKilometros.Text)
            };

            // Registro de ruta
            bool registrado = rutaService.Registrar(matricula, ruta);
            if (!registrado)
            {
                MessageBox.Show("Ingrese un código diferente");
                return;
            }

            // Mostrar en el ListView
            MostrarRutas(rutaService.ListarTodo(matricula));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
