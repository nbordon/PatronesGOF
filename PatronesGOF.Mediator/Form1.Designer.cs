namespace PatronesGOF.Mediator
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
            this.lstMensajes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensaje1 = new System.Windows.Forms.TextBox();
            this.txtMensaje2 = new System.Windows.Forms.TextBox();
            this.btnEnviar1 = new System.Windows.Forms.Button();
            this.btnEnviar2 = new System.Windows.Forms.Button();
            this.lstMsgUsuario1 = new System.Windows.Forms.ListBox();
            this.lstMsgUsuario2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstMensajes
            // 
            this.lstMensajes.FormattingEnabled = true;
            this.lstMensajes.Location = new System.Drawing.Point(263, 40);
            this.lstMensajes.Name = "lstMensajes";
            this.lstMensajes.Size = new System.Drawing.Size(502, 368);
            this.lstMensajes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "De Usuario1 a Usuario2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(793, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "De Usuario2 a Usuario1";
            // 
            // txtMensaje1
            // 
            this.txtMensaje1.Location = new System.Drawing.Point(16, 73);
            this.txtMensaje1.Name = "txtMensaje1";
            this.txtMensaje1.Size = new System.Drawing.Size(117, 20);
            this.txtMensaje1.TabIndex = 3;
            // 
            // txtMensaje2
            // 
            this.txtMensaje2.Location = new System.Drawing.Point(796, 73);
            this.txtMensaje2.Name = "txtMensaje2";
            this.txtMensaje2.Size = new System.Drawing.Size(117, 20);
            this.txtMensaje2.TabIndex = 4;
            // 
            // btnEnviar1
            // 
            this.btnEnviar1.Location = new System.Drawing.Point(139, 70);
            this.btnEnviar1.Name = "btnEnviar1";
            this.btnEnviar1.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar1.TabIndex = 5;
            this.btnEnviar1.Text = "Enviar";
            this.btnEnviar1.UseVisualStyleBackColor = true;
            this.btnEnviar1.Click += new System.EventHandler(this.btnEnviar1_Click);
            // 
            // btnEnviar2
            // 
            this.btnEnviar2.Location = new System.Drawing.Point(919, 70);
            this.btnEnviar2.Name = "btnEnviar2";
            this.btnEnviar2.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar2.TabIndex = 6;
            this.btnEnviar2.Text = "Enviar";
            this.btnEnviar2.UseVisualStyleBackColor = true;
            this.btnEnviar2.Click += new System.EventHandler(this.btnEnviar2_Click);
            // 
            // lstMsgUsuario1
            // 
            this.lstMsgUsuario1.FormattingEnabled = true;
            this.lstMsgUsuario1.HorizontalScrollbar = true;
            this.lstMsgUsuario1.Location = new System.Drawing.Point(16, 118);
            this.lstMsgUsuario1.Name = "lstMsgUsuario1";
            this.lstMsgUsuario1.Size = new System.Drawing.Size(198, 290);
            this.lstMsgUsuario1.TabIndex = 7;
            // 
            // lstMsgUsuario2
            // 
            this.lstMsgUsuario2.FormattingEnabled = true;
            this.lstMsgUsuario2.HorizontalScrollbar = true;
            this.lstMsgUsuario2.Location = new System.Drawing.Point(796, 118);
            this.lstMsgUsuario2.Name = "lstMsgUsuario2";
            this.lstMsgUsuario2.Size = new System.Drawing.Size(198, 290);
            this.lstMsgUsuario2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.Controls.Add(this.lstMsgUsuario2);
            this.Controls.Add(this.lstMsgUsuario1);
            this.Controls.Add(this.btnEnviar2);
            this.Controls.Add(this.btnEnviar1);
            this.Controls.Add(this.txtMensaje2);
            this.Controls.Add(this.txtMensaje1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMensajes);
            this.Name = "Form1";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMensajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensaje1;
        private System.Windows.Forms.TextBox txtMensaje2;
        private System.Windows.Forms.Button btnEnviar1;
        private System.Windows.Forms.Button btnEnviar2;
        private System.Windows.Forms.ListBox lstMsgUsuario1;
        private System.Windows.Forms.ListBox lstMsgUsuario2;
    }
}

