﻿namespace PatronesGOF.Strategy
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreJugador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboArma = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarArma = new System.Windows.Forms.Button();
            this.btnDisparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jugador";
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.AutoSize = true;
            this.txtNombreJugador.Location = new System.Drawing.Point(12, 84);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(45, 13);
            this.txtNombreJugador.TabIndex = 1;
            this.txtNombreJugador.Text = "Jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arma";
            // 
            // comboArma
            // 
            this.comboArma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboArma.Location = new System.Drawing.Point(15, 192);
            this.comboArma.Name = "comboArma";
            this.comboArma.Size = new System.Drawing.Size(121, 21);
            this.comboArma.TabIndex = 3;
            // 
            // btnSeleccionarArma
            // 
            this.btnSeleccionarArma.Location = new System.Drawing.Point(13, 232);
            this.btnSeleccionarArma.Name = "btnSeleccionarArma";
            this.btnSeleccionarArma.Size = new System.Drawing.Size(123, 23);
            this.btnSeleccionarArma.TabIndex = 4;
            this.btnSeleccionarArma.Text = "Seleccionar Arma";
            this.btnSeleccionarArma.UseVisualStyleBackColor = true;
            this.btnSeleccionarArma.Click += new System.EventHandler(this.btnSeleccionarArma_Click);
            // 
            // btnDisparar
            // 
            this.btnDisparar.Location = new System.Drawing.Point(13, 125);
            this.btnDisparar.Name = "btnDisparar";
            this.btnDisparar.Size = new System.Drawing.Size(123, 23);
            this.btnDisparar.TabIndex = 5;
            this.btnDisparar.Text = "Disparar";
            this.btnDisparar.UseVisualStyleBackColor = true;
            this.btnDisparar.Click += new System.EventHandler(this.btnDisparar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 308);
            this.Controls.Add(this.btnDisparar);
            this.Controls.Add(this.btnSeleccionarArma);
            this.Controls.Add(this.comboArma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreJugador);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CS GO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNombreJugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboArma;
        private System.Windows.Forms.Button btnSeleccionarArma;
        private System.Windows.Forms.Button btnDisparar;
    }
}

