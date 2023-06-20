int PowerAB(int A, int B)
{
	int Power = 1;
	for (int i = 1; i <= B; i++) {Power = Power * A;};
	return Power;
}

Console.WriteLine("Input number A ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Input number B ");
int numB = int.Parse(Console.ReadLine());
int rez = PowerAB(numA, numB);
Console.Write($"A^B = {rez}");