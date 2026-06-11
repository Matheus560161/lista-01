Console.Write("Informe sua nota final: ");

if (int.TryParse(Console.ReadLine(), out int nota))
{
    if (nota < 5){
        Console.WriteLine("Estudante reprovado.");
    }
    else if (nota >= 5 && nota < 7){
        Console.WriteLine("Estudante em recuperação.");
    }
    else if (nota >= 7 && nota <= 10){
        Console.WriteLine("Estudante aprovado.");
    } else {
        Console.WriteLine("Nota inválida, digite sua nota novamente.");
    }
}