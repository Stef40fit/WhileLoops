//Write a program to sum the digits of given number:

//· Read an integer positive number from the console

//· Sum its digits and print the sum

//Example: The number is 3451. Digits sum is 3 + 4 + 5 + 1 = 13.

int n = int.Parse(Console.ReadLine());
int sum= 0;
while (n > 0)
{
    int digit = n % 10;
    sum += digit;
    n /= 10;
}

Console.WriteLine(sum);

