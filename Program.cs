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
            //Store datafile into a string after reading from current directory.
            string DataFileName = "pbs-atc-2016csvjuly.csv";
            string WorkingDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine (WorkingDirectory); 

            string fullFileName = Path.Combine(WorkingDirectory, DataFileName);//What is it this line of code doing?

            Console.WriteLine(string.Format("Working of data file -> {0}", fullFileName));

            IEnumerable<string> lines = File.ReadAllLines(fullFileName);
            
            List<string> all_elements  = GetValues(lines);

            all_elements.ForEach( e => Console.WriteLine(e));
            Console.WriteLine("Total number of elements contained in the CSV file is: " + all_elements.Count);
            Console.Write("Enter the elements, you'd like to search for: ");
            string[] searchElements = Console.ReadLine().Split(' ');

            List<FoundResult> results = new List<FoundResult>();


var a = all_elements.Select((x , i)=> new { V=x ,I = i} );
var b =a.Where( s => s.V == "March");
var c = b.Select(x=>x.I);
var f = c.ToArray();


            foreach (string searchElement in searchElements)
            {
                if (all_elements.Contains(searchElement))
                    results.Add( new FoundResult(){
                        Value = searchElement , 
                        Count = all_elements.Where( s => s == searchElement).Select(x=>x).Count(), 
                        Indexes = all_elements.Select((x , i)=> new { V=x ,I = i} ).Where( s => s.V == searchElement).Select(x=>x.I).ToArray()
                        });
            }
            
            results.ForEach( r => Console.WriteLine("Value={0} , Repated={1} , Indexes={2}", r.Value, r.Count, string.Join(",",r.Indexes) ) );

            // double qubits = Math.Log(all_elements.Count) / Math.Log(2.0);
            // Console.WriteLine(qubits);
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


// I want all the values to be indexed Frist. Then, when a repeated value is found, the indexes (int) should be extracted from the first value 