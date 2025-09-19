bool storyStart = true;
bool leftPath = false;
bool rightPath = false;
Console.WriteLine("Please write your name");
string playerName = Console.ReadLine();
Console.WriteLine("while hiking " + playerName + ", you stumble upon a cave, you try to shine");
Console.WriteLine("your flash light in the cave and nothing but darkness looks back.");
Console.WriteLine("you still decide to explore the cave as you walk the darkness");
Console.WriteLine("seems to subside. Once you can see fully you come across a fork");
Console.WriteLine("in the road, do you want to go left(1) or right(2).");
int playerChoice = int.Parse(Console.ReadLine());
if (storyStart)
{
    switch (playerChoice)
    {
        case 1:
            leftPath = true;
            break;
        case 2:
            rightPath = true;
            break;
        default:
            Console.WriteLine("unexpected response");
            break;
    }
    storyStart = false;
}
if (leftPath)
{
    Console.WriteLine("while going down the left path you stumble chest");
    Console.WriteLine("the path continues onward, so " + playerName + " do you");
    Console.WriteLine("examine the chest(1) or do you keep moving forward(2)");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            Console.WriteLine("As you force open the chest a foul stench comes out, when");
            Console.WriteLine("you can see the contents you realize " + playerName + " its a bunch of bones");
            Console.WriteLine("You see them and instantly run towards the way you came not wanting to");
            Console.WriteLine("find out who or WHAT put those there. You escape the cave and when you");
            Console.WriteLine("return with the police the cave is completely gone.");
            break;
        case 2:
            Console.WriteLine("you decide that you can look in the chest on your way out of the cave");
            Console.WriteLine("after 3 hours of walking you decide that's enough for you and turn around...");
            Console.WriteLine("you feel like you've been walking for days no sign of the exit or even the");
            Console.WriteLine("chest for that matter. You end up starving to death in this endless cave.");
            break;
        default:
            Console.WriteLine("unexpected response");
            break;
    }
}
if (rightPath)
{
    Console.WriteLine("while going down the right path you stumble broken cart");
    Console.WriteLine("the path continues onward, so " + playerName + " do you");
    Console.WriteLine("examine the broken cart(1) or do you keep moving forward(2)");
    playerChoice = int.Parse(Console.ReadLine());
    if (playerChoice == 1)
    {
        Console.WriteLine("as you shift pieces of broken wood around you find a bag of gold,");
        Console.WriteLine("you decide that taking this and leaving the cave is the best option");
        Console.WriteLine(playerName + ", you've escaped the cave!");
    }
    if (playerChoice == 2)
    {
        Console.WriteLine("you decide that you don't want to get down and dirty examining a cart, so you");
        Console.WriteLine("continue down the path and as you're distracted your attacked by a bear");
        Console.WriteLine("im sorry to say " + playerName + " but you end up dying from the attack");
    }
}