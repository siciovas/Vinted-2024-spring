using VintedBackendAssignment;

var lines = FileService.ReadLinesFromFile();

foreach (var line in lines)
{
    var parsedLines = FileService.ParseLines(line);

    if (parsedLines != null)
    {
        Console.WriteLine(parsedLines.FormatLines());
    }
}

