//referenciando os modelos
using System.Linq.Expressions;
using System.Reflection.Metadata;
using Calculadoras.Models;
using Pessoa.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("RJ");
listaString.Add("ES");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// for(int contador = 0; contador < listaString.Count; contador++){
//   Console.WriteLine($"Posicao N {contador} - {listaString[contador]}");
// }
// int contadorForeach = 0;
// foreach(string item in listaString){
//   Console.WriteLine($"Posicao N {contadorForeach} - {item}");
//   contadorForeach++;

// }


// int[] arrayInteiro = new int[3];

// arrayInteiro[0] = 72;
// arrayInteiro[1] = 64;
// arrayInteiro[2] = 50;

// int[] arrayInteiroDobrado = new int[arrayInteiro.Length*2];
// Array.Copy(arrayInteiro, arrayInteiroDobrado, arrayInteiro.Length);

//arrayInteiro[3] = 1; // quebra o codigo
// percorrendo o array com o for;
//Array.Resize(ref arrayInteiro, arrayInteiro.Length*2); //aumentar o tamanho do array

// for(int contador = 0; contador < arrayInteiro.Length; contador++){
//   Console.WriteLine($"{contador}. {arrayInteiro[contador]}");
// }


// percorrendo um array com foreach;
// foreach(int valor in arrayInteiro)
// {
//   Console.WriteLine(valor);
// }

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu){
//   Console.Clear();
//   Console.WriteLine("Digite a sua opcao: ");
//   Console.WriteLine("1 - Cadastrar cliente");
//   Console.WriteLine("2 - Buscar cliente");
//   Console.WriteLine("3 - Apagar cliente");
//   Console.WriteLine("4 - Encerrar");

//   opcao = Console.ReadLine();

//   switch(opcao){
//     case "1":
//       Console.WriteLine("Cadastro cliente");
//       break;

//     case "2":
//       Console.WriteLine("Buscar cliente");
//       break;

//     case "3":
//       Console.WriteLine("Apagar cliente");
//       break;

//     case "4":
//       Console.WriteLine("Encerrar");
//       exibirMenu = false;
//       // Environment.Exit(0);
//       break;

//     default:
//       Console.WriteLine("Opcao Invalida");
//       break;
//   }
// }
// Console.WriteLine("O programa encerrou");

// int numero = 0;
// int soma = 5;
// int contador = 0;

// do{
//   contador++;
//   numero++;
//   Console.WriteLine($"{contador}. {numero}x{soma} = {numero * soma}");
// }while(numero <= 20);


// int numero = 2;
// int soma = 0;
// int contador = 0;

// while(contador <= 9){
//   soma++;
//   contador++;
//   Console.WriteLine($"{contador}. {numero} x {soma} = {numero * soma}");

//   if(soma == 8){
//   break;
//   }
// }

// int numero = 5;

// for(int contador = 0;contador <= 10;contador++){
//   Console.WriteLine($"{contador}. {numero} x {contador} = {numero * contador}");
// }

// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10");

// numero++;

// Console.WriteLine(numero);

// Calculadora calc = new Calculadora();

// calc.seno(30);
// calc.cosseno(30);
// calc.tangente(30);

// Console.WriteLine("De o n1: ");
// string n0 = Console.ReadLine();
// Console.WriteLine("De o n2: ");
// string n1 = Console.ReadLine();
// int n2 = int.Parse(n0);
// int n3 = int.Parse(n1);

// calc.Somar(n2,n3);

// Console.WriteLine("Quantos anos voce tem? ");
// string idade = Console.ReadLine();
// int idadeInt = int.Parse(idade);
// Console.WriteLine("Tem autorizacao para entrar? s/n");
// string confirmacao = Console.ReadLine();

// if (idadeInt <= 17 && confirmacao != "s"){
//   Console.WriteLine("Voce nao tem idade para entrar e nem permissao para entrar");
// }else if(idadeInt >= 18 || confirmacao == "s"){
//   Console.WriteLine("Voce pode entrar");
// }


// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch(letra)
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine(letra + ", e uma vogal!!");
//     break;
//   default:
//     Console.WriteLine(letra + ", nao e uma vogal!!");
//     break;
// };


// int quantidadeEstoque = 10;
// int quantidadeCompra = 1;
// bool venda = quantidadeCompra >= 1 && quantidadeEstoque >= quantidadeCompra;

// Console.WriteLine("Quantidade em estoque: " + quantidadeEstoque);
// Console.WriteLine("Quantidade compra: " + quantidadeCompra);
// Console.WriteLine("E possivel realizar a venda? " + venda);

// if(quantidadeCompra <= 0){
//   Console.WriteLine("Insira uma quantidade valida (maior que 0)");
// }else if(venda){
//   Console.WriteLine("Venda realizada");
// }else{
//   Console.WriteLine("Desculpe, nao esta disponivel");
// }

//Maneira segura de conversao

// string a = "15";
// int b = 0;
// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversao realizada com sucesso!");

//cast implicito

// int a = 5;
// double b = a;

// Console.WriteLine(b);

// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);

// int a = Convert.ToInt32("5");
// int a = int.Parse("5");

// Console.WriteLine(a);

// int a = 10;
// int b = 20;

// int c = a + b;

//c = c + 5 == c += 5

// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);

// string apresentacao = "Ola, seja bem-vindo";
// int quantidade = 1;
// double altura = 1.68;
// decimal dinero = 323.60M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade: "+ quantidade);
// Console.WriteLine("Valor da variavel altura: "+ altura.ToString("0.00"));
// Console.WriteLine("Valor da variavel dinero: "+ dinero);
// Console.WriteLine("Valor da variavel condicao: "+ condicao);


// PessoaFisica pessoa1 = new PessoaFisica();//variavel

// pessoa1.Nome = "Rob";
// pessoa1.Idade = 22;
// pessoa1.Apresentar();