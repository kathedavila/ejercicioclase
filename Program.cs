using System;

namespace calificacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numgan, numper;
            double[,] maca = new double[,] {{1,2,3,4,5},{1,1,2,3,3},{5,5,4,3,2},{5,4,4,3,3}};
            double[] notfin = new double[maca.GetLength(0)];
           Operacionescalificaciones ope = new Operacionescalificaciones();
           notfin = ope.NotaFinal(maca);
          ope.MejorEstudiante(notfin);
        ope.MenorEstudiante(notfin);
        numgan = ope.CantidadGanadores(notfin);
        double[,] estgan = new double[numgan,2];
        estgan=ope.Ganadores(notfin,numgan);
        ope.Imprimir(estgan,"Ganadores");
        numper = ope.CantidadPerdedores(notfin);
        double[,] estper = new double[numgan,2];
        estper=ope.Perdedores(notfin,numgan);
        ope.Imprimir(estper,"Perdedores");
        }
    }
}
