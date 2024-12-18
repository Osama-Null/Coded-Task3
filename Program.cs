using System.ComponentModel.Design;

Console.Write("Enter your weight: "); double weight = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter your height: "); double height = Convert.ToDouble(Console.ReadLine()) / 100;
Console.Write("Enter your age: "); int age = Convert.ToInt16(Console.ReadLine());

double BMI = (weight / (Math.Pow(height, 2)));

//__________________________________________________
//string BMIState;

//if (BMI < 18.5 && BMI >= 0)
//{
//    BMIState = "underweight";
//}
//else if (BMI >= 18.5 && BMI <= 24.9)
//{
//    BMIState = "healthy";
//}
//else if (BMI >= 25.0 && BMI <= 29.9)
//{
//    BMIState = "overweight";
//}
//else if (BMI >= 30)
//{
//    BMIState = "obese";
//}

//__________________________________________________
string BMIState;

if (age >= 19 && age <= 24 && BMI >= 19 && BMI <= 24)
{
    BMIState = "You are healthy";
    Console.WriteLine(BMIState);
}
else if (age >= 19 && age <= 24 && BMI < 19 && BMI > 24)
{
    BMIState = "You are not healthy";
    Console.WriteLine(BMIState);
}
else if (age >= 25 && age <= 34 && BMI >= 20 && BMI <= 25)
{
    BMIState = "You are healthy";
    Console.WriteLine(BMIState);
}
else if (age >= 25 && age <= 34 && BMI < 20 && BMI > 25)
{
    BMIState = "You are not healthy";
    Console.WriteLine(BMIState);
}
else if (age >= 35 && age <= 44 && BMI >= 21 && BMI <= 26)
{
    BMIState = "You are healthy";
    Console.WriteLine(BMIState);
}
else if (age >= 35 && age <= 44 && BMI < 21 && BMI > 26)
{
    BMIState = "You are not healthy";
    Console.WriteLine(BMIState);
}
else if (age >= 45 && age <= 54 && BMI >= 22 && BMI <= 27)
{
    BMIState = "You are healthy";
    Console.WriteLine(BMIState);
}
else if (age >= 45 && age <= 54 && BMI < 22 && BMI > 27)
{
    BMIState = "You are not healthy";
    Console.WriteLine(BMIState);
}
else if (age >= 55 && age <= 64 && BMI >= 23 && BMI <= 28)
{
    BMIState = "You are healthy";
    Console.WriteLine(BMIState);
}
else if (age >= 55 && age <= 64 && BMI < 23 && BMI > 28)
{
    BMIState = "You are not healthy";
    Console.WriteLine(BMIState);
}
else if (age >= 64 && BMI >= 24 && BMI <= 29)
{
    BMIState = "You are healthy";
    Console.WriteLine(BMIState);
}
else if (age >= 64 && BMI < 24 && BMI > 29)
{
    BMIState = "You are not healthy";
    Console.WriteLine(BMIState);
}

else
{
    BMIState = "Chill bro!";
    Console.WriteLine(BMIState);
}


