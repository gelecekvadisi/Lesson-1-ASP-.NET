using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
	public class MyGenericClass<T> where T : class
	{
		private T genericValue;
        public MyGenericClass(T value)
        {
			genericValue = value;
        }
        public T NumberGet()
        {
            return genericValue;
        }
        public T value2 { get; set; }
    }
}
