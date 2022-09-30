double FirstFriendSpeed = 1;
double SecondFriendSpeed = 4;
double DogSpeed = 3;
double Distance = 80000;

int count = 0;
int friend = 2;
double time = 0;

while (Distance > 10)
{
    if (friend == 1)
    {
        time = Distance / (FirstFriendSpeed + DogSpeed);
        friend = 2;
    }
    else
    {
        time = Distance / (SecondFriendSpeed + DogSpeed);
        friend = 1;
    }
    Distance = Distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
}

Console.WriteLine ("Колическо раз, что пробежала собака:");
Console.WriteLine (count);
