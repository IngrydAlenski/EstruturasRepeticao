
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
int nota;
int somaNotas = 0;
int qtdNotas = 0;
do
{
    Console.WriteLine("Informe uma nota: ");
    nota = int.Parse(Console.ReadLine());

    if (nota >= 0 && nota <= 10)
    {
        somaNotas = nota + somaNotas;
        qtdNotas++;
    }

} while (nota >= 0 && nota <= 10);
int media = somaNotas / qtdNotas;
Console.WriteLine(media);