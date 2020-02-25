using System;
using MySystem;
using MySystem.DataAccess;
using MySystem.Drawing;

namespace Client
{
	class Program
	{
		static void Main()
		{
			SqlDataAccess.GetData();
			//OracleDataAccess.GetData();
			Circle.Draw();
			MyConsole.Write("write this");
			MsAccessDataAccess.GetData();
		}
	}
}