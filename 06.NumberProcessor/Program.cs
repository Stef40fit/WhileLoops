//Write a program to process a sequence of commands:

//· Read an initial number from the input

//· Read an execute a sequence of the following commands:

//o "Inc" – add 1 to the number (increment)

//o "Dec" – subtract 1 from the number (decrement)

//o "End" – print the number and stop the program

int n = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

while (command != "End")
{
    if(command == "Inc")
    {
        n += 1;
        command = Console.ReadLine();
    }
    else if (command == "Dec")
    {
        n -= 1;
        command = Console.ReadLine();
    }
}

Console.WriteLine(n);
