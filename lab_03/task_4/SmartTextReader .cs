class SmartTextReader : ITextReader
{
    public string[,] ReadText(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        int rows = lines.Length;
        int maxLength = lines.Max(line => line.Length);
        string[,] textMatrix = new string[rows, maxLength];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < lines[i].Length; j++)
            {
                textMatrix[i, j] = lines[i][j].ToString();
            }
        }

        return textMatrix;
    }
}