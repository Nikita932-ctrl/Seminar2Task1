// нашите программу которая принимает на вход 3-х значное число и возвращает второй символ

int FindSecondNumber(int number)
{
    int max = 999;
    int min = 100;

    if (number > min && number <= max)
    {
        number = number % 100;
        number = number / 10;
    }
    else if (number >= max)
    {
        while(number > max)
        {          
            number--;           
        }
        number = number % 100;
        number = number / 10;
    }else if (number < min | number == 0)
    {
        while (number <= min | number == 0)
        {
            number++;
        }
        number = number % 100;
        number = number / 10;
    }
    return number;



}

Console.WriteLine(FindSecondNumber(999999));



