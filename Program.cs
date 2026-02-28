// Mostrar un patrón donde cada fila tenga el número de la fila repetido.
int filas = 5;

for (int fila = 1; fila <= filas; fila++)
{
    for (int j = 1; j <= fila; j++)
    {
        Console.Write(fila + "");
    }
    Console.WriteLine();
}