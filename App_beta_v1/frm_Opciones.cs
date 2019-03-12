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
    public partial class frm_Opciones : Form
    {
        public frm_Opciones()
        {
            InitializeComponent();
        }

        private void frm_Opciones_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();

        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            frm_Suma suma = new frm_Suma();
            suma.Show(this);
            this.Hide();
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            frm_Resta resta = new frm_Resta();
            resta.Show(this);
            this.Hide();
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            frm_Multi multi = new frm_Multi();
            multi.Show(this);
            this.Hide();
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            frm_Divisiones divi = new frm_Divisiones();
            divi.Show(this);
            this.Hide();
        }
    }
}
