using LinqLambda.Modelagem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;

namespace LinqLambda
{
    public static class PreenchmentoDeDados
    {
        public static List<Aluno> CriarAlunos()
        {
            return new List<Aluno>() {
                new Aluno()
                {
                    Id = 1,
                    Nome = "JoseKlecio",
                    Telefone = "99999-9999",
                    DataNasc = new DateTime(1980,10,30),
                    Email = "joseKlecio@yahoo.com"
                },
                new Aluno()
                {
                    Id = 2,
                    Nome = "Sizenando",
                    Telefone = "98888-8888",
                    DataNasc = new DateTime(1979,9,29),
                    Email = "sizenando@gmail.com"
                },
                new Aluno()
                {
                    Id = 3,
                    Nome = "Wedja",
                    Telefone = "97777-7777",
                    DataNasc = new DateTime(1978,8,28),
                    Email = "wedja@hotmail.com"
                },
                new Aluno(){
                    Id = 4,
                    Nome = "Wadja",
                    Telefone = "96666-6666",
                    DataNasc = new DateTime(1977,7,27),
                    Email = "wadja@gmail.com"
                }
            };
        }

        public static List<Curso> CriarCursos()
        {
            return new List<Curso>()
            {
                new Curso()
                {
                    Id = 1,
                    NomeDoCurso = "Curso A",
                    Descricao = "Curso iniciante."
                },
                new Curso()
                {
                    Id = 2,
                    NomeDoCurso = "Curso B",
                    Descricao = "Curso intermediário."
                },
                new Curso()
                {
                    Id = 3,
                    NomeDoCurso = "Curso C",
                    Descricao = "Curso avançado."
                }
            };
        }

        public static List<Professor> CriarProfessores()
        {
            return new List<Professor>()
            { 
                new Professor()
                {
                    Id = 1,
                    DataNasc = new DateTime(2000,01,01),
                    Email = "Astolfo@gmail.com",
                    Nome = "Astolfo",
                    Telefone = "91111-1111",
                    AptoParaCurso = new List<int>(){1,2,3}
                },
                new Professor()
                {
                    Id = 2,
                    DataNasc = new DateTime(2001,02,02),
                    Email = "Einsten@gmail.com",
                    Nome = "Einsten",
                    Telefone = "92222-2222",
                    AptoParaCurso = new List<int>(){1,2}
                },
                new Professor()
                {
                    Id = 3,
                    DataNasc = new DateTime(2002,03,03),
                    Email = "Copernico@gmail.com",
                    Nome = "Copernico",
                    Telefone = "93333-3333",
                    AptoParaCurso = new List<int>(){1}
                }
            };
        }

        public static List<Turma> CrirarTurma()
        {
            return new List<Turma>()
            {
                new Turma()
                {
                    Id = 1,
                    Alunos = new List<int>() {1,2},
                    IdCurso = 1,
                    IdProfessor = 1,
                    NomeDaTurma = "Matutino - Primeiro Semestre - 2020"
                },
                new Turma()
                {
                    Id = 2,
                    Alunos = new List<int>(){3,4},
                    IdCurso = 2,
                    IdProfessor = 2,
                    NomeDaTurma = "Vespertino - Primeiro Semester - 2020"
                },
                new Turma()
                {
                    Id = 3,
                    Alunos = new List<int>(){1,4},
                    IdCurso = 3,
                    IdProfessor = 3,
                    NomeDaTurma = "Noturno - Primeiro Semestre - 2020"
                }
            };
        }
    }
}
