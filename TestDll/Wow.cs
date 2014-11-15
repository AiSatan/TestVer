using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestDll
{
    public class Wow
    {
	    public async void Start(string str)
	    {  
			Console.WriteLine("DLL: " + str + " NET: " + Environment.Version);
			await new Task(Test);
	    }

	    private void Test()
	    {

			Console.WriteLine("In Thread! NET: " + Environment.Version);
			Thread.Sleep(1000);
	    }
    }
}
