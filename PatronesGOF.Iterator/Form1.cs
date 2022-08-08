using PatronesGOF.Iterator.Ejemplo.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronesGOF.Iterator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            _iterador = _collection.CrearIterator();
            InitializeComponent();
        }

        private Collection _collection = new ConcreteCollection();
        private IteratorEjemplo _iterador;

        private void Listar()
        {
            lstLista.Items.Clear();
            _iterador.First();
            Item i = _iterador.CurrentItem();

            if(i != null) lstLista.Items.Add(i);

            while (!_iterador.IsDone())
            {
                _iterador.Siguiente();
                lstLista.Items.Add(_iterador.CurrentItem());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var item = new Item(txtItem.Text);
            _collection.Agregar(item);

            Listar();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            _iterador.First();
            txtPrimero.Text = _iterador.CurrentItem().Nombre;
            txtActual.Text = _iterador.CurrentItem().Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_iterador.IsDone())
            {
                _iterador.Siguiente();
                txtActual.Text = _iterador.CurrentItem().Nombre;
            }
        }
    }
}
