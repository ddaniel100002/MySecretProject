using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecretProject.Utilities;

internal class FlitzaGenerator
{
    
    public static void Generate()
    {
        int randomFlitzasCounter = Random.Shared.Next(1, 21);

        for (int i = 0; i < randomFlitzasCounter; i++) 
        {
            Console.WriteLine("Flitza");
        }

        Console.WriteLine($"\n\nFlitza has been generated {randomFlitzasCounter} times!");
    }
}
