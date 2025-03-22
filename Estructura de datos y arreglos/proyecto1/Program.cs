using System;

class Program
{
    static void Main()
    {
      
        string[] empleados = { "Joel Cruz", "Amanda Santana", "Alexander Martín", "Héctor Guzmán", "Milagros Catedral" };
        string[] departamentos = { "Recursos Humanos", "Tráfico", "Área de Limpieza", "Ventas y Contabilidad", "Almacén" };
        string[] combinados = new string[5];

       
        for (int i = 0; i < combinados.Length; i++)
        {
            combinados[i] = empleados[i] + " - " + departamentos[i];
        }

      
        Console.WriteLine("Lista de empleados y departamentos:");
        foreach (var item in combinados)
        {
            Console.WriteLine(item);
        }
    }
}

