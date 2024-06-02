using System;
using System.Numerics;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        //controlTiempo(3, 30);
        generarTerreno(3);
    }
    
    //CalcularAngulo(new Vector2(0.16f,0.65f), new Vector2(0, 0));
    //return angle (0,0) (3,4) return 37ª
    private static void CalcularAngulo(Vector2 point1, Vector2 point2)
    {
        double angle = Math.Atan2(point2.X - point1.X, point2.Y - point1.Y);

        if (angle < 0)
        {
            angle += 2 * Math.PI;
        }
        angle = Math.Round(angle * (180 / Math.PI), 2);
        
        Console.WriteLine(angle); 
    }
    
    //return vetor unitario del anglo 90ª
    static void CalcularSenoCoseno(double angulo)
    {
        double radianes=angulo * Math.PI / 180;
        double dirY = Math.Round(Math.Sin(radianes), 4);
        double dirX = Math.Round(Math.Cos(radianes), 4);
        Console.WriteLine($"El seno de {angulo} grados es: {dirY}");
        Console.WriteLine($"El coseno de {angulo} grados es: {dirX}");
        Console.WriteLine("("+dirX.ToString()+"; "+ dirY.ToString()+")");
    }

    static void controlTiempo(int minuto, int segundo)
    {
        int min = minuto;
        int seg = segundo;

        while (min>0 && seg>0)
        {
            seg--;
            if (seg <= 0)
            {
                min--;
                if (min > 0)
                {
                    seg = 60;
                }
            }
            Console.WriteLine(min.ToString()+":"+seg.ToString());
        }
    }
    //figonashi
    static void ejecicio(int salto)
    {
        int num1=0;
        int num2 = 1;
        int aux;

        for (int i = 0; i < salto; i++)
        {
            Console.WriteLine(num1);
            aux = num2;
            num2 += num1;
            num1 = aux;
        }
        //0,1,1,2,3,5,8
      //num1, num2, aux
        //------0
        //0,1,-
        //0,1,0
        //0,1,0
        //1,1,0
        
        //------1
        //1,1,1
        //1,2,
    }

    static void generarTerreno(int radio)
    {
        int diametro=2*radio;
        int cont = 1;
        
        //genera una matriz
        for (int i = 0; i < diametro*diametro; i++)
        {
            //hacenos un filtro
            if (i >= cont * cont)
            {
                //solo los pares
                if (cont % 2 == 0)
                {
                    Console.WriteLine("---");
                }
                cont++;
            }
            Console.WriteLine(i);
        }
        //Console.WriteLine(dir);
    }
}
