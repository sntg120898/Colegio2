using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colegio2
{
    public partial class Colegio : Form
    {
        public Colegio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cmb.Items.Add(txtCurso.Text);
        }

        private void Cmb_SelectedValueChanged(object sender, EventArgs e)
        {
            int indice = Cmb.SelectedIndex;
            lblIndice.Text = indice.ToString();
            
            lblTexto.Text = Cmb.Items[indice].ToString();
        }
    }
}
