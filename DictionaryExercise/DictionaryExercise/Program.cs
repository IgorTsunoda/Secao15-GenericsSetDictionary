using System.Reflection.Metadata;

namespace DictionaryExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //file content:
            //Alex Blue,15
            //Maria Green,22
            //Bob Brown,21
            //Alex Blue,30
            //Bob Brown,15
            //Maria Green,27
            //Maria Green,22
            //Bob Brown,25
            //Alex Blue,31

            string file = @"c:\temp\in.txt";

            using (StreamReader sr = new StreamReader(file))
            {
                Dictionary<string, int> votation = new Dictionary<string, int>();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(",");
                    string name = line[0];
                    int value = int.Parse(line[1]);
                    if (votation.ContainsKey(name))
                    {
                        votation[name] += value;
                    }
                    else
                    {
                        votation[name] = value;
                    }
                }
                foreach (KeyValuePair<string, int> item in votation)
                {
                    Console.WriteLine(item.Key + " : " + item.Value);
                }
            }
        }
    }
}
