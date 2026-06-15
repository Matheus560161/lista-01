Console.WriteLine("Informe sua idade: ");
int idade = int.Parse(Console.ReadLine());
if (idade > 0 && idade < 11)
{
    Console.WriteLine("Criança");
}
else if (idade >= 11 && idade < 17)
{
    Console.WriteLine("Adolescente");
}
else if (idade >= 18 && idade < 59)
{
    Console.WriteLine("Adulto");
}
else
{
    Console.WriteLine("Idoso");
}