using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_beta_v1
{
    public partial class frm_Multi : Form
    {
        int contadorA = 0;
        int contadorE = 0;
        int multi = 0;
        public frm_Multi()
        {
            InitializeComponent();
        }
        public void consultar()
        {

            Random aux = new Random(Guid.NewGuid().GetHashCode());


            tb_num1.Text = Convert.ToString(aux.Next(1, 10));
            tb_num2.Text = Convert.ToString(aux.Next(1, 10));

            multi = int.Parse(tb_num1.Text) * int.Parse(tb_num2.Text);
        }

        public void limpiar()
        {
            tb_num1.Text = "";
            tb_num2.Text = "";
            tb_res.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Las reglas son sencillas, acierta correctamente 5 multiplicaciones y ganas, fallas 3 y pierdes, Buena Suerte!!", "REGLAS DEL JUEGO");
            consultar();
        }

        private void btn_comprobar_Click(object sender, EventArgs e)
        {
            int res = 0;
            res = int.Parse(tb_res.Text);


            if (multi == res)
            {
                MessageBox.Show("Haz acertado!! ");
                contadorA++;
                limpiar();
                consultar();

            }
            else
            {
                MessageBox.Show("Haz fallado :( esfuerzate mas");
                contadorE++;
                limpiar();
                consultar();
            }

            tb_aciertos.Text = Convert.ToString(contadorA);
            tb_error.Text = Convert.ToString(contadorE);

            if (contadorA >= 5)
            {
                MessageBox.Show("FELICIDADES COMPLETASTE CON EXITO LAS MULTIPLICACIONES");
                this.Owner.Show();
                this.Close();
            }
            else if (contadorE >= 3)
            {
                MessageBox.Show("Que mala suerte intentalo de nuevo");
                this.Owner.Show();
                this.Close();

            }

        }

        private void tb_res_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
