using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12H_TesteDiag_2021
{
    public partial class Form1 : Form
    {
        List<Aluno> ListaAlunos=new List<Aluno>();
        public Form1()
        {
            InitializeComponent();

        }
        //sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //admin
        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin f = new FormAdmin(ListaAlunos);
            f.Show();
        }
        //aluno
        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //portaria
        private void portariaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
