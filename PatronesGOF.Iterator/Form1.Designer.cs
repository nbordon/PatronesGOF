namespace PatronesGOF.Iterator
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
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimero = new System.Windows.Forms.TextBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(94, 41);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(121, 20);
            this.txtItem.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(253, 38);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstLista
            // 
            this.lstLista.Enabled = false;
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(28, 85);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(300, 160);
            this.lstLista.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Primero";
            // 
            // txtPrimero
            // 
            this.txtPrimero.Location = new System.Drawing.Point(94, 282);
            this.txtPrimero.Name = "txtPrimero";
            this.txtPrimero.ReadOnly = true;
            this.txtPrimero.Size = new System.Drawing.Size(121, 20);
            this.txtPrimero.TabIndex = 5;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(253, 279);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnPrimero.TabIndex = 6;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtActual
            // 
            this.txtActual.AcceptsReturn = true;
            this.txtActual.Location = new System.Drawing.Point(94, 338);
            this.txtActual.Name = "txtActual";
            this.txtActual.ReadOnly = true;
            this.txtActual.Size = new System.Drawing.Size(121, 20);
            this.txtActual.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Actual";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.txtPrimero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Iterador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrimero;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.Label label3;
    }
}

