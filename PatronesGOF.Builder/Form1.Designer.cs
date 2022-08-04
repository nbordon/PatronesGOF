namespace PatronesGOF.Builder
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
            this.cboMontajes = new System.Windows.Forms.ComboBox();
            this.lstIngredientes = new System.Windows.Forms.ListBox();
            this.btnConstruirPizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione línea de montaje:";
            // 
            // cboMontajes
            // 
            this.cboMontajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMontajes.FormattingEnabled = true;
            this.cboMontajes.Location = new System.Drawing.Point(36, 92);
            this.cboMontajes.Name = "cboMontajes";
            this.cboMontajes.Size = new System.Drawing.Size(142, 21);
            this.cboMontajes.TabIndex = 1;
            // 
            // lstIngredientes
            // 
            this.lstIngredientes.Enabled = false;
            this.lstIngredientes.FormattingEnabled = true;
            this.lstIngredientes.Location = new System.Drawing.Point(36, 138);
            this.lstIngredientes.Name = "lstIngredientes";
            this.lstIngredientes.Size = new System.Drawing.Size(588, 121);
            this.lstIngredientes.TabIndex = 2;
            // 
            // btnConstruirPizza
            // 
            this.btnConstruirPizza.Location = new System.Drawing.Point(207, 89);
            this.btnConstruirPizza.Name = "btnConstruirPizza";
            this.btnConstruirPizza.Size = new System.Drawing.Size(190, 23);
            this.btnConstruirPizza.TabIndex = 3;
            this.btnConstruirPizza.Text = "Construir Pizza";
            this.btnConstruirPizza.UseVisualStyleBackColor = true;
            this.btnConstruirPizza.Click += new System.EventHandler(this.btnConstruirPizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConstruirPizza);
            this.Controls.Add(this.lstIngredientes);
            this.Controls.Add(this.cboMontajes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizzeria Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMontajes;
        private System.Windows.Forms.ListBox lstIngredientes;
        private System.Windows.Forms.Button btnConstruirPizza;
    }
}

