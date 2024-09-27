using System.Runtime.CompilerServices;
using ExemplosFundamentos.Models;

//Estudando classes e objetos
Pessoa aninha = new Pessoa();
aninha.Idade = 32;
aninha.Nome = "Ana Cláudia";
aninha.Apresentar();

Pessoa joao = new Pessoa();
joao.Idade = 25;
joao.Nome = "João Pedro";
joao.Apresentar();

//Estudando tipos de dados
string apresentacao = "Olá, seja bem vindo!";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M; //indicado para valores monetários
bool condicao = true;
DateTime dataAtual = DateTime.Now;
DateTime dataAmanha = DateTime.Now.AddDays(1);

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável altura com duas casas decimais: "
+ altura.ToString("0.00")); // aqui especificamos que queremos a visualização com duas casas decimais
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);
Console.WriteLine("Hoje é dia: " + dataAtual);
Console.WriteLine("Amanhã é dia: " + dataAmanha);

//Estudando combinação de operadores
int a = 10;
int b = 20;
int c = a + b; //30
c += 5; //35

Console.WriteLine(c);

//Estudando conversão de tipos de variáveis
int varConvertida = Convert.ToInt32("5");
Console.WriteLine("Valor da variável convertida: " + varConvertida);

int var2Convertida = int.Parse("9");
Console.WriteLine("Valor da outra variável convertida: " + var2Convertida);

var inteiro = 5;
string stringConvertida = inteiro.ToString();
Console.WriteLine("Valor da variável inteira convertida em string: " + stringConvertida);

//Cast implícito
int inteiro5 = 5;
double double5 = inteiro5;

Console.WriteLine(double5);
Console.WriteLine(inteiro5 == double5);

//Ordem dos  Operadores
int contaMatematica = 4 / 2 + 2; //resultado é 4
Console.WriteLine(contaMatematica);

int contaMatematicaParenteses = 4 / (2 + 2);
Console.WriteLine(contaMatematicaParenteses); //resultado é 1

//Conversões Seguras
string quinze = "15";
int quinzeNumeral = Convert.ToInt32(quinze);

Console.WriteLine(quinzeNumeral);
Console.WriteLine("Conversão realizada com sucesso!!");

string naoEhInt = "21-*";
int zero = 0;

int.TryParse(naoEhInt, out zero);
Console.WriteLine(zero);

//Operadores Condicionais
int quantidadeEmEstoque = 10;
int quantidadeCompra = -20;
bool possivelVenda = quantidadeCompra > 0 && quantidadeCompra <= quantidadeEmEstoque;

if (quantidadeCompra <= 0)
    Console.WriteLine("Venda inválida pois a quantidade de compra deve ser maior que zero.");
else if (possivelVenda)
    Console.WriteLine("Venda realizada com sucesso!");
else
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");

//Um programa para saber se a letra que o usuário digitou é uma vogal
Console.WriteLine("Digite uma letra.");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é uma vogal.");
        break;
}

//Operadores Lógicos
//Forma que eu faria a verificação:
var idade = 30;
bool autorizacaoResponsavel = false;

if (idade > 18)
    Console.WriteLine("Maior de idade. Entrada liberada.");
else if (idade < 18 && autorizacaoResponsavel)
    Console.WriteLine("Menor de idade, com autorização dos pais. Entrada liberada.");
else
    Console.WriteLine("Entrada proibida.");

//Forma que o professor fez a lógica, para ensinar o "OU":
bool ehMaiorDeIdade = false;
bool possuiAutorizacaoDoResponsavel = true;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
    Console.WriteLine("Entrada liberada.");
else
    Console.WriteLine("Entrada não liberada.");

//Forma que eu faria a verificação:
bool possuiFrequenciaMinima = true;
bool mediaMaiorOuIgualA7 = false;

if (possuiFrequenciaMinima && mediaMaiorOuIgualA7)
    Console.WriteLine("Parabéns! Você foi aprovado.");
else if (!possuiFrequenciaMinima)
    Console.WriteLine("Você foi reprovado por excesso de faltas.");
else if (!mediaMaiorOuIgualA7)
    Console.WriteLine("Você foi reprovado porque não atingiu a média nas notas.");

//Forma que o professor fez:
bool possuiPresencaMinima = true;
double media = 5.5;

