namespace CLASE_MARTES27
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
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.lblMontoPrestamo = new System.Windows.Forms.Label();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pnlCalculo = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.txtValorCuota = new System.Windows.Forms.TextBox();
            this.lblValorCuota = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.lblInteres = new System.Windows.Forms.Label();
            this.pnlCalculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Location = new System.Drawing.Point(50, 24);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(77, 13);
            this.lblDatosCliente.TabIndex = 0;
            this.lblDatosCliente.Text = "Datos clientes:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(53, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del Cliente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(53, 99);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(158, 99);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 4;
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Location = new System.Drawing.Point(56, 147);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(101, 13);
            this.lblPrestamo.TabIndex = 5;
            this.lblPrestamo.Text = "Datos del prestamo:";
            // 
            // lblMontoPrestamo
            // 
            this.lblMontoPrestamo.AutoSize = true;
            this.lblMontoPrestamo.Location = new System.Drawing.Point(53, 180);
            this.lblMontoPrestamo.Name = "lblMontoPrestamo";
            this.lblMontoPrestamo.Size = new System.Drawing.Size(198, 13);
            this.lblMontoPrestamo.TabIndex = 6;
            this.lblMontoPrestamo.Text = "Ingrese el monto del prestamo a solicitar:";
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Location = new System.Drawing.Point(267, 180);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(170, 20);
            this.txtMontoPrestamo.TabIndex = 7;
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(56, 213);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(144, 13);
            this.lblCuotas.TabIndex = 8;
            this.lblCuotas.Text = "Ingrese el número de cuotas:";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(267, 213);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(170, 20);
            this.txtCuotas.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(56, 239);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(381, 35);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pnlCalculo
            // 
            this.pnlCalculo.Controls.Add(this.textBox1);
            this.pnlCalculo.Controls.Add(this.lblTotalPago);
            this.pnlCalculo.Controls.Add(this.txtValorCuota);
            this.pnlCalculo.Controls.Add(this.lblValorCuota);
            this.pnlCalculo.Controls.Add(this.txtInteres);
            this.pnlCalculo.Controls.Add(this.lblInteres);
            this.pnlCalculo.Location = new System.Drawing.Point(56, 292);
            this.pnlCalculo.Name = "pnlCalculo";
            this.pnlCalculo.Size = new System.Drawing.Size(381, 146);
            this.pnlCalculo.TabIndex = 11;
            this.pnlCalculo.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Location = new System.Drawing.Point(6, 100);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(137, 13);
            this.lblTotalPago.TabIndex = 4;
            this.lblTotalPago.Text = "Total a pagar por el crédito:";
            // 
            // txtValorCuota
            // 
            this.txtValorCuota.Location = new System.Drawing.Point(156, 49);
            this.txtValorCuota.Name = "txtValorCuota";
            this.txtValorCuota.Size = new System.Drawing.Size(145, 20);
            this.txtValorCuota.TabIndex = 3;
            // 
            // lblValorCuota
            // 
            this.lblValorCuota.AutoSize = true;
            this.lblValorCuota.Location = new System.Drawing.Point(6, 52);
            this.lblValorCuota.Name = "lblValorCuota";
            this.lblValorCuota.Size = new System.Drawing.Size(90, 13);
            this.lblValorCuota.TabIndex = 2;
            this.lblValorCuota.Text = "Valor de la cuota:";
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(156, 9);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(145, 20);
            this.txtInteres.TabIndex = 1;
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(3, 12);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(130, 13);
            this.lblInteres.TabIndex = 0;
            this.lblInteres.Text = "Interés mensual en pesos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCalculo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.txtMontoPrestamo);
            this.Controls.Add(this.lblMontoPrestamo);
            this.Controls.Add(this.lblPrestamo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDatosCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlCalculo.ResumeLayout(false);
            this.pnlCalculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Label lblMontoPrestamo;
        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel pnlCalculo;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.TextBox txtValorCuota;
        private System.Windows.Forms.Label lblValorCuota;
    }
}

