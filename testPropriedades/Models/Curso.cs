using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using propriedades.Models;

namespace CursoAdd.Models
{
public class Curso
  {
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    public void AdicionarAluno(Pessoa aluno)
    {
      Alunos.Add(aluno);
    }
    public int AlunosMatriculados()
    {
      int quantidade = Alunos.Count;
      return quantidade;
    }
    public bool RemoverAlubo(Pessoa aluno)
    {
      return Alunos.Remove(aluno);
    }
    public void ListarAluno()
    {
      Console.WriteLine($"Alunos do curso de {Nome}");
      for (int conta = 0; conta < Alunos.Count; conta++)
      {
        string texto = $"N {conta + 1} - {Alunos[conta].NomeCompleto}";
        Console.WriteLine(texto);
      }
    }
  }
}