/* Enunciado:
Se tienen las temperaturas diarias (en °C) de los 7 días de una semana
almacenadas en un arreglo double[] . Diseñar un programa en C# que:
1. Lea las 7 temperaturas desde el teclado
2. Encuentre el día más caluroso (índice y temperatura máxima)
3. Encuentre el día más frío (índice y temperatura mínima)
4. Calcule el promedio semanal
5. Ordene las temperaturas de menor a mayor (Bubble Sort) y las muestre
6. Bonus: Cuente cuántos días superaron el promedio semanal
*/


using System;
class TemperaturesRegister
{
   static void Main()
   {
      double[] temps = new double[7];
      string[] weekDays = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
      double sumTemps = 0;
      
      for (int i = 0; i < temps.Length; i++)
      {
         Console.Write("Ingresa la temperatura del dia " + weekDays[i] + ": ");
         if (double.TryParse(Console.ReadLine(), out double temp))
         {
            temps[i] = temp;
            sumTemps += temps[i];
         }
      }

      double average = sumTemps / temps.Length;
      Console.WriteLine("El promedio de las temperaturas es: " + average);

      // Search the max and min temperatures in the array
      // Revisar el día más caluroso y el día más frío
      double maxTemp = temps[0];
      double minTemp = temps[0];
      int posMax = 0;
      int posMin = 0;
      for (int i = 1; i < temps.Length; i++)
      {
         
         if (temps[i] > maxTemp)
         {
            maxTemp = temps[i];
            posMax = i;
         }

         if (temps[i] < minTemp)
         {
            minTemp = temps[i];
            posMin = i;
         }

      Console.WriteLine("El día más caluroso fue el " + weekDays[posMax] + " con " + maxTemp + "°C");
      Console.WriteLine("El día más frío fue el " + weekDays[posMin] + " con " + minTemp + "°C");
      }
   }
}