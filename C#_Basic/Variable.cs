using System;

class Litera
{
    static void Main()
    {
        Console.WriteLine(1234);
        Console.WriteLine(3.14F);
        Console.WriteLine('A');
        Console.WriteLine("HELLO");

        int i;
        i = 1234;
        Console.WriteLine(i);

        int number = 7;
        Console.WriteLine("{0}", number);

        int number1, number2, number3;

        number1 = 1;
        number2 = 2;
        number3 = 3;

        Console.WriteLine("{0}, {1}, {2}", number1, number2, number3);

        int a, b, c;
        a = b = c = 10;

        Console.WriteLine("{0}, {1}, {2}", a, b, c);

        sbyte iSbyte = 127;
        short iInt16 = 32767;
        int iInt32 = 2147483647;
        long iInt64 = 9223372036854775807;

        Console.WriteLine("8비트 sbyte : {0}", iSbyte);
        Console.WriteLine("16비트 short : {0}", iInt16);
        Console.WriteLine("32비트 int : {0}", iInt32);
        Console.WriteLine("64비트 long : {0}", iInt64);

        double PI = 3.141592; // 실수 데이터
        Console.WriteLine("{0}", PI);

        double min = Double.MinValue;
        double max = Double.MaxValue;

        Console.WriteLine(min);
        Console.WriteLine("{0}", max);

    }
}