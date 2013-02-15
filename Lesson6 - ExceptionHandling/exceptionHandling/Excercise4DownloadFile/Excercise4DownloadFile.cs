using System;
using System.IO;
using System.Net;

class Excercise4DownloadFile
{
    static void Main()
    {
        Console.WriteLine("Enter the URL that you wish to download.");
        Console.Write("URL: ");
        string url = Console.ReadLine();
        Console.WriteLine("Directory to download to:");
        string directory = Console.ReadLine();
        try
        {
            WebClient request = new WebClient();
            using (request)
            {
                request.DownloadFile(url, directory);
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The url does not exist or it was not entered.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid input data.");
        }
        catch (WebException)
        {
            Console.WriteLine("You do not have privileges to download / Problem with internet connection.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Error 404: File not found!");
        }
    }
}