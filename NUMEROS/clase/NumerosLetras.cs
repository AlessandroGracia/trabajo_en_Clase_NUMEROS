using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMEROS
{
    class NumerosLetras
    {
        static string[] unidades = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "Diez", "once", "doce", "trece", "catorce", "quince", "dieciseis", "diecisiete", "diesiocho","diecinueve" };
       static string[] decenas = { "Cero","diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa", "Cien" };
        static string[] Centenas = { "cien", "docientos", "trecientos", "Cuatrocientos", "Quinientos", "Seiscientos", "Setecientos", "Ochocientos", "novecientos" };
        

        public static void TestUnidades()
        {
            foreach(string cad in unidades)
            {
                Console.WriteLine(cad);
            }
            
        }
        public static string getUnidades(int num)
        {
            string aux = "";
            if (num >=0 && num < 20)
                aux = unidades[num];

            return aux;
        }

        public static string getDecenas(int num)
       {
            string aux = "";
            if (num >= 0 && num < 20)
                aux = getUnidades(num);
            if (num >= 20 && num < 100)
                aux = decenas[num / 10];
            {
                int residuo = num % 10;
                aux = decenas[num / 10];
                if (residuo > 0)
                    aux +=  " y " + unidades[residuo];
            }
           return aux;
        }



    }
}
