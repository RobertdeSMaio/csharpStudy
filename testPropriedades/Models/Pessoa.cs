using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades.Models
{
  public class Pessoa
  {
    public Pessoa(){}//construtor valor padrao
    public Pessoa(string nome, string sobrenome)//construtor recebendo algo
    {
      Nome = nome;
      Sobrenome = sobrenome;
    }
    private string _nome;//private = somente pode instanciar dentro da classe
    private int _idade;
    public int Idade //public = qualquer um pode acessar
    {
      get => _idade;
      set{
        if(value <= 0){
          throw new ArgumentException("A idade nao pode ser menor ou igual a zero");
        }
        _idade = value;
      }
    }
    public string Nome
    {
      get => _nome.ToUpper();
      set{
        if(value == ""){
          throw new ArgumentException("O nome nao pode ser vazio");
        }
        _nome = value;
      }
    }
    public string Sobrenome{get;set;}

    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();


    public double Altura { get; set; }
    public void Apresentar()
    {
      Console.WriteLine($"Nome: {NomeCompleto}, idade: {Idade}, altura {Altura}");
    }
    
  }
}