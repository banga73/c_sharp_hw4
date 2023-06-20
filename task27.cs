int SumDights(int A, int length)
{
	int i = 0;
	int[] DightsA = new int[length];
	int SumA = 0;
	while (i < length)
	{
		DightsA[i] = A%10;
		A = A/10;
		SumA = SumA + DightsA[i];
		i++;
	}
	return SumA;
}

Console.WriteLine("Input number ");
string str = Console.ReadLine();
int len = str.Length;
int numA = int.Parse(str);
int rez = SumDights(numA, len);
Console.Write($"Sum of dights id {rez}");