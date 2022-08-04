using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronesGOF.Builder
{
    public partial class Form1 : Form
    {
        List<PizzaBuilder> _lineas;
        public Form1()
        {
            InitializeComponent();

            _lineas = new List<PizzaBuilder>();
            _lineas.Add(new PizzaItalianaBuilder());
            _lineas.Add(new PizzaLightBuilder());
            _lineas.Add(new PizzaMuzzaBuilder());
            _lineas.Add(new PizzaCanchaBuilder());

            this.cboMontajes.DataSource = _lineas;
        }

        private void btnConstruirPizza_Click(object sender, EventArgs e)
        {
            PizzaBuilder builder = (PizzaBuilder)cboMontajes.SelectedItem;
            Pizza pizza = builder.BuildPizza();

            this.lstIngredientes.Items.Add(pizza);
        }
    }
}
