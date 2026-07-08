using System.Data;

namespace DSA_VSCode._01_Basics
{
    public class Loops
    {
        /* Square star Pattern
        *****
        *****
        *****
        *****
        ***** */
        public static void SquarePattern()
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        /* Square Row Pattern
        1 1 1 1 1
        2 2 2 2 2
        3 3 3 3 3
        4 4 4 4 4
        5 5 5 5 5 */
        public static void SquareRowPattern()
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
        }
        /* Right Triangle Star Pattern
        * 
        * * 
        * * * 
        * * * * 
        * * * * *  */
        public static void RightTriangleStarPattern()
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
        /* Inverted Right Triangle
        * 
        * * 
        * * * 
        * * * * 
        * * * * *  */
        public static void InvertedRightTriangleStarPattern()
        {
            for (int row = 5; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        /* Pyramid Shape Pattern
            *
           ***
          *****
         *******
        ********* */
        public static void PyramidShapePattern()
        {
            for (int row = 1; row <= 5; row++)
            {
                // Loop for Spaces
                for (int space = 5; space > row; space--)
                {
                    Console.Write("  ");
                }
                for (int col = 1; col <= (row * 2) - 1; col++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

        }
        /* Diamond Star Pattern
            *
           ***
          *****
         *******
        *********
         *******
          *****
           ***
            * */
        public static void DiamondStarPattern()
        {
            //Upper Part
            for (int row = 1; row <= 5; row++)
            {
                for (int space = 5; space > row; space--)
                {
                    Console.Write("  ");

                }
                for (int col = 1; col <= (2 * row) - 1; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            // Lower Part
            for (int row = 4; row >= 1; row--)
            {

                for (int space = 1; space <= 5 - row; space++)
                {
                    Console.Write("  ");
                }
                for (int col = 1; col <= (2 * row) - 1; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

                /* for (int space = 1; space < 6 - row; space++)
                {
                    Console.Write("  ");
                }
                for (int col = 1; col <= 2 * (row - 1); col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(); */

            }

        }
        /* Left Triangle with spaces (right-aligned opposite)
            *
           **
          ***
         ****
        ***** */
        public static void LeftTriStarPattern()
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int space = 5; space > row; space--)
                {
                    Console.Write("  ");
                }
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
        /* inverted Left Triangle with spaces(right-aligned opposite)
        *****
         ****
          ***
           **
            * */
        public static void InvertedLeftTriStarPattern()
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int space = 1; space < row; space++)
                {
                    Console.Write("  ");
                }
                for (int col = 5; col >= row; col--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        /* Hollow Square Pattern
        ***
        * *
        *** */
        public static void HollowSquarePattern()
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 5; col++)
                    if (row == 1 || row == 5 || col == 1 || col == 5)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                Console.WriteLine();
            }

        }
        /* Hollow Right Triangle pattern
        *
        **
        ** *
        **** */
        public static void HollowRightTriPattern()
        {
            for (int row = 1; row <= 10; row++)
            {
                for (int col = 1; col <= 10; col++)
                {
                    if (row == 10 || col == 1 || row == col)
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
    }
}