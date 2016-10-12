using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
  public  class DiagonalDifference
    {
      //Se declaran las variables a utilizar
      int [] nummatriz= new int[100];
         
          int cont1 = 0;
          int k= 0;
          int diag1 = 0;
          int diag2 = 0;
          int difference = 0;
      public int Matrix(String numero)
      {
         //Se guarda en un arreglo tipo string, lo que retorne el .split de la variable numero
          //En este caso seria, el numero que se recibio por entrada, sin el caracter '|'
           String [] matriz2 = numero.Split('|');
          //Se le asigna a una matriz "matriznum", el numero de filas y columnas 
           int[,] matriznum = new int[matriz2.Length, matriz2.Length];
              //* Se recorre el arreglo matriz2 
           for (int j = 0; j < matriz2.Length; j++)
           {
               //Se agrega a un arreglo matriz3, lo que retorne el .split, en este caso seria
               // el arreglo matriz2, sin espacios en blanco
               String[] matriz3 = matriz2[j].Split(' ');
               // Se recorre el arreglo matriz3
               for (int z = 0; z < matriz3.Length; z++)
               {
                   // En una variable tipo string, se guarda los numeros que tiene matriz3
                   String numeros = matriz3[z];
                   // al arreglo tipo int nummatriz, le agrego lo que tiene la variable numeros
                   
                   nummatriz[k] = int.Parse(numeros);
                   //Aumento el contador de nummatriz, para que pueda pasar de posicion
                   k++;
               }
               
           }
              

           
          //Se recorre la matriz "matriz4", con dos for
          for (int i = 0; i < matriznum.GetLength(0); i++)
          {
              for (int j = 0; j < matriznum.GetLength(0); j++)
			{
                  //A matriz4, le agrego los numeros que se guardaron en el arreglo nummatriz
			 matriznum[i,j] = nummatriz[cont1];
                  //Aumento contador, para que nummatriz, pueda pasar de posicion
                  cont1++;
			}
          } 
         
          //Recorro la matriz, para imprimir la primera diagonal
          for (int i = 0; i < matriznum.GetLength(0); i++)
          {
              
              diag1 += matriznum[i, i];
             
          }
          //Se inicializa un nuevo contador
           int cont2 = 0;
          //Se hace un contador, para que este inicie de la ultima  columna que tenga la matriz
          int cont3 = matriznum.GetLength(1) - 1;
          //Se hace un for para recorrer nuevamente la matriz
          for (int i = 0; i < matriznum.GetLength(0); i++)
          
          {
              //Se suma la diagonal dos, y aumento las filas (cont2) y disminuyo las columnas(cont3) 
               diag2 += matriznum[cont2, cont3];
              cont2++;
              cont3--;

          }
          //Se calcula la diferencia
          difference = diag1 - diag2;
         
          // Se retorna la diferencia 
          return difference;
          }

     
          
      }
    }

