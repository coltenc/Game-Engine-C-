using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Game_Engine
{
    internal class Inputs
    {
        public static int x = 0;
        public static int y = 0;
        public static int z = 0;

        public static void KeyPressed()
        { 
            ConsoleKeyInfo input = Console.ReadKey(intercept: true);

            //Movement w,a,s,d, jumping, and crouching(to be added).
            if (input.Key == ConsoleKey.W)
            {
                Console.WriteLine("Forward");
                x = 1;
                vectors();
            }

            if (input.Key == ConsoleKey.S)
            {
                Console.WriteLine("Back");
                x = -1;
                vectors();
            }

            if (input.Key == ConsoleKey.A)
            {
                Console.WriteLine("Left");
                y = -1;
                vectors();
            }

            if (input.Key == ConsoleKey.D)
            {
                Console.WriteLine("Right");
                y = 1;
                vectors();
            }


            if (input.Key == ConsoleKey.Spacebar)
            {
                vectors();
                Console.WriteLine("Jump!");

                if (Program.is2D)
                {
                    Console.WriteLine("No input");
                }
                else
                {
                    z++;
                    vectors();
                }
            }


            //stop game
            if (input.Key == ConsoleKey.Escape)
            {
                Program.outputPages = 2;
            }



            //numbers
            if(input.Key == ConsoleKey.D1)
            {
                if (Program.outputPages < 3)
                {
                    Program.outputPages = 3;
                }
                else
                {
                    Console.WriteLine("Play");
                    KeyPressed();
                }
            }

            if (input.Key == ConsoleKey.D2)
            {
                switch (Program.outputPages)
                {
                    case 1:
                        Program.outputPages = 1;
                        break;

                    case 2:
                        Program.outputPages = 2;
                        break;

                    case 3:
                        if (Program.is2D == true)
                        {
                            Program.is2D = false;
                            Console.Clear();
                        }
                        else
                        {
                            Program.is2D = true;
                            Console.Clear();
                        }
                        break;

                    default:
                        break;
                }
            }

            if (input.Key == ConsoleKey.D3)
            {
                if(Program.outputPages < 3)
                {
                    Program.isGaming = false;
                }
            }

            if (input.Key == ConsoleKey.D4)
            {

                if (Program.outputPages == 1)
                {
                    if (Program.is2D)
                    {
                        Program.is2D = false;
                    }
                    else
                    {
                        Program.is2D = true;
                    }
                }
            }
        }


        //checks to see if the controls are 2d or 3d.
        public static void vectors()
        {
            if(Program.is2D == true)
            {
                Console.WriteLine("2d Controls");
                if(x != 0)
                {
                    Vector2.Horizontal();
                }

                if (y != 0) 
                {
                    Vector3.Vertical();
                }

            }

            if(Program.is2D == false)
            {
                Console.WriteLine("3d Controls");
                
                if(x != 0)
                {
                    Vector3.Horizontal();
                }

                if(y != 0)
                {
                    Vector3.Vertical();
                }

                if(z != 0)
                {
                    Vector3.Up();
                }
            }
        }
    }
}
