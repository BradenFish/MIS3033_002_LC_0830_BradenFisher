// MIS 3033 002
// August 30, 2023
// Braden Fisher

string str1; // complex
str1 = new string("MIS3033");
str1 = @"M\nIS\t3033"; // line 6 and 7 are the same
str1 = "MIS3033BradenFisher";

int l;
l = str1.Length;
Console.WriteLine(l);

Console.WriteLine(str1.ToLower());
Console.WriteLine(str1.Contains("MIS"));
