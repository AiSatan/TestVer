using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("EXE: " + "Work" + " NET: " + Environment.Version);
			Assembly a = Assembly.LoadFile(@"C:\Users\Satan\Documents\visual studio 2013\Projects\Test_Flamework_ver\TestDll\bin\Debug\TestDll.dll");
			Type t = a.GetType("TestDll.Wow"); 
			Object instance = Activator.CreateInstance(t);
			MethodInfo m = t.GetMethod("Start");
			m.Invoke(instance, new object[] { "Work" });
			Console.ReadLine();
		}
	}
}
