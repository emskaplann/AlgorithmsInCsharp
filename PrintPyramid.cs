using System;
using System.Text;

class Program {
  public static void Main (string[] args)
  {
    PrintPyramid(9);
  }

  public static void PrintPyramid(int level)
  {
    // Write your code here...
    var stringBuilder = new StringBuilder();
    var levelIndicator = 1;

    // we need to start with level - 1 space before printing first layer
    for (var x = level; x > 0; x--)
    {
        var levelSpace = x - 1;
        var maxLevelWidth = (level * 2) - 1;

        for (var i = 0; i < levelSpace; i++)
        {
          stringBuilder.Append(' ');
        }

        for (var i = 0; i < maxLevelWidth - (levelSpace * 2); i++)
        {
          stringBuilder.Append(levelIndicator.ToString());
        }
      
        for (var i = 0; i < levelSpace; i++)
        {
          stringBuilder.Append(' ');
        }

        stringBuilder.Append('\n');
        levelIndicator++;
    }

    Console.WriteLine(stringBuilder.ToString());
  }
}


// input: 1
// output: #

// input: 3
// output: #
//        ###
//       #####

// input: 6
// output: #
//        ###
//       #####
//      #######
//     #########
//    ###########
