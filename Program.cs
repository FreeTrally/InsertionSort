using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter command (sort or test)");
            var line = Console.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                switch (line.Trim())
                {
                    case "sort":
                        Sort();
                        break;
                    case "test":
                        Writer();
                        break;
                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }

                Console.WriteLine("Enter command (sort or test)");
                line = Console.ReadLine();
            }         
        }

        private static void Sort()
        {
            Console.WriteLine("Enter array to sort, string by string");
            Console.WriteLine("When you entered all data, enter empty string");
            var line = Console.ReadLine();
            var list = new List<string>();
            while (!string.IsNullOrEmpty(line))
            {
                list.Add(line);

                line = Console.ReadLine();
            }

            var array = list.ToArray();
            InsertionSort.SortString(array);
            foreach (var e in array)
                Console.WriteLine(e);
        }

        private static void Writer()
        {
            string pathCsvFile = @"C:\Users\Сергей\source\repos\InsertionSort\Data.csv";

            var testData = GenerateData();

            var csv = new StringBuilder();

            foreach (var e in testData)
            {
                var newLine = string.Format("{0},{1},{2}", e.Length, e.Memory, e.Time);
                csv.AppendLine(newLine);
            }

            File.WriteAllText(pathCsvFile, csv.ToString());
        }

        private static List<TestData> GenerateData()
        {
            var testData = new List<TestData>();
            var r = new Random();
            
            for (var i = 10; i <= 10000; i += 10)
            {
                var array = new int[i];
                for (var j = 0; j < array.Length; j++)
                    array[j] = r.Next(0, 1000);

                var result = InsertionSort.Sort(array);
                testData.Add(new TestData(i, result));
            }

            return testData;
        }
    }

    public class TestData
    {
        public string Length { get; set; }
        public string Memory { get; set; }
        public string Time { get; set; }

        public TestData(int length, SortComplexity data)
        {
            Length = length.ToString();
            Memory = data.Memory.ToString();
            Time = data.Time.ToString();
        }
    }
}