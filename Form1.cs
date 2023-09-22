using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Lab2Asi_DS23003
{
    /// <summary>
    /// Autor: Juan Cristobal De Leon Sanchez
    /// Carne: DS23003
    /// Fecha: 22/09/2023
    /// Programcion I
    /// Laboratorio 2 Asincrono Evaluado
    /// Gasolinera Shell
    /// </summary>

    public partial class Form1 : Form
    {
        List<Cliente> listaClientes = new List<Cliente>();
        public Form1()
        {
            InitializeComponent();
            txtNombre.KeyPress += new KeyPressEventHandler(txtNombre_KeyPress);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            {

                // Información del cliente desde el formulario
                string nombre = txtNombre.Text;
                string tipoCombustible = cbCombustible.SelectedItem.ToString();
                double galones;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(tipoCombustible) || !double.TryParse(txtGalones.Text, out galones) || galones < 0)
                {
                    MessageBox.Show("No pueden quedar campos vacios");
                    return;
                }

                double precioCombustible = (tipoCombustible == "Diesel") ? 3.50 : 4.00;
                double totalPagar = galones * precioCombustible;

                Cliente nuevoCliente = new Cliente(nombre, tipoCombustible, galones, totalPagar);
                listaClientes.Add(nuevoCliente);

                MessageBox.Show($@"Cliente {nombre} 
Tipo de combustible: {tipoCombustible}
Total a pagar $:  {totalPagar}");

                // Mostramos los datos en el GroupBox
                gbClienteDatos.Text = "Cliente";
                lblNombre.Text = $"Nombre: {nombre}";
                lblTipoCombustible.Text = $"Tipo de Combustible: {tipoCombustible}";
                lblTotalPagar.Text = $"Total a Pagar: {totalPagar.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
                // Actualizar  DataGridView
                dataGridViewResultados.Rows.Add(nombre, tipoCombustible, totalPagar);
            }
        }

        private void btnMostrarResultados_Click(object sender, EventArgs e)
        {
            //Cantidad de pagos realizados y el total de ventas
            int cantidadPagos = listaClientes.Count;
            double totalVentas = 0;

            Dictionary<string, int> conteoCombustibles = new Dictionary<string, int>();

            for (int i = 0; i < listaClientes.Count; i++)
            {
                Cliente cliente = listaClientes[i];
                totalVentas += cliente.TotalPagar;

                if (conteoCombustibles.ContainsKey(cliente.TipoCombustible))
                {
                    conteoCombustibles[cliente.TipoCombustible]++;
                }
                else
                {
                    conteoCombustibles[cliente.TipoCombustible] = 1;
                }
            }

            string combustibleMasComprado = "";
            int maxCompras = 0;

            // Encontramos el combustible más comprado en la tienda
            IEnumerator<KeyValuePair<string, int>> enumerator = conteoCombustibles.GetEnumerator();
            while (enumerator.MoveNext())
            {
                KeyValuePair<string, int> kvp = enumerator.Current;
                if (kvp.Value > maxCompras)
                {
                    combustibleMasComprado = kvp.Key;
                    maxCompras = kvp.Value;
                }
            }

            // Mostrar los resultados generales en el DataGridView
            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Rows.Add("Cantidad de Pagos Realizados:", cantidadPagos);
            dataGridViewResultados.Rows.Add("Combustible más Comprado:", combustibleMasComprado);
            dataGridViewResultados.Rows.Add("Monto Total de Ventas Ingresadas:", totalVentas);
        }

        public class Cliente
        {
            public string Nombre { get; set; }
            public string TipoCombustible { get; set; }
            public double Galones { get; set; }
            public double TotalPagar { get; set; }

            public Cliente(string nombre, string tipoCombustible, double galones, double totalPagar)
            {
                Nombre = nombre;
                TipoCombustible = tipoCombustible;
                Galones = galones;
                TotalPagar = totalPagar;
            }
        }

        private void dataGridViewResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validacion para que solo se ingresen letras, espacios y teclas de retroceso
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiamos los campos
            txtGalones.Clear();
            txtNombre.Clear();
            lblNombre.Text = "Nombre: ";
            lblTotalPagar.Text = "Total a pagar: ";
            lblTipoCombustible.Text = "Tipo de combustible: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Terminamos la ejecucion de la aplicacion
            MessageBox.Show("Gracias por preferirnos :) ");
            //Cantidad de pagos realizados y el total de ventas
            int cantidadPagos = listaClientes.Count;
            double totalVentas = 0;

            Dictionary<string, int> conteoCombustibles = new Dictionary<string, int>();

            for (int i = 0; i < listaClientes.Count; i++)
            {
                Cliente cliente = listaClientes[i];
                totalVentas += cliente.TotalPagar;

                if (conteoCombustibles.ContainsKey(cliente.TipoCombustible))
                {
                    conteoCombustibles[cliente.TipoCombustible]++;
                }
                else
                {
                    conteoCombustibles[cliente.TipoCombustible] = 1;
                }
            }

            string combustibleMasComprado = "";
            int maxCompras = 0;

            // Encontramos el combustible más comprado en la tienda
            IEnumerator<KeyValuePair<string, int>> enumerator = conteoCombustibles.GetEnumerator();
            while (enumerator.MoveNext())
            {
                KeyValuePair<string, int> kvp = enumerator.Current;
                if (kvp.Value > maxCompras)
                {
                    combustibleMasComprado = kvp.Key;
                    maxCompras = kvp.Value;
                }
            }

            // Mostrar los resultados generales en el DataGridView
            MessageBox.Show( Convert.ToString("Cantidad de pagos realizados: "+ cantidadPagos));
            MessageBox.Show(Convert.ToString("El combustible mas comprado fue: "+ combustibleMasComprado));
            MessageBox.Show(Convert.ToString("El monto en el total de ventas es: " + totalVentas));




            Close();
        }
    }
}


