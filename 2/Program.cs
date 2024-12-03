int soma = 0;

using (StreamReader nr = new StreamReader("E:\\adventofcode\\Advent2024\\2\\ex2.txt"))
{
    string line;
    while ((line = nr.ReadLine()) != null)
    {
        int[] listaInt = line.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        if (ValidacaoProcesso(listaInt))
        {
            soma += 1;
        }

    }
}

Console.WriteLine("Soma de processos seguros: " + soma);

bool ValidacaoProcesso(int[] reports)
{
    bool validacao = false;
    bool crescente = false;
    bool decrescente = false;
    int[] diferenca = new int[0];

    for (int i = 0; i < reports.Length - 1; i++)
    {
        diferenca = diferenca.Append(Math.Abs(reports[i + 1] - reports[i])).ToArray();
    }

    for (int i = 0; i < reports.Length - 1; i++)
    {
        if (reports[i] <= reports[i + 1])
        {
            crescente = true;
        }
        if (reports[i] >= reports[i + 1])
        {
            decrescente = true;
        }
    }
    if (crescente != decrescente)
    {
        if (diferenca.Max() <= 3)
        {
            return true;
        }
    }
    return validacao;
}