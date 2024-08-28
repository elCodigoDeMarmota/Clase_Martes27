using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE_MARTES27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal tasa = 0.0M;
            decimal interesmensual = 0.0M;
            decimal valorCuota = 0.0M;
          
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) ||
                    string.IsNullOrEmpty(txtEdad.Text) ||
                    string.IsNullOrEmpty(txtMontoPrestamo.Text) ||
                    string.IsNullOrEmpty(txtCuotas.Text))
                {
                    MessageBox.Show("Debe ingresar todos los datos requeridos");
                    return;
                }
                else
                {
                    int Edad = Convert.ToInt32(txtEdad.Text);
                    if (Edad< 18) 
                    {
                        MessageBox.Show("Debe ser mayor de 18 años");
                    }
                    else
                    {
                        pnlCalculo.Visible = true;
                        if ((Edad > 60))
                        { 
                        tasa = 0.04M;
                        }
                        else 
                        {
                            tasa = 0.10M;
                        }
                        interesmensual = Convert.ToDecimal(txtMontoPrestamo.Text) * tasa;
                        txtInteres.Text = interesmensual.ToString();
                        valorCuota = Convert.ToDecimal(txtMontoPrestamo.Text)/ 

                    }
                }
            }
            catch (Exception Nombre)
            {

                throw Nombre;
            }
            
        }
    }
}
