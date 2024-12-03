using System.IO;


List<int> esquerda = new List<int>();
List<int> direita = new List<int>();

using (StreamReader nr = new StreamReader("E:\\adventofcode\\Advent2024\\1\\ex1.txt"))
{
    string line;
    while ((line = nr.ReadLine()) != null)
    {
        string[] parts = line.Split('-');

        if (parts.Length == 2)
        {
            esquerda.Add(int.Parse(parts[0]));
            direita.Add(int.Parse(parts[1]));
        }

    }
}


esquerda.Sort();
direita.Sort();

int soma = 0;
int numEsq;
int numDir;

for (int i = 0; i < direita.Count; i++)
{
    for (int j = 0; j < esquerda.Count; j++)
    {
        numEsq = esquerda[j];
        numDir = direita[j];

        Console.WriteLine($"{numDir} - {numEsq}");

        soma += Math.Abs(Math.Abs(numDir) - Math.Abs(numEsq));

    }
    break;
}

Console.WriteLine("Esquerda: " + string.Join(", ", esquerda));
Console.WriteLine("Direita: " + string.Join(", ", direita));



Console.WriteLine("Soma: " + soma);

