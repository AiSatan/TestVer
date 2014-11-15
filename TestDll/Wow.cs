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
			await Task.Run(new Action(Test));
			Console.WriteLine("Runing.. DLL: " + str + " NET: " + Environment.Version);
	    }

	    private void Test()
	    {
			Console.WriteLine("In Thread! NET: " + Environment.Version);
			Thread.Sleep(5000);
			Console.WriteLine("In Thread! End Sleep! NET: " + Environment.Version);
	    }
    }
}
