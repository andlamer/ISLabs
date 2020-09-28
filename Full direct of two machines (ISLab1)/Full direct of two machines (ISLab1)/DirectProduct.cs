using System;
using System.Collections.Generic;

namespace Full_direct_of_two_machines__ISLab1_
{
	class DirectProduct
	{
		public static Machine fullDirectProduct(Machine machineA, Machine machineB)
		{
			Machine resultOfMultiplication = new Machine();
			resultOfMultiplication.allStates = Utilities.CartesianProductOfArrays(machineA.allStates, machineB.allStates);
			if (!machineA.inputAlphabet.Equals(machineB.inputAlphabet))
				return null;
			resultOfMultiplication.inputAlphabet = machineA.inputAlphabet;
			resultOfMultiplication.transitionFunction = Utilities.createNewTransitionFunction
				(machineA.transitionFunction, machineB.transitionFunction);
			resultOfMultiplication.initialStates = Utilities.CartesianProductOfArrays
				(machineA.initialStates, machineB.initialStates);
			resultOfMultiplication.outputStates = Utilities.CartesianProductOfArrays
				(machineA.outputStates, machineB.outputStates);
			return resultOfMultiplication;
		}
	}

	class Utilities
	{
		public static List<int[]> CartesianProductOfArrays(List<int[]> arrayA, List<int[]> arrayB)
		{
			List<int[]> resultProduct = new List<int[]>();
			foreach (int[] elementA in arrayA)
			{
				foreach (int[] elementB in arrayB)
				{
					int[] tempResult = new int[elementA.Length + elementB.Length];
					int i = 0;
					while (i < elementA.Length)
					{
						tempResult[i] = elementA[i];
						i++;
					}
					while ((i - elementA.Length) < elementB.Length)
					{
						tempResult[i] = elementB[i - elementA.Length];
						i++;
					}
					resultProduct.Add(tempResult);
				}
			}
			return resultProduct;
		}
		public static List<KeyValuePair<KeyValuePair<int[], string>, int[]>> createNewTransitionFunction(List<KeyValuePair<KeyValuePair<int[], string>, int[]>> transitionFunctionA, List<KeyValuePair<KeyValuePair<int[], string>, int[]>> transitionFunctionB)
		{
			List<KeyValuePair<KeyValuePair<int[], string>, int[]>> resultedTransitionFunction = new List<KeyValuePair<KeyValuePair<int[], string>, int[]>>();
			foreach (KeyValuePair<KeyValuePair<int[], string>, int[]> keyValuePairA in transitionFunctionA)
			{
				foreach (KeyValuePair<KeyValuePair<int[], string>, int[]> keyValuePairB in transitionFunctionB)
				{
					if (keyValuePairA.Key.Value == keyValuePairB.Key.Value)
					{
						KeyValuePair<int[], string> tempPair = new KeyValuePair<int[], string>
							(new int[] { keyValuePairA.Key.Key[0], keyValuePairB.Key.Key[0] }, keyValuePairA.Key.Value);
						int[] statesResult = new int[] { keyValuePairA.Value[0], keyValuePairB.Value[0] };
						KeyValuePair<KeyValuePair<int[], string>, int[]> tempStatePair = new
							KeyValuePair<KeyValuePair<int[], string>, int[]>(tempPair, statesResult);
						resultedTransitionFunction.Add(tempStatePair);
					}
				}
			}
			return resultedTransitionFunction;
		}
		public static void DisplayListOfArrays(List<int[]> list)
		{
			foreach (int[] element in list)
			{
				Console.Write("[");
				for (int i = 0; i < element.Length; i++)
				{
					if (i == element.Length - 1)
						Console.Write("{0}", element[i]);
					else
						Console.Write("{0}, ", element[i]);
				}
				Console.Write("]	");
			}
			Console.WriteLine();
		}
		public static void DisplayListOfArrays(List<string[]> list)
		{
			foreach (string[] element in list)
			{
				Console.Write("[");
				for (int i = 0; i < element.Length; i++)
				{
					if (i == element.Length - 1)
						Console.Write("{0}", element[i]);
					else
						Console.Write("{0}, ", element[i]);
				}
				Console.Write("]	");
			}
			Console.WriteLine();
		}
	}
}
