using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrizes;

namespace TesterOpMatriz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OpMatrizNxNxN op = new OpMatrizNxNxN();
            int[,,] vec = { { { 2, 4}, { 3, 0 } },
                            { {2, 4}, { 5, 6} } };



            int[,,] vec2 = { { { 2, 3 }, { 3, 4 } },
                             { {2, 4}, { 5, 6} } };


            int[,,,] resposta = op.MultMatrizNxNxN(vec, vec2);



            for (int u = 0; u < resposta.GetLength(0); u++)
            {
                Console.Write("\n\n[CUBO {0}]", u);
                for (int z = 0; z < resposta.GetLength(0); z++)
                {
                    Console.Write("\n[TABELA{0}]", z);
                    //mostra vetor mostra vetor
                    for (int i = 0; i < resposta.GetLength(0); i++)
                    {
                        Console.WriteLine();
                        for (int j = 0; j < resposta.GetLength(1); j++)
                            Console.Write("[{0}]", resposta[u, z, i, j]);
                    }
                }
            }

            
            Console.WriteLine();

        }
    }
}
