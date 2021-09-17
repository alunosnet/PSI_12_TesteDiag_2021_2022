using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12H_TesteDiag_2021
{
    public class AlunoProf : Aluno
    {
        string Curso;
        string Nif;

        public AlunoProf(string curso, string nif,string nprocesso, string nome, DateTime dataNascimento, bool estado = false) 
            : base(nprocesso, nome, dataNascimento, estado)
        {
            Curso = curso;
            Nif= nif;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" - {0} - {1}",Curso,Nif);
        }
    }
}
