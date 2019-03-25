using System;
using System.Collections.Generic;
using System.Text;

namespace Matrizes
{
    public class OpMatrizNxNxN
    {
        public int[,,] MultMatrizNxNxN(int[,,] matrizA, int[,,] matrizB)
        {
            int sizeMatix = matrizA.GetLength(0);
            int[,,] matrizResult = new int[sizeMatix, sizeMatix, sizeMatix];
            int aux;

            //variação eixo Z
            for (int z = 0; z < matrizA.GetLength(2);)
            {
                //Variação eixo Y == coluna
                for (int y = 0; y < matrizA.GetLength(1); y++)
                {
                    //Variação eixo X == linha
                    for (int x = 0; x < matrizA.GetLength(0); x++)
                    {
                        aux = 0;
                        for (int k = 0; k < matrizA.GetLength(0); k++)
                        {
                            aux += matrizA[z,y, k] * matrizB[z,k, x];
                        }

                        matrizResult[z, y, x] = aux;


                    }
                }

             
            }
            return matrizResult;
        }

            
    }
}
}
