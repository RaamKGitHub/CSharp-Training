using System;
using CalculationLogic;
namespace Calculator
{

	class Calculate
	{
		 static void Main()
			{
			int x=10;
			int y=20;
			
				int  addRes=Calculation.Add(x, y);
				 int subRes=Calculation.Sub(x, y);
				Console.WriteLine(addRes);
				Console.WriteLine(subRes);
				
				
			}

	}
}
