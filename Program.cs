

using System;
using System.Xml.Schema;

namespace conMonedas
{
class Monedas
    {
        static void Main(string[] args)
        {
            int Opc, Pesos, valorB;
          
            
            Menu();
                 String Op = Console.ReadLine();
                  Opc = int.Parse(Op);
                 Console.Clear();
               switch (Opc)
               {
                case 1:
                   Pesos = ingresoPesos();
                    Console.WriteLine("Ingrese valor en Dolares :");
                    string A = Console.ReadLine();
                   valorB = int.Parse(A);
                    calculoDolar(Pesos, valorB);                  
                    break;

               /* case 2:
                    
                   Console.WriteLine("Ingres valor en Euros :");
                    string B = Console.ReadLine();
                    int valorB = int.Parse(B);
                    Calculo(valorA, valorB);
                    break;*/








            }
              Console.Read();
          }
        public static void calculoDolar(int X, int Z)
        {
            int i = 0, c = 0, d = 0, e = 0, f = 0, g = 0, h = 0, j = 0;
            int Total = X / Z;
            Console.Write("Total en dolares : " + Total);
            Console.Clear();
             
            Console.ReadKey();
             Console.WriteLine("\n\n");
            while (Total >= 100)
            {
              Total = Total - 100;
                i++;
                Console.WriteLine(Total);
            }
              if(i != 0) 
              {
                Console.WriteLine("Cantidad de billetes de 100 Dolar :" + i);
              }
            
            while (Total >= 50)
            {
              Total= Total - 50;
                c++;   
            }
              if(c != 0) 
              {
                Console.WriteLine("Cantidad de billetes de 50 Dolar :" + c);
              }
            
            while (Total >= 20)
            {
               Total = Total - 20;
                d++;
            }
              if(d != 0)
              {
               Console.WriteLine("Cantidad de billetes de 20 Dolar :" + d);
              }
            
            while (Total >= 10)
            {
                Total = Total - 10;
                e++;
            }
              if (e != 0)
              {
                Console.WriteLine("Cantidad de billetes de 10 Dolar :" + e);
              }
            
            while (Total >= 5)
            {
                Total = Total - 5;
                f++;
            }
              if(f != 0)
              {
                Console.WriteLine("Cantidad de billetes de 5 Dolar :" + f);
              }
            
            while (Total >= 2)
            {
                Total = Total - 2;
                g++;
            }
              if(g != 0)
              {
                Console.WriteLine("Cantidad de billetes de 2 Dolar :" + g);
              }
            
            while (Total >= 2)
            {
                Total = Total - 2;
                h++;
            }
              if(h != 0)
              {
                Console.WriteLine("Cantidad de billetes de 2 Dolar :" + h);
              }

            while (Total >= 1)
            {
                Total = Total - 1;
                j++;
            }
            if (j != 0)
            {
                Console.WriteLine("Cantidad de billetes de 1 Dolar :" + j);
            }
       
          }

        public static int ingresoPesos()
        {
            Console.WriteLine("Ingrese valor en Pesos : ");
            string A = Console.ReadLine();
            int valorA = int.Parse(A);

            return valorA;
        
        }




         
        
        
        
        
        
        
        
        public static void Menu()
        {
            Console.WriteLine("\nElija una opcion : \n\n");
             Console.WriteLine("1-Dolar.\n");
            Console.WriteLine("2-Euro.\n");
             Console.WriteLine("3-Real.\n");
            Console.WriteLine("4-Libra.\n");
             Console.WriteLine("5-Peso uruguayo\n");
        }

    } 

}