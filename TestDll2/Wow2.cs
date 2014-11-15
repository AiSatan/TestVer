using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDll2
{
    public class Wow2
	{
		public async void Start(string str)
		{
			await Task.Delay(5000);
			throw new Exception("!!");
		}
    }
}