if (possuiPresencaMinima && media >= 7)
    Console.WriteLine("Parabéns! Você foi aprovado.");
else
    Console.WriteLine("Reprovado.");

bool estaChovendo = true;
bool estaTarde = true;

if (!estaChovendo && !estaTarde)
    Console.WriteLine("Tchau! Vou pedalar!");
else
    Console.WriteLine("Vou pedalar outro dia...");

//Operadores Aritméticos e Classe Math

int x = 10;
int y = 3;

Calculadora calculadora = new Calculadora();
calculadora.Somar(x, y);
calculadora.Subtrair(x,y);
calculadora.Multiplicar(x,y);
calculadora.Dividir(x,y);
calculadora.RetornarRestoDivisao(x,y);
calculadora.RealizarPotenciacao(x,y);
calculadora.LocalizarRaizQuadrada(x);

//Incremento e Decremento
//Muito comumente utilizados em laços de repetição
var numeroIncremento = 10;
Console.WriteLine(numeroIncremento);
Console.WriteLine($"Incrementando o {numeroIncremento}");
numeroIncremento++;
Console.WriteLine(numeroIncremento);

var numeroDecremento = 15;
Console.WriteLine(numeroDecremento);
Console.WriteLine($"Decrementando o {numeroDecremento}");
numeroDecremento--;
Console.WriteLine(numeroDecremento);

//Funções Trigonométricas
double angulo = 30;
calculadora.ObterSeno(angulo);
calculadora.ObterCoseno(angulo);
calculadora.ObterTangente(angulo);

//Laços de Repetição
int numeroFor = 5; //Tabuada do 5
Console.WriteLine("Tabuada do 5");
for (int contador = 0; contador <= 10; contador++)
    Console.WriteLine($"{numeroFor} x {contador} = {numeroFor * contador}");

int numeroWhile = 6; //Tabuada do 6
int contadorWhile = 0;
Console.WriteLine("Tabuada do 6");
while (contadorWhile <= 10)
{
    Console.WriteLine($"{contadorWhile + 1}ª Execução: {numeroWhile} x {contadorWhile} = {numeroWhile * contadorWhile}");
    contadorWhile++;
}

int soma = 0, numeroDoWhile = 0; //podemos declarar várias variáveis do mesmo tipo em uma mesma linha
do
{
    Console.WriteLine("Digite um número (0 para parar)");
    numeroDoWhile = Convert.ToInt32(Console.ReadLine());

    soma += numeroDoWhile;

} while (numeroDoWhile != 0);

Console.WriteLine($"Soma total dos números digitados: {soma}");
    
string opcaoUsuario;
bool exibirMenu = true;

while(exibirMenu) 
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");    

    opcaoUsuario = Console.ReadLine();

    switch (opcaoUsuario)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //outra forma de sair do programa, sem utilizar o flag 'exibirMenu':
            //Environment.Exit(0);
            break;
        
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

//Arrays e Listas
int[] arrayInteiros = new int[3];
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
}

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
arrayInteiros[3] = 720;
arrayInteiros[4] = 645;
arrayInteiros[5] = 505;

var contadorForeach = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
    contadorForeach++;
}

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

var contadorForeachArrayDobrado = 0;
foreach (int valor in arrayInteirosDobrado)
{
    Console.WriteLine($"Posição Nº {contadorForeachArrayDobrado} - {valor}");
    contadorForeachArrayDobrado++;
}

List<string> listaEstadosBrasileiros = new List<string>();
listaEstadosBrasileiros.Add("SP");
listaEstadosBrasileiros.Add("BA");
listaEstadosBrasileiros.Add("MG");

Console.WriteLine("Percorrendo a lista de estados brasileiros com FOR:");
for (int i = 0; i < listaEstadosBrasileiros.Count; i++)
{
    Console.WriteLine($"Posição nº {i} - {listaEstadosBrasileiros[i]}");
}

Console.WriteLine("Percorrendo a lista de estados brasileiros com FOREACH:");
int contadorEstados = 0;
foreach (var item in listaEstadosBrasileiros)
{
    Console.WriteLine($"Posição nº {contadorEstados} - {item}");
    contadorEstados++;
}

//Comentários são textos que o compilador ignora
// usamos para comentários curtos

/*
    usamos para
    comentários de
    várias linhas
*/



