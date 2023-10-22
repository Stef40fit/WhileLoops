//Write a program to read a number in the range [1 … 100]:

//· Read an integer number from the console

//· Check if the number is in the range [1 … 100]

//o No(number is NOT in the range) à read a new number

//o Yes(number is IN the range) à print the number and the program stops

int n = int.Parse(Console.ReadLine());

while (n < 1 || n > 100)
{
    n = int.Parse(Console.ReadLine()); 
    
}

Console.WriteLine(n);