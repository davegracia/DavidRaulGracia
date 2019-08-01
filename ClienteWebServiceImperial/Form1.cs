using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClienteWebServiceImperial.ServicioImperial;

namespace ClienteWebServiceImperial
{
    public partial class Form1 : Form
    {
        readonly WebServiceImperialSoapClient _clienteImperial = new WebServiceImperialSoapClient();
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(textBox1.Text) && !String.IsNullOrWhiteSpace(textBox2.Text))
            {
                var datos = new List<string> { textBox1.Text, textBox2.Text }.ToList();

                ArrayOfString identificacion = new ArrayOfString();

                _clienteImperial.AdjuntarRebelde(textBox1.Text);
                _clienteImperial.AdjuntarPlaneta(textBox2.Text);

                identificacion.AddRange(datos);

                _clienteImperial.AdjuntarIdentificacion(identificacion);
            }
            else
            {
                Log.Error("No se ha procedido a la insercíon de datos " + DateTime.Now);
                MessageBox.Show("No puedes dejarlo vacio ni con espacios en blanco");
            }
        }
    }
}
