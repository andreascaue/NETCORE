using LinqLambda.Modelagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqLambda.Consultas
{
    public class ConsultasLambdas
    {
        private List<Aluno> TabelaAlunos { get; set; }

        private List<Curso> TabelaCursos { get; set; }

        private List<Professor> TabelaProfessores { get; set; }

        private List<Turma> TabelaTurmas { get; set; }
    

        public ConsultasLambdas()
        {
            TabelaAlunos = PreenchmentoDeDados.CriarAlunos();
            TabelaCursos = PreenchmentoDeDados.CriarCursos();
            TabelaProfessores = PreenchmentoDeDados.CriarProfessores();
            TabelaTurmas = PreenchmentoDeDados.CrirarTurma();
        }

        public List<string> SelecionarNomeDosAlunos()
        {
            //Na frente vai ter a collection nesse caso TabelaAlunos
            //Depois a palavra chave para que você faça consultas nesse caso SELEC
            //Podemos fazer a seleção de um ou n campos da minha collection
            //O x representa uma variável
            //Sempre nesse tipo de consulta os parametros ficam do lado esquerdo do => e a consulta 
            //que você realizar no lado direito do =>
            return TabelaAlunos.Select(x => x.Nome).ToList();
        }

        public List<string> SelecionarProfessorPorCurso(int idCurso)
        {
            //Where para adcionar condições na minha consulta
            return TabelaProfessores
                .Where(x => x.AptoParaCurso.Contains(idCurso))
                .Select(x => x.Nome).ToList();
        }

        public bool VerificarSeCursoExiste(string palavraChave)
        {
            //
            return TabelaCursos.Any(x => x.Descricao.Contains(palavraChave));
        }

        public object SelecionarDadosDaTurma()
        {
            //Quando quero retornar uma informação que não tem um padrão de um objeto pre criado.
            //Vai criar um objeto do tipo anonymous que vai ter duas propriedades com essa informaçãoes
            //primeira propriedade vai ser do tipo Turma e a segunda propriedade vai ser do tipo Prof
            //(turma, prof) são os paramtros que passamos para o novo objeto que vai ser criado
            return TabelaTurmas.Join(
                TabelaProfessores,
                turma => turma.IdProfessor,
                prof => prof.Id,
                (turma, prof) => new { Turma = turma, Prof = prof}
                );
        }

    }
}
