using System;

class Excercise1DescribeStrings
{
    static void Main()
    {
        Console.WriteLine(
@"In C#, the string keyword is an alias for String.
Therefore, String and string are equivalent, and you can use whichever naming
convention you prefer.
The String class provides many methods for safely creating, manipulating, 
and comparing strings. In addition, the C# language overloads some operators
to simplify common string operations.");
     Console.WriteLine(
@"
Important methods are:

Clone - returns a reference to this instance of String

Compare - compares two specified String objects and returns
an integer that indicates their relative position in the sort order.

CompareTo - compares the string to a specified String/Object and
indicates whether this instance precedes, follows, or appears in
the same position in the sort order as the specified Object/String.

Copy - creates a new instance of the String with the same value as a
specified String

Equals(Object)/(String) - Determines whether this instance and a specified 
object, which must alsobe a String object or the specified string, have
the same value.

Format - Replaces one or more format items in a specified string with the 
string representation of a specified object.

IndexOf - Reports the zero-based index of the first occurrence of the specified string in this instance.");

    }
}

