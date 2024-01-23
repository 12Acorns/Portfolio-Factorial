namespace FactorialApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] inputNumbers = new int[]
			{
				4, 6, 7, 12, 27, 19
			};

			long[] _results = new long[6];

			for(int i = 0; i < inputNumbers.Length; i++)
			{
				_results[i] = FindFactorial(inputNumbers[i]);
				Console.Write($"{inputNumbers[i]}: {_results[i]}\n");
			}
			Console.WriteLine();
		}
		static long FindFactorial(int _input)
		{
			return FactorialFinder(_input);
		}
		static long FactorialFinder(int _input, long _currentFactorial = 0)
		{
			if(_input == 1)
			{
				return _currentFactorial;
			}
			_currentFactorial += _input * (--_input);
			_currentFactorial = FactorialFinder(_input, _currentFactorial);
			return _currentFactorial;
		}
	}
}
