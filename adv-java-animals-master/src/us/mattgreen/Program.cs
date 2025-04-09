

using System;
using System.Collections.Generic;

namespace AnimalsApp
{

 class Program {

    private static readonly FileOutput outFile = new FileOutput("animals.txt");
    private static readonly FileInput inFile = new FileInput("animals.txt");

    public static void Main(String[] args) {
        List<Talkable> zoo = new List<Talkable>();

        // Lines to Replace Begin Here
        zoo.Add(new Dog(true, "Bean"));
        zoo.Add(new Cat(9, "Charlie"));
        zoo.Add(new Teacher(44, "Stacy Read"));
        // End Lines to Replace

        // Convert Java code to C# was not able to get to step 3 in the assignment

        foreach (Talkable thing in zoo) {
            Console.WriteLine(thing);
        }
        outFile.Close();
        inFile.Read();
        inFile.Close();

        FileInput indata = new FileInput("animals.txt");
        string line;
        while ((line = indata.ReadLine()) != null) {
            Console.WriteLine(line);
        }
    }

    public static void printOut(Talkable p) {
         Console.WriteLine($"{p.GetName()} says={p.Talk()}");
    outFile.Write($"{p.GetName()} | {p.Talk()}");

    }
}

}