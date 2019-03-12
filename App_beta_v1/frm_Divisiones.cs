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
    public partial class frm_Divisiones : Form
    {
        int contadorA = 0;
        int contadorE = 0;
        int divi = 0;
        public frm_Divisiones()
        {
            InitializeComponent();
            MessageBox.Show("CUANDO ESCRIBA SU RESPUESTA DE UNA DE LAS 3 OPCIONES DADAS, ESCRIBA EL RESULTADO NO EL INCISO", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void consultar()
        {
            int a = 2;
            Random aux = new Random(Guid.NewGuid().GetHashCode());
            

                tb_num1.Text = Convert.ToString(aux.Next(1, 10)*10);
                tb_num2.Text = Convert.ToString(aux.Next(1, 10));

               

            divi = int.Parse(tb_num1.Text) / int.Parse(tb_num2.Text);

        }
        public void limpiar()
        {
            tb_num1.Text = "";
            tb_num2.Text = "";
            tb_res.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("Las reglas son sencillas, acierta correctamente 5 divisiones y ganas, fallas 3 y pierdes,IMPORTANTE DEBES ESCRIBIR EL RESULTADO QUE CREAS ES EL CORRECTO DE UNA DE LAS 3 OPCIONES SOLO EL RESULTADO NO LA LETRA Buena Suerte!!", "REGLAS DEL JUEGO");
                consultar();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btn_comprobar_Click(object sender, EventArgs e)
        {
            int res = 0;
            res = int.Parse(tb_res.Text);


            if (divi == res)
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
                MessageBox.Show("FELICIDADES COMPLETASTE CON EXITO LAS RESTAS");
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

        private void frm_Divisiones_Load(object sender, EventArgs e)
        {

        }
    }
}
