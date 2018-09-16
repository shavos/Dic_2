using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Dic_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string DataFileName = "pbs-atc-2016csvjuly_new.csv";
            string WorkingDirectory = Directory.GetCurrentDirectory();

            string fullFileName = Path.Combine(WorkingDirectory, DataFileName);

            Console.WriteLine(string.Format("Working of data file -> {0}", fullFileName));

            IEnumerable<string> lines = File.ReadAllLines(fullFileName);
            
            List<string> all_elements  = GetValues(lines);

            all_elements.ForEach( e => Console.WriteLine(e));
            
            Console.Write("Enter the elements, you'd like to search for: ");
            string[] searchElements = Console.ReadLine().Split(' ');

            List<FoundResult> results = new List<FoundResult>();
            foreach (string searchElement in searchElements)
            {
                if (all_elements.Contains(searchElement))
                    results.Add( new FoundResult(){Value = searchElement , Count = all_elements.Where( s => s == searchElement).Select(x=>x).Count()});
            }
            
            results.ForEach( r => Console.WriteLine("Value={0} , Repated={1}", r.Value, r.Count));

            double qubits = Math.Log(all_elements.Count) / Math.Log(2.0);
            Console.WriteLine(qubits);
            Console.ReadLine();
            
        }

        private static List<string> GetValues(IEnumerable<string> lines)
        {
            List<string> all_elements = new List<string>();
            foreach (string item in lines)
            {
                string[] values = item.Split(',');

                //Reading though each word of a line, adding to a list
                foreach (string v in values)
                {
                    all_elements.Add(v);
                }
            }

            return all_elements;
        }

    }
}


