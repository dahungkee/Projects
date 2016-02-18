using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
	class program {
		static void Main(string[] args) {
			//factorial.FunFactorial();
			//Console.WriteLine(StringTools.Alphabetize("sam"));
			//Console.WriteLine(StringTools.Alphabetize("spot"));
			//Console.WriteLine(StringTools.Alphabetize("cat"));

			Console.WriteLine("Is 'sam' and 'mas' permutation? " + StringTools.IsStringPermutation("sam", "Mas"));
			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}
	}
}
