using System;

public class Class1
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter range for sequence: ");
        string rang = Console.ReadLine();
        sequence(Convert.ToInt32(rang));


        Console.WriteLine("Enter range in which you would like to find the self dividing numbers:");
        Console.Write("Enter Lower Range: "); string z1 = Console.ReadLine();
        Console.Write("Enter Upper Range: "); string z2 = Console.ReadLine();
        isSelfDividing(Convert.ToInt32(z1), Convert.ToInt32(z2));

        Console.WriteLine();
        Console.WriteLine("Enter length of triangle:");
        string num = Console.ReadLine();
        triangle(Convert.ToInt32(num));

       /*______________Q5_____________*/
        Console.Write("Array J[] method: ");
        
        string i4 = Console.ReadLine();
       
        int in4 = int.Parse(i4);

        Console.Write("Array S[] method:: ");
        
        string i5 = Console.ReadLine();
       
        int in5 = int.Parse(i5);

        int[] X = new int[in4];
        int[] Y = new int[in5];
        int X_lenght = in4;
        int Y_lenght = in5;

        input_array(X, Y, X_lenght, Y_lenght);
        LCsubstr(X, Y);
        /*_____________________________*/


        Console.Write("Please enter how many types of Jeweles in Array J[] numJewelsInStones method: ");
        // This variable will gather data from user input
        string input4 = Console.ReadLine();
        // This variable will be used to perform some iterations and is parsed as an integer
        int input_value4 = int.Parse(input4);
        Console.Write("Please enter how many types of Stones you have in Array S[] numJewelsInStones method:: ");
        // This variable will gather data from user input
        string input5 = Console.ReadLine();
        // This variable will be used to perform some iterations and is parsed as an integer
        int input_value5 = int.Parse(input5);

        int[] J = new int[input_value4];
        int[] S = new int[input_value5];
        int J_lenght = input_value4;
        int S_lenght = input_value5;

        input_array(J, S, J_lenght, S_lenght);
        int r4 = numJewelsInStones(J, S, J_lenght, S_lenght);
        Console.WriteLine(r4);
        Console.Write("\n");


    }



    //SEQUENCE: QUESTION 2
    public static void sequence(int rang)
    {
        int count = 0;
        for (int i = 1; i < rang; i++)
        {

            for (int j = 0; j < i && count != rang; j++)
            {
                Console.Write(i);
                count++;
            }

        }
    }

    //SELF DIVIDING NUMBERS: QUESTION 1
    public static void isSelfDividing(int x, int y)
    {
        int rem = 0;
        //Iterate through the numbers between x and y
        for (int i = x; i <= y; i++)
        {
            //num will be used to input the self-dividing numbers
            int num = i;
            //div will be used to get every digit a number
            int div = i;
            //Print all the self.-dividing numbers using While loop
            while (div != 0)
            {
                //After dividing by 10, get every digit by taking the remainder, for example: 128%10->8
                rem = div % 10;
                //Remove the  multiple of 10
                if (rem == 0)
                    break;
                //Remove the number that cannot be divisible by digit it contains
                if (num % rem != 0)
                    break;
                //For example: 128/10->12; 12->1
                div = div / 10;
                //Input the self-dividing numbers
                if (div == 0)
                    Console.Write(" " + num);
            }

        }
    }

    //QUESTION 3: TRIANGLE
    public static void triangle(int num)
    {
        try
        {
            

            int line, counter;
            int loop_counter = num;

            for (line = 1; line <= loop_counter; line++)
            {
                
                for (counter = 1; counter <= line; counter++)
                {
                    Console.Write(" ");
                }
                
                for (int n = line; n <= loop_counter; n++)
                {
                    Console.Write("* ");
                    
                }
                Console.Write("\n");

                
                Console.WriteLine("\n");
            }
        }
        catch
        {
            Console.WriteLine("Exception occured while computing printTriangle()");
        }
    }
    //QUESTION 5: SUBARRAY
    public static void LCsubstr(int[] x, int[] y)                                           /*Longest Common Substring.      */
    {
        for (int i = 0; i < x.Length; i++)
        {
           
            for (int j = i; j < x.Length; j++)
            {
                
                for (int k = i; k <= j; k++)
                {
                    Console.WriteLine(x[k]);
                }
                Console.WriteLine();
            }
        }                                                                        /*$  is "" if no common string.  */
    }

    //QUESTION 4: JEWELS AND STONES
    public static void input_array(int[] J, int[] S, int J_lenght, int S_lenght)
    {
        //This loop is to read the Jewel array from console
        Console.Write("Please enter elements of Jewel array J: ");
        for (int i = 0; i < J_lenght; i++)
        {
            J[i] = int.Parse(Console.ReadLine());
        }
        //This loop is to read the Stone array from console
        Console.Write("Please enter elements of Stone array S: ");
        for (int i = 0; i < S_lenght; i++)
        {
            S[i] = int.Parse(Console.ReadLine());
        }
        Console.Read();
    }
    public static int numJewelsInStones(int[] J, int[] S, int J_lenght, int S_lenght)
    {
        try
        {
            //write your code here
            int[] J_array = J;
            int[] S_array = S;
            //this count variable is used to take number of elements common in Stones from Jewel
            int count = 0;
            //outer for loop is used to read Jewel array
            for (int i = 0; i < J_lenght; i++)
            {
                //this inner for loop is used to read Stones array
                for (int j = 0; j < S_lenght; j++)
                {
                    //this condition checks the common elements present in array Jewel and Stone
                    if (J_array[i] == S_array[j])
                    {
                        count++;
                    }
                    else
                    {
                        // count = 0;
                        break;
                    }
                }
            }
            if (count != 0)
            {
                
                Console.Write("Number of you Stones that are Jewels too: ", count);
                return count;
            }
            else
            {
                Console.Write("You don't have any Stones that are Jewels too:");
            }
        }
        catch
        {
            Console.WriteLine("Exception occured while computing numJewelsInStones()");
        }
        return 0;
    }

}