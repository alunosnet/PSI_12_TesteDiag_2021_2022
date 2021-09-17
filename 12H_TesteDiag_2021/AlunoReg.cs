using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12H_TesteDiag_2021
{
    public class AlunoReg : Aluno
    {
        string Turma;
        string AnoEscolar;

        public AlunoReg(string turma,string anoescolar,string nprocesso, string nome, DateTime dataNascimento, bool estado = false) : base(nprocesso, nome, dataNascimento, estado)
        {
            Turma = turma;
            AnoEscolar = anoescolar;
        }
        public override string ToString()
        {
            return base.ToString() + String.Format(" - {0} - {1}", Turma, AnoEscolar); ;
        }
    }
}
