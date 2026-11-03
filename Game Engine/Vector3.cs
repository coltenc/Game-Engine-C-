using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Engine
{
    internal class Vector3
    {
        public static int X = 0;
        public static int Y = 0;
        public static int Z = 0;

        public static void Forward()
        {

        }

        public static void Right()
        {

        }

        public static void Horizontal()
        {
            if (Inputs.x == -1)
            {
                X--;
                Inputs.x = 0;
            }
            else
            {
                X++;
                Inputs.x = 0;
            }

        }

        public static void Vertical()
        {
            if (Inputs.y == -1)
            {
                Y--;
                Inputs.y = 0;
            }
            else
            {
                Y++;
                Inputs.y = 0;
            }

        }

        public static void Up()
        {
            if(Inputs.z == -1)
            {
                Z--;
                Inputs.z = 0;
            }
            else
            {
                Z++;
                Inputs.z = 0;
            }
        }
    }
}
