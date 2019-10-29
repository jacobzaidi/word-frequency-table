/**

	Takes a file and creates a word frequency table.
	
	Name: Saqib Zaidi Sahib
	
	UPI: ssah933
	
	AUID: 222479856
	
	COMPSCI 335 S2 2018 Assignment 1

*/


using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
	static void Main(string[] args)
	{
		try 
		{
			int k = 3;
			string path = args[0];
			if (args.Length == 2) 
				k = Int32.Parse(args[1]);
			string text = File.ReadAllText(path);
			Regex rgx = new Regex(@"[^A-Za-z]+");
			var words = rgx.Replace(text, " ").Trim().Split(' ');
			IEnumerable<string> frs = words
                .GroupBy(s => s.ToUpper())
                .Select(g => g.Count().ToString() + " " + g.Key)
                .OrderByDescending(kc => Int32.Parse(kc.Split(' ')[0]))
                .ThenBy(kc => kc.Split(' ')[1])
                .Take(k);
            var finalOutput = string.Join("\n\n", frs);
            Console.WriteLine(finalOutput);
        }
		catch(Exception e)
		{
			Console.WriteLine("*** Error: {0}", e.Message);
		}
	}
}