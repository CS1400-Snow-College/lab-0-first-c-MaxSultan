// See https://aka.ms/new-console-template for more information

// There are two similar methods, StartsWith and EndsWith that also search for substrings in a string. 
// These methods find a substring at the beginning or the end of the string. 
// Try to modify the previous sample to use StartsWith and EndsWith instead of Contains. 
// Search for "You" or "goodbye" at the beginning of a string. 
// Search for "hello" or "goodbye" at the end of a string
string songLyrics = "You say goodbye, and I say hello";

Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));
Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));
