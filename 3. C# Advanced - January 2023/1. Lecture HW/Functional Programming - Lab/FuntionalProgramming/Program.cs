public delegate void Test(int x, int y);

internal class Program
{
    static void Main(string[] args)
    {

        Test x = new Test((x, y) => { });
        Console.WriteLine("Hello World!");
    }
}
