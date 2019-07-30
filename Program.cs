using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            //mil cadenas de caracteres, tamaño entre 2 y 10, minimo una vocal por cada 4 consonantes
            Random rnd = new Random();
            string stConsonantes = "bcdfghjklmnpqrstuvwxyzBCDFGHJKLMNPQRSTVWXYZ1234567890";
            string stVocales = "aeiouAEIOU";
            string str = "";
            int lSt = 0;
            int selector, acomulaConsonates = 0 ;

            for (int i = 0; i < 1000; i++) //es de mil caracteres
            {
                lSt = rnd.Next(2, 11);  //para escojer el tamaño del cadena
                str = "";
                for (int j = 0; j < lSt; j++)
                {
                    selector = rnd.Next(0, 2); //0 para consonante, 1 para vocal
                    if (selector==0)
                    {
                        if (acomulaConsonates < 3)
                        {
                            str += stConsonantes[rnd.Next(stConsonantes.Length)];
                            acomulaConsonates++;
                        }else{
                            str += stVocales[rnd.Next(stVocales.Length)];
                            acomulaConsonates = 0;
                        }
                    }
                    else
                    {
                        str += stVocales[rnd.Next(stVocales.Length)];
                        acomulaConsonates = 0;
                    }
                }
                Console.WriteLine(str);
            }
            Console.ReadLine();

        }
    }
}
