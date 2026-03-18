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