using LinqLambda.Modelagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LinqLambda.Consultas
{
    public class ConsultasLinq
    {
        private List<Aluno> TabelaAlunos { get; set; }

        private List<Curso> TabelaCursos { get; set; }

        private List<Professor> TabelaProfessores { get; set; }

        private List<Turma> TabelaTurmas { get; set; }

        public ConsultasLinq()
        {
            TabelaAlunos = PreenchmentoDeDados.CriarAlunos();
            TabelaCursos = PreenchmentoDeDados.CriarCursos();
            TabelaProfessores = PreenchmentoDeDados.CriarProfessores();
            TabelaTurmas = PreenchmentoDeDados.CrirarTurma();
        }

        public List<string> SelecionarNomeDosAlunos()
        {
            //tabAlujnos apelido para a coleção in Collection
            return (from tabAlunos in TabelaAlunos
                    select tabAlunos.Nome).ToList();
        }

        public List<string> SelecionarProfessorPorCurso(int idCurso)
        {
            return (from tabProfessor in TabelaProfessores
                    where tabProfessor.AptoParaCurso.Contains(idCurso)
                    select tabProfessor.Nome).ToList();
        }

        public bool VerificarSeCursoExiste(string palavraChave)
        {
            //Any faz a consulta para saber se existe algum, se existir retorna verdadeiro.
            return (from tabCurso in TabelaCursos
                    select tabCurso)
                    .Any(x => x.Descricao.Contains(palavraChave));
        }

        public object SelecionarDadosDaTurma()
        {
            //Quando quero retornar uma informação que não tem um padrão de um objeto pre criado.
            //Vai criar um objeto do tipo anonymous que vai ter duas propriedades com essa informaçãoes
            //primeira propriedade vai ser do tipo Turma e a segunda propriedade vai ser do tipo Prof
            return (from tabTurma in TabelaTurmas
                    join tabProf in TabelaProfessores on tabTurma.IdProfessor equals tabProf.Id
                    select new { Turma = tabTurma, Prof = tabProf })
                    .ToList();
        }
    }
}
