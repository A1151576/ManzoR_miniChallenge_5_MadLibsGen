// Rafael Manzo 
// 10/20/2022
// Mini challenge 5
// Mad libs generator.

Console.Clear();

Console.WriteLine("I have a story to tell but i need your help!");
Console.WriteLine("I'll need some information for this story starting with a place. use your imagination!");
string piece01 = Console.ReadLine();

Console.WriteLine("-----------------------------");

Console.WriteLine("Nice, now i need a noun.");
string piece02 = Console.ReadLine();

Console.WriteLine("-----------------------------");


Console.WriteLine("Ok, now use an adjective to describe yourself.");
string piece03 = Console.ReadLine();

Console.WriteLine("-----------------------------");


Console.WriteLine("Now give me the name of a person you really like.");
string piece04 = Console.ReadLine();

Console.WriteLine("-----------------------------");


Console.WriteLine( "Great! now tell me your favorite drink");
string piece05 = Console.ReadLine();

Console.WriteLine("-----------------------------");


Console.WriteLine("Enter another adjective.");
string piece06= Console.ReadLine();

Console.WriteLine("-----------------------------");


Console.WriteLine("Alright, enter a ploural noun.");
string piece07=Console.ReadLine();

Console.WriteLine("-----------------------------");


Console.WriteLine("Now i need a verb.");
string piece08=Console.ReadLine();

Console.WriteLine("-----------------------------");


Console.WriteLine("Something you'd like to see.");
string piece09=Console.ReadLine();

Console.WriteLine("-----------------------------");


Console.WriteLine("Who is your favorite celebrity?");
string piece10=Console.ReadLine();

Console.WriteLine("-----------------------------");


Console.WriteLine("I went to the " + piece01 );
Console.WriteLine("I wanted to buy some " + piece02 );
Console.WriteLine("So that i could look "  + piece03 + " at the party");
Console.WriteLine( piece04 +  " went to the party with me" );
Console.WriteLine ( piece05 +  " was our choice of drink.");
Console.WriteLine ( "I danced all night like " + piece06);
Console.WriteLine ( "I saw a lot of " + piece07 +" while i danced.");
Console.WriteLine ( "I " + piece08 + " home by myself after the party.");
Console.WriteLine ( "I walked by " + piece09 + " as i went home.");
Console.WriteLine ( "When i got home " + piece10 + " was waiting for me." );

Console.WriteLine("-----------------------------");

