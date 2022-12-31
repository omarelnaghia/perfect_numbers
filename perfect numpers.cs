using System;
public class perfect
{
    public static void Main()
    {
        int n, i, sum;
        int fristnumber, end_number;

        Console.WriteLine("find perfect numbers\n");
        Console.WriteLine("_____");
        Console.WriteLine(" enter the frist number: ");
        fristnumber = int.Parse(Console.ReadLine());

        Console.Write("enter the end number : ");
        end_number = int.Parse(Console.ReadLine());

        Console.WriteLine("perfect number betwen {0} and {1}", fristnumber, lastnumber);


        for (n = frist_number; n <= end_number; n++)
        {
            i = 1;
            sum = 0;
            while (i < n)
            {
                if (n % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == n&&sum!=0)
            {
                Console.WriteLine(" the perfect numbers : " + n);

            }


        }
        Console.ReadKey();

    }
}