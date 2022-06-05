//Break
//for(int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}
////Console.WriteLine("----------------------------------");
////Continue
//for (int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}

//Break and Continue in While Loop

//Break
int i = 0;
while (i<10)
{
    Console.WriteLine(i);
    i++;
    if (i == 4)
    {
        break ;
    }
}
Console.WriteLine("----------------------------------");
//Continue 
int k = 0;
while (k<10)
{
    if (k == 4)
    {
        k++;
        continue ;
    }
    Console.WriteLine(k);
    k++;
}
