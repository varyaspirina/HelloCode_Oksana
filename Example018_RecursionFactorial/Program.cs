// Напишем функцию для нахождения факториала с применением рекурсии

//Программа
for (int i = 1; i < 30; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}


// Метод
double Factorial(int n)
{
    if(n == 1) return 1;
    else return n*Factorial(n-1);
}

