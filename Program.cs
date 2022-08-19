using System.Collections.Generic;
using System;


{
    Console.WriteLine("Ask a question and your fortune will be revealed");
    Console.WriteLine("------------------------------------------------");
};


List<string> response = new List<string>()
{
"As I see it, yes.",
"Ask again later.",
"Better not tell you now.",
"Cannot predict now.",
"Concentrate and ask again.",
"Don’t count on it.",
"It is certain.",
"It is decidedly so.",
"Most likely.",
"My reply is no.",
"My sources say no.",
"Outlook not so good.",
"Outlook good.",
"Reply hazy, try again.",
"Signs point to yes.",
"Very doubtful.",
"Without a doubt.",
"Yes.",
"Yes – definitely.",
"You may re;ly on it.",
};


while (true)
{
    Random NUM = new Random();
    int newNum = NUM.Next(0, 21);
    string userInput = Console.ReadLine();
    // Console.WriteLine($"Random Number = {NUM.Next(0,21)}");
    Console.WriteLine($"Your answer: {response[newNum]}");
}


