public class RockPaperScissor{


    public static int StageOne(string[] input)
    {
        var shapesScores = new Dictionary<string, int>()
        {
            {"X", 1},
            {"Y", 2},
            {"Z", 3}
        }; 

        var drawMapping = new Dictionary<string, string>()
        {
            {"A", "X"},
            {"B", "Y"},
            {"C", "Z"}
        }; 

        var winningMapping = new Dictionary<string, string>()
        {
            {"A", "Y"},
            {"B", "Z"},
            {"C", "X"}
        };

        var myScore = 0;

        foreach (var match in input)
        {
            var splittedMatch = match.Split(" ");

            if (winningMapping[splittedMatch[0]] == splittedMatch[1])
            {
                Console.WriteLine($"won with:{splittedMatch[1]} Score added: {6+shapesScores[splittedMatch[1]]}");

                myScore+= (6+shapesScores[splittedMatch[1]]);
            }
            else if (drawMapping[splittedMatch[0]] == splittedMatch[1])
            {
                Console.WriteLine($"Draw with:{splittedMatch[1]} Score added: 3");
                myScore+=3+shapesScores[splittedMatch[1]];
            }
            else 
            {
                Console.WriteLine($"Lost with:{splittedMatch[1]} Score added: {shapesScores[splittedMatch[1]]}");
                myScore+=shapesScores[splittedMatch[1]];
            }
        }

        return myScore;
    }   

    public static int StageTwo(string[] input)
    {
        var shapesScores = new Dictionary<string, int>()
        {
            {"X", 1},
            {"Y", 2},
            {"Z", 3}
        }; 

        var drawMapping = new Dictionary<string, string>()
        {
            {"A", "X"},
            {"B", "Y"},
            {"C", "Z"}
        }; 

        var winningMapping = new Dictionary<string, string>()
        {
            {"A", "Y"},
            {"B", "Z"},
            {"C", "X"}
        };

        var loseMapping = new Dictionary<string, string>()
        {
            {"A", "Z"},
            {"B", "X"},
            {"C", "Y"}
        };

        var myScore = 0;

        foreach (var match in input)
        {
            var splittedMatch = match.Split(" ");

            if (splittedMatch[1] == "Y")
            {
                // draw
                Console.WriteLine($"Draw with:{splittedMatch[1]} Score added: 3");
                myScore+=3+shapesScores[drawMapping[splittedMatch[0]]];
                
            } 
            else if (splittedMatch[1] == "X")
            {
                // lose
                Console.WriteLine($"Lost with:{splittedMatch[1]} Score added: {shapesScores[splittedMatch[1]]}");
                myScore+=shapesScores[loseMapping[splittedMatch[0]]];

            } 
            else 
            {
                // win
                Console.WriteLine($"won with:{splittedMatch[1]} Score added: {6+shapesScores[splittedMatch[1]]}");

                myScore+= (6+shapesScores[winningMapping[splittedMatch[0]]]);
            }
        }

        return myScore;
    }   
}

