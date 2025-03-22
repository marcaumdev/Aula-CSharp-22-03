int numero = 1;

while (numero <= 10)
{
    //Console.WriteLine(numero);
    numero = numero + 1;
}

bool estaLogado = true;

string nome = "marcos";
string senha = "1234#Aa";

while (!estaLogado)
{
    Console.Write("\nDigite o seu nome: ");
    string nomeDigitado = Console.ReadLine();

    Console.Write("Digite a sua senha: ");
    string senhaDigitada = Console.ReadLine();

    if (nome == nomeDigitado && senha == senhaDigitada)
    {
        Console.WriteLine("Login Feito com Sucesso!");
        estaLogado = true;
    }
    else
    {
        Console.WriteLine("Usário ou senha incorretos!");
    }
}

do
{
    //Console.Write("\nDigite o seu nome1: ");
    //string nomeDigitado = Console.ReadLine();

    //Console.Write("Digite a sua senha1: ");
    //string senhaDigitada = Console.ReadLine();

    if (nome == "nomeDigitado && senha == senhaDigitada")
    {
        Console.WriteLine("Login Feito com Sucesso!");
        estaLogado = true;
    }
    else
    {
        //Console.WriteLine("Usário ou senha incorretos!");
    }
} while (!estaLogado);


for (int contador = 0; contador <= 10; contador++)
{
    //Console.WriteLine(contador);
}
//Crie um programa que exiba todos os números pares de 0 até 20.
for (int contador = 0; contador <= 20; contador++)
{
    if (contador % 2 == 0)
    {
        //Console.WriteLine($"O numero {contador} é Par!");
    }
}

for (int contador = 0; contador <= 20; contador += 2)
{
    //Console.WriteLine($"O numero {contador} é Par!");
}

int positivos = 0;

for (int i = 1; i <= 5; i++)
{
    //Console.WriteLine($"Digite o {i}º número: ");
    //int numeroColetado = int.Parse(Console.ReadLine());
    //numeroColetado = Convert.ToInt32(Console.ReadLine());

    //if (numeroColetado >= 1)
    //{
    //    positivos = positivos + 1;
    //    //positivos++;
    //}
}

//Console.WriteLine($"Você digitou {positivos} número positivos!");

// Verificação de Número Primo

//Console.Write("Digite um número: ");
int numeroPrimo = 1;
bool ehPrimo = true;

if (numeroPrimo < 2)
{
    ehPrimo = false;
}
else
{
    for (int i = 2; i < numeroPrimo; i++)
    {
        if (numero % i == 0)
        {
            ehPrimo = false;
            break;
        }
    }
}

if (ehPrimo)
{
    //Console.WriteLine($"{numeroPrimo} é um número primo");
}
else
{
    //Console.WriteLine($"{numeroPrimo} não é um número primo");
}

//LISTAS
string[] listaMercado = new string[5];
//                0   1   2   3   4
int[] valores = { 10, 20, 30, 40, 50 };
int[] pares = new int[] { };
//int[] valores = new int[] { 10, 20, 30, 40, 50 };

List<string> lista;

Console.WriteLine(valores[1]);

for(int i = 0; i < 5; i++)
{
    //Console.Write($"Digite o item {i}: ");
    //pares.Append(int.Parse(Console.ReadLine()));
}
Console.Write("\n");
for(int i = 0; i < 5; i++)
{
    //Console.WriteLine($"item {i}: {listaMercado[i]}");
}

List<int> numeros = new List<int>();

for(int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros.Add(int.Parse(Console.ReadLine()));
}

//var maiorNumero = 0;

//for (int i = 0; i < numeros.Count; i++)
//{
//    if (numeros[i] > maiorNumero)
//    {
//        maiorNumero = numeros[i];
//    }
//}
//var menorNumero = maiorNumero;
//for (int i = 0; i < numeros.Count; i++)
//{
//    if (numeros[i] < menorNumero)
//    {
//        menorNumero = numeros[i];
//    }
//}

//Console.WriteLine($"O menor número é {menorNumero}");
//Console.WriteLine($"O maior número é {maiorNumero}");

Console.WriteLine($"Maior: {numeros.Max()}, Menor: {numeros.Min()}");