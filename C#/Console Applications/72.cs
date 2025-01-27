using System;
        int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] b = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int i = 0, j = 0;

        System.Console.WriteLine();
        System.Console.WriteLine("A Matrix");
        System.Console.WriteLine("........");
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
                System.Console.Write("\t" + a[i, j]); 
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
        System.Console.WriteLine("B Matrix");
        System.Console.WriteLine("........");
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
                System.Console.Write("\t" + b[i, j]); 
            System.Console.WriteLine();
        }

        System.Console.WriteLine();
        System.Console.WriteLine("A + B Matrix");
        System.Console.WriteLine("........");
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
                System.Console.Write("\t" + (a[i, j] + b[i, j]));
            System.Console.WriteLine(); 
        }
