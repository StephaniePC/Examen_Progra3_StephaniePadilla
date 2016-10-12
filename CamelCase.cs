using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class CamelCase
    {
        //Se crea una lista tipo char
        List<char> lista = new List<char>();
        public int calculate(String palabra)
        {
            //Se agrega a la lista la palabra pasada por parametro
            lista.Add(palabra[0]);
            //Se crea un contador en 0
            int result = 0;
            //Se valida si la primera palabra comienza con miniscula, si se cumple, el contador aumenta en 1
            // si no se cumple, el contador se disminuye en 1
            if (char.IsLower(palabra[0]))
            {
                result++;
            }
            else
            {
                result--;
            }
            //Se hace un for para recorrer la palabra, con un .skip, para que ignore la letra que esta en la posicion 0
            foreach (char item in palabra.Skip(0))
            {
                //Se valida si hay mayusculas en la palabra
                if (char.IsUpper(item))
                {
                    //Si se cumple se incrementa el contador
                    result++;
                }
            }
            //Retorna contador
            return result;

        }

    }
}
