using EjerciciosLibroCSharp.Cap1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            Console.WriteLine("Digite la opcion del capitulo que desea");
            opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                int op;
                Console.WriteLine("Cual ejerccio desea");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Cap1.Ejerccio1_5 cj = new Cap1.Ejerccio1_5();
                        cj.Ejercicio1();
                        break;
                    case 2:
                        Cap1.Ejerccio1_5 c = new Cap1.Ejerccio1_5();
                        c.Ejercicio5();
                        break;



                }
            }
            else if (opcion == 2)
            {
                int opc;
                Console.WriteLine("Cual ejerccio desea");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Cap2.Ejerccios1_3_5 e = new Cap2.Ejerccios1_3_5();
                        e.Ejerccio1();
                        break;

                    case 2:
                        Cap2.Ejerccios1_3_5 ej = new Cap2.Ejerccios1_3_5();
                        ej.Ejerccio3();
                        break;

                    case 3:
                        Cap2.Ejerccios1_3_5 eje = new Cap2.Ejerccios1_3_5();
                        eje.Ejerccio5();
                        break;



                }

            }
            else if (opcion == 3)
            {
                int opc;
                Console.WriteLine("Cual ejerccio desea");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Cap3.Ejercicio1_4_5 cp = new Cap3.Ejercicio1_4_5();
                        cp.Ejercicio1();
                        break;


                    case 2:
                        Cap3.Ejercicio1_4_5 c = new Cap3.Ejercicio1_4_5();
                        c.Ejercicio4();
                        break;

                    case 3:
                        Cap3.Ejercicio1_4_5 ej = new Cap3.Ejercicio1_4_5();
                        ej.Ejercicio4();
                        break;


                }
            }
            else if (opcion == 4)
            {
                int opc;
                Console.WriteLine("Cual ejerccio desea");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Cap4.Ejercicios1_2_5 ej = new Cap4.Ejercicios1_2_5();
                        ej.Ejercici1();
                        break;

                    case 2: Cap4.Ejercicios1_2_5 c = new Cap4.Ejercicios1_2_5();
                        c.Ejercicio2();
                        break;
                }
            }
      }
    }
}