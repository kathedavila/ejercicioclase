using System;

namespace calificacion
{
    public class Operacionescalificaciones
    {
        public int Numeroestudiantes()
        {
            int x;
            Console.WriteLine("Ingrese cantidad de estudiantes");
            x= Convert.ToInt32(Console.ReadLine());
            return x;
        }

        public void IngresarNotas(int x, int y)
        {
            int[,] cali = new int[x,y];
            for(int a = 0; a < x; a++)
            {
                for(int b = 0; b < y; b++)
                {
                    cali[a,b]= Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public double[] NotaFinal(double[,] matriz)
        {
            double n1,n2,n3,n4,n5;
            double[] final = new double[matriz.GetLength(0)];
            for(int a=0; a < matriz.GetLength(0); a++)
            {
                n1 = matriz[a,1] * 0.25;
                n2 = matriz[a,2] * 0.25;
                n3 = matriz[a,3] * 0.20;
                n4 = matriz[a,4] * 0.20;
                n5 = matriz[a,1] * 0.10;
                final[a] = n1 + n2 + n3 + n4 + n5;
            }
            return final;
        }
        public void Imprimir(double[,] notfin, String estado)
        {
            if (estado.Equals("Ganadores"))
            {
               Console.WriteLine("Los estudiantes ganadores son:" );
            }else
            {
                Console.WriteLine("Los estudiantes perdedores son:" );
            }
            for(int a = 0; a < notfin.GetLength(0); a++)
            {
                Console.WriteLine(notfin[a,0] + " con nota " + notfin[a,1]);
            }
        }

        public void MejorEstudiante(double[] notfin)
        {
            double promedio = notfin[0];
            int x = 0;
            for(int a = 1; a < notfin.Length; a++)
            {
                if (promedio < notfin[a])
                {
                    promedio = notfin[a];
                    x = a + 1;
                }
                
            }
            Console.WriteLine("El mejor promedio es del Estudiante " + x + " con una nota final de "+ promedio);
        }

        public void MenorEstudiante(double[] notfin)
        {
            double promedio = notfin[0];
            int x = 0;
            for(int a = 1; a < notfin.Length; a++)
            {
                if (promedio > notfin[a])
                {
                    promedio = notfin[a];
                    x = a + 1;
                }
                
            }
            Console.WriteLine("El Estudiante " + x + "  con una nota final mas baja de "+ promedio);
        }

        public int CantidadGanadores(double[] vector)
        {
            int ganadores = 0;
            for(int a = 0; a < vector.Length; a++)
            {
                if(vector[a] >= 3.5)
                {
                    ganadores = ganadores + 1;
                }
            }
            return ganadores;
        }

        public int CantidadPerdedores(double[] vector)
        {
            int perdedores = 0;
            for(int a = 0; a < vector.Length; a++)
            {
                if(vector[a] >= 3.5)
                {
                    perdedores = perdedores + 1;
                }
            }
            return perdedores;
        }

        public double[,] Ganadores(double[] vector,int cangan)
        {
            double[,] vecgan = new double[ cangan , 2 ];
            int br = 0;
            for(int a = 0; a < vector.Length; a++)
            {
            if(vector[a] >= 3.5)
                {
                    vecgan[br,0]= Convert.ToDouble(a) + 1;
                    vecgan[br,1]= vector[a];
                    br = br + 1;
                }
            }
            return vecgan;
        }
        public double[,] Perdedores(double[] vector,int canper)
        {
            double[,] vecper = new double[ canper , 2 ];
            int br = 0;
            for(int a = 0; a < vector.Length; a++)
            {
            if(vector[a] < 3.5)
                {
                    vecper[br,0]= Convert.ToDouble(a) + 1;
                    vecper[br,1]= vector[a];
                    br = br + 1;
                }
            }
            return vecper;
        }
    }
}