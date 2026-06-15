Console.Write("Informe a quantidade de tarefas concluídas:");

int tarefasConcluidas = int.Parse(Console.ReadLine()!);
if (tarefasConcluidas >= 50)
{
    Console.WriteLine($"Méta atingida!");
    Console.WriteLine($"Você concluiu {tarefasConcluidas} tarefas!");
}
else
{
    Console.WriteLine("Meta não atingida.");
    Console.WriteLine($"Faltam {50 - tarefasConcluidas} tarefas para atingir a meta!");
}
