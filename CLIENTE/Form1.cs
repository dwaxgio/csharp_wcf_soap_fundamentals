using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Creo servicio, en el cual se define la interfaz con sus metodos, y la clase que implementa a la interfaz

            // 2. Implemento en cliente el servicio habilitado, ej boton
            MiServicio.Service1Client oClient = new MiServicio.Service1Client(); // Instancio objeto del servicio

            // El objeto instanciado, tiene los metodos de la clase
            string res = oClient.GetData(66, 11);
            MessageBox.Show(res); // Se muestra mensaje en ventana

            // 2.2 Implementación del segundo metodo del servicio
            MiServicio.CompositeType oData = new MiServicio.CompositeType();

            oData.BoolValue = true;
            oData.StringValue = "Prueba";

            var res2 = oClient.GetDataUsingDataContract(oData);
            MessageBox.Show(res2.StringValue);
        }
    }
}
