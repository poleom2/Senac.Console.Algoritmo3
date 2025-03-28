
using System.Globalization;

Console.Write("informe seu nome competo: "); 
string nomecompleo = Console.ReadLine();
Console.WriteLine();

Console.Write("Quanto quartos tem na sua casa: ");
int quartos = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Informe o preco da sua internet: ");
double precodainternet = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("informe seu ultimo nome, edade e altura ");
string linha = Console.ReadLine();
string[] vetor = linha.Split(' ');
string sobrenome = vetor[0];
int idade = int.Parse( vetor[1]);
double altura = double.Parse(vetor[2]);

Console.WriteLine(nomecompleo);
Console.WriteLine(quartos);
Console.WriteLine(quartos);
Console.WriteLine(precodainternet.ToString("F2"));
Console.WriteLine(sobrenome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2"));



   
    



