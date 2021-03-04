using System.IO;
using System;
using CsvHelper;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание генератора случайных чисел
            Random rand = new Random();
            // Путь к файлу numbers.csv
            string path = "C:/numbers.csv";
            // Создание потока ввода в файл
            using (StreamWriter streamWrite = new StreamWriter(path))
            {
                // Настраиваем разделитель csv файла
                var config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { Delimiter="," };
                // Создание потока записи csv файла на основе потока ввода в файл
                using (CsvWriter csvWrite = new CsvWriter(streamWrite, config))
                {
                    // Цикл добавления столбцов
                    for (int i = 0; i < 100; i++)
                    {
                        // Добавление числа в файл numbers.csv
                        csvWrite.WriteField(rand.Next(1,100).ToString());
                    }
                }
            }
        }
    }
}
