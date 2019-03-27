using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Matrizes
{
    public class OpMatrizNxN
    {
        Stopwatch stopwatch;

        public int[,] MultMatrizNxN(int[,] matrizA, int[,] matrizB)
        {
            int[,] matrizResult = new int[matrizA.GetLength(0), matrizA.GetLength(1)];
            int aux;
            stopwatch.Start();
            //Variação eixo Y == coluna
            for (int y = 0; y < matrizA.GetLength(1); y++)
            {
                //Variação eixo X == linha
                for (int x = 0; x < matrizA.GetLength(0); x++)
                {
                    aux = 0;
                    for (int k = 0; k < matrizA.GetLength(0); k++)
                    {
                        aux += matrizA[y, k] * matrizB[k, x];
                    }

                    matrizResult[y, x] = aux;


                }
            }
            stopwatch.Stop();
            //Printa o tempo gasto neste metodo;
            Console.WriteLine("Tempo gasto para a multiplicação NxN " + stopwatch.Elapsed);
            return matrizResult;
        }
    }
}

