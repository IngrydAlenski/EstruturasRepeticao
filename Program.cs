﻿
// Estruturas Condicionais 

// Etruturas de Repeticao 
// Repete uma acao

// Imprimir todos os numeros de 1 a 5 

// enquanto - while 

//  Repete uma acao ENQUANTO algo for verdade 

//int numero = 1;

// while ( numero < 6 )
// //   Console.WriteLine(numero);
// Incremento
//numero = numero + 1;
//  numero++;
//
// Faça  - Enquanto (Do - While)
//int idade = int.Parse(Console.ReadLine());

//while (idade != 17)
//{
// Console.WriteLine("Informe a idade: ");
//   idade = int.Parse(Console.ReadLine()); 

//int idade;

//do
//    Console.WriteLine("informe a idade: ");
//   idade = int .Parse(Console.ReadLine()); 
//} while (idade != 17);


// Para - for 
// Quero imprimir os numeros de 1 a 5

// 1- cria uma variavel chamada I (indice)
// 2- Condição para continuar 
// 3- Incremento ao executar as chaves 




//for   (int N = 0; N < 21; N++)
//{
//    Console.WriteLine(N);
//}




// Faça  - Enquanto (Do - While)
//int idade = int.Parse(Console.ReadLine());

//while (idade != 17)
//{
// Console.WriteLine("Informe a idade: ");
//   idade = int.Parse(Console.ReadLine()); 

//int idade;

//do
//    Console.WriteLine("informe a idade: ");
//   idade = int .Parse(Console.ReadLine()); 
//} while (idade != 17);





//Peça ao usuário para inserir a senha "1234". Continue pedindo até que ele acerte.
// Minha resposta
//Console.WriteLine("Insira a senha: ");
//int senha = int.Parse(Console.ReadLine());

//while (senha != 1234)
//{
//    Console.WriteLine("Insira a senha: ");
//    senha = int.Parse(Console.ReadLine());

//}



////Peça um número ao usuário e faça uma contagem regressiva até 0.
//// Minha resposta 
//for (int R = 104; R > 0; R--)
//{
//    Console.WriteLine(R);
//}



////Crie um programa que exiba os números de 1 a 20 na tela.
//// Minha resposta 
//for (int N = 0; N < 21; N++)
//{
//    Console.WriteLine(N);
//}



////Peça ao usuário um número e exiba a tabuada dele de 1 a 10.
//// Minha resposta

//Console.Write("Digite um número para ver sua tabuada: ");
//        int numero = int.Parse(Console.ReadLine());

//        Console.WriteLine("Tabuada do {numero}:");
//        for (int T = 1; T <= 10; T++)
//        {
//            Console.WriteLine($"{numero} x {T} = {numero * T}");
//        }


// Correcao 17/03 18/03

// Solicite notas ao usuário (entre 0 e 10) até que ele insira um número inválido. Depois, exiba a média das notas.




/// Conteudos 
/// Exercicos 17/03 e 18/03
//int nota;
//int somaNotas = 0;
//int qtdNotas = 0;
//do
//{
//    Console.WriteLine("Informe uma nota: ");
//    nota = int.Parse(Console.ReadLine());

//    if (nota >= 0 && nota <= 10)
//    {
//        somaNotas = nota + somaNotas;
//        qtdNotas++;
//    }

//} while (nota >= 0 && nota <= 10);
//int media = somaNotas / qtdNotas;
//Console.WriteLine(media);


////Exception
////IOException - In and Out - Entrada e Saida 
//// FormatExcepition - Erros no formato ( tipo de dado)

//// Try / catch - tenta - pegar
////Breakpoint 
//try
//{
//    int num = int.Parse(Console.ReadLine());
//    int Resultado = num / 0;

//}
//catch (FormatException ex)
//{
//    Console.WriteLine(" Erro: Informe apenas numeros. "); 
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine(" Erro : numero muito grande");

//}
//catch
//{ 

//}

//try
//{
//    int numero = int.Parse(Console.ReadLine());
//}
//catch (FormatException ex)
//{
//    Console.WriteLine(" Apenas numeros são aceitos ");
//}

//int idade = int.Parse(Console.ReadLine());

//if  (idade < 0)
//{
//    throw new ArgumentOutOfRangeException("Idade não pode ser negativa");
//}


// **2. Divisão Segura**

//Crie um programa que peça dois números ao usuário e divida o primeiro pelo segundo. Use `try/catch` para evitar divisão por zero e entrada inválida.


//try
//{
//    Console.WriteLine("Digite um numero");

//    int num1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Digite outro numero");

//    int num2 = int.Parse(Console.ReadLine());

//    int resultado = num1 / num2;

//    Console.WriteLine(resultado);
//}
//catch (DivideByZeroException dz)
//{
//    Console.WriteLine("Não e possivel divir por zero");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Apenas numeros serão aceitos");
//}



////Peça ao usuário para inserir sua idade e diga se ele é maior ou menor de idade. Use try/catch para evitar entradas inválidas.


//int idade =0;

//try
//{
//    Console.WriteLine("Digite sua idade");

// idade = int.Parse(Console.ReadLine()); 

//if  (idade=0)

// {
//  Console.WriteLine(" Voce e maior de idade ");
// }

//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Escreva apenas numeros");
//}

//catch (OverflowException ov)
//{
//    Console.WriteLine(" Esse numero não e valido");
//}

////correcao

//try

// if (idade < 0 || idade > 20)

//{
//    throw new OverflowException("idade invalida");
//}
// catch ( FormatException)
//{
//    Console.WriteLine(" Informe apenas numeros");
//}
//catch (OverflowException)
//{
//    Console.WriteLine(" Idade invalida");
//}


//Conteudo

int idade1;
int idade2;
int idade3;
int idade4;
int idade5;

//Conjunto de informacoes/dados
//vetor/Array- ele tem um limite

int[] idades = new int[5];

string[] nomes = new string[10];

//Crio o Vetor e dou um nome 
//<TIPO> []des;

//inicializando o Vetor 
//new <TIPO> [<QUANTIDADES>];

//Posicao
// 0 1 2 3 4 5 6 7 8 9 
//nomes[0] = Console.ReadLine();

Console.WriteLine(nomes[0]);

idades[4] = 26;

//FOR - percorrer Lista/Vetores
//Cadastrar todos os nomes
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(nomes[i]);
}

// Para cada 
foreach (var item in nomes)
{
    Console.WriteLine(item);
}

//Criar um vetor de idade com 4 posicoes
//Use um for 