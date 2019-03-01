using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdbDatabase
{
	class Program
	{
		static void Main(string[] args)
		{
			List<DataDTO> db1 = new List<DataDTO>();

			DataDAO base1 = new DataDAO();
			base1.Load(db1, "C:\\NoScan\\Database.mdb");

			foreach (DataDTO r in db1)
				Console.WriteLine(r.id + " " + r.name.ToString() + " " + r.phone.ToString() + " " + r.email.ToString());

			Console.WriteLine("\n\nPress any key ...");
			Console.ReadKey();
		}
	}
}
