
internal class Program
{
    private static void Main (string[] args)
    {
        string[] ArrayOfNames = new string[5]  { "Emi", "Sheila", "Pablo", "Juan","Jose" };

      //Funcion Imprimir el arreglo
      ImprimirArray(ArrayOfNames,5);

      Console.WriteLine("Ingrese el nombre que quiere buscar: ");
      string name = Console.ReadLine();
          
      int posicion = Buscar(ArrayOfNames, name);
      if (posicion == -1)
      {
        Console.WriteLine("El nombre  " +name+ " no existe");
      }
      else
      {
        Console.WriteLine(name + "  esta en la posicion:  "+posicion);
      }
    }

    //funcion Imprimir
    public static void ImprimirArray(string[] array, int tamanio)
    {
        for (int i = 0; i < tamanio; i++)
        {
            Console.WriteLine("Array posicion: " + i + " Valor: " + array[i]);
        }
    }

    //funcion buscar el nombre
    public static int Buscar(string[] array, string n)
    {
     for (int i=0; i < array.Length; i++)
     {
       if (array[i] == n)
       {
         return i;
       }
     }
      return -1;
    }  
}