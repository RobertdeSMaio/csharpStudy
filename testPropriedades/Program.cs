using propriedades.Models;
using CursoAdd.Models;
using System.Globalization;

int n4 = 15;
bool ehPar = false;

//if ternario

ehPar = n4 % 2 == 0;

Console.WriteLine($"O numero {n4} e " + (ehPar ? "par" : "impar"));


(int, string, string, decimal) tupla = (1, "Rob", "Maio", 1.68M); //mais recomendada + legibilidade
// ValueTuple<int, string, string, decimal> outraTupla = (1, "Rob", "Maio", 1.68M); pode ocorrer erro
// var outroExTupla = Tuple.Create(1, "Rob", "Maio", 1.68M); pode ocorrer erro

Console.WriteLine($"ID: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("ES" , "Espirito Santo");
estados.Add("RJ" , "Rio de Janeiro");
estados.Add("MG" , "Minas Gerais");

foreach (var item in estados)
{
  Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
}

Stack<int> pilha = new Stack<int>();

pilha.Push(10);
pilha.Push(15);
pilha.Push(20);

foreach (int item in pilha)
{
  Console.WriteLine(item);
}

pilha.Pop();
foreach (int item in pilha)
{
  Console.WriteLine(item);
}

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(6);
fila.Enqueue(4);
fila.Enqueue(8);

foreach (int item in fila)
{
  Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);


foreach (int item in fila)
{
  Console.WriteLine(item);
}

string dataString = "2022-04-31 18:00";
bool sucess = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);
if(sucess){
  Console.WriteLine($"Conversao com sucesso: {date}");
}else{
  Console.WriteLine($"{dataString} nao e uma data valida");
}
Console.WriteLine(dataString);

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal dindin = 82.40M;

Console.WriteLine(dindin.ToString("C2"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));

Pessoa p1 = new Pessoa(nome:"Rob",sobrenome:"Maio");
// p1.Nome = "Rob";
// p1.Sobrenome = "Maio";
// p1.Idade = 22;
// p1.Altura = 1.68;
// p1.Apresentar();

Pessoa p2 = new Pessoa(nome: "Pedro",sobrenome:"Alvares");
// p2.Nome = "Pedro";
// p2.Sobrenome = "Alvares";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAluno();