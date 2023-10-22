//Write a program that:

//· Reads an integer number N

//· Print the numbers from N down to 1 (inclusively), each on separate line

//Note: N will always be bigger than 1.

int n = int.Parse(Console.ReadLine());
int i = 1;
while (n>= i)
{
    Console.WriteLine(n);
    n--;
}
