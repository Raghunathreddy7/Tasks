﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class exception
    {
        public class StackFullException : Exception
        {
            public override string Message
            {
                get
                {
                    return "Hey, The array is full!";
                }
            }
        }

        public class StackEmptyException : Exception
        {
            public override string Message
            {
                get
                {
                    return "Hey, The array is Empty!";
                }
            }

        }
    }
}
