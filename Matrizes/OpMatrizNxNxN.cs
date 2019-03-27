using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Matrizes
{
    public class OpMatrizNxNxN
    {
        Stopwatch stopwatch;

        public int[,,,] MultMatrizNxNxN(int[,,] matrizA, int[,,] matrizB)
        {
            
            long size = matrizA.GetLongLength(0);
            int[,,,] matrizResult = new int[size, size, size, size];
            int aux;

            stopwatch.Start();


            for (int u = 0; u <size; u++)
            {
                for (int z = 0; z < size; z++)
                {
                    for (int l = 0; l < size; l++)
                    {
                        //Variação eixo Y == coluna
                        for (int y = 0; y < size; y++)
                        {
                            //Variação eixo X == linha
                            for (int x = 0; x < size; x++)
                            {
                                aux = 0;
                                for (int k = 0; k < size; k++)
                                {
                                    aux += matrizA[z, y, k] * matrizB[l, k, x];
                                }

                                matrizResult[u, z, y, x] = aux;


                            }
                        }
                    }
                }




            }

            stopwatch.Stop();
            //Printa o tempo gasto neste metodo;
            Console.WriteLine("Tempo gasto para a multiplicação NxNxN "+ stopwatch.Elapsed);
            return matrizResult;
          

        }
        

    }
}
   

