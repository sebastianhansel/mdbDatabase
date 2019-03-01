using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace mdbDatabase
{
	class DataDAO
	{
		public void Load(List<DataDTO> db, string path)
		{
			OleDbDataReader dbDataReader = null;
			
			string database = @"Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=" + path;
			OleDbConnection dbConnection = new OleDbConnection(database);

			OleDbCommand dbCommandLoad = new OleDbCommand("select ID, Name, Phone, Email from Table1", dbConnection);
			
			dbConnection.Open();
			dbDataReader = dbCommandLoad.ExecuteReader();

			string[] value;
			value = new string[4];
			int counter = 0;
			while (dbDataReader.Read())
			{
				for (int i = 0; i < 4; i++)
				{
					value[i] = "";
					if (dbDataReader[i] != null)
					{
						value[i] = dbDataReader[i].ToString();
					}
				}
				db.Add(new DataDTO(value[0], value[1], value[2], value[3]));
				counter++;
			}

			Console.WriteLine("{0} records:\n", counter);

			dbConnection.Close();
		}
	}
}
