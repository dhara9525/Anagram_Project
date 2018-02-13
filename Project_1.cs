using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter input as space seperaed values: ");
		String inputString = Console.ReadLine();
		inputString = inputString.Trim();
		if (String.IsNullOrEmpty(inputString) == true || inputString == " ")
		{
			Console.WriteLine("Input string is not valid");
			return;
		}
		Char delimiter = ' ';
		String[] substrings = inputString.Split(delimiter);
		List<String> stringList = new List<String>();
		foreach (String st in substrings)
		{
			stringList.Add(st);
		}
		ismatch(stringList);
	}
	public static void ismatch(List<String> stringList)
	{
		int length = stringList.Count;
		List<String> stringList1 = new List<String>();
		int count = 0;
		for (int i = 0; i < length - 1; i++)
		{
			for (int j = i + 1; j < length; j++)
			{
				char[] a = stringList[i].ToLower().ToCharArray();
				char[] b = stringList[j].ToLower().ToCharArray();
				Array.Sort(a);
				Array.Sort(b);
				if (new String(a).Equals(new String(b)))
				{
					stringList1.Add(stringList[i]);
					stringList1.Add(stringList[j]);
					stringList.Remove(stringList[j]);
					length = length - 1;
				}
			}
			stringList1.Add("\n");
		}
		Console.WriteLine("Result :\n");
		foreach (String resultString in stringList1)
		{
			Console.Write(" " + resultString);
			count++;
		}
		if (count == 0)
		{
			Console.WriteLine("In the given string anagram words don't exist");
			return;
		}
	}
}