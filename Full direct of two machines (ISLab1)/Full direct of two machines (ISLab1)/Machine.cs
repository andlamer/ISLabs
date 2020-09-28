using System;
using System.Collections.Generic;



namespace Full_direct_of_two_machines__ISLab1_
{
	class Machine
	{
		public List<KeyValuePair<KeyValuePair<int[], string>, int[]>> transitionFunction;
		public List<int[]> allStates = new List<int[]>();
		public List<string[]> inputAlphabet = new List<string[]>();
		public List<int[]> initialStates = new List<int[]>();
		public List<int[]> outputStates = new List<int[]>();

		public Machine()
		{

		}
		public Machine(List<int[]> allStates, List<string[]> inputAlphabet,
			List<KeyValuePair<KeyValuePair<int[], string>, int[]>> transitionFunction, 
			List<int[]> initialStates, List<int[]> outputStates)
		{
			this.initialStates = initialStates;
			this.transitionFunction = transitionFunction;
			this.inputAlphabet = inputAlphabet;
			this.allStates = allStates;
			this.outputStates = outputStates;
		}

		public void ShowMachineInfo()
		{
			Console.WriteLine("States");
			Utilities.DisplayListOfArrays(this.allStates);
			Console.WriteLine("Alphabet");
			Utilities.DisplayListOfArrays(this.inputAlphabet);
			Console.WriteLine("Transtion Function");
			foreach (var element in this.transitionFunction)
			{
				Console.Write("<(");
				for (int i = 0; i < element.Key.Key.Length; i++)
				{
					if (i == element.Key.Key.Length - 1)
					{
						Console.Write("{0}", element.Key.Key[i]);
					}
					else
					{
						Console.Write("{0},", element.Key.Key[i]);
					}
				}
				Console.Write("),\"{0}\">,(", element.Key.Value);
				for (int i = 0; i < element.Value.Length; i++)
				{
					if (i == element.Value.Length - 1)
					{
						Console.Write("{0}", element.Value[i]);
					}
					else
					{
						Console.Write("{0},", element.Value[i]);
					}
				}
				Console.Write(")>\n");
			}
			Console.WriteLine("\nInitial States");
			Utilities.DisplayListOfArrays(this.initialStates);
			Console.WriteLine("\nFinal States");
			Utilities.DisplayListOfArrays(this.outputStates);
		}
	}
}
