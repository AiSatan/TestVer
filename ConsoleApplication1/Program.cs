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
			Assembly a = Assembly.LoadFile(@"C:\Users\Satan\Documents\visual studio 2013\Projects\Test_Flamework_ver\TestDll2\bin\Debug\TestDll2.dll"); // dll - "ClassLibrary3"
			Type t = a.GetType("TestDll2.Wow2"); // namespace - "MyPlayers" , class - "Player"
			Object instance = Activator.CreateInstance(t);
			MethodInfo m = t.GetMethod("Start"); // method
			m.Invoke(instance, new object[] { "Work" });
			Console.ReadLine();
		}
	}
}
