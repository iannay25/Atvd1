using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atvd_em_sala
{
    public partial class Form1 : Form
    {
        List<Produto> produto = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cadastro_Click(object sender, EventArgs e)
        {

            Produto p = new Produto();

            p.Codigo = text_codigo.Text;
            p.Descricao = text_descricao.Text;
            p.Precoaqui = Convert.ToDouble(text_precoaqui.Text);
            p.Lucro = Convert.ToDouble(text_lucro.Text);
            p.Precovenda = (p.Precoaqui * p.Lucro / 100) + p.Precoaqui;
            text_valor.Text =  ((p.Precoaqui * p.Lucro /100) + p.Precoaqui).ToString();

            produto.Add(p);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = produto;
            

        }
    }
}
