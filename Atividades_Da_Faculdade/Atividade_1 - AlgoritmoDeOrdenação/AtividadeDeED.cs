using System;
using System.Collections.Generic;
using System.Diagnostics;

public class AlgoritmosDeOrdenacao
{
    // BubbleSort - Iterativo

    public static List<int> BubbleSort(List<int> lista)
    {
        List<int> resultado = new List<int>(lista);
        int tamanhoDoArray = resultado.Count;

        for (int i = 0; i < tamanhoDoArray - 1; i++)
        {
            bool troca = false;

            for (int j = 0; j < (tamanhoDoArray - 1 - i); j++)
            {
                if (resultado[j] > resultado[j + 1])
                {
                    int temp = resultado[j];
                    resultado[j] = resultado[j + 1];
                    resultado[j + 1] = temp;
                    troca = true;
                }
            }

            if (!troca)
            {
                break;
            }
        }

        return resultado;
    }

    //SelectionSort - Iterativo

    public static List<int> SelectionSort(List<int> lista)
    {
        List<int> resultado = new List<int>(lista);

        for (int i = 0; i < resultado.Count; i++)
        {
            int minIndice = i;

            for (int j = i + 1; j < resultado.Count; j++)
            {
                if (resultado[j] < resultado[minIndice])
                {
                    minIndice = j;
                }
            }

            if (minIndice != i)
            {
                int temp = resultado[i];
                resultado[i] = resultado[minIndice];
                resultado[minIndice] = temp;
            }
        }

        return resultado;
    }

    // QuickSort - Recursivo

    public static List<int> QuickSort(List<int> lista)
    {
        if (lista.Count <= 1)
        {
            return new List<int>(lista);
        }

        int pivo = lista[lista.Count / 2];
        List<int> menores = new List<int>();
        List<int> iguais = new List<int>();
        List<int> maiores = new List<int>();

        foreach (int num in lista)
        {
            if (num < pivo)
            {
                menores.Add(num);
            }
            else if (num > pivo)
            {
                maiores.Add(num);
            }
            else
            {
                iguais.Add(num);
            }
        }

        List<int> ordenado = new List<int>();
        ordenado.AddRange(QuickSort(menores));
        ordenado.AddRange(iguais);
        ordenado.AddRange(QuickSort(maiores));

        return ordenado;
    }

    // Bagulho pra Gerar Listas

    public static List<int> GeradorDeListas(int tamanho)
    {
        Random random = new Random();
        List<int> lista = new List<int>();

        for (int i = 0; i < tamanho; i++)
        {
            lista.Add(random.Next(1, 1000000));
        }

        return lista;
    }

    // Bagulho pra Medir o Tempo - Muito Complexo, Slk

    public static void MedirTempo(Func<List<int>> metodo, string nome)
    {
        Stopwatch contador = Stopwatch.StartNew();
        metodo();
        contador.Stop();
        Console.WriteLine($"{nome}: {contador.ElapsedMilliseconds} ms");
    }

    public static void Main(string[] args)
    {
        List<int> jaOrdenada = new List<int> { 1, 2, 3, 4, 5, 6 }; // Lista Já Ordenada
        List<int> quaseOrdenada = new List<int> { 1, 2, 3, 4, 6, 5 }; // Lista Quase Ordenada
        List<int> listaBaguncada = new List<int> { 3, 6, 1, 5, 2, 4 }; // Lista Bagunçada
        List<int> vazia = new List<int>(); // Lista Vazia
        List<int> listaComMil = GeradorDeListas(1000); // Lista com 1000 Elementos
        List<int> listaComDezMil = GeradorDeListas(10000); // Lista com 10000 Elementos
        List<int> listaComCemMil = GeradorDeListas(100000); // Lista com 100000 Elementos

        Console.WriteLine("Testando tempos de execução:");

        // Coloca a Lista a ser Testada Aqui

        List<int> copia1 = new List<int>(jaOrdenada);
        List<int> copia2 = new List<int>(jaOrdenada);
        List<int> copia3 = new List<int>(jaOrdenada);

        // Bagulho Complexo pra Medir Tempo de Execução

        MedirTempo(() => BubbleSort(copia1), "BubbleSort");
        MedirTempo(() => SelectionSort(copia2), "SelectionSort");
        MedirTempo(() => QuickSort(copia3), "QuickSort");

        // Muda aqui também a lista a ser testada, só pra ficar bonitinha a visualização

        Console.WriteLine("\nTestando ordenação:");
        Console.WriteLine("Lista original:  " + string.Join(", ", jaOrdenada));
        Console.WriteLine("Bubble Sort:     " + string.Join(", ", BubbleSort(jaOrdenada)));
        Console.WriteLine("Selection Sort:  " + string.Join(", ", SelectionSort(jaOrdenada)));
        Console.WriteLine("Quick Sort:      " + string.Join(", ", QuickSort(jaOrdenada)));
    }
}
