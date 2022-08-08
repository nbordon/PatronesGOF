using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronesGOF.Mediator
{
    public partial class Form1 : Form
    {
        Chat _chat;
        Usuario u1;
        Usuario u2;

        public Form1()
        {
            InitializeComponent();
            _chat = new Chatroom();
            u1 = new Usuario1("usuario 1");
            u2 = new Usuario2("usuario 2");

            _chat.Registrar(u1);
            _chat.Registrar(u2);
        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            _chat.Enviar(this.txtMensaje1.Text, u2, u1);
            MonstrarMensajes();
            MonstrarMensajesU2();
        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            _chat.Enviar(this.txtMensaje2.Text, u1, u2);
            MonstrarMensajes();
            MonstrarMensajesU1();
        }

        public void MonstrarMensajesU1()
        {
            this.lstMsgUsuario1.DataSource = null;
            this.lstMsgUsuario1.DataSource = u1.Mensajes;
        }

        public void MonstrarMensajesU2()
        {
            this.lstMsgUsuario2.DataSource = null;
            this.lstMsgUsuario2.DataSource = u2.Mensajes;
        }

        public void MonstrarMensajes()
        {
            this.lstMensajes.DataSource = null;
            this.lstMensajes.DataSource = _chat.Mensajes;
        }
    }
}
