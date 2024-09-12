using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_07_Funktioner {
	internal class Program {

		static void PrintGreeting() {
			Console.WriteLine("Tjena tjena");
		}

		static string GetGreeting() {
			return "Tjena tjena";
		}

		static void PrintGreetingToPerson(string name) {
			Console.WriteLine("Hejhej " + name);
		}

		static int Double(int x) {
			return x * 2;
		}

		static void Main(string[] args) {
			PrintGreeting();

			PrintGreetingToPerson("Anna");
			PrintGreetingToPerson("Sigge");

			int doubled = Double(2);
			Console.WriteLine(doubled);

			string greeting = GetGreeting();

			Console.WriteLine(greeting);
		}
	}
}
