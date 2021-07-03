using System;

using SockPairs;
//Create a variable of type Sock and enter the information
Sock sockPair = new Sock {sock = 1,sock2 = 2, sock3 = 3, sock4 = 2, sock5 = 0, sock6 = 3, sock7 = 2};
//Display the information
sockPair.displayPair();

Console.WriteLine("Pairs: {0}",sockPair.pairs);