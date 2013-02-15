using System;
using System.Text;

namespace Excercise7EncodeDecode
{
    class Excercise7EncodeDecode
    {
        
        static void Main()
        {
            Console.WriteLine("Enter your massage:");
            string message = Console.ReadLine();
            Console.Write("Enter you key: ");
            string key = Console.ReadLine();

            StringBuilder encryptedMessage = new StringBuilder(message.Length);

            for (int i = 0; i < message.Length; i++)
            encryptedMessage.Append((char)(message[i] ^ key[i % key.Length]));
            Console.WriteLine("Codet it looks like: ");
            Console.WriteLine(encryptedMessage);
            StringBuilder decriptedMessage = new StringBuilder(message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                decriptedMessage.Append((char)(encryptedMessage[i] ^ key[i % key.Length]));
            }
            Console.WriteLine("Decoded it looks like: ");
            Console.WriteLine(decriptedMessage);
            
        }
    }
}