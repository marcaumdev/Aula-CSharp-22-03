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