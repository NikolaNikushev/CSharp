using System;

    class Excercise14Dictionary
    {
        const int n = 4;
        static void Main()
        {
            string[,] dictinary = new string[n, 2];

            dictinary[0, 0] = ".NET";
            dictinary[0, 1] = "platform for applications from Microsoft";
            dictinary[1, 0] = "CLR"; 
            dictinary[1, 1] = "managed execution environment for .NET";
            dictinary[2, 0] = "C#";
            dictinary[2, 1] = " (pronounced see sharp) is a multi-paradigm programming language encompassing strong typing, imperative, declarative, functional, generic, object-oriented (class-based), and component-oriented programming disciplines developred by Microsoft. We use it.";
            dictinary[3, 0] = "namespace";
            dictinary[3, 1] = "hierarchical organization of classes";
          
            string input;
            Console.Write("Enter word: ");
            input = Console.ReadLine();
            for (int i = 0; i <= n - 1; i++)
            {
                if (input == dictinary[i,0])
                {
                    Console.WriteLine("{0} - {1}", dictinary[i,0],dictinary[i,1]);
                }
            }
      }
}
