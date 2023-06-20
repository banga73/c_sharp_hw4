int[] ArrayIn(int length)
{
	int[] DightsA = new int[length];
	for (int i = 0; i < length; i++)
	{
		Console.WriteLine($"Input {i} element ");
		DightsA[i] = int.Parse(Console.ReadLine());
	}			
	return DightsA;
}

void ArrayOut(int[] arr, int length)
{
	for (int i = 0; i < length; i++)
	{
		Console.Write($"{arr[i]} ");
	}
}
Console.WriteLine("Input quant of elements ");
int LenArr = int.Parse(Console.ReadLine());
int[] NewArray = ArrayIn(LenArr);
ArrayOut(NewArray, LenArr);