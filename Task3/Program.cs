public class HelloWorld
{	
	static void PrintArray(int[] myArray, int i = 0)
	{
	    int l=myArray.Length;
		if (i < l)
		{
			Console.WriteLine(myArray[l-i-1]);
			PrintArray(myArray, i + 1);
		}
	}
	
    public static void Main(string[] args)
    {
		int[] myArray = {10, 20, 30, 40, 50};
		
		PrintArray(myArray);
    }
}
