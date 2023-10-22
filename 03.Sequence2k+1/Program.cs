
//Write a program to print a sequence of numbers:

//· The first number is 1

//· Each next number is 2 times the previous number + 1

//· Read an integer number n from the console – the max number

//· Print the elements of the sequence (starting with 1), which are ≤ n

int n = int.Parse(Console.ReadLine());
int i = 1;
while (i <= n)
{
    Console.WriteLine(i);
    i = (i * 2) + 1;
    
}

