using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCSharp.Cap2
{
    class Ejerccios1_3_5
    {
        public void Ejerccio1()
        {
            float CLado;
            float VLado;
            float perimetro;
            string valor = "";

            Console.WriteLine("Inserte cantidad de lados del poligono regular");
            valor = Console.ReadLine();
            CLado = Convert.ToSingle(valor);

            Console.WriteLine("Inserte valor de lados del poligo regular");
            valor = Console.ReadLine();
            VLado = Convert.ToSingle(valor);

            perimetro = CLado * VLado;
            Console.WriteLine("El perimetro es :{0}", perimetro);

        }
        public void Ejerccio3()
        {
            float grados;
            float radianes;
            String v = "";
            Console.WriteLine("Inserte el numero de grados");
            v = Console.ReadLine();
            grados = Convert.ToSingle(v);

            radianes = (grados * 3.14f) / 180;
            Console.WriteLine("los grados covertidos en radianes es: {0}", radianes);
            Console.ReadKey();
        }




        
        public void Ejerccio5()
        {
            float dolar = 0;
            float tEuro = 0;
            float total = 0;
            string valor = "";

            Console.WriteLine("Ingrese dolares a cambiar");
            valor = Console.ReadLine();
            dolar = Convert.ToSingle(valor);

            Console.WriteLine("Ingrese tasa euros");
            valor = Console.ReadLine();
            tEuro = Convert.ToSingle(valor);
            total = dolar / tEuro;
            Console.WriteLine("La cantidad de euros es: {0}", total);
            Console.ReadKey();



        }
    }
}
