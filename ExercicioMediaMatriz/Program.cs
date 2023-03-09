double[,] matriz = new double[5, 3];
int linha, col;

for(linha =  0; linha < 5; linha++)
{
    for (col = 0; col < 2; col++)
    {
        Console.WriteLine("Digite o termo: [" + linha + "] [" + col + "]");
        matriz[linha, col] = double.Parse(Console.ReadLine());
    }
}

for (linha = 0; linha < 5; linha++)
{
    matriz[linha, 2] = (matriz[linha, 0] + matriz[linha, 1]) / 2;
}

Console.WriteLine("\nA matriz é: ");
for (linha = 0; linha < 5; linha++)
{
    for (col = 0; col < 3; col++)
    {
        Console.Write(matriz[linha, col] + " |");
    }
    Console.WriteLine();
}