using System;
class TemperaturesRegister
{
   static void Main()
   {
      double[] temps = new double[7];
      string[] weekDays = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
      double sumTemps = 0;
      double promedio = 0;
      double maxTemp = temps[0];
      double minTemp = temps[0];

      for (int i = 0; i < temps.Length; i++)
      {
         Console.Write("Ingresa la temperatura del dia " + weekDays[i] + ": ");
         if (double.TryParse(Console.ReadLine(), out double temp))
         {
            temps[i] = temp;
            sumTemps += temps[i];
         }
      }

      promedio = sumTemps / temps.Length;
      Console.WriteLine("El promedio de las temperaturas es: " + promedio);

      // Search the max and min temperatures in the array
      for (int i = 1; i < temps.Length; i++)
      {
         if (temps[i] > maxTemp)
            maxTemp = temps[i];
         if (temps[i] < minTemp)
            minTemp = temps[i];
      }
      Console.WriteLine("La temperatura máxima es: " + maxTemp);
      Console.WriteLine("La temperatura mínima es: " + minTemp);
   }
}