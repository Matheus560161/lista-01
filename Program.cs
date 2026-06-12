Console.Write("Informe o valor total da compra: ");

decimal valorCompra = decimal.Parse(Console.ReadLine()!);

decimal desconto = 0;

if (valorCompra >= 200)
{
    desconto = valorCompra * 0.10m;
}

decimal valorFinal = valorCompra - desconto;

Console.WriteLine($"Valor original: R$ {valorCompra}");
Console.WriteLine($"Desconto aplicado: R$ {desconto}");
Console.WriteLine($"Valor final: R$ {valorFinal}");