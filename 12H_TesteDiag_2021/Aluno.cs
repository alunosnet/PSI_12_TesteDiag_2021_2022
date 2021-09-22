using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12H_TesteDiag_2021
{
    public class Aluno
    {
        string Nprocesso;
        string Nome;
        DateTime DataNascimento;
        bool Estado;    //True->Na escola; False -> fora da escola

        public Aluno(string nprocesso, string nome, DateTime dataNascimento, bool estado=false)
        {
            Nprocesso = nprocesso;
            Nome = nome;
            DataNascimento = dataNascimento;
            Estado = estado;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}",
                Nprocesso, Nome, (Estado ? "Na Escola" : "Fora da escola"));
        }

        internal void Entrada_Saida()
        {
            Estado = !Estado;
        }
    }
}
