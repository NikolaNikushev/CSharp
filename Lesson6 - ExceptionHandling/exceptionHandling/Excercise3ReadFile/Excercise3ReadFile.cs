using System;
using System.IO;

class Excercise3ReadFile
{
    static void Main()
    {
        string input = Console.ReadLine();
        try
        {
            StreamReader read = new StreamReader(input);
            using (read)
            {
                string line = read.ReadLine();
                Console.WriteLine(line);
                while (line != null)
                {
                    line = read.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("You did not give a directory nor a file... ");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The directory/file does not match a standart directory/file input.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The given directory is not found.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The given file does not exist in the given directory!!");
        }
        catch (IOException)
        {
            Console.WriteLine("Error in the stream! File might be locked!");
        }
    }
}