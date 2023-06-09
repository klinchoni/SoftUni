namespace OddLines
{
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            //using (StreamWriter writer = new StreamWriter("../../../output.txt"))
            //{
            //    writer.Write("Tova ne e KLINCHONI");
            //    writer.WriteLine("Hello My first actual write to a file!!!");
            //}

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string line = "";
                    int row = 0;
                    while (line != null)
                    {
                        line = reader.ReadLine();
                        if (row % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        row++;
                    }
                }
            }
        }
    }
}
