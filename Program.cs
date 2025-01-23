while(true)
{
    Console.WriteLine("Hello, choose a number to see a figure:\n");
    Console.WriteLine($"1) - Right-angled Triangle \n2) - Square \n3) - Diamond \n4) - Left-angled Triangle \n5) - Hollow Square \n6) - Pyramid \n7) - Reverse Pyramid \n8) - Rectangle with Hollow Center\n");

    int number = int.Parse(Console.ReadLine());

    int rows = 0;
    int width = 0;
    int height = 0;

    while (number <= 0 || number >= 9)
    {
        Console.WriteLine("\nInvalid input. \nTry again.\n");
        number = int.Parse(Console.ReadLine());
    }

    if (number >= 1 && number <= 7)
    {
        Console.WriteLine("\nChoose the number of rows of the shape: \n");

        rows = int.Parse(Console.ReadLine());

        while (rows <= 0)
        {
            Console.WriteLine("\nInvalid size. \nTry again. \n");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
    }
    else if (number == 8)
    {
        Console.WriteLine("\nChoose the width and the height of the shape: \n");

        width = int.Parse(Console.ReadLine());
        height = int.Parse(Console.ReadLine());

        while (height <= 0 || width <= 0)
        {
            Console.WriteLine("\nInvalid size. \nTry again. \n");
            width = int.Parse(Console.ReadLine());
            height = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
    }
    Console.WriteLine();

    double ceiling3 = Math.Ceiling(rows / 2.0);
    double floor3 = ceiling3 - 1;
    int count3a = (int)ceiling3 - 1;
    int count3b = 1;
    int count3c = 1;
    int count3d = (int)floor3 * 2 - 1;
    int count6 = 1;
    int count7 = 0;
    int num7 = rows;

    if (number == 1)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else if (number == 2)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else if (number == 3)
    {
        for (int i = 1; i <= ceiling3; i++)
        {
            for (int k = 1; k <= count3a; k++)
            {
                Console.Write(" ");
            }
            for (int r = 1; r <= count3b; r++)
            {
                Console.Write("*");
            }
            for (int d = 1; d <= count3a; d++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            count3a--;
            count3b += 2;
        }
        for (int j = 1; j <= floor3; j++)
        {
            for (int w = 1; w <= count3c; w++)
            {
                Console.Write(" ");
            }
            for (int p = 1; p <= count3d; p++)
            {
                Console.Write("*");
            }
            for (int e = 1; e <= count3c; e++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            count3c++;
            count3d -= 2;
        }
    }
    else if (number == 4)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = rows; j >= i; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else if (number == 5)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows; j++)
            {
                if (i == 1 || i == rows)
                {
                    Console.Write("*");
                }
                else if (j == 1 || j == rows)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    else if (number == 6)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= (rows - i); j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= count6; k++)
            {
                Console.Write("*");
            }
            for (int j = 1; j <= (rows - i); j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            count6 += 2;
        }
    }
    else if (number == 7)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int l = 1; l <= count7; l++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= (num7 * 2 - 1); k++)
            {
                Console.Write("*");
            }
            for (int j = 1; j <= count7; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            count7++;
            num7--;
        }
    }
    else if (number == 8)
    {
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= width; j++)
            {
                if (i == 1 || i == height)
                {
                    Console.Write("*");
                }
                else if (j == 1 || j == width)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    Console.WriteLine("\nDo you want to restart the programm? \nAnswer with (y/n).\n");
    string choice = Console.ReadLine();

    while (choice != "n" && choice != "y")
    {
        Console.WriteLine("\nInvalid choice. \nAnswer with (y/n).\n");
        choice = Console.ReadLine();
    }

    if (choice.ToLower() == "n")
    {
        break;
    }
    Console.WriteLine();
}

Console.WriteLine("\nThanks for your participation!");