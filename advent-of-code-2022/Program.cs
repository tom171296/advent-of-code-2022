string[] fileData = File.ReadAllLines("2Dec/input.txt");

var result = RockPaperScissor.StageTwo(fileData);

Console.WriteLine(result);