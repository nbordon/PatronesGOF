using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronesGOF.TemplateMethod
{
    public partial class Form1 : Form
    {
        List<Cliente> _clientes;
        List<string> _creditos;

        public Form1()
        {
            InitializeComponent();

            _clientes = new List<Cliente>();
            _clientes.Add(new Cliente() { Nombre = "Roberto Gomez" });
            _clientes.Add(new Cliente() { Nombre = "Marta Sanchez" });

            this.cmbClientes.DataSource = _clientes;

            _creditos = new List<string>();
            _creditos.Add("Personal");
            _creditos.Add("Hipotecario");

            this.cmbCreditos.DataSource = _creditos;
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            var credito = this.cmbCreditos.SelectedItem.ToString();
            var cliente = (Cliente) this.cmbClientes.SelectedItem;

            try
            {
                if (credito == null) throw new Exception("Debe seleccionar un Crédito");

                Credito c;

                switch (credito)
                {
                    case "Hipotecario":
                        c = new CreditoHipotecario(cliente);
                        break;
                    case "Personal":
                        c = new CreditoPersonal(cliente);
                        break;
                    default:
                        throw new Exception("Debe seleccionar un Crédito");
                }

                this.lstResultado.Items.Clear();
                this.lstResultado.Items.AddRange(c.Verificar());
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
