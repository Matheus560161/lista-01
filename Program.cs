Console.Write("Informe a temperatura atual: ");
if (double.TryParse(Console.ReadLine(), out double temperatura))
{
    if (temperatura < 18)
    {
        Console.WriteLine("Ambiente frio!");
    }
    else if (temperatura >= 18 && temperatura < 26)
    {
        Console.WriteLine("Ambiente confortável!");
    }
    else if (temperatura >= 26)
    {
        Console.WriteLine("Ambiente quente!");
    }
}