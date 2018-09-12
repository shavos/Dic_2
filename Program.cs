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
            
            Console.Write("Enter the elements, you'd like to search for: ");
            string[] s = Console.ReadLine().Split(' ');

            var lines = File.ReadAllLines("/Users/shovan/Projects/Dic_2/pbs-atc-2016csvjuly_new.csv");

            List<string> all_elements = new List<string>();
            //Dictionary<int, string> dictionaryTest = new Dictionary<int, string>();
            Dictionary<int, List<string>> duplicate = new Dictionary<int, List<string>>();
            //<long> markedElements = new QArray<long>() { 0, 39, 101, 234 };

            List<int> markedElements = new List<int>();

            
           

            //Read each line and split it in words, then print (instead, need to store values in lists -> turn into dictionary)
            
            //Reading though each line
            foreach (string item in lines)
            {
                var values = item.Split(',');

                //Reading though each word of a line, adding to a list
                foreach (var v in values)
             
             
                {
                all_elements.Add(v);
                }
                //Displaying all elements sored in a list
                foreach (string i in all_elements)
                {
                    Console.WriteLine(i);
                    
                }
            }
                for(int i=0; i <all_elements.Count; i++)
                {
                duplicate.Add(i, new List<string>{all_elements[i]});
                
                // foreach(string a in all_elements){
                //     if(a=="Year"){
                //         Console.WriteLine("{0}",i);
                //     }else{
                //         Console.WriteLine("Value does not exist in the database");
                //     }
                // }
                }
                
               
                //}
                //var dup = 
                // if(dictionaryTest.ContainsKey(i)){
                //     duplicate.Add(i, new List<string>{all_elements[i]});
                // }else{

                // }
                //}
                foreach (KeyValuePair<int, List<string>> allitem in duplicate)
                {
                    
                Console.Write("['{0}',", allitem.Key);
                {
                    foreach (var v in allitem.Value)
                    {
                       if (v==s[0])     
                        Console.Write("'{0}']", allitem.Key);
                    }
                }
                Console.WriteLine();
                 }

                 double qubits = Math.Log(all_elements.Count)/Math.Log(2.0);
                 Console.WriteLine(qubits);


                 //line read -> split into words -> turned each word into Dictionary ->(displayed all the )started reading the lines again, split into words
                 //->


            }
            
            //Console.WriteLine(all_elements);
                
            }
            
        



            /*++++++++++++++++++++++++++++++++++++++++++++++++++ */

         //  using(var path = new StreamReader("/Users/shovan/Projects/Dic_2/pbs-atc-2016csvjuly_new.csv"))

            
        //  {
        //      List<string> all_elements = new List<string>();

        //     while(!path.EndOfStream)
        //      {
        //         var line = path.ReadLine();
        //         var values = line.Split(',');
        //         all_elements.Add(values[0]);     
        //      }
        //      foreach(var item in all_elements)
        //      {
        //         Console.WriteLine(item);
        //      }
        //     Dictionary<int, string> dictionaryTest = new Dictionary<int, string>();

        //     for(int i=0; i <all_elements.Count; i++)
        //     {
        //         dictionaryTest.Add(i, all_elements[i]);
        //     }

        //     foreach (KeyValuePair<int, string> item in dictionaryTest)
        //     {
        //         //Console.WriteLine("Array Position {0} and Position Value {1}",item.Key,item.Value.ToString()); 
        //     Console.WriteLine("'{0}','{1}'", item.Key, item.Value);
        //     }

            /*++++++++++++++++++++++++++++++++++++++++++++++++++ */

            /************************************************* */   
            //     /*Need to handle dupliate value here*/
            //     var dict = line.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).Select((str, idx) => new { str, idx }).ToDictionary(x => x.str, x => (uint)x.idx);
             
            //  //List<KeyValuePair<string, string>> myduplicateLovingDictionary= new List<KeyValuePair<string, string>>();
            //  //myduplicateLovingDictionary.Add(dict);
            //     foreach (KeyValuePair<string, uint> itemGroup in dict)
            //     {
            //         Console.WriteLine("'{0}','{1}'", itemGroup.Key, itemGroup.Value);
            //     }
            
            //  }
             /**************************************************** */

              // Count number of values available in each line & Print
                //int totalCount = values.Count();
                //Console.WriteLine(totalCount);

        

             
        
    }


