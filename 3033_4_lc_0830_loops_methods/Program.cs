// Tre Gonzales 113450167
// August 30 2022 MIS 3033 004 Lecture Codes
// Loops and Methods


// Loops:
// - For Loop:
// 0 is the initialization. Initialization is only executed once
// 1 is the condition, resulting in true or false.if true, 3 is executed, if false then the loop stops.
// 2 is post processing.
// 3 is the loop body.

//for(0 ;1 ;2 )      
//{
//    3
//}
// 0->1->3->2->1->3->2...


//for (int = 10; i <= 20;i++)
//{
//    Console.WriteLine(i);
//}

//int i = 15;
//for (;i <= 20 ;)
//{
//    Console.WriteLine(i);
//    i++;      (i++ = i + 1)
//}

using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

Console.WriteLine("For loop results:");
int i = 9;
for (; ;)
{
    i++;
    if (i > 20)
    {
        break;
    }

    if(i == 13 || i == 17)
    {
        continue;
    }

    Console.WriteLine(i);
}
    // While Loop:
Console.WriteLine("\nWhile Loop Results:");

//while (2)
//{
//    3
//}

// 2->3->2->3->...
i = 9;
while (i<20)
{
    i++;
    if (i == 13 || i == 17)
    {
        continue;
    }
    Console.WriteLine(i);
}

    // Do While Loop:
Console.WriteLine("\nDo While loop results");

//do{3}while(2);

i = 9;
do
{
    i++;
    if (i == 11 || i == 13)
    {
        continue;
    }
    Console.WriteLine(i);
}
while (i<=20);

//Methods & Functions
//DataType1 functions_name(DataType var1, DataType var2,...)
//{
//     .....
//    return product;
//}
Console.WriteLine("\nFunctions/Methods resuls");

double testN = 10.2;
double product = _getLargerDblVal(testN, 1.1);
Console.WriteLine(product);




Console.ReadLine();

double _getLargerDblVal(double dbl1, double dbl2)
{
    double product;
    if (dbl1 > dbl2)
    {
        product = dbl1;
    }
    else
    {
        product = dbl2;
    }

    return product;
}
