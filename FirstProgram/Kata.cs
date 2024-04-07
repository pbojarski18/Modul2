using System;
public static class Kata
{
    public static string AddBinary(int a, int b)
    {
        string binary = "";
        var result = a + b;
        while (result >= 1)
        {
            if (result % 2 == 0)
            {
                binary = binary + "0";
            }
            else
            {
                binary = binary + "1";
            }
            result = result / 2;
        }
        return new string(binary.Reverse().ToArray());

    }
}
