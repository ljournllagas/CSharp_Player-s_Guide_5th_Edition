Console.WriteLine("What kind of thing are we talking about?");
string thing = Console.ReadLine(); //stores the thing that you're talking about
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string describe = Console.ReadLine(); /* 
                                * describe what it is
                                */
string doom = "Doom"; 
string three_thousand = "3000";
Console.WriteLine("The " + describe + " " + thing + " of " + doom + " " + three_thousand + "!");
Console.ReadLine();