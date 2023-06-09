int size = int.Parse(Console.ReadLine());

string carNumber = Console.ReadLine();
string[,] matrixRenamed = ReadMatrix<string>(() => Console.ReadLine().Split(), size, size);

bool isFirstTunnelFound = false;
int firstTunnelRow = 0;
int firstTunnelCol = 0;

int secondTunnelRow = 0;
int secondTunnelCol = 0;

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrixRenamed[row, col] == "T" && !isFirstTunnelFound)
        {
            firstTunnelRow = row;
            firstTunnelCol = col;
            isFirstTunnelFound = true;
        }
        else if (matrixRenamed[row, col] == "T")
        {
            secondTunnelRow = row;
            secondTunnelCol = col;
        }
    }
}


//down
//right

string command = Console.ReadLine().ToLower();
int carRow = 0;
int carCol = 0;
int kms = 0;
bool isFinished = false;

while (command != "end")
{
    //matrix[carRow, carCol] = ".";

    if (command == "down")
    {
        carRow++;
    }
    if (command == "up")
    {
        carRow--;
    }
    if (command == "left")
    {
        carCol--;
    }
    if (command == "right")
    {
        carCol++;
    }

    if (matrixRenamed[carRow, carCol] == ".")
    {
        kms += 10;
    }
    if (matrixRenamed[carRow, carCol] == "T")
    {
        matrixRenamed[carRow, carCol] = ".";
        if (carRow == firstTunnelRow && carCol == firstTunnelCol)
        {
            carRow = secondTunnelRow;
            carCol = secondTunnelCol;
        }
        else
        {
            carRow = firstTunnelRow;
            carCol = firstTunnelCol;
        }

        matrixRenamed[carRow, carCol] = ".";
        kms += 30;
    }
    if (matrixRenamed[carRow, carCol] == "F")
    {
        kms += 10;
        isFinished = true;
        break;
    }

    //matrix[carRow, carCol] = "C";

    //Console.WriteLine("Next step: ");
    //PrintMatrix(matrix, e => Console.Write(e + ' '));

    command = Console.ReadLine().ToLower();
}

matrixRenamed[carRow, carCol] = "C";

if (isFinished)
{
    Console.WriteLine($"Racing car {carNumber} finished the stage!");
}
else
{
    Console.WriteLine($"Racing car {carNumber} DNF.");
}

Console.WriteLine($"Distance covered {kms} km.");

PrintMatrix(matrixRenamed, e => Console.Write(e));


static T[,] ReadMatrix<T>(Func<T[]> rowDataGetter, int rows, int cols)
{
    T[,] matrix = new T[rows, cols];
    for (int row = 0; row < rows; row++)
    {
        T[] rowData = rowDataGetter();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowData[col];
        }
    }

    return matrix;
}

static void PrintMatrix<T>(T[,] matrix, Action<T> printer)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            printer(matrix[row, col]);
        }

        Console.WriteLine();
    }
}
