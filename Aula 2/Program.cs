int numero = 1;

while(numero <= 10)
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

    if(nome == nomeDigitado && senha == senhaDigitada)
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
    Console.Write("\nDigite o seu nome1: ");
    string nomeDigitado = Console.ReadLine();

    Console.Write("Digite a sua senha1: ");
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
} while (!estaLogado);


for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine(contador);
}
//Crie um programa que exiba todos os números pares de 0 até 20.
for(int contador = 0; contador <= 20; contador++)
{
    if(contador % 2 == 0)
    {
        Console.WriteLine($"O numero {contador} é Par!");
    }
}

for(int contador = 0; contador <= 20; contador += 2)
{
    Console.WriteLine($"O numero {contador} é Par!");
}

int positivos = 0;

for(int i = 1; i <= 5; i++) 
{
    Console.WriteLine($"Digite o {i}º número: ");
    int numeroColetado = int.Parse(Console.ReadLine());
    //numeroColetado = Convert.ToInt32(Console.ReadLine());

    if(numeroColetado >= 1)
    {
        positivos = positivos + 1;
        //positivos++;
    }
}

Console.WriteLine($"Você digitou {positivos} número positivos!");