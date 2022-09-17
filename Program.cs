Console.WriteLine("Média Aritmética de 3 numeros\n");

Console.Write("Digite o primeiro numero: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo numero: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o terceiro numero: ");
double numero3 = Convert.ToDouble(Console.ReadLine());

double media = (numero1 + numero2 + numero3) / 3;

Console.WriteLine($"média: {media:N1}");