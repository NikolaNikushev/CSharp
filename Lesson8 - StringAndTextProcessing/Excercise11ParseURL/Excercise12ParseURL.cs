using System;

class Excercise12ParseURL
{
    static void Main()
    {
        Console.WriteLine("Input URL: ");
        string input = Console.ReadLine();
        string protocol="", server="", resource="";
        protocol=input.Substring(0,input.IndexOf("://"));
        server = input.Substring(input.IndexOf("://")+3, input.Length - 3 - protocol.Length);
        server=server.Substring(0,server.IndexOf('/'));
        resource = input.Substring(input.IndexOf("://") + 3, input.Length - 3 - protocol.Length);
        resource = resource.Substring(resource.IndexOf('/'), input.Length - 3 - protocol.Length - server.Length);
        Console.WriteLine("[protocol] = \"{0}\"", protocol);
        Console.WriteLine("[server]   = \"{0}\"", server);
        Console.WriteLine("[resource] = \"{0}\"", resource);
    }
}
