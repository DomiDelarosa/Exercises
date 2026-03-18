using System;
class TemperaturesRegister
{
   static void Main()
   {
      double[] temps = new double[7];
      string[] diaSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
      double sumaTemps = 0;

      for (int i = 0; i < temps.Length; i++)
      {
         Console.Write("Ingresa la temperatura del día " + diaSemana[i] + ": ");
         if (double.TryParse(Console.ReadLine(), out double temp))
         {
            temps[i] = temp;
            sumaTemps += temps[i];
         }
         else
         {
            Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
            i--;
         }
      }

      double promedio = sumaTemps / temps.Length;

      // Revisar el día más caluroso y el día más frío
      double maxTemp = temps[0];
      double minTemp = temps[0];
      int posMax = 0;
      int posMin = 0;
      for (int i = 1; i < temps.Length; i++)
      {
         if (temps[i] > maxTemp) // si la temperatura actual es mayor a la máxima registrada, se actualiza el valor de la máxima y su posición
         {
            maxTemp = temps[i];
            posMax = i;
         }

         if (temps[i] < minTemp) // si la temperatura actual es menor a la mínima registrada, se actualiza el valor de la mínima y su posición
         {
            minTemp = temps[i];
            posMin = i;
         }
      }

      // bubble sort para ordenar las temperaturas de menor a mayor

      for (int i = 0; i < temps.Length - 1; i++)
      {
         for (int j = 0; j < temps.Length - i - 1; j++)
         {
            if (temps[j] > temps[j + 1]) // si la temperatura actual es mayor a la siguiente, se intercambian los valores
            {
               double temp = temps[j];
               temps[j] = temps[j + 1];
               temps[j + 1] = temp;
            }
         }
      }

      // cuántos días estuvieron por encima del promedio
      int diasPorEncimaPromedio = 0;

      for (int i = 0; i < temps.Length; i++)
      {
         if (temps[i] > promedio)
         {
            diasPorEncimaPromedio++;
         }
      }

      Console.WriteLine("El promedio de las temperaturas es: " + promedio + "°C");
      Console.WriteLine("El día más caluroso fue el " + diaSemana[posMax] + " con " + maxTemp + "°C");
      Console.WriteLine("El día más frío fue el " + diaSemana[posMin] + " con " + minTemp + "°C");
      Console.WriteLine("Las temperaturas ordenadas de menor a mayor son: ");
      for (int i = 0; i < temps.Length; i++) // se imprimen las temperaturas ordenadas de menor a mayor
      {
         Console.Write(temps[i] + "°C ");
      }
      Console.WriteLine("\nLa cantidad de días que estuvieron por encima del promedio es: " + diasPorEncimaPromedio);

   }
}