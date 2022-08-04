using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronesGOF.Strategy
{
    public partial class Form1 : Form
    {
        List<Arma> _estrategiasDisparo;
        Jugador _jugador;
        public Form1()
        {
            InitializeComponent();

            _estrategiasDisparo = new List<Arma>();

            _estrategiasDisparo.Add(new Pistola());
            _estrategiasDisparo.Add(new Bazooka());
            _estrategiasDisparo.Add(new Ak47());
            _estrategiasDisparo.Add(new AireComprimido());

            this.comboArma.DataSource = _estrategiasDisparo;

            _jugador = new Jugador();
            _jugador.Nombre = "Rambo";
            this.txtNombreJugador.Text = _jugador.Nombre;

        }

        private void btnDisparar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_jugador.Disparar());
        }

        private void btnSeleccionarArma_Click(object sender, EventArgs e)
        {
            Arma arma = (Arma)this.comboArma.SelectedItem;
            _jugador.CambiarEstrategia(arma);
        }
    }
}
