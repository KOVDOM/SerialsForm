using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            lista.Items.Clear();
            q.dbSelect(lista);
        }
        Queries q = new Queries();
        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            q.dbInsert(lista);
            lista.Items.Clear();
            q.dbSelect(lista);
        }

        private void lista_Click(object sender, EventArgs e)
        {
            string szoveg = lista.Text.ToString();
            string[] darabok=szoveg.Split('-');
            textBox1.Text = darabok[0];
            textBox2.Text= darabok[1];
        }

        private void lista_DoubleClick(object sender, EventArgs e)
        {
            q.dbDelete(Convert.ToInt32(textBox1.Text));
            lista.Items.Clear();
            q.dbSelect(lista);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            q.dbUpdate(Convert.ToInt32(textBox1.Text));
            lista.Items.Clear();
            q.dbSelect(lista);
        }
    }
}
