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
    public partial class FormAdmin : Form
    {
        List<Aluno> ListaAlunos;

        public FormAdmin(List<Aluno> l)
        {
            InitializeComponent();
            ListaAlunos = l;
            //lbAlunos.DataSource = ListaAlunos;
            AtualizaLista();
        }
        //adicionar
        private void button1_Click(object sender, EventArgs e)
        {
            string nprocesso = tbNProcesso.Text;
            string nome = tbNome.Text;
            DateTime data = dtPData.Value;
            string campo1 = tbCampo1.Text;
            string campo2 = tbCampo2.Text;
            Aluno aluno;
            if (rbProf.Checked)
            {
                aluno = new AlunoProf(campo1, campo2, nprocesso, nome, data);
            }
            else
            {
                aluno = new AlunoReg(campo1, campo2, nprocesso, nome, data);
            }
            ListaAlunos.Add(aluno);
            AtualizaLista();
        }

        private void AtualizaLista()
        {
            lbAlunos.Items.Clear();
            foreach (Aluno a in ListaAlunos)
                lbAlunos.Items.Add(a);
        }

        //profissional
        private void rbProf_CheckedChanged(object sender, EventArgs e)
        {
            lbCampo1.Text = "Curso";
            lbCampo2.Text = "Nif";
        }
        //regular
        private void rbReg_CheckedChanged(object sender, EventArgs e)
        {
            lbCampo1.Text = "Turma";
            lbCampo2.Text = "Ano Escolar";
        }

        private void lbCampo1_Click(object sender, EventArgs e)
        {

        }

        private void lbCampo2_Click(object sender, EventArgs e)
        {

        }
        //remover elemento
        private void button2_Click(object sender, EventArgs e)
        {
            int posicao = lbAlunos.SelectedIndex;
            if (posicao < 0)
            {
                MessageBox.Show("Selecione o elemento a remover");
                return;
            }
            ListaAlunos.RemoveAt(posicao);
            AtualizaLista();

        }

        private void detalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aluno escolhido = DevolveAlunoEscolhido();
            if(escolhido!=null) MessageBox.Show(escolhido.ToString());

        }

        private Aluno DevolveAlunoEscolhido()
        {
            Aluno escolhido = (Aluno)lbAlunos.SelectedItem;
            if (escolhido == null)
            {
                MessageBox.Show("Selecione o aluno");
                return null;
            }
            return escolhido;
        }

        private void entradaSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aluno escolhido = (Aluno)lbAlunos.SelectedItem;
            if (escolhido != null)
                escolhido.Entrada_Saida();
            AtualizaLista();
        }
    }
}
