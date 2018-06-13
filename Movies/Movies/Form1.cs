using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    public partial class Form1 : Form
    {
        public event EventHandler<ARGS> OnSearch;

        public Form1()
        {
            InitializeComponent();
        }
        public string GetTexto()
        { string texto = TextBuscador.Text;
            return texto;
        }
        public void NoSeBusca()
        { listBox1.Items.Add("Debe ingresar al menos 3 caracteres en el cuadro de busqueda."); }

        public void mostrarInfo(Object o)
        {

            listBox1.Items.Add(o.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
