using System;

namespace Interface
{
	class Program
	{
		static void Main(string[] args)
		{
			// poderia usar uma fábrica, como Factory Method, ou Abstract Factory...
			DBConnection con = new SqlConnection()
			{
				ConnectionString = "SQL Server"
			};
			con.Open();
			con.Close();
			Console.ReadLine();
		}
	}
}
