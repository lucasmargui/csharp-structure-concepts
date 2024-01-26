using System;

namespace Virtual
{

    class MyBaseClass
    {
        // Virtual: usada para modificar uma declaração de método, propriedade, indexador ou evento e permitir que ela seja substituída em uma classe derivada

        public virtual string Name { get; set; }

        // ordinary virtual property with backing field
        private int _num;
        public virtual int Number
        {
            get { return _num; }
            set { _num = value; }
        }
    }


    class MyDerivedClass : MyBaseClass
    {
        private string _name;

        // Override auto-implemented property with ordinary property
        // to provide specialized accessor behavior.
        public override string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    _name = "Unknown";
                }
            }
        }
    }
    class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
