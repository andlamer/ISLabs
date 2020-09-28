using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ServiceModel.Description;

namespace Full_direct_of_two_machines__ISLab1_
{

	class Program
	{
		static void Main(string[] args)
		{
			Test();
			Console.ReadKey();
		}

		public static void Test()
		{
			#region States A1
			List<int[]> A1 = new List<int[]>();
			A1.Add(new int[] { 0 });
			A1.Add(new int[] { 1 });
			A1.Add(new int[] { 2 });
			A1.Add(new int[] { 3 });
			A1.Add(new int[] { 4 });
			#endregion

			#region Alphabet X
			List<string[]> X = new List<string[]>();
			X.Add(new string[] { "x"});
			X.Add(new string[] { "y" });
			#endregion

			#region Initial States A01
			List<int[]> A01 = new List<int[]>();
			A01.Add(new int[] { 0 });
			#endregion

			#region Final States F1
			List<int[]> F1 = new List<int[]>();
			F1.Add(new int[] { 4 });
			#endregion

			#region Transition Function A1
			List<KeyValuePair<KeyValuePair<int[], string>, int[]>> transtitionFunctionA1 = new List<KeyValuePair<KeyValuePair<int[], string>, int[]>>();
			transtitionFunctionA1.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 0}, "y"), new int[] { 1 }));
			transtitionFunctionA1.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 1}, "y"), new int[] { 1 }));
			transtitionFunctionA1.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 1}, "x"), new int[] { 4 }));
			transtitionFunctionA1.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 4}, "y"), new int[] { 4 }));
			transtitionFunctionA1.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 0}, "x"), new int[] { 2 }));
			transtitionFunctionA1.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 2}, "y"), new int[] { 4 }));
			transtitionFunctionA1.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 2}, "x"), new int[] { 3 }));
			transtitionFunctionA1.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 3}, "x"), new int[] { 2 }));
			transtitionFunctionA1.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 3}, "y"), new int[] { 4 }));
			transtitionFunctionA1.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 4}, "x"), new int[] { 3 }));
			#endregion
			Machine machineA1 = new Machine(A1, X, transtitionFunctionA1, A01, F1);

			#region States A2
			List<int[]> A2 = new List<int[]>();
			A2.Add(new int[] { 0 });
			A2.Add(new int[] { 1 });
			A2.Add(new int[] { 2 });
			#endregion

			#region Initial States A02
			List<int[]> A02 = new List<int[]>();
			A02.Add(new int[] { 0 });
			#endregion

			#region Final States F2
			List<int[]> F2 = new List<int[]>();
			F2.Add(new int[] { 2 });
			#endregion

			#region Transition Function A2
			List<KeyValuePair<KeyValuePair<int[], string>, int[]>> transtitionFunctionA2 = new List<KeyValuePair<KeyValuePair<int[], string>, int[]>>();
			transtitionFunctionA2.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 0 }, "y"), new int[] { 2 }));
			transtitionFunctionA2.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 2 }, "y"), new int[] { 2 }));
			transtitionFunctionA2.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 2 }, "x"), new int[] { 1 }));
			transtitionFunctionA2.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 1 }, "y"), new int[] { 2 }));
			transtitionFunctionA2.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 1 }, "x"), new int[] { 0 }));
			transtitionFunctionA2.Add(new KeyValuePair<KeyValuePair<int[], string>, int[]>(new KeyValuePair<int[], string>
				(new int[] { 0 }, "x"), new int[] { 1 }));
			#endregion

			Machine machineA2 = new Machine(A2, X, transtitionFunctionA2, A02, F2);
			Machine resultMachine = DirectProduct.fullDirectProduct(machineA1, machineA2);
			resultMachine.ShowMachineInfo();
		}
	}
}
