using System;
// program is located in folder numeralSystems -> adding numeral system to the class name would make it
// have way too many recursions
class Excercise7AnySystemToAnySystem
{
    static void Main()
    {
        string[] letter = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        int s = 0, d = 0;
        int decimalResult = 0;
        string result = "";
        int takenActions = 0;
        Console.WriteLine("Enter numeral system base:  [from 2 to 16]");
        Console.Write("From which numeral system do you want to enter: ");
        do
        {
            s = int.Parse(Console.ReadLine());
        } while (s < 2 || s > 16);
        Console.Write("To which numeral system do you want to convert: ");
        do
        {
            d = int.Parse(Console.ReadLine());
        } while (d < 2 || d > 16);

line32:

        Console.Write("Number = ");
        string number = Console.ReadLine();
        // convert number to UPPER case and reverse it
        number = number.ToUpper();
        number = Functions.Functions.Reverse(number);
        // end of input data
        if (d == s)
        {
            Console.WriteLine(number);
        }
        else
        {
            int counter = 0;
            // convert to decimal base
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < letter.Length; j++)
                {
                    if (Convert.ToString(number[i]) == letter[j])
                    {
                        decimalResult += j * (int)Math.Pow(s, i);
                        takenActions++;
                        break;
                    }
                }
            }
            // check if all symbols in the input number are valid
            if (takenActions != number.Length)
            {
                Console.WriteLine("You have inputed an invalid number.");
                goto line32;
            }
            else
            {
                // convert to new base
                while (decimalResult > 0)
                {
                    result += letter[decimalResult % d];
                    counter++;
                    if (counter % 4 == 0 && d==2) result += " ";
                    decimalResult /= d;
                }
                Console.WriteLine("Representation of your number = {0}", Functions.Functions.Reverse(result));
            }
        }
    }
}